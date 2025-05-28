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
            comboSemestre = new ComboBox();
            comboMateria = new ComboBox();
            comboDia1 = new ComboBox();
            comboDia2 = new ComboBox();
            timeInicio1 = new DateTimePicker();
            timeFin1 = new DateTimePicker();
            timeInicio2 = new DateTimePicker();
            timeFin2 = new DateTimePicker();
            btnGuardar = new Button();
            dataGridViewHorario = new DataGridView();
            btnVolver = new Button();
            labelSemestre = new Label();
            labelMateria = new Label();
            labelDia1 = new Label();
            labelDia2 = new Label();
            labelHoraInicio1 = new Label();
            labelHoraFin1 = new Label();
            labelHoraInicio2 = new Label();
            labelHoraFin2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).BeginInit();
            SuspendLayout();
            // 
            // comboSemestre
            // 
            comboSemestre.Location = new Point(100, 20);
            comboSemestre.Name = "comboSemestre";
            comboSemestre.Size = new Size(200, 23);
            comboSemestre.TabIndex = 8;
            // 
            // comboMateria
            // 
            comboMateria.Location = new Point(100, 60);
            comboMateria.Name = "comboMateria";
            comboMateria.Size = new Size(400, 23);
            comboMateria.TabIndex = 9;
            // 
            // comboDia1
            // 
            comboDia1.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });
            comboDia1.Location = new Point(100, 100);
            comboDia1.Name = "comboDia1";
            comboDia1.Size = new Size(140, 23);
            comboDia1.TabIndex = 10;
            // 
            // comboDia2
            // 
            comboDia2.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });
            comboDia2.Location = new Point(100, 140);
            comboDia2.Name = "comboDia2";
            comboDia2.Size = new Size(140, 23);
            comboDia2.TabIndex = 11;
            // 
            // timeInicio1
            // 
            timeInicio1.CustomFormat = "HH:00";
            timeInicio1.Format = DateTimePickerFormat.Custom;
            timeInicio1.Location = new Point(330, 100);
            timeInicio1.Name = "timeInicio1";
            timeInicio1.ShowUpDown = true;
            timeInicio1.Size = new Size(100, 23);
            timeInicio1.TabIndex = 12;
            // 
            // timeFin1
            // 
            timeFin1.CustomFormat = "HH:00";
            timeFin1.Format = DateTimePickerFormat.Custom;
            timeFin1.Location = new Point(530, 100);
            timeFin1.Name = "timeFin1";
            timeFin1.ShowUpDown = true;
            timeFin1.Size = new Size(100, 23);
            timeFin1.TabIndex = 13;
            // 
            // timeInicio2
            // 
            timeInicio2.CustomFormat = "HH:00";
            timeInicio2.Format = DateTimePickerFormat.Custom;
            timeInicio2.Location = new Point(330, 140);
            timeInicio2.Name = "timeInicio2";
            timeInicio2.ShowUpDown = true;
            timeInicio2.Size = new Size(100, 23);
            timeInicio2.TabIndex = 14;
            // 
            // timeFin2
            // 
            timeFin2.CustomFormat = "HH:00";
            timeFin2.Format = DateTimePickerFormat.Custom;
            timeFin2.Location = new Point(530, 140);
            timeFin2.Name = "timeFin2";
            timeFin2.ShowUpDown = true;
            timeFin2.Size = new Size(100, 23);
            timeFin2.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(650, 120);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 30);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar horario";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridViewHorario
            // 
            dataGridViewHorario.Location = new Point(33, 189);
            dataGridViewHorario.Name = "dataGridViewHorario";
            dataGridViewHorario.Size = new Size(750, 300);
            dataGridViewHorario.TabIndex = 18;
            dataGridViewHorario.CellContentClick += dataGridViewHorario_CellContentClick;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(1159, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(138, 38);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.Click += btnVolver_Click;
            // 
            // labelSemestre
            // 
            labelSemestre.Location = new Point(20, 20);
            labelSemestre.Name = "labelSemestre";
            labelSemestre.Size = new Size(80, 20);
            labelSemestre.TabIndex = 0;
            labelSemestre.Text = "Semestre:";
            // 
            // labelMateria
            // 
            labelMateria.Location = new Point(20, 60);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(80, 20);
            labelMateria.TabIndex = 1;
            labelMateria.Text = "Materia:";
            // 
            // labelDia1
            // 
            labelDia1.Location = new Point(20, 100);
            labelDia1.Name = "labelDia1";
            labelDia1.Size = new Size(80, 20);
            labelDia1.TabIndex = 2;
            labelDia1.Text = "Día 1:";
            // 
            // labelDia2
            // 
            labelDia2.Location = new Point(20, 140);
            labelDia2.Name = "labelDia2";
            labelDia2.Size = new Size(80, 20);
            labelDia2.TabIndex = 3;
            labelDia2.Text = "Día 2:";
            // 
            // labelHoraInicio1
            // 
            labelHoraInicio1.Location = new Point(250, 100);
            labelHoraInicio1.Name = "labelHoraInicio1";
            labelHoraInicio1.Size = new Size(80, 20);
            labelHoraInicio1.TabIndex = 4;
            labelHoraInicio1.Text = "Hora inicio:";
            // 
            // labelHoraFin1
            // 
            labelHoraFin1.Location = new Point(450, 100);
            labelHoraFin1.Name = "labelHoraFin1";
            labelHoraFin1.Size = new Size(80, 20);
            labelHoraFin1.TabIndex = 5;
            labelHoraFin1.Text = "Hora fin:";
            // 
            // labelHoraInicio2
            // 
            labelHoraInicio2.Location = new Point(250, 140);
            labelHoraInicio2.Name = "labelHoraInicio2";
            labelHoraInicio2.Size = new Size(80, 20);
            labelHoraInicio2.TabIndex = 6;
            labelHoraInicio2.Text = "Hora inicio:";
            // 
            // labelHoraFin2
            // 
            labelHoraFin2.Location = new Point(450, 140);
            labelHoraFin2.Name = "labelHoraFin2";
            labelHoraFin2.Size = new Size(80, 20);
            labelHoraFin2.TabIndex = 7;
            labelHoraFin2.Text = "Hora fin:";
            // 
            // Form5
            // 
            ClientSize = new Size(902, 541);
            Controls.Add(labelSemestre);
            Controls.Add(labelMateria);
            Controls.Add(labelDia1);
            Controls.Add(labelDia2);
            Controls.Add(labelHoraInicio1);
            Controls.Add(labelHoraFin1);
            Controls.Add(labelHoraInicio2);
            Controls.Add(labelHoraFin2);
            Controls.Add(comboSemestre);
            Controls.Add(comboMateria);
            Controls.Add(comboDia1);
            Controls.Add(comboDia2);
            Controls.Add(timeInicio1);
            Controls.Add(timeFin1);
            Controls.Add(timeInicio2);
            Controls.Add(timeFin2);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(dataGridViewHorario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Horarios";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.ComboBox comboDia1;
        private System.Windows.Forms.ComboBox comboDia2;
        private System.Windows.Forms.DateTimePicker timeInicio1;
        private System.Windows.Forms.DateTimePicker timeFin1;
        private System.Windows.Forms.DateTimePicker timeInicio2;
        private System.Windows.Forms.DateTimePicker timeFin2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridViewHorario;

        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelDia1;
        private System.Windows.Forms.Label labelDia2;
        private System.Windows.Forms.Label labelHoraInicio1;
        private System.Windows.Forms.Label labelHoraFin1;
        private System.Windows.Forms.Label labelHoraInicio2;
        private System.Windows.Forms.Label labelHoraFin2;
    }
}
