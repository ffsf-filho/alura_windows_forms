using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Formularios_Curso_7
{
	public partial class Frm_Agencia : Form
	{
		public Frm_Agencia()
		{
			InitializeComponent();

			this.Text = "Cadastro de Agência";
			Tls_Principal.Items[0].ToolTipText = "Fechar a caixa de diálogo";
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
