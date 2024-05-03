using System.Windows.Forms;

namespace CursoWindowsForms.Formularios_Curso_3
{
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Cliquei com o botão {e.Button.ToString()}", "Botão Pressionado");
            }
        }
    }
}
