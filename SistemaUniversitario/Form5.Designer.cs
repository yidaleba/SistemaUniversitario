namespace UniversidadApp
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.comboDia1 = new System.Windows.Forms.ComboBox();
            this.timeInicio1 = new System.Windows.Forms.DateTimePicker();
            this.timeFin1 = new System.Windows.Forms.DateTimePicker();
            this.comboDia2 = new System.Windows.Forms.ComboBox();
            this.timeInicio2 = new System.Windows.Forms.DateTimePicker();
            this.timeFin2 = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridViewHorario = new System.Windows.Forms.DataGridView();

            this.labelSemestre = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelDia1 = new System.Windows.Forms.Label();
            this.labelHoraInicio1 = new System.Windows.Forms.Label();
            this.labelHoraFin1 = new System.Windows.Forms.Label();
            this.labelDia2 = new System.Windows.Forms.Label();
            this.labelHoraInicio2 = new System.Windows.Forms.Label();
            this.labelHoraFin2 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).BeginInit();
            this.SuspendLayout();

            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Location = new System.Drawing.Point(12, 15);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(54, 13);
            this.labelSemestre.TabIndex = 20;
            this.labelSemestre.Text = "Semestre:";
            // 
            // comboSemestre
            // 
            this.comboSemestre.FormattingEnabled = true;
            this.comboSemestre.Location = new System.Drawing.Point(70, 12);
            this.comboSemestre.Name = "comboSemestre";
            this.comboSemestre.Size = new System.Drawing.Size(60, 21);
            this.comboSemestre.TabIndex = 0;
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(140, 15);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(44, 13);
            this.labelMateria.TabIndex = 21;
            this.labelMateria.Text = "Materia:";
            // 
            // comboMateria
            // 
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(190, 12);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(250, 21);
            this.comboMateria.TabIndex = 1;
            // 
            // labelDia1
            // 
            this.labelDia1.AutoSize = true;
            this.labelDia1.Location = new System.Drawing.Point(12, 53);
            this.labelDia1.Name = "labelDia1";
            this.labelDia1.Size = new System.Drawing.Size(23, 13);
            this.labelDia1.TabIndex = 22;
            this.labelDia1.Text = "Día:";
            // 
            // comboDia1
            // 
            this.comboDia1.FormattingEnabled = true;
            this.comboDia1.Items.AddRange(new object[] {
            "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"});
            this.comboDia1.Location = new System.Drawing.Point(41, 50);
            this.comboDia1.Name = "comboDia1";
            this.comboDia1.Size = new System.Drawing.Size(100, 21);
            this.comboDia1.TabIndex = 2;
            // 
            // labelHoraInicio1
            // 
            this.labelHoraInicio1.AutoSize = true;
            this.labelHoraInicio1.Location = new System.Drawing.Point(150, 53);
            this.labelHoraInicio1.Name = "labelHoraInicio1";
            this.labelHoraInicio1.Size = new System.Drawing.Size(64, 13);
            this.labelHoraInicio1.TabIndex = 23;
            this.labelHoraInicio1.Text = "Hora Inicio:";
            // 
            // timeInicio1
            // 
            this.timeInicio1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInicio1.CustomFormat = "HH:00";
            this.timeInicio1.ShowUpDown = true;
            this.timeInicio1.Location = new System.Drawing.Point(220, 50);
            this.timeInicio1.Name = "timeInicio1";
            this.timeInicio1.Size = new System.Drawing.Size(70, 20);
            this.timeInicio1.TabIndex = 3;
            // 
            // labelHoraFin1
            // 
            this.labelHoraFin1.AutoSize = true;
            this.labelHoraFin1.Location = new System.Drawing.Point(300, 53);
            this.labelHoraFin1.Name = "labelHoraFin1";
            this.labelHoraFin1.Size = new System.Drawing.Size(51, 13);
            this.labelHoraFin1.TabIndex = 24;
            this.labelHoraFin1.Text = "Hora Fin:";
            // 
            // timeFin1
            // 
            this.timeFin1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFin1.CustomFormat = "HH:00";
            this.timeFin1.ShowUpDown = true;
            this.timeFin1.Location = new System.Drawing.Point(360, 50);
            this.timeFin1.Name = "timeFin1";
            this.timeFin1.Size = new System.Drawing.Size(70, 20);
            this.timeFin1.TabIndex = 4;
            // 
            // labelDia2
            // 
            this.labelDia2.AutoSize = true;
            this.labelDia2.Location = new System.Drawing.Point(12, 88);
            this.labelDia2.Name = "labelDia2";
            this.labelDia2.Size = new System.Drawing.Size(23, 13);
            this.labelDia2.TabIndex = 25;
            this.labelDia2.Text = "Día:";
            // 
            // comboDia2
            // 
            this.comboDia2.FormattingEnabled = true;
            this.comboDia2.Items.AddRange(new object[] {
            "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"});
            this.comboDia2.Location = new System.Drawing.Point(41, 85);
            this.comboDia2.Name = "comboDia2";
            this.comboDia2.Size = new System.Drawing.Size(100, 21);
            this.comboDia2.TabIndex = 5;
            // 
            // labelHoraInicio2
            // 
            this.labelHoraInicio2.AutoSize = true;
            this.labelHoraInicio2.Location = new System.Drawing.Point(150, 88);
            this.labelHoraInicio2.Name = "labelHoraInicio2";
            this.labelHoraInicio2.Size = new System.Drawing.Size(64, 13);
            this.labelHoraInicio2.TabIndex = 26;
            this.labelHoraInicio2.Text = "Hora Inicio:";
            // 
            // timeInicio2
            // 
            this.timeInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInicio2.CustomFormat = "HH:00";
            this.timeInicio2.ShowUpDown = true;
            this.timeInicio2.Location = new System.Drawing.Point(220, 85);
            this.timeInicio2.Name = "timeInicio2";
            this.timeInicio2.Size = new System.Drawing.Size(70, 20);
            this.timeInicio2.TabIndex = 6;
            // 
            // labelHoraFin2
            // 
            this.labelHoraFin2.AutoSize = true;
            this.labelHoraFin2.Location = new System.Drawing.Point(300, 88);
            this.labelHoraFin2.Name = "labelHoraFin2";
            this.labelHoraFin2.Size = new System.Drawing.Size(51, 13);
            this.labelHoraFin2.TabIndex = 27;
            this.labelHoraFin2.Text = "Hora Fin:";
            // 
            // timeFin2
            // 
            this.timeFin2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFin2.CustomFormat = "HH:00";
            this.timeFin2.ShowUpDown = true;
            this.timeFin2.Location = new System.Drawing.Point(360, 85);
            this.timeFin2.Name = "timeFin2";
            this.timeFin2.Size = new System.Drawing.Size(70, 20);
            this.timeFin2.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(450, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Horario";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(450, 50);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver a Form3";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridViewHorario
            // 
            this.dataGridViewHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorario.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewHorario.Name = "dataGridViewHorario";
            this.dataGridViewHorario.Size = new System.Drawing.Size(760, 320);
            this.dataGridViewHorario.TabIndex = 10;
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewHorario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.timeFin2);
            this.Controls.Add(this.timeInicio2);
            this.Controls.Add(this.labelHoraFin2);
            this.Controls.Add(this.comboDia2);
            this.Controls.Add(this.labelDia2);
            this.Controls.Add(this.labelHoraInicio2);
            this.Controls.Add(this.timeFin1);
            this.Controls.Add(this.timeInicio1);
            this.Controls.Add(this.labelHoraFin1);
            this.Controls.Add(this.labelHoraInicio1);
            this.Controls.Add(this.comboDia1);
            this.Controls.Add(this.labelDia1);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.comboSemestre);
            this.Controls.Add(this.labelSemestre);
            this.Name = "Form5";
            this.Text = "Gestión de Horarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSemestre;
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

        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelDia1;
        private System.Windows.Forms.Label labelHoraInicio1;
        private System.Windows.Forms.Label labelHoraFin1;
        private System.Windows.Forms.Label labelDia2;
        private System.Windows.Forms.Label labelHoraInicio2;
        private System.Windows.Forms.Label labelHoraFin2;
    }
}