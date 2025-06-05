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
        private bool modoEdicion = false;

        public Form5()
        {
            InitializeComponent();
            conexion = new SQLiteConnection("Data Source=universidad.db;Version=3;");
            conexion.Open();
            this.FormClosed += (s, e) => Application.Exit();
            CrearTablaHorariosSiNoExiste();
            CargarCarreras(); // nuevo
            CargarSemestres();
            cargarHorarios();
            CargarMaterias();
            dataGridViewHorario.Columns["Id"].Visible = false;

            // Esperar a que comboCarrera y comboSemestre estén cargados
            if (comboCarrera.SelectedItem != null && comboSemestre.SelectedItem != null)
            {
                cargarHorarios();
            }
            comboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSemestre.DropDownStyle = ComboBoxStyle.DropDownList;

            // Asegurarse de que las columnas de botones existan desde el inicio


            if (!dataGridViewHorario.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
                {
                    HeaderText = "Eliminar",
                    Name = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dataGridViewHorario.Columns.Add(btnEliminar);
            }
            dataGridViewHorario.CellContentClick += dataGridViewHorario_CellContentClick;
            ConfigurarColumnaDias();
            dataGridViewHorario.CellValidating += DataGridViewHorario_CellValidating;
            dataGridViewHorario.EditingControlShowing += (s, e) =>
        dataGridViewHorario_EditingControlShowing(s, e, dataGridViewHorario.CurrentCell.ColumnIndex);
        }



        private void DataGridViewHorario_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dataGridViewHorario.Columns[e.ColumnIndex].Name;

            if (columnName == "Semestre" || columnName == "Grupo" || columnName == "CantEstudiantes")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out _))
                {
                    MessageBox.Show($"Solo se permiten valores numéricos en '{columnName}'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (columnName == "Inicio" || columnName == "HoraFin")
            {
                string hora = e.FormattedValue?.ToString() ?? "";
                if (!string.IsNullOrWhiteSpace(hora) && !IsValidTime(hora))
                {
                    MessageBox.Show("Formato de hora inválido. Use HH:mm.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private bool IsValidTime(string time)
        {
            return TimeSpan.TryParse(time, out _);
        }

        private void dataGridViewHorario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e, int columnIndex)
        {
            if (dataGridViewHorario.Columns[columnIndex].Name == "Inicio" ||
                dataGridViewHorario.Columns[columnIndex].Name == "Fin")
            {
                e.Control.KeyPress -= ValidateOnlyNumbers;
                e.Control.KeyPress += ValidateOnlyNumbers;
            }
        }

        private void ValidateOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.KeyChar == (char)Keys.Back) return;

            // Permitir solo números y ":"
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }

            // Limitar formato a HH:mm
            if (textBox.Text.Length == 2 && e.KeyChar != ':' && e.KeyChar != (char)Keys.Back)
            {
                textBox.Text += ":";
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void dataGridViewHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que sea una fila válida y que el clic sea en un botón
            if (e.RowIndex >= 0)
            {
                string columna = dataGridViewHorario.Columns[e.ColumnIndex].Name;

                int idHorario = Convert.ToInt32(dataGridViewHorario.Rows[e.RowIndex].Cells["Id"].Value);

                if (columna == "Eliminar")
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este horario?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        EliminarHorario(idHorario);
                        cargarHorarios(); // Recargar datos
                    }
                }
            }
        }

        private void EliminarHorario(int id)
        {
            string query = "DELETE FROM Horarios WHERE Id = @id";
            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }


        private void CrearTablaHorariosSiNoExiste()
        {
            string query = @"CREATE TABLE IF NOT EXISTS Horarios (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                MateriaId INTEGER,
                Grupo INTEGER NOT NULL,
                CantEstudiantes INTEGER NOT NULL,
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
            comboSemestre.Items.Add("Todos");  // Opción para mostrar todos
            for (int i = 1; i <= 10; i++)
                comboSemestre.Items.Add(i.ToString());

            comboSemestre.SelectedItem = "Todos"; // Selección por defecto
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

            // Establecer "Ingeniería Civil" si está en la lista
            if (comboCarrera.Items.Contains("Ingenieria civil"))
            {
                comboCarrera.SelectedItem = "Ingenieria civil";
            }

            comboCarrera.SelectedIndexChanged += ComboCarrera_SelectedIndexChanged;
        }





        private void ComboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
            cargarHorarios();
        }



        private void CargarMaterias()
        {
            comboMateria.Items.Clear();
            if (comboCarrera.SelectedItem == null || comboSemestre.SelectedItem == null) return;

            string filtro = comboMateria.Text.Trim();
            string carrera = comboCarrera.SelectedItem.ToString();
            string semestre = comboSemestre.SelectedItem.ToString();

            string query = @"SELECT Id, Nombre FROM Materias 
                     WHERE Carrera = @carrera";

            if (semestre != "Todos")
                query += " AND Semestre = @semestre";

            query += " AND (Nombre LIKE @filtro OR Codigo LIKE @filtro)";

            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@carrera", carrera);
            if (semestre != "Todos")
                cmd.Parameters.AddWithValue("@semestre", semestre);
            cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");

            using var reader = cmd.ExecuteReader();
            comboMateria.Items.Add("Todas");
            while (reader.Read())
            {
                comboMateria.Items.Add(new ComboBoxItem(reader["Nombre"].ToString(), reader["Id"].ToString()));
            }
            comboMateria.SelectedIndex = 0;
        }


        private void comboMateria_TextChanged(object sender, EventArgs e)
        {
            if (comboMateria.SelectedIndex == -1) // Solo si no es una selección directa
            {
                FiltrarMateriasPorTexto(comboMateria.Text.Trim());
            }

        }

        private void FiltrarMateriasPorTexto(string texto)
        {
            comboMateria.Items.Clear();
            if (comboCarrera.SelectedItem == null || comboSemestre.SelectedItem == null) return;

            string carrera = comboCarrera.SelectedItem.ToString();
            string semestre = comboSemestre.SelectedItem.ToString();

            string query = @"SELECT Id, Nombre FROM Materias 
                     WHERE Carrera = @carrera";

            if (semestre != "Todos")
                query += " AND Semestre = @semestre";

            query += " AND (Nombre LIKE @filtro OR Codigo LIKE @filtro)";

            using var cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@carrera", carrera);
            if (semestre != "Todos")
                cmd.Parameters.AddWithValue("@semestre", semestre);
            cmd.Parameters.AddWithValue("@filtro", $"%{texto}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboMateria.Items.Add(new ComboBoxItem(reader["Nombre"].ToString(), reader["Id"].ToString()));
            }

            comboMateria.DroppedDown = true; // Opcional: muestra el menú desplegable al escribir
            comboMateria.SelectionStart = comboMateria.Text.Length;
        }




        private void cargarHorarios()
        {
            using (var conn = new SQLiteConnection("Data Source=universidad.db"))
            {
                conn.Open();
                string query = @"SELECT h.Id, m.Nombre AS Materia, m.Codigo, m.Carrera, m.Semestre, 
                        h.Grupo, h.CantEstudiantes, d.Nombre || ' ' || d.Apellido AS Docente, h.Dia, h.HoraInicio, h.HoraFin
                 FROM Horarios h
                 INNER JOIN Materias m ON h.MateriaId = m.Id
                 LEFT JOIN DocenteMateria dm ON m.Id = dm.MateriaId
                 LEFT JOIN Docente d ON dm.DocenteId = d.Id
                 WHERE 1=1"; // base de la consulta

                var cmd = new SQLiteCommand();
                cmd.Connection = conn;

                // Filtro por carrera
                if (comboCarrera.SelectedItem != null)
                {
                    query += " AND m.Carrera = @carrera";
                    cmd.Parameters.AddWithValue("@carrera", comboCarrera.SelectedItem.ToString());
                }

                // Filtro por semestre
                if (comboSemestre.SelectedItem != null && comboSemestre.SelectedItem.ToString() != "Todos")
                {
                    query += " AND m.Semestre = @semestre";
                    cmd.Parameters.AddWithValue("@semestre", comboSemestre.SelectedItem.ToString());
                }

                if (comboMateria.SelectedItem is ComboBoxItem selectedMateria)
                {
                    query += " AND m.Id = @materiaId";
                    cmd.Parameters.AddWithValue("@materiaId", selectedMateria.Value);
                }

                // Filtro por materia (nombre o código)
                string filtroMateria = comboMateria.Text.Trim();

                if (!string.IsNullOrEmpty(filtroMateria) && filtroMateria != "Todas")
                {
                    query += " AND (m.Nombre LIKE @filtro OR m.Codigo LIKE @filtro)";
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtroMateria}%");
                }

                query += " ORDER BY m.Codigo ASC";
                cmd.CommandText = query;

                using (var da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewHorario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridViewHorario.DataSource = dt;

                    dataGridViewHorario.Columns["Materia"].HeaderText = "Materia";
                    dataGridViewHorario.Columns["Codigo"].HeaderText = "Código";
                    dataGridViewHorario.Columns["Carrera"].HeaderText = "Carrera";
                    dataGridViewHorario.Columns["Semestre"].HeaderText = "Semestre";
                    dataGridViewHorario.Columns["Grupo"].HeaderText = "Grupo";
                    dataGridViewHorario.Columns["CantEstudiantes"].HeaderText = "N° Estudiantes";
                    dataGridViewHorario.Columns["Docente"].HeaderText = "Docente";
                    dataGridViewHorario.Columns["Dia"].HeaderText = "Día";
                    dataGridViewHorario.Columns["HoraInicio"].HeaderText = "Inicio";
                    dataGridViewHorario.Columns["HoraFin"].HeaderText = "Fin";

                    dataGridViewHorario.ReadOnly = true;
                    dataGridViewHorario.AllowUserToAddRows = false;
                }
            }
        }

        private void ConfigurarColumnaDias()
        {
            if (dataGridViewHorario.Columns.Contains("Dia"))
            {
                int indexOriginal = dataGridViewHorario.Columns["Dia"].Index;

                // Eliminar solo si es de tipo texto
                if (dataGridViewHorario.Columns["Dia"] is DataGridViewTextBoxColumn)
                {
                    dataGridViewHorario.Columns.RemoveAt(indexOriginal);

                    var comboDia = new DataGridViewComboBoxColumn();
                    comboDia.Name = "Dia";
                    comboDia.HeaderText = "Día";
                    comboDia.DataPropertyName = "Dia";
                    comboDia.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
                    comboDia.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

                    dataGridViewHorario.Columns.Insert(indexOriginal, comboDia);
                }
            }
        }

        private void RestablecerColumnaDias()
        {
            if (dataGridViewHorario.Columns.Contains("Dia"))
            {
                int indexOriginal = dataGridViewHorario.Columns["Dia"].Index;

                if (dataGridViewHorario.Columns["Dia"] is DataGridViewComboBoxColumn)
                {
                    dataGridViewHorario.Columns.RemoveAt(indexOriginal);

                    var textColumn = new DataGridViewTextBoxColumn();
                    textColumn.Name = "Dia";
                    textColumn.HeaderText = "Día";
                    textColumn.DataPropertyName = "Dia";

                    dataGridViewHorario.Columns.Insert(indexOriginal, textColumn);
                }
            }
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



        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void ComboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes poner la lógica para filtrar materias según la carrera seleccionada
            // Por ejemplo:

            CargarMaterias();
            cargarHorarios();
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


        private void limpiarFormularioHorario()
        {
            comboMateria.SelectedIndex = -1;
            comboDias.SelectedIndex = -1;
            comboGrupo.Text = "";
            textBoxEstudiantes.Text = "";
            comboDocente.SelectedIndex = -1;
            comboDias.Text = "";
            dataGridViewAgregarHorario.Rows.Clear();
        }

        private void comboDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad = int.Parse(comboDias.SelectedItem.ToString());
            dataGridViewAgregarHorario.Rows.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                dataGridViewAgregarHorario.Rows.Add(); // Asegúrate que las columnas sean: Día, HoraInicio, HoraFin
            }
        }

        private int obtenerIdMateria(string texto)
        {
            int id = -1;
            using (var conn = new SQLiteConnection("Data Source=universidad.db"))
            {
                conn.Open();
                string query = "SELECT Id FROM Materias WHERE Nombre = @Texto OR Codigo = @Texto";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Texto", texto);
                    var result = cmd.ExecuteScalar();
                    if (result != null) id = Convert.ToInt32(result);
                }
            }
            return id;
        }


        private void labelDia1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMateriaPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
            cargarHorarios();
        }

        private void comboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargarHorarios();

        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (comboMateria.SelectedIndex == -1 || comboDocente.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(comboGrupo.Text) || string.IsNullOrWhiteSpace(textBoxEstudiantes.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            int materiaId = obtenerIdMateria(comboMateria.Text);
            int grupo = int.Parse(comboGrupo.Text);
            int cantEstudiantes = int.Parse(textBoxEstudiantes.Text);

            using (var conn = new SQLiteConnection("Data Source=universidad.db"))
            {
                conn.Open();

                foreach (DataGridViewRow fila in dataGridViewAgregarHorario.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string dia = fila.Cells["Dia"].Value?.ToString();
                    string horaInicio = fila.Cells["HoraInicio"].Value?.ToString();
                    string horaFin = fila.Cells["HoraFin"].Value?.ToString();

                    if (string.IsNullOrEmpty(dia) || string.IsNullOrEmpty(horaInicio) || string.IsNullOrEmpty(horaFin))
                        continue;

                    string query = @"INSERT INTO Horarios (MateriaId, Grupo, CantEstudiantes, Dia, HoraInicio, HoraFin)
                             VALUES (@MateriaId, @Grupo, @CantEstudiantes, @Dia, @HoraInicio, @HoraFin)";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MateriaId", materiaId);
                        cmd.Parameters.AddWithValue("@Grupo", grupo);
                        cmd.Parameters.AddWithValue("@CantEstudiantes", cantEstudiantes);
                        cmd.Parameters.AddWithValue("@Dia", dia);
                        cmd.Parameters.AddWithValue("@HoraInicio", horaInicio);
                        cmd.Parameters.AddWithValue("@HoraFin", horaFin);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Horario guardado exitosamente.");
                panelHorario.Visible = false;
                limpiarFormularioHorario();
                cargarHorarios(); // Refresca la tabla principal
            }
        }

        private void btnAgregarHorario_Click_1(object sender, EventArgs e)
        {

            panelHorario.Visible = !panelHorario.Visible;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!modoEdicion)
            {
                // Entrar en modo edición
                ConfigurarColumnaDias();
                dataGridViewHorario.ReadOnly = false;
                dataGridViewHorario.AllowUserToAddRows = false; // Evita agregar nuevas filas
                btnEditar.Text = "Guardar Cambios";
                modoEdicion = true;

                // Permitir edición solo en ciertas columnas (opcional)
                foreach (DataGridViewColumn col in dataGridViewHorario.Columns)
                {
                    if (col.Name == "Id" || col.Name == "Docente") // Columnas no editables
                        col.ReadOnly = true;
                    else
                        col.ReadOnly = false;
                }

                MessageBox.Show("Modo edición activado. Puedes modificar las celdas.");
            }
            else
            {
                // Guardar cambios
                GuardarCambiosEnHorarios();
                btnEditar.Text = "Editar";
                modoEdicion = false;
                dataGridViewHorario.ReadOnly = true;
                MessageBox.Show("Cambios guardados exitosamente.");
            }
        }

        private void GuardarCambiosEnHorarios()
        {
            string query = @"UPDATE Horarios SET 
                     Dia = @Dia, HoraInicio = @HoraInicio, HoraFin = @HoraFin,
                     Grupo = @Grupo, CantEstudiantes = @CantEstudiantes
                     WHERE Id = @Id";

            using var transaction = conexion.BeginTransaction();

            try
            {
                foreach (DataGridViewRow fila in dataGridViewHorario.Rows)
                {
                    if (fila.IsNewRow) continue;

                    int id = Convert.ToInt32(fila.Cells["Id"].Value);
                    string dia = fila.Cells["Dia"].Value?.ToString() ?? "";
                    string inicio = fila.Cells["HoraInicio"].Value?.ToString() ?? "";
                    string fin = fila.Cells["HoraFin"].Value?.ToString() ?? "";
                    int grupo = Convert.ToInt32(fila.Cells["Grupo"].Value);
                    int cantEstudiantes = Convert.ToInt32(fila.Cells["CantEstudiantes"].Value);

                    using var cmd = new SQLiteCommand(query, conexion, transaction);
                    cmd.Parameters.AddWithValue("@Dia", dia);
                    cmd.Parameters.AddWithValue("@HoraInicio", inicio);
                    cmd.Parameters.AddWithValue("@HoraFin", fin);
                    cmd.Parameters.AddWithValue("@Grupo", grupo);
                    cmd.Parameters.AddWithValue("@CantEstudiantes", cantEstudiantes);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error al guardar cambios: {ex.Message}");
            }
        }

    }
}
