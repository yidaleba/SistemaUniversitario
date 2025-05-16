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

            CrearTablaHorariosSiNoExiste();
            CargarSemestres();
            MostrarHorario();
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

        private void ComboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
            MostrarHorario();
        }

        private void CargarMaterias()
        {
            comboMateria.Items.Clear();

            if (comboSemestre.SelectedItem == null) return;

            string query = "SELECT Id, Nombre FROM Materias WHERE Semestre = @semestre";
            using var cmd = new SQLiteCommand(query, conexion);
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
            if (comboSemestre.SelectedItem == null)
                return;

            DataTable dt = new DataTable();
            dt.Columns.Add("Hora");

            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" };
            foreach (var dia in dias)
                dt.Columns.Add(dia);

            for (int h = 7; h <= 20; h++)
            {
                DataRow fila = dt.NewRow();
                fila["Hora"] = $"{h}:00";
                foreach (var dia in dias)
                    fila[dia] = "";
                dt.Rows.Add(fila);
            }

            string query = @"SELECT h.Dia, h.HoraInicio, h.HoraFin, m.Nombre 
                             FROM Horarios h
                             INNER JOIN Materias m ON h.MateriaId = m.Id
                             WHERE m.Semestre = @semestre";
            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@semestre", comboSemestre.SelectedItem.ToString());

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dia = reader["Dia"].ToString();
                string inicio = reader["HoraInicio"].ToString();
                string fin = reader["HoraFin"].ToString();
                string nombre = reader["Nombre"].ToString();

                int hi = TimeSpan.Parse(inicio).Hours;
                int hf = TimeSpan.Parse(fin).Hours;

                for (int h = hi; h < hf; h++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Hora"].ToString().StartsWith($"{h}:"))
                        {
                            row[dia] = nombre;
                        }
                    }
                }
            }

            dataGridViewHorario.DataSource = dt;
            dataGridViewHorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
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
    }
}
