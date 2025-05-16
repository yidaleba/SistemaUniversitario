namespace SistemaUniversitario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnPostgrados;
        private System.Windows.Forms.Button btnEspecializaciones;

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCursos = new Button();
            btnCarreras = new Button();
            btnPostgrados = new Button();
            btnEspecializaciones = new Button();
            SuspendLayout();
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(304, 82);
            btnCursos.Margin = new Padding(3, 2, 3, 2);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(175, 30);
            btnCursos.TabIndex = 0;
            btnCursos.Text = "Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnCarreras
            // 
            btnCarreras.Location = new Point(304, 120);
            btnCarreras.Margin = new Padding(3, 2, 3, 2);
            btnCarreras.Name = "btnCarreras";
            btnCarreras.Size = new Size(175, 30);
            btnCarreras.TabIndex = 1;
            btnCarreras.Text = "Carreras";
            btnCarreras.UseVisualStyleBackColor = true;
            btnCarreras.Click += btnCarreras_Click;
            // 
            // btnPostgrados
            // 
            btnPostgrados.Location = new Point(304, 158);
            btnPostgrados.Margin = new Padding(3, 2, 3, 2);
            btnPostgrados.Name = "btnPostgrados";
            btnPostgrados.Size = new Size(175, 30);
            btnPostgrados.TabIndex = 2;
            btnPostgrados.Text = "Postgrados";
            btnPostgrados.UseVisualStyleBackColor = true;
            btnPostgrados.Click += btnPostgrados_Click;
            // 
            // btnEspecializaciones
            // 
            btnEspecializaciones.Location = new Point(304, 195);
            btnEspecializaciones.Margin = new Padding(3, 2, 3, 2);
            btnEspecializaciones.Name = "btnEspecializaciones";
            btnEspecializaciones.Size = new Size(175, 30);
            btnEspecializaciones.TabIndex = 3;
            btnEspecializaciones.Text = "Especializaciones";
            btnEspecializaciones.UseVisualStyleBackColor = true;
            btnEspecializaciones.Click += btnEspecializaciones_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 525);
            Controls.Add(btnCursos);
            Controls.Add(btnCarreras);
            Controls.Add(btnPostgrados);
            Controls.Add(btnEspecializaciones);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Sistema Universitario";
            ResumeLayout(false);
        }

        #endregion
    }
}
