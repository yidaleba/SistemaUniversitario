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
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.comboDia1 = new System.Windows.Forms.ComboBox();
            this.comboDia2 = new System.Windows.Forms.ComboBox();
            this.timeInicio1 = new System.Windows.Forms.DateTimePicker();
            this.timeFin1 = new System.Windows.Forms.DateTimePicker();
            this.timeInicio2 = new System.Windows.Forms.DateTimePicker();
            this.timeFin2 = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridViewHorario = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();

            this.labelSemestre = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelDia1 = new System.Windows.Forms.Label();
            this.labelDia2 = new System.Windows.Forms.Label();
            this.labelHoraInicio1 = new System.Windows.Forms.Label();
            this.labelHoraFin1 = new System.Windows.Forms.Label();
            this.labelHoraInicio2 = new System.Windows.Forms.Label();
            this.labelHoraFin2 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).BeginInit();
            this.SuspendLayout();

            // Labels
            this.labelSemestre.Text = "Semestre:";
            this.labelSemestre.Location = new System.Drawing.Point(20, 20);
            this.labelSemestre.Size = new System.Drawing.Size(80, 20);

            this.labelMateria.Text = "Materia:";
            this.labelMateria.Location = new System.Drawing.Point(20, 60);
            this.labelMateria.Size = new System.Drawing.Size(80, 20);

            this.labelDia1.Text = "Día 1:";
            this.labelDia1.Location = new System.Drawing.Point(20, 100);
            this.labelDia1.Size = new System.Drawing.Size(80, 20);

            this.labelHoraInicio1.Text = "Hora inicio:";
            this.labelHoraInicio1.Location = new System.Drawing.Point(250, 100);
            this.labelHoraInicio1.Size = new System.Drawing.Size(80, 20);

            this.labelHoraFin1.Text = "Hora fin:";
            this.labelHoraFin1.Location = new System.Drawing.Point(450, 100);
            this.labelHoraFin1.Size = new System.Drawing.Size(80, 20);

            this.labelDia2.Text = "Día 2:";
            this.labelDia2.Location = new System.Drawing.Point(20, 140);
            this.labelDia2.Size = new System.Drawing.Size(80, 20);

            this.labelHoraInicio2.Text = "Hora inicio:";
            this.labelHoraInicio2.Location = new System.Drawing.Point(250, 140);
            this.labelHoraInicio2.Size = new System.Drawing.Size(80, 20);

            this.labelHoraFin2.Text = "Hora fin:";
            this.labelHoraFin2.Location = new System.Drawing.Point(450, 140);
            this.labelHoraFin2.Size = new System.Drawing.Size(80, 20);

            // ComboBoxes
            this.comboSemestre.Location = new System.Drawing.Point(100, 20);
            this.comboSemestre.Size = new System.Drawing.Size(200, 24);

            this.comboMateria.Location = new System.Drawing.Point(100, 60);
            this.comboMateria.Size = new System.Drawing.Size(400, 24);

            this.comboDia1.Location = new System.Drawing.Point(100, 100);
            this.comboDia1.Size = new System.Drawing.Size(140, 24);
            this.comboDia1.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });

            this.comboDia2.Location = new System.Drawing.Point(100, 140);
            this.comboDia2.Size = new System.Drawing.Size(140, 24);
            this.comboDia2.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado" });

            // TimePickers
            this.timeInicio1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInicio1.CustomFormat = "HH:00";
            this.timeInicio1.ShowUpDown = true;
            this.timeInicio1.Location = new System.Drawing.Point(330, 100);
            this.timeInicio1.Width = 100;

            this.timeFin1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFin1.CustomFormat = "HH:00";
            this.timeFin1.ShowUpDown = true;
            this.timeFin1.Location = new System.Drawing.Point(530, 100);
            this.timeFin1.Width = 100;

            this.timeInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInicio2.CustomFormat = "HH:00";
            this.timeInicio2.ShowUpDown = true;
            this.timeInicio2.Location = new System.Drawing.Point(330, 140);
            this.timeInicio2.Width = 100;

            this.timeFin2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFin2.CustomFormat = "HH:00";
            this.timeFin2.ShowUpDown = true;
            this.timeFin2.Location = new System.Drawing.Point(530, 140);
            this.timeFin2.Width = 100;

            // Botón Guardar
            this.btnGuardar.Text = "Guardar horario";
            this.btnGuardar.Location = new System.Drawing.Point(650, 120);
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Botón Volver
            this.btnVolver.Text = "Volver";
            this.btnVolver.Location = new System.Drawing.Point(650, 20);
            this.btnVolver.Size = new System.Drawing.Size(120, 30);
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // DataGridView
            this.dataGridViewHorario.Location = new System.Drawing.Point(20, 200);
            this.dataGridViewHorario.Size = new System.Drawing.Size(750, 300);

            // Form
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelDia1);
            this.Controls.Add(this.labelDia2);
            this.Controls.Add(this.labelHoraInicio1);
            this.Controls.Add(this.labelHoraFin1);
            this.Controls.Add(this.labelHoraInicio2);
            this.Controls.Add(this.labelHoraFin2);
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
            this.Text = "Gestión de Horarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).EndInit();
            this.ResumeLayout(false);
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
