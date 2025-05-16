using System;
using System.Windows.Forms;

namespace SistemaUniversitario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnIngCivil_Click(object sender, EventArgs e)
        {
            
            Form3 formCivil = new Form3();
            formCivil.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Cierra Form4 y vuelve a Form3
        }


        private void btnMecatronica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carrera: Mecatrónica");
        }

        private void btnDerecho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carrera: Derecho");
        }
    }
}
