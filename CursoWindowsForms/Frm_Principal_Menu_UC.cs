using CursoWindowsForms.Formularios_UC_Curso_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemostracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }

        private void demosntracaoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemostracaoKey += 1;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage();
            TB.Name = $"Demostração Key {ControleDemostracaoKey}";
            TB.Text = $"Demostração Key {ControleDemostracaoKey}";
            TB.ImageIndex = 0 ;
            TB.Controls.Add(U);

            Tbc_Aplicacoes.Controls.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage();
            TB.Name = $"Hello World {ControleHelloWorld}";
            TB.Text = $"Hello World {ControleHelloWorld}";
            TB.ImageIndex = 1;
            TB.Controls.Add(U);

            Tbc_Aplicacoes.Controls.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage();
            TB.Name = $"Mascara {ControleMascara}";
            TB.Text = $"Mascara {ControleMascara}";
            TB.ImageIndex = 2;
            TB.Controls.Add(U);

            Tbc_Aplicacoes.Controls.Add(TB);
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;

            TabPage TB = new TabPage();
            TB.Name = $"Valida CPF {ControleValidaCPF}";
            TB.Text = $"Valida CPF {ControleValidaCPF}";
            TB.ImageIndex = 3;
            TB.Controls.Add(U);

            Tbc_Aplicacoes.Controls.Add(TB);
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f = new Frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }
    }
}
