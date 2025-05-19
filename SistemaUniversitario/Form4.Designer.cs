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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtFiltroMateria;
        private System.Windows.Forms.Label lblBuscar;


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
            btnGuardar = new Button();
            lblSemestre = new Label();
            btnVolver = new Button();
            btnGuardarCambios = new Button();
            txtFiltroMateria = new TextBox();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            panelAgregarMateria.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.Location = new Point(12, 86);
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.Size = new Size(827, 250);
            dataGridViewMaterias.TabIndex = 0;
            dataGridViewMaterias.CellContentClick += dataGridViewMaterias_CellContentClick;
            // 
            // comboSemestre
            // 
            comboSemestre.Location = new Point(69, 15);
            comboSemestre.Name = "comboSemestre";
            comboSemestre.Size = new Size(152, 23);
            comboSemestre.TabIndex = 1;
            comboSemestre.SelectedIndexChanged += comboSemestre_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(240, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(172, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Nueva Materia";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panelAgregarMateria
            // 
            panelAgregarMateria.Controls.Add(txtNombre);
            panelAgregarMateria.Controls.Add(txtSemestre);
            panelAgregarMateria.Controls.Add(txtCodigo);
            panelAgregarMateria.Controls.Add(txtHoras);
            panelAgregarMateria.Controls.Add(btnGuardar);
            panelAgregarMateria.Location = new Point(12, 352);
            panelAgregarMateria.Name = "panelAgregarMateria";
            panelAgregarMateria.Size = new Size(443, 91);
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
            txtSemestre.Location = new Point(116, 10);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.PlaceholderText = "Semestre";
            txtSemestre.Size = new Size(100, 23);
            txtSemestre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(222, 10);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Código";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(328, 10);
            txtHoras.Name = "txtHoras";
            txtHoras.PlaceholderText = "Horas";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(152, 39);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 36);
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
            btnGuardarCambios.Location = new Point(658, 352);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(181, 30);
            btnGuardarCambios.TabIndex = 0;
            btnGuardarCambios.Text = "Guardar Cambios de la tabla";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtFiltroMateria
            // 
            txtFiltroMateria.Location = new Point(116, 57);
            txtFiltroMateria.Name = "txtFiltroMateria";
            txtFiltroMateria.Size = new Size(200, 23);
            txtFiltroMateria.TabIndex = 102;
            txtFiltroMateria.TextChanged += txtFiltroMateria_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(22, 60);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(88, 15);
            lblBuscar.TabIndex = 101;
            lblBuscar.Text = "Buscar Materia:";
            // 
            // Form4
            // 
            ClientSize = new Size(851, 477);
            Controls.Add(lblBuscar);
            Controls.Add(txtFiltroMateria);
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
            PerformLayout();
        }
    }
}
