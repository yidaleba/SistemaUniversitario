namespace SistemaUniversitario
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRegresar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnHorarios;

        private void InitializeComponent()
        {
            btnMaterias = new Button();
            btnHorarios = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // btnMaterias
            // 
            btnMaterias.Location = new Point(58, 50);
            btnMaterias.Margin = new Padding(3, 2, 3, 2);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(175, 30);
            btnMaterias.TabIndex = 0;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnHorarios
            // 
            btnHorarios.Location = new Point(58, 96);
            btnHorarios.Margin = new Padding(3, 2, 3, 2);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(175, 30);
            btnHorarios.TabIndex = 1;
            btnHorarios.Text = "Horarios";
            btnHorarios.UseVisualStyleBackColor = true;
            btnHorarios.Click += btnHorarios_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(9, 8);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(88, 22);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnHorarios);
            Controls.Add(btnMaterias);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Ingeniería Civil";
            ResumeLayout(false);
        }

        #endregion
    }
}
