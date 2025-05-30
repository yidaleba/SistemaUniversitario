using SistemaUniversitario;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UniversidadApp
{
    public partial class Form5 : Form
    {
        private SQLiteConnection conexion;

        public Form5()
        {
            InitializeComponent();
            conexion = new SQLiteConnection("Data Source=universidad.db;Version=3;");
            conexion.Open();
            this.FormClosed += (s, e) => Application.Exit();
            CrearTablaHorariosSiNoExiste();
            CargarCarreras(); // nuevo
            CargarSemestres();
            MostrarHorario();
            dataGridViewHorario.CellClick += dataGridViewHorario_CellClick;

        }

        private void CrearTablaHorariosSiNoExiste()
        {
            string query = @"CREATE TABLE IF NOT EXISTS Horarios (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                MateriaId INTEGER,
                Dia TEXT,
                HoraInicio TEXT,
                HoraFin TEXT,
                FOREIGN KEY (MateriaId) REFERENCES Materias(Id)
            )";
            new SQLiteCommand(query, conexion).ExecuteNonQuery();
        }

        private void CargarSemestres()
        {
            comboSemestre.Items.Clear();
            for (int i = 1; i <= 10; i++)
                comboSemestre.Items.Add(i.ToString());
            comboSemestre.SelectedIndexChanged += ComboSemestre_SelectedIndexChanged;
        }

        private void CargarCarreras()
        {
            comboCarrera.Items.Clear();
            string query = "SELECT DISTINCT Carrera FROM Materias ORDER BY Carrera";
            using var cmd = new SQLiteCommand(query, conexion);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboCarrera.Items.Add(reader["Carrera"].ToString());
            }

            comboCarrera.SelectedIndexChanged += ComboCarrera_SelectedIndexChanged;
        }



        private void ComboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
            MostrarHorario();
        }

        private void ComboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
            MostrarHorario();
        }

        private void CargarMaterias()
        {
            comboMateria.Items.Clear();

            if (comboCarrera.SelectedItem == null || comboSemestre.SelectedItem == null) return;

            string query = "SELECT Id, Nombre FROM Materias WHERE Carrera = @carrera AND Semestre = @semestre";
            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@carrera", comboCarrera.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@semestre", comboSemestre.SelectedItem.ToString());

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboMateria.Items.Add(new ComboBoxItem(reader["Nombre"].ToString(), reader["Id"].ToString()));
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboMateria.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una materia.");
                return;
            }

            int materiaId = int.Parse(((ComboBoxItem)comboMateria.SelectedItem).Value);
            string dia1 = comboDia1.Text;
            string horaInicio1 = timeInicio1.Text;
            string horaFin1 = timeFin1.Text;

            string dia2 = comboDia2.Text;
            string horaInicio2 = timeInicio2.Text;
            string horaFin2 = timeFin2.Text;

            if (string.IsNullOrWhiteSpace(dia1) || string.IsNullOrWhiteSpace(horaInicio1) || string.IsNullOrWhiteSpace(horaFin1))
            {
                MessageBox.Show("Debe completar al menos el primer horario.");
                return;
            }

            if (dia1 == dia2)
            {
                MessageBox.Show("Los días seleccionados no pueden ser iguales.");
                return;
            }

            double totalHoras = CalcularHoras(horaInicio1, horaFin1);
            if (!string.IsNullOrWhiteSpace(dia2))
                totalHoras += CalcularHoras(horaInicio2, horaFin2);

            int horasPermitidas = ObtenerHorasMateria(materiaId);
            if (totalHoras > horasPermitidas)
            {
                MessageBox.Show($"La suma de horas ({totalHoras}) supera las permitidas ({horasPermitidas}) para esta materia.");
                return;
            }

            if (HayConflictoHorario(dia1, horaInicio1, horaFin1) ||
                (!string.IsNullOrWhiteSpace(dia2) && HayConflictoHorario(dia2, horaInicio2, horaFin2)))
            {
                MessageBox.Show("Existe un conflicto de horario con otra materia.");
                return;
            }

            GuardarHorario(materiaId, dia1, horaInicio1, horaFin1);
            if (!string.IsNullOrWhiteSpace(dia2))
                GuardarHorario(materiaId, dia2, horaInicio2, horaFin2);

            MessageBox.Show("Horario guardado correctamente.");
            MostrarHorario();
        }

        private bool HayConflictoHorario(string dia, string inicio, string fin)
        {
            string query = @"SELECT COUNT(*) FROM Horarios WHERE Dia = @dia 
                             AND ((@inicio < HoraFin AND @fin > HoraInicio))";
            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@dia", dia);
            cmd.Parameters.AddWithValue("@inicio", inicio);
            cmd.Parameters.AddWithValue("@fin", fin);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private int ObtenerHorasMateria(int materiaId)
        {
            string query = "SELECT Horas FROM Materias WHERE Id = @id";
            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@id", materiaId);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private double CalcularHoras(string inicio, string fin)
        {
            TimeSpan hi = TimeSpan.Parse(inicio);
            TimeSpan hf = TimeSpan.Parse(fin);
            return (hf - hi).TotalHours;
        }

        private void GuardarHorario(int materiaId, string dia, string inicio, string fin)
        {
            string insert = "INSERT INTO Horarios (MateriaId, Dia, HoraInicio, HoraFin) VALUES (@materia, @dia, @inicio, @fin)";
            using var cmd = new SQLiteCommand(insert, conexion);
            cmd.Parameters.AddWithValue("@materia", materiaId);
            cmd.Parameters.AddWithValue("@dia", dia);
            cmd.Parameters.AddWithValue("@inicio", inicio);
            cmd.Parameters.AddWithValue("@fin", fin);
            cmd.ExecuteNonQuery();
        }

        private void MostrarHorario()
        {
            if (comboCarrera.SelectedItem == null || comboSemestre.SelectedItem == null)
                return;

            string carrera = comboCarrera.SelectedItem.ToString();
            string semestre = comboSemestre.SelectedItem.ToString();

            string query = @"
        SELECT 
            m.Id AS MateriaId,
            m.Nombre AS NombreMateria,
            m.Carrera,
            m.Semestre,
            h.Dia,
            h.HoraInicio,
            h.HoraFin
        FROM Horarios h
        INNER JOIN Materias m ON h.MateriaId = m.Id
        WHERE m.Carrera = @carrera AND m.Semestre = @semestre
        ORDER BY m.Nombre, h.Dia
    ";

            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@carrera", carrera);
            cmd.Parameters.AddWithValue("@semestre", semestre);

            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewHorario.DataSource = dt;

            // Quitar columnas de botones si ya existen
            if (dataGridViewHorario.Columns["Editar"] == null)
            {
                var btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "Editar",
                    Name = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewHorario.Columns.Add(btnEditar);
            }

            if (dataGridViewHorario.Columns["Eliminar"] == null)
            {
                var btnEliminar = new DataGridViewButtonColumn
                {
                    HeaderText = "Eliminar",
                    Name = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewHorario.Columns.Add(btnEliminar);
            }

            dataGridViewHorario.Columns["MateriaId"].Visible = false;

            dataGridViewHorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHorario.AllowUserToAddRows = false;
            dataGridViewHorario.ReadOnly = true;
            dataGridViewHorario.Columns.Cast<DataGridViewColumn>().ToList().ForEach(col => col.SortMode = DataGridViewColumnSortMode.Automatic);
        }


        private void dataGridViewHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var grid = (DataGridView)sender;

                if (grid.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int materiaId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["MateriaId"].Value);
                    // Abre un nuevo formulario o panel para editar horarios
                    MessageBox.Show("Editar horario de la materia con ID: " + materiaId);
                    // Aquí podrías cargar un formulario de edición con los datos actuales
                }

                if (grid.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    int materiaId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["MateriaId"].Value);
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar todos los horarios de esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM Horarios WHERE MateriaId = @id";
                        using var cmd = new SQLiteCommand(deleteQuery, conexion);
                        cmd.Parameters.AddWithValue("@id", materiaId);
                        cmd.ExecuteNonQuery();

                        MostrarHorario();
                    }
                }
            }
        }





        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void comboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes poner la lógica para filtrar materias según la carrera seleccionada
            // Por ejemplo:
            CargarMateriasFiltradas();
        }

        private void CargarMateriasFiltradas()
        {
            string carreraSeleccionada = comboCarrera.SelectedItem?.ToString();
            string semestreSeleccionado = comboSemestre.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(carreraSeleccionada) || string.IsNullOrEmpty(semestreSeleccionado))
                return;

            // Aquí llamas a tu base de datos para filtrar las materias según carrera y semestre.
            // Por ejemplo, suponiendo que tienes una conexión a SQLite:
            string consulta = "SELECT Nombre FROM Materias WHERE Carrera = @carrera AND Semestre = @semestre";
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=universidad.db"))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@carrera", carreraSeleccionada);
                cmd.Parameters.AddWithValue("@semestre", semestreSeleccionado);

                SQLiteDataReader reader = cmd.ExecuteReader();
                comboMateria.Items.Clear();
                while (reader.Read())
                {
                    comboMateria.Items.Add(reader["Nombre"].ToString());
                }
            }
        }

        private void textBuscarMateria_TextChanged(object sender, EventArgs e)
        {
            FiltrarMateriasPorTexto();
        }

        private void FiltrarMateriasPorTexto()
        {
            string textoFiltro = textBuscarMateria.Text.ToLower();

            foreach (DataGridViewRow fila in dataGridViewHorario.Rows)
            {
                if (fila.Cells["NombreMateria"].Value != null)
                {
                    string nombreMateria = fila.Cells["NombreMateria"].Value.ToString().ToLower();
                    fila.Visible = nombreMateria.Contains(textoFiltro);
                }
            }
        }




        private class ComboBoxItem
        {
            public string Text { get; }
            public string Value { get; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString() => Text;
        }

        private void dataGridViewHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelDia1_Click(object sender, EventArgs e)
        {

        }
    }
}
