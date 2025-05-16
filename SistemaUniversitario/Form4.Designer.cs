namespace UniversidadApp
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewMaterias;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelAgregarMateria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.CheckBox checkMesas;
        private System.Windows.Forms.CheckBox checkLaboratorio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblSemestre;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelAgregarMateria = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.checkMesas = new System.Windows.Forms.CheckBox();
            this.checkLaboratorio = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSemestre = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
            this.panelAgregarMateria.SuspendLayout();
            this.SuspendLayout();

            // dataGridViewMaterias
            this.dataGridViewMaterias.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewMaterias.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewMaterias.TabIndex = 0;

            // comboSemestre
            this.comboSemestre.Location = new System.Drawing.Point(100, 15);
            this.comboSemestre.Size = new System.Drawing.Size(121, 21);
            this.comboSemestre.SelectedIndexChanged += new System.EventHandler(this.comboSemestre_SelectedIndexChanged);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(240, 13);
            this.btnAgregar.Text = "Agregar Materia";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // panelAgregarMateria
            this.panelAgregarMateria.Controls.Add(this.txtNombre);
            this.panelAgregarMateria.Controls.Add(this.txtSemestre);
            this.panelAgregarMateria.Controls.Add(this.txtCodigo);
            this.panelAgregarMateria.Controls.Add(this.txtHoras);
            this.panelAgregarMateria.Controls.Add(this.checkMesas);
            this.panelAgregarMateria.Controls.Add(this.checkLaboratorio);
            this.panelAgregarMateria.Controls.Add(this.btnGuardar);
            this.panelAgregarMateria.Location = new System.Drawing.Point(12, 310);
            this.panelAgregarMateria.Size = new System.Drawing.Size(400, 150);
            this.panelAgregarMateria.TabIndex = 1;

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(10, 10);
            this.txtNombre.PlaceholderText = "Nombre";

            // txtSemestre
            this.txtSemestre.Location = new System.Drawing.Point(10, 40);
            this.txtSemestre.PlaceholderText = "Semestre";

            // txtCodigo
            this.txtCodigo.Location = new System.Drawing.Point(10, 70);
            this.txtCodigo.PlaceholderText = "Código";

            // txtHoras
            this.txtHoras.Location = new System.Drawing.Point(10, 100);
            this.txtHoras.PlaceholderText = "Horas";

            // checkMesas
            this.checkMesas.Location = new System.Drawing.Point(150, 10);
            this.checkMesas.Text = "Mesas";
            this.checkMesas.CheckedChanged += new System.EventHandler(this.checkMesas_CheckedChanged);

            // checkLaboratorio
            this.checkLaboratorio.Location = new System.Drawing.Point(150, 40);
            this.checkLaboratorio.Text = "Laboratorio";
            this.checkLaboratorio.CheckedChanged += new System.EventHandler(this.checkLaboratorio_CheckedChanged);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(150, 80);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Form4
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.dataGridViewMaterias);
            this.Controls.Add(this.comboSemestre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelAgregarMateria);
            this.Name = "Form4";
            this.Text = "Gestión de Materias";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).EndInit();
            this.panelAgregarMateria.ResumeLayout(false);
            this.panelAgregarMateria.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
