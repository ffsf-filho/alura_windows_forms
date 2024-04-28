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
    public partial class Frm_ValidaCPF_UC : UserControl
    {
        public Frm_ValidaCPF_UC()
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
