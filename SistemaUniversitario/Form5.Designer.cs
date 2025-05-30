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
            textBuscarMateria = new TextBox();
            comboMateria = new ComboBox();
            comboDia1 = new ComboBox();
            timeInicio1 = new DateTimePicker();
            timeFin1 = new DateTimePicker();
            comboDia2 = new ComboBox();
            timeInicio2 = new DateTimePicker();
            timeFin2 = new DateTimePicker();
            btnGuardar = new Button();
            btnVolver = new Button();
            dataGridViewHorario = new DataGridView();
            labelCarrera = new Label();
            labelSemestre = new Label();
            labelBuscarMateria = new Label();
            labelMateria = new Label();
            labelDia1 = new Label();
            labelHora1 = new Label();
            labelDia2 = new Label();
            labelHora2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).BeginInit();
            SuspendLayout();
            // 
            // comboCarrera
            // 
            comboCarrera.FormattingEnabled = true;
            comboCarrera.Location = new Point(20, 30);
            comboCarrera.Name = "comboCarrera";
            comboCarrera.Size = new Size(150, 23);
            comboCarrera.TabIndex = 0;
            comboCarrera.SelectedIndexChanged += comboCarrera_SelectedIndexChanged;
            // 
            // comboSemestre
            // 
            comboSemestre.FormattingEnabled = true;
            comboSemestre.Location = new Point(217, 30);
            comboSemestre.Name = "comboSemestre";
            comboSemestre.Size = new Size(100, 23);
            comboSemestre.TabIndex = 1;
            // 
            // textBuscarMateria
            // 
            textBuscarMateria.Location = new Point(348, 30);
            textBuscarMateria.Name = "textBuscarMateria";
            textBuscarMateria.Size = new Size(200, 23);
            textBuscarMateria.TabIndex = 2;
            textBuscarMateria.TextChanged += textBuscarMateria_TextChanged;
            // 
            // comboMateria
            // 
            comboMateria.FormattingEnabled = true;
            comboMateria.Location = new Point(610, 30);
            comboMateria.Name = "comboMateria";
            comboMateria.Size = new Size(200, 23);
            comboMateria.TabIndex = 3;
            // 
            // comboDia1
            // 
            comboDia1.FormattingEnabled = true;
            comboDia1.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });
            comboDia1.Location = new Point(20, 90);
            comboDia1.Name = "comboDia1";
            comboDia1.Size = new Size(120, 23);
            comboDia1.TabIndex = 4;
            // 
            // timeInicio1
            // 
            timeInicio1.Format = DateTimePickerFormat.Time;
            timeInicio1.Location = new Point(256, 87);
            timeInicio1.Name = "timeInicio1";
            timeInicio1.ShowUpDown = true;
            timeInicio1.Size = new Size(200, 23);
            timeInicio1.TabIndex = 5;
            // 
            // timeFin1
            // 
            timeFin1.Format = DateTimePickerFormat.Time;
            timeFin1.Location = new Point(480, 87);
            timeFin1.Name = "timeFin1";
            timeFin1.ShowUpDown = true;
            timeFin1.Size = new Size(200, 23);
            timeFin1.TabIndex = 6;
            // 
            // comboDia2
            // 
            comboDia2.FormattingEnabled = true;
            comboDia2.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });
            comboDia2.Location = new Point(20, 133);
            comboDia2.Name = "comboDia2";
            comboDia2.Size = new Size(120, 23);
            comboDia2.TabIndex = 7;
            // 
            // timeInicio2
            // 
            timeInicio2.Format = DateTimePickerFormat.Time;
            timeInicio2.Location = new Point(256, 130);
            timeInicio2.Name = "timeInicio2";
            timeInicio2.ShowUpDown = true;
            timeInicio2.Size = new Size(200, 23);
            timeInicio2.TabIndex = 8;
            // 
            // timeFin2
            // 
            timeFin2.Format = DateTimePickerFormat.Time;
            timeFin2.Location = new Point(480, 130);
            timeFin2.Name = "timeFin2";
            timeFin2.ShowUpDown = true;
            timeFin2.Size = new Size(200, 23);
            timeFin2.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(994, 80);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(980, 23);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 30);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridViewHorario
            // 
            dataGridViewHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorario.Location = new Point(20, 180);
            dataGridViewHorario.Name = "dataGridViewHorario";
            dataGridViewHorario.Size = new Size(790, 386);
            dataGridViewHorario.TabIndex = 12;
            // 
            // labelCarrera
            // 
            labelCarrera.Location = new Point(20, 10);
            labelCarrera.Name = "labelCarrera";
            labelCarrera.Size = new Size(100, 23);
            labelCarrera.TabIndex = 13;
            labelCarrera.Text = "Carrera:";
            // 
            // labelSemestre
            // 
            labelSemestre.Location = new Point(217, 9);
            labelSemestre.Name = "labelSemestre";
            labelSemestre.Size = new Size(100, 23);
            labelSemestre.TabIndex = 14;
            labelSemestre.Text = "Semestre:";
            // 
            // labelBuscarMateria
            // 
            labelBuscarMateria.Location = new Point(348, 9);
            labelBuscarMateria.Name = "labelBuscarMateria";
            labelBuscarMateria.Size = new Size(100, 23);
            labelBuscarMateria.TabIndex = 15;
            labelBuscarMateria.Text = "Buscar Materia:";
            // 
            // labelMateria
            // 
            labelMateria.Location = new Point(610, 9);
            labelMateria.Name = "labelMateria";
            labelMateria.Size = new Size(100, 23);
            labelMateria.TabIndex = 16;
            labelMateria.Text = "Materia:";
            // 
            // labelDia1
            // 
            labelDia1.Location = new Point(20, 70);
            labelDia1.Name = "labelDia1";
            labelDia1.Size = new Size(100, 23);
            labelDia1.TabIndex = 17;
            labelDia1.Text = "Día 1:";
            // 
            // labelHora1
            // 
            labelHora1.Location = new Point(150, 93);
            labelHora1.Name = "labelHora1";
            labelHora1.Size = new Size(100, 23);
            labelHora1.TabIndex = 18;
            labelHora1.Text = "Hora Inicio/Fin:";
            // 
            // labelDia2
            // 
            labelDia2.Location = new Point(20, 116);
            labelDia2.Name = "labelDia2";
            labelDia2.Size = new Size(100, 23);
            labelDia2.TabIndex = 19;
            labelDia2.Text = "Día 2:";
            // 
            // labelHora2
            // 
            labelHora2.Location = new Point(150, 133);
            labelHora2.Name = "labelHora2";
            labelHora2.Size = new Size(100, 23);
            labelHora2.TabIndex = 20;
            labelHora2.Text = "Hora Inicio/Fin:";
            // 
            // Form5
            // 
            ClientSize = new Size(1328, 589);
            Controls.Add(comboCarrera);
            Controls.Add(comboSemestre);
            Controls.Add(textBuscarMateria);
            Controls.Add(comboMateria);
            Controls.Add(comboDia1);
            Controls.Add(timeInicio1);
            Controls.Add(timeFin1);
            Controls.Add(comboDia2);
            Controls.Add(timeInicio2);
            Controls.Add(timeFin2);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(dataGridViewHorario);
            Controls.Add(labelCarrera);
            Controls.Add(labelSemestre);
            Controls.Add(labelBuscarMateria);
            Controls.Add(labelMateria);
            Controls.Add(labelDia1);
            Controls.Add(labelHora1);
            Controls.Add(labelDia2);
            Controls.Add(labelHora2);
            Name = "Form5";
            Text = "Asignación de Horarios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboCarrera;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.TextBox textBuscarMateria;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.ComboBox comboDia1;
        private System.Windows.Forms.DateTimePicker timeInicio1;
        private System.Windows.Forms.DateTimePicker timeFin1;
        private System.Windows.Forms.ComboBox comboDia2;
        private System.Windows.Forms.DateTimePicker timeInicio2;
        private System.Windows.Forms.DateTimePicker timeFin2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridViewHorario;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Label labelBuscarMateria;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelDia1;
        private System.Windows.Forms.Label labelHora1;
        private System.Windows.Forms.Label labelDia2;
        private System.Windows.Forms.Label labelHora2;
    }
}
