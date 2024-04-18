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
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            configuraMascara("00:00");
            limpaFormulario();
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            configuraMascara("00000-000");
            limpaFormulario();
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            configuraMascara("$ 000,000,000.00");
            limpaFormulario();
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            configuraMascara("00/00/0000");
            limpaFormulario();
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            configuraMascara("000000", true);
            limpaFormulario();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            configuraMascara("(00) 0000-0000");
            limpaFormulario();
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_Conteudo.Text = Msk_TextBox.Text;
        }

        private void configuraMascara(string mascara, bool passwordvalue = false)
        {
            Msk_TextBox.UseSystemPasswordChar = passwordvalue;
            Msk_TextBox.Mask = mascara;
            Lbl_MascaraAtiva.Text = mascara;
        }

        private void limpaFormulario()
        {
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }
    }
}
