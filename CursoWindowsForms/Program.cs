using CursoWindowsForms.Formularios_Curso_3;
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_MouseCursor());
        }
    }
}
