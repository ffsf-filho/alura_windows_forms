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

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
            Msk_CPF.Focus();
        }
    }
}
