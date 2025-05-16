using System;
using System.Windows.Forms;


namespace SistemaUniversitario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección: Cursos");
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            
            Form2 formCarreras = new Form2();
            formCarreras.Show();
            this.Hide();
        }

        private void btnPostgrados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección: Postgrados");
        }

        private void btnEspecializaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sección: Especializaciones");
        }
    }
}
