using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Formularios_Curso_3
{
    public partial class Frm_MouseCaptura : Form
    {
        public Frm_MouseCaptura()
        {
            InitializeComponent();
        }

        private void Btn_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Foi pressionado o botão da(o) {e.Button.ToString()}", "Mensagem");
        }
    }
}
