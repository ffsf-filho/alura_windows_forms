using System.Drawing;
using System.Windows.Forms;
using CursoWindowsForms.Bibliotecas;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, System.EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Resultado.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();
            Lbl_Resultado.ForeColor = Color.White;

            switch (forca)
            {
                case ChecaForcaSenha.ForcaDaSenha.Forte:
                    Lbl_Resultado.BackColor = Color.Green;
                    break;
                case ChecaForcaSenha.ForcaDaSenha.Aceitavel:
                    Lbl_Resultado.BackColor = Color.Red;
                    break;
                case ChecaForcaSenha.ForcaDaSenha.Segura:
                    Lbl_Resultado.BackColor = Color.Blue;
                    break;
                case ChecaForcaSenha.ForcaDaSenha.Inaceitavel:
                    Lbl_Resultado.BackColor = Color.Red;
                    break;
                default:
                    Lbl_Resultado.BackColor = Color.Yellow;
                    break;
            }
        }

        private void Btn_Versenha_Click(object sender, System.EventArgs e)
        {
            if (Txt_Senha.PasswordChar.Equals('*'))
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_Versenha.Text = "Ocultar Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                Btn_Versenha.Text = "Ver Senha";
            }
        }
    }
}
