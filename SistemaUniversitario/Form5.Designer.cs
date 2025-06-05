namespace UniversidadApp
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboCarrera = new ComboBox();
            comboSemestre = new ComboBox();
            comboMateria = new ComboBox();
            btnAgregarHorario = new Button();
            btnVolver = new Button();
            dataGridViewHorario = new DataGridView();
            panelHorario = new Panel();
            textBoxEstudiantes = new TextBox();
            comboGrupo = new ComboBox();
            btnGuardar = new Button();
            dataGridViewAgregarHorario = new DataGridView();
            comboDocente = new ComboBox();
            comboDias = new ComboBox();
            comboMateriaPanel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).BeginInit();
            panelHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgregarHorario).BeginInit();
            SuspendLayout();
            // 
            // comboCarrera
            // 
            comboCarrera.FormattingEnabled = true;
            comboCarrera.Location = new Point(76, 17);
            comboCarrera.Name = "comboCarrera";
            comboCarrera.Size = new Size(112, 23);
            comboCarrera.TabIndex = 0;
            comboCarrera.SelectedIndexChanged += ComboCarrera_SelectedIndexChanged;
            // 
            // comboSemestre
            // 
            comboSemestre.FormattingEnabled = true;
            comboSemestre.Location = new Point(76, 61);
            comboSemestre.Name = "comboSemestre";
            comboSemestre.Size = new Size(112, 23);
            comboSemestre.TabIndex = 1;
            // 
            // comboMateria
            // 
            comboMateria.FormattingEnabled = true;
            comboMateria.Location = new Point(76, 101);
            comboMateria.Name = "comboMateria";
            comboMateria.Size = new Size(112, 23);
            comboMateria.TabIndex = 3;
            comboMateria.Tag = "";
            comboMateria.SelectedIndexChanged += comboMateria_SelectedIndexChanged;
            // 
            // btnAgregarHorario
            // 
            btnAgregarHorario.Location = new Point(20, 355);
            btnAgregarHorario.Name = "btnAgregarHorario";
            btnAgregarHorario.Size = new Size(124, 30);
            btnAgregarHorario.TabIndex = 10;
            btnAgregarHorario.Text = "+Agregar Horario";
            btnAgregarHorario.UseVisualStyleBackColor = true;
            btnAgregarHorario.Click += btnAgregarHorario_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1231, 499);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(93, 41);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridViewHorario
            // 
            dataGridViewHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorario.Location = new Point(194, 12);
            dataGridViewHorario.Name = "dataGridViewHorario";
            dataGridViewHorario.Size = new Size(1130, 338);
            dataGridViewHorario.TabIndex = 12;
            // 
            // panelHorario
            // 
            panelHorario.Controls.Add(textBoxEstudiantes);
            panelHorario.Controls.Add(comboGrupo);
            panelHorario.Controls.Add(btnGuardar);
            panelHorario.Controls.Add(dataGridViewAgregarHorario);
            panelHorario.Controls.Add(comboDocente);
            panelHorario.Controls.Add(comboDias);
            panelHorario.Controls.Add(comboMateriaPanel);
            panelHorario.Location = new Point(20, 391);
            panelHorario.Name = "panelHorario";
            panelHorario.Size = new Size(663, 186);
            panelHorario.TabIndex = 19;
            panelHorario.Visible = false;
            // 
            // textBoxEstudiantes
            // 
            textBoxEstudiantes.ForeColor = SystemColors.ActiveCaptionText;
            textBoxEstudiantes.Location = new Point(340, 12);
            textBoxEstudiantes.Name = "textBoxEstudiantes";
            textBoxEstudiantes.PlaceholderText = "N° Estudiantes";
            textBoxEstudiantes.Size = new Size(100, 23);
            textBoxEstudiantes.TabIndex = 25;
            // 
            // comboGrupo
            // 
            comboGrupo.FormattingEnabled = true;
            comboGrupo.Location = new Point(234, 12);
            comboGrupo.Name = "comboGrupo";
            comboGrupo.Size = new Size(90, 23);
            comboGrupo.TabIndex = 24;
            comboGrupo.Text = "Grupo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(576, 83);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // dataGridViewAgregarHorario
            // 
            dataGridViewAgregarHorario.AllowUserToAddRows = false;
            dataGridViewAgregarHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgregarHorario.Location = new Point(12, 51);
            dataGridViewAgregarHorario.Name = "dataGridViewAgregarHorario";
            dataGridViewAgregarHorario.Size = new Size(536, 116);
            dataGridViewAgregarHorario.TabIndex = 22;
            // 
            // comboDocente
            // 
            comboDocente.FormattingEnabled = true;
            comboDocente.Location = new Point(463, 12);
            comboDocente.Name = "comboDocente";
            comboDocente.Size = new Size(85, 23);
            comboDocente.TabIndex = 21;
            comboDocente.Text = "Docente";
            // 
            // comboDias
            // 
            comboDias.FormattingEnabled = true;
            comboDias.Location = new Point(152, 12);
            comboDias.Name = "comboDias";
            comboDias.Size = new Size(62, 23);
            comboDias.TabIndex = 20;
            comboDias.Text = "N° Días";
            comboDias.SelectedIndexChanged += comboBoxDias_SelectedIndexChanged;
            // 
            // comboMateriaPanel
            // 
            comboMateriaPanel.FormattingEnabled = true;
            comboMateriaPanel.Location = new Point(12, 12);
            comboMateriaPanel.Name = "comboMateriaPanel";
            comboMateriaPanel.Size = new Size(112, 23);
            comboMateriaPanel.TabIndex = 19;
            comboMateriaPanel.Tag = "";
            comboMateriaPanel.Text = "Materia/Código";
            comboMateriaPanel.SelectedIndexChanged += comboMateriaPanel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 20;
            label1.Text = "Carrera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 21;
            label2.Text = "Semestre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 22;
            label3.Text = "Materia";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(113, 220);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form5
            // 
            ClientSize = new Size(1336, 582);
            Controls.Add(btnEditar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelHorario);
            Controls.Add(comboCarrera);
            Controls.Add(comboSemestre);
            Controls.Add(comboMateria);
            Controls.Add(btnAgregarHorario);
            Controls.Add(btnVolver);
            Controls.Add(dataGridViewHorario);
            Name = "Form5";
            Text = "Asignación de Horarios";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).EndInit();
            panelHorario.ResumeLayout(false);
            panelHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgregarHorario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboCarrera;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridViewHorario;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private Panel panelHorario;
        private ComboBox comboMateriaPanel;
        private ComboBox comboDias;
        private DataGridView dataGridViewAgregarHorario;
        private ComboBox comboDocente;
        private Button btnGuardar;
        private ComboBox comboGrupo;
        private TextBox textBoxEstudiantes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEditar;
    }
}
