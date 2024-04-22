using CursoWindowsForms.Bibliotecas;
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }


        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();

            if (string.IsNullOrWhiteSpace(vConteudo) || vConteudo.Length < 11)
            {
                MessageBox.Show("Você deve digitar um CPF, ele deve conter 11 digitos.", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ValidaCPF validaCPF = new ValidaCPF();
                    bool cpfValido = validaCPF.Valida(Msk_CPF.Text);

                    if (cpfValido)
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
            Msk_CPF.Focus();
        }
    }
}
