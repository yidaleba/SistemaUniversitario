using System;
using System.Windows.Forms;
using UniversidadApp;  

namespace SistemaUniversitario
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
           
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Cierra Form4 y vuelve a Form3
        }
        private void btnHorarios_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
