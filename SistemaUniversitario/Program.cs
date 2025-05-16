using System;
using System.Windows.Forms;

namespace SistemaUniversitario
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos una instancia del formulario inicial
            Form1 formPrincipal = new Form1();

            // Usamos Application.Run con un ApplicationContext personalizado
            Application.Run(new CustomContext(formPrincipal));
        }
    }

    public class CustomContext : ApplicationContext
    {
        public CustomContext(Form formInicial)
        {
            formInicial.FormClosed += (s, e) =>
            {
                if (Application.OpenForms.Count == 0)
                {
                    ExitThread(); // Salir de la aplicación cuando no quedan formularios abiertos
                }
            };

            formInicial.Show();
        }
    }
}
