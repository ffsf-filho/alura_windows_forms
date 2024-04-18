using System;
using System.Drawing;
using System.Windows.Forms;
using CursoWindowsForms.Bibliotecas;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            ValidaCPF validaCPF = new ValidaCPF();
            bool cpfValido = validaCPF.Valida(Msk_CPF.Text);

            if (cpfValido)
            {
                Lbl_Resultado.Text = "CPF VÁLIDO";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF INVÁLIDO";
                Lbl_Resultado.ForeColor = Color.Red;
            }
            
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
            Lbl_Resultado.Text = "";
            Msk_CPF.Focus();
        }
    }
}
