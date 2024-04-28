using CursoWindowsFormsBiblioteca.ClassesUteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Formularios_UC_Curso_1
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
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

        private void Btn_Versenha_Click(object sender, EventArgs e)
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
