using System;
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

                ItemMenu item1 = new ItemMenu("Item do menu 1", "Frm_DemonstracaoKey");

                List<ItemMenu> menu1DropDown = new List<ItemMenu>
                {
                    new ItemMenu("Mascara", "Frm_Mascara"),
                    new ItemMenu("Menu 1.2")
                };

                ContextMenu.Items.Add(DesenhaItemMenu(item1,menu1DropDown));
                
                ItemMenu item2 = new ItemMenu("Item do menu 2");
                ToolStripMenuItem vToolTipItem2 = DesenhaItemMenu(item2);
                ContextMenu.Items.Add(vToolTipItem2);

                ItemMenu item3 = new ItemMenu("Valida CPF", "Frm_ValidaCPF");
                ToolStripMenuItem vToolTipItem3 = DesenhaItemMenu(item3);
                ContextMenu.Items.Add(vToolTipItem3);
                
                ContextMenu.Show(this,new Point(e.X, e.Y));
                vToolTipItem2.Click += new EventHandler(vToolTipItem2_Click);
                vToolTipItem3.Click += new EventHandler(vToolTipItem3_Click);
            }
        }

        void vToolTipItem2_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Selecionado o Item do menu 2");
        }

        void vToolTipItem3_Click(object sender1, EventArgs e1)
        {
            MessageBox.Show("Selecionado Valida CPF");
        }

        private ToolStripMenuItem DesenhaItemMenu(ItemMenu menu, List<ItemMenu> listaDropDown = null)
        {
            ToolStripMenuItem vTooTip = new ToolStripMenuItem();
            vTooTip.Text = menu.textoMenu;

            if (!string.IsNullOrWhiteSpace(menu.nomeImage))
            {
                Image image = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(menu.nomeImage);
                vTooTip.Image = image;
            }


            if (listaDropDown != null)
            {
                foreach (ItemMenu item in listaDropDown)
                {
                    if (string.IsNullOrWhiteSpace(item.nomeImage))
                    {
                        vTooTip.DropDownItems.Add(item.textoMenu);
                    }
                    else
                    {
                        Image image = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(item.nomeImage);
                        vTooTip.DropDownItems.Add(item.textoMenu,image);
                    }
                }
            }

            return vTooTip;
        }

        private class ItemMenu
        {
            public string textoMenu { get; set; }
            public string nomeImage { get; set; }
            
            public ItemMenu(string nomeMenu, string imagem = null)
            {
                this.textoMenu = nomeMenu;
                this.nomeImage = imagem;
            }
        }
    }
}
