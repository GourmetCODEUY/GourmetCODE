using System;
using System.Windows.Forms;
using proyecto.Presentacion;

namespace TuProyecto
{
    static class Ejecutor
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin formLogin = new FormLogin();
            Application.Run(formLogin);
        }
    }
}
