namespace SistemaUniversitario
{
    partial class Form2
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

        private System.Windows.Forms.Button btnIngCivil;
        private System.Windows.Forms.Button btnMecatronica;
        private System.Windows.Forms.Button btnDerecho;

        private void InitializeComponent()
        {
            btnIngCivil = new Button();
            btnMecatronica = new Button();
            btnDerecho = new Button();
            SuspendLayout();
            // 
            // btnIngCivil
            // 
            btnIngCivil.Location = new Point(84, 48);
            btnIngCivil.Margin = new Padding(3, 2, 3, 2);
            btnIngCivil.Name = "btnIngCivil";
            btnIngCivil.Size = new Size(175, 30);
            btnIngCivil.TabIndex = 0;
            btnIngCivil.Text = "Ingeniería Civil";
            btnIngCivil.UseVisualStyleBackColor = true;
            btnIngCivil.Click += btnIngCivil_Click;
            // 
            // btnMecatronica
            // 
            btnMecatronica.Location = new Point(84, 86);
            btnMecatronica.Margin = new Padding(3, 2, 3, 2);
            btnMecatronica.Name = "btnMecatronica";
            btnMecatronica.Size = new Size(175, 30);
            btnMecatronica.TabIndex = 1;
            btnMecatronica.Text = "Mecatrónica";
            btnMecatronica.UseVisualStyleBackColor = true;
            btnMecatronica.Click += btnMecatronica_Click;
            // 
            // btnDerecho
            // 
            btnDerecho.Location = new Point(84, 124);
            btnDerecho.Margin = new Padding(3, 2, 3, 2);
            btnDerecho.Name = "btnDerecho";
            btnDerecho.Size = new Size(175, 30);
            btnDerecho.TabIndex = 2;
            btnDerecho.Text = "Derecho";
            btnDerecho.UseVisualStyleBackColor = true;
            btnDerecho.Click += btnDerecho_Click;
            // 
            // Form2
            // 
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnRegresar.Location = new System.Drawing.Point(10, 10);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 30);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            this.Controls.Add(this.btnRegresar);

            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(btnDerecho);
            Controls.Add(btnMecatronica);
            Controls.Add(btnIngCivil);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Carreras";
            ResumeLayout(false);
        }

        #endregion
    }
}
