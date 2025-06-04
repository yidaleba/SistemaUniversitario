namespace UniversidadApp
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewMaterias = new DataGridView();
            txtFiltroMateria = new TextBox();
            comboSemestre = new ComboBox();
            comboCarreraFiltro = new ComboBox();
            btnGuardarCambios = new Button();
            btnAgregar = new Button();
            btnVolver = new Button();
            panelAgregarMateria = new Panel();
            txtNombre = new TextBox();
            comboCarreraAgregar = new ComboBox();
            txtSemestre = new TextBox();
            txtCodigo = new TextBox();
            txtHoras = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            panelAgregarMateria.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMaterias.Location = new Point(23, 61);
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.Size = new Size(1059, 329);
            dataGridViewMaterias.TabIndex = 0;
            // 
            // txtFiltroMateria
            // 
            txtFiltroMateria.Location = new Point(142, 17);
            txtFiltroMateria.Name = "txtFiltroMateria";
            txtFiltroMateria.Size = new Size(126, 23);
            txtFiltroMateria.TabIndex = 1;
            txtFiltroMateria.TextChanged += txtFiltroMateria_TextChanged;
            // 
            // comboSemestre
            // 
            comboSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSemestre.FormattingEnabled = true;
            comboSemestre.Location = new Point(429, 17);
            comboSemestre.Name = "comboSemestre";
            comboSemestre.Size = new Size(126, 23);
            comboSemestre.TabIndex = 2;
            comboSemestre.SelectedIndexChanged += comboSemestre_SelectedIndexChanged;
            // 
            // comboCarreraFiltro
            // 
            comboCarreraFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCarreraFiltro.FormattingEnabled = true;
            comboCarreraFiltro.Location = new Point(715, 22);
            comboCarreraFiltro.Name = "comboCarreraFiltro";
            comboCarreraFiltro.Size = new Size(236, 23);
            comboCarreraFiltro.TabIndex = 3;
            comboCarreraFiltro.SelectedIndexChanged += comboCarreraFiltro_SelectedIndexChanged;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(1132, 169);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(162, 88);
            btnGuardarCambios.TabIndex = 4;
            btnGuardarCambios.Text = "Guardar Cambios de la Tabla";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 431);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "+ AGREGAR MATERIA";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1187, 20);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 62);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // panelAgregarMateria
            // 
            panelAgregarMateria.BorderStyle = BorderStyle.FixedSingle;
            panelAgregarMateria.Controls.Add(txtNombre);
            panelAgregarMateria.Controls.Add(comboCarreraAgregar);
            panelAgregarMateria.Controls.Add(txtSemestre);
            panelAgregarMateria.Controls.Add(txtCodigo);
            panelAgregarMateria.Controls.Add(txtHoras);
            panelAgregarMateria.Controls.Add(btnGuardar);
            panelAgregarMateria.Location = new Point(23, 506);
            panelAgregarMateria.Name = "panelAgregarMateria";
            panelAgregarMateria.Size = new Size(750, 68);
            panelAgregarMateria.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(3, 11);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 0;
            // 
            // comboCarreraAgregar
            // 
            comboCarreraAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCarreraAgregar.FormattingEnabled = true;
            comboCarreraAgregar.Location = new Point(170, 10);
            comboCarreraAgregar.Name = "comboCarreraAgregar";
            comboCarreraAgregar.Size = new Size(150, 23);
            comboCarreraAgregar.TabIndex = 1;
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(330, 10);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.PlaceholderText = "Semestre";
            txtSemestre.Size = new Size(100, 23);
            txtSemestre.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(440, 10);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Código";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(550, 10);
            txtHoras.Name = "txtHoras";
            txtHoras.PlaceholderText = "Horas";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(660, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 8;
            label1.Text = "Filtro por Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 20);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtro por Semestre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 25);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 10;
            label3.Text = "Filtro por Carrera";
            // 
            // Form4
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1316, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelAgregarMateria);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(comboCarreraFiltro);
            Controls.Add(comboSemestre);
            Controls.Add(txtFiltroMateria);
            Controls.Add(dataGridViewMaterias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Materias";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).EndInit();
            panelAgregarMateria.ResumeLayout(false);
            panelAgregarMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewMaterias;
        private System.Windows.Forms.TextBox txtFiltroMateria;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.ComboBox comboCarreraFiltro;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelAgregarMateria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.ComboBox comboCarreraAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

