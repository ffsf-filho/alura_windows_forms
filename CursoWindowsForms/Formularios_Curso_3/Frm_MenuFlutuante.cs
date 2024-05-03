using System.Collections.Generic;
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

                List<string> menu1 = new List<string>() { "Menu 1.1", "Menu 1.2" };
                ContextMenu.Items.Add(DesenhaItemMenu("Item do menu 1",menu1));
                ContextMenu.Items.Add(DesenhaItemMenu("Item do menu 2"));
                ContextMenu.Items.Add(DesenhaItemMenu("Item do menu 3"));
                
                ContextMenu.Show(this,new Point(e.X, e.Y));
            }
        }

        private ToolStripMenuItem DesenhaItemMenu(string texto, List<string> listaDropDown = null)
        {
            ToolStripMenuItem vTooTip = new ToolStripMenuItem();
            vTooTip.Text = texto;

            if (listaDropDown != null)
            {
                foreach (string item in listaDropDown)
                {
                    vTooTip.DropDownItems.Add(item);
                }
            }

            return vTooTip;
        }
    }
}
