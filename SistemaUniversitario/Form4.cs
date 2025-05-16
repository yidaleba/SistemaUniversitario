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

            dataGridViewMaterias.CellValueChanged += DataGridViewMaterias_CellValueChanged;
            dataGridViewMaterias.CurrentCellDirtyStateChanged += DataGridViewMaterias_CurrentCellDirtyStateChanged;
        }

        private void CrearTablaSiNoExiste()
        {
            string query = @"CREATE TABLE IF NOT EXISTS Materias (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre TEXT,
                Semestre INTEGER,
                Codigo TEXT,
                Horas INTEGER,
                Mesas INTEGER,
                Laboratorio INTEGER
            )";
            new SQLiteCommand(query, conexion).ExecuteNonQuery();
        }

        private void CargarComboSemestres()
        {
            comboSemestre.Items.Clear();
            comboSemestre.Items.Add("Todos");
            for (int i = 1; i <= 10; i++)
                comboSemestre.Items.Add(i.ToString());
            comboSemestre.SelectedIndex = 0;
        }

        private void MostrarMaterias()
        {
            string filtro = comboSemestre.SelectedIndex <= 0 ? "" : $"WHERE Semestre = {comboSemestre.SelectedItem}";
            string query = $"SELECT * FROM Materias {filtro}";

            var adaptador = new SQLiteDataAdapter(query, conexion);
            var tabla = new DataTable();
            adaptador.Fill(tabla);

            dataGridViewMaterias.Columns.Clear();
            dataGridViewMaterias.AutoGenerateColumns = false;

            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Semestre", DataPropertyName = "Semestre" });
            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "Codigo" });
            dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Horas", DataPropertyName = "Horas" });

            dataGridViewMaterias.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Mesas",
                DataPropertyName = "Mesas",
                Name = "Mesas"
            });

            dataGridViewMaterias.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Laboratorio",
                DataPropertyName = "Laboratorio",
                Name = "Laboratorio"
            });

            dataGridViewMaterias.DataSource = tabla;
        }

        private void DataGridViewMaterias_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMaterias.IsCurrentCellDirty)
            {
                dataGridViewMaterias.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewMaterias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewMaterias.Rows[e.RowIndex];

                if (dataGridViewMaterias.Columns[e.ColumnIndex].Name == "Mesas")
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Mesas"].Value);
                    if (isChecked)
                    {
                        row.Cells["Laboratorio"].Value = false;
                    }
                }
                else if (dataGridViewMaterias.Columns[e.ColumnIndex].Name == "Laboratorio")
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Laboratorio"].Value);
                    if (isChecked)
                    {
                        row.Cells["Mesas"].Value = false;
                    }
                }
            }
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
            int mesas = checkMesas.Checked ? 1 : 0;
            int lab = checkLaboratorio.Checked ? 1 : 0;

            string insert = "INSERT INTO Materias (Nombre, Semestre, Codigo, Horas, Mesas, Laboratorio) " +
                            "VALUES (@nombre, @semestre, @codigo, @horas, @mesas, @lab)";

            using var cmd = new SQLiteCommand(insert, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@semestre", semestre);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@horas", horas);
            cmd.Parameters.AddWithValue("@mesas", mesas);
            cmd.Parameters.AddWithValue("@lab", lab);
            cmd.ExecuteNonQuery();

            MostrarMaterias();
            LimpiarCampos();
            panelAgregarMateria.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtSemestre.Clear();
            txtCodigo.Clear();
            txtHoras.Clear();
            checkMesas.Checked = false;
            checkLaboratorio.Checked = false;
        }

        private void comboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterias();
        }

        private void checkMesas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMesas.Checked)
                checkLaboratorio.Checked = false;
        }

        private void checkLaboratorio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaboratorio.Checked)
                checkMesas.Checked = false;
        }
    }
}
