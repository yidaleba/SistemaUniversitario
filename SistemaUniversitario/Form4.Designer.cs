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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarCambios;


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
            dataGridViewMaterias = new DataGridView();
            comboSemestre = new ComboBox();
            btnAgregar = new Button();
            panelAgregarMateria = new Panel();
            txtNombre = new TextBox();
            txtSemestre = new TextBox();
            txtCodigo = new TextBox();
            txtHoras = new TextBox();
            checkMesas = new CheckBox();
            checkLaboratorio = new CheckBox();
            btnGuardar = new Button();
            lblSemestre = new Label();
            btnVolver = new Button();
            btnGuardarCambios = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            panelAgregarMateria.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.Location = new Point(12, 50);
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.Size = new Size(760, 250);
            dataGridViewMaterias.TabIndex = 0;
            // 
            // comboSemestre
            // 
            comboSemestre.Location = new Point(100, 15);
            comboSemestre.Name = "comboSemestre";
            comboSemestre.Size = new Size(121, 23);
            comboSemestre.TabIndex = 1;
            comboSemestre.SelectedIndexChanged += comboSemestre_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(240, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Materia";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panelAgregarMateria
            // 
            panelAgregarMateria.Controls.Add(txtNombre);
            panelAgregarMateria.Controls.Add(txtSemestre);
            panelAgregarMateria.Controls.Add(txtCodigo);
            panelAgregarMateria.Controls.Add(txtHoras);
            panelAgregarMateria.Controls.Add(checkMesas);
            panelAgregarMateria.Controls.Add(checkLaboratorio);
            panelAgregarMateria.Controls.Add(btnGuardar);
            panelAgregarMateria.Location = new Point(12, 310);
            panelAgregarMateria.Name = "panelAgregarMateria";
            panelAgregarMateria.Size = new Size(400, 150);
            panelAgregarMateria.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(10, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(10, 40);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.PlaceholderText = "Semestre";
            txtSemestre.Size = new Size(100, 23);
            txtSemestre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(10, 70);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Código";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(10, 100);
            txtHoras.Name = "txtHoras";
            txtHoras.PlaceholderText = "Horas";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 3;
            // 
            // checkMesas
            // 
            checkMesas.Location = new Point(150, 10);
            checkMesas.Name = "checkMesas";
            checkMesas.Size = new Size(104, 24);
            checkMesas.TabIndex = 4;
            checkMesas.Text = "Mesas";
            checkMesas.CheckedChanged += checkMesas_CheckedChanged;
            // 
            // checkLaboratorio
            // 
            checkLaboratorio.Location = new Point(150, 40);
            checkLaboratorio.Name = "checkLaboratorio";
            checkLaboratorio.Size = new Size(104, 24);
            checkLaboratorio.TabIndex = 5;
            checkLaboratorio.Text = "Laboratorio";
            checkLaboratorio.CheckedChanged += checkLaboratorio_CheckedChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 80);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblSemestre
            // 
            lblSemestre.Location = new Point(0, 0);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(100, 23);
            lblSemestre.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(655, 15);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 30);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(500, 15);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(130, 30);
            btnGuardarCambios.TabIndex = 0;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // Form4
            // 
            ClientSize = new Size(784, 481);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnVolver);
            Controls.Add(dataGridViewMaterias);
            Controls.Add(comboSemestre);
            Controls.Add(btnAgregar);
            Controls.Add(panelAgregarMateria);
            Name = "Form4";
            Text = "Gestión de Materias";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).EndInit();
            panelAgregarMateria.ResumeLayout(false);
            panelAgregarMateria.PerformLayout();
            ResumeLayout(false);
        }
    }
}
