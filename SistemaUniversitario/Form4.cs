using SistemaUniversitario;
using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace UniversidadApp
{
    public partial class Form4 : Form
    {
        private SQLiteConnection conexion;

        public Form4()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

            conexion = new SQLiteConnection("Data Source=universidad.db;Version=3;");
            conexion.Open();
            CrearTablaSiNoExiste();

            CargarComboSemestres();
            MostrarMaterias();
            panelAgregarMateria.Visible = false;

            dataGridViewMaterias.CurrentCellDirtyStateChanged += DataGridViewMaterias_CurrentCellDirtyStateChanged;
        }

        private void CrearTablaSiNoExiste()
        {
            string query = @"CREATE TABLE IF NOT EXISTS Materias (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre TEXT,
                Semestre INTEGER,
                Codigo TEXT,
                Horas INTEGER
            )";
            new SQLiteCommand(query, conexion).ExecuteNonQuery();
        }

        private void CargarComboSemestres()
        {
            comboSemestre.Items.Clear();
            comboSemestre.Items.Add("Todos los semestres");
            for (int i = 1; i <= 10; i++)
                comboSemestre.Items.Add(i.ToString());
            comboSemestre.SelectedIndex = 0;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            using var conexion = new SQLiteConnection("Data Source=universidad.db;Version=3;");
            conexion.Open();

            foreach (DataGridViewRow row in dataGridViewMaterias.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string nombre = row.Cells["Nombre"].Value?.ToString() ?? "";
                    int semestre = Convert.ToInt32(row.Cells["Semestre"].Value);
                    string codigo = row.Cells["Código"].Value?.ToString() ?? "";
                    int horas = Convert.ToInt32(row.Cells["Horas"].Value);

                    string updateQuery = @"UPDATE Materias 
                                        SET Nombre = @nombre, Semestre = @semestre, Codigo = @codigo, Horas = @horas
                                        WHERE Id = @id";

                    using var cmd = new SQLiteCommand(updateQuery, conexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@semestre", semestre);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@horas", horas);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Cambios guardados correctamente.");
            MostrarMaterias(); // Refrescar la tabla
        }

        private void MostrarMaterias()
        {
            string filtroSemestre = comboSemestre.SelectedIndex <= 0 ? "" : $"Semestre = {comboSemestre.SelectedItem}";
            string filtroNombre = string.IsNullOrWhiteSpace(txtFiltroMateria.Text) ? "" : $"Nombre LIKE '%{txtFiltroMateria.Text}%'";

            string where = "";

            if (!string.IsNullOrEmpty(filtroSemestre) && !string.IsNullOrEmpty(filtroNombre))
                where = $"WHERE {filtroSemestre} AND {filtroNombre}";
            else if (!string.IsNullOrEmpty(filtroSemestre))
                where = $"WHERE {filtroSemestre}";
            else if (!string.IsNullOrEmpty(filtroNombre))
                where = $"WHERE {filtroNombre}";

            string query = $"SELECT * FROM Materias {where}";

            var adaptador = new SQLiteDataAdapter(query, conexion);
            var tabla = new DataTable();
            adaptador.Fill(tabla);

            dataGridViewMaterias.Columns.Clear();
            dataGridViewMaterias.AutoGenerateColumns = false;

            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "Id",
                Name = "Id",
                Visible = false
            });

            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre", Name = "Nombre" });
            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Semestre", DataPropertyName = "Semestre", Name = "Semestre" });
            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "Codigo", Name = "Código" });
            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Horas", DataPropertyName = "Horas", Name = "Horas" });

            dataGridViewMaterias.DataSource = tabla;
        }

        private void DataGridViewMaterias_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.IsCurrentCellDirty)
            {
                dataGridViewMaterias.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAgregarMateria.Visible = !panelAgregarMateria.Visible;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int semestre = int.Parse(txtSemestre.Text);
            string codigo = txtCodigo.Text;
            int horas = int.Parse(txtHoras.Text);

            string insert = "INSERT INTO Materias (Nombre, Semestre, Codigo, Horas) " +
                "VALUES (@nombre, @semestre, @codigo, @horas)";


            using var cmd = new SQLiteCommand(insert, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@semestre", semestre);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@horas", horas);
            cmd.ExecuteNonQuery();

            MostrarMaterias();
            LimpiarCampos();
            panelAgregarMateria.Visible = false;
        }

        private void txtFiltroMateria_TextChanged(object sender, EventArgs e)
        {
            MostrarMaterias();
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtSemestre.Clear();
            txtCodigo.Clear();
            txtHoras.Clear();
        }

        private void comboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterias();
        }

        

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
