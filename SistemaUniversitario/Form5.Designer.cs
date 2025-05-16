namespace UniversidadApp
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
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
        private System.Windows.Forms.Label labelHoraInicio1;
        private System.Windows.Forms.Label labelHoraFin1;
        private System.Windows.Forms.Label labelDia2;
        private System.Windows.Forms.Label labelHoraInicio2;
        private System.Windows.Forms.Label labelHoraFin2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.comboDia1 = new System.Windows.Forms.ComboBox();
            this.comboDia2 = new System.Windows.Forms.ComboBox();
            this.timeInicio1 = new System.Windows.Forms.DateTimePicker();
            this.timeFin1 = new System.Windows.Forms.DateTimePicker();
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

            // comboSemestre
            this.comboSemestre.Location = new System.Drawing.Point(120, 20);
            this.comboSemestre.Name = "comboSemestre";
            this.comboSemestre.Size = new System.Drawing.Size(121, 21);

            // labelSemestre
            this.labelSemestre.Location = new System.Drawing.Point(20, 20);
            this.labelSemestre.Text = "Semestre:";

            // comboMateria
            this.comboMateria.Location = new System.Drawing.Point(120, 50);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(200, 21);

            // labelMateria
            this.labelMateria.Location = new System.Drawing.Point(20, 50);
            this.labelMateria.Text = "Materia:";

            // comboDia1
            this.comboDia1.Location = new System.Drawing.Point(120, 90);
            this.comboDia1.Name = "comboDia1";
            this.comboDia1.Size = new System.Drawing.Size(121, 21);
            this.comboDia1.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });

            // labelDia1
            this.labelDia1.Location = new System.Drawing.Point(20, 90);
            this.labelDia1.Text = "Día 1:";

            // timeInicio1
            this.timeInicio1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeInicio1.ShowUpDown = true;
            this.timeInicio1.Location = new System.Drawing.Point(120, 120);
            this.timeInicio1.Name = "timeInicio1";
            this.timeInicio1.Size = new System.Drawing.Size(100, 20);

            // labelHoraInicio1
            this.labelHoraInicio1.Location = new System.Drawing.Point(20, 120);
            this.labelHoraInicio1.Text = "Inicio 1:";

            // timeFin1
            this.timeFin1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFin1.ShowUpDown = true;
            this.timeFin1.Location = new System.Drawing.Point(120, 150);
            this.timeFin1.Name = "timeFin1";
            this.timeFin1.Size = new System.Drawing.Size(100, 20);

            // labelHoraFin1
            this.labelHoraFin1.Location = new System.Drawing.Point(20, 150);
            this.labelHoraFin1.Text = "Fin 1:";

            // comboDia2
            this.comboDia2.Location = new System.Drawing.Point(120, 190);
            this.comboDia2.Name = "comboDia2";
            this.comboDia2.Size = new System.Drawing.Size(121, 21);
            this.comboDia2.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });

            // labelDia2
            this.labelDia2.Location = new System.Drawing.Point(20, 190);
            this.labelDia2.Text = "Día 2 (opcional):";

            // timeInicio2
            this.timeInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeInicio2.ShowUpDown = true;
            this.timeInicio2.Location = new System.Drawing.Point(120, 220);
            this.timeInicio2.Name = "timeInicio2";
            this.timeInicio2.Size = new System.Drawing.Size(100, 20);

            // labelHoraInicio2
            this.labelHoraInicio2.Location = new System.Drawing.Point(20, 220);
            this.labelHoraInicio2.Text = "Inicio 2:";

            // timeFin2
            this.timeFin2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFin2.ShowUpDown = true;
            this.timeFin2.Location = new System.Drawing.Point(120, 250);
            this.timeFin2.Name = "timeFin2";
            this.timeFin2.Size = new System.Drawing.Size(100, 20);

            // labelHoraFin2
            this.labelHoraFin2.Location = new System.Drawing.Point(20, 250);
            this.labelHoraFin2.Text = "Fin 2:";

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(120, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnVolver
            this.btnVolver.Location = new System.Drawing.Point(20, 290);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // dataGridViewHorario
            this.dataGridViewHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorario.Location = new System.Drawing.Point(350, 20);
            this.dataGridViewHorario.Name = "dataGridViewHorario";
            this.dataGridViewHorario.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewHorario.TabIndex = 0;

            // Form5
            this.ClientSize = new System.Drawing.Size(980, 360);
            this.Controls.Add(this.comboSemestre);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.comboDia1);
            this.Controls.Add(this.comboDia2);
            this.Controls.Add(this.timeInicio1);
            this.Controls.Add(this.timeFin1);
            this.Controls.Add(this.timeInicio2);
            this.Controls.Add(this.timeFin2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridViewHorario);

            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelDia1);
            this.Controls.Add(this.labelHoraInicio1);
            this.Controls.Add(this.labelHoraFin1);
            this.Controls.Add(this.labelDia2);
            this.Controls.Add(this.labelHoraInicio2);
            this.Controls.Add(this.labelHoraFin2);

            this.Name = "Form5";
            this.Text = "Gestión de Horarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
