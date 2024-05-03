using System.Drawing;
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
                //MessageBox.Show($"Cliquei com o botão {e.Button.ToString()}, na posição ({e.X},{e.Y})", "Botão Pressionado");
                ContextMenuStrip ContextMenu = new ContextMenuStrip();
                ToolStripMenuItem vTooTip001 = new ToolStripMenuItem();
                vTooTip001.Text = "Item do menu 1";

                ContextMenu.Items.Add(vTooTip001);
                ContextMenu.Show(this,new Point(e.X, e.Y));
            }
        }
    }
}
