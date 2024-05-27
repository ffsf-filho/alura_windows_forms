using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CursoWindowsForms.Formularios_Curso_5
{
	public partial class Frm_Busca : Form
	{
		private readonly List<List<string>> _ListaBusca;
        public string idSelect { get; set; }	

        public Frm_Busca(List<List<string>> ListaBusca)
		{
			InitializeComponent();
			this._ListaBusca = ListaBusca;

			this.Text = "Busca Cliente";
			Tls_Principal.Items[0].ToolTipText = "Salvar a seleção.";
			Tls_Principal.Items[1].ToolTipText = "Fechar a seleção.";

			PreencherLista();
		}

		private void toolStripButton1_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void saveToolStripButton_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
			ItemBox ItemSelicionado = (ItemBox) Lst_Busca.Items[Lst_Busca.SelectedIndex];
			idSelect = ItemSelicionado.id;
			this.Close();
		}

		private void PreencherLista()
		{
			Lst_Busca.Items.Clear();


			for (int i = 0; i < _ListaBusca.Count; i++)
			{
				ItemBox itemBox = new ItemBox();
				itemBox.id = _ListaBusca[i][0];
				itemBox.nome = _ListaBusca[i][1];
				Lst_Busca.Items.Add(itemBox);
			}

			Lst_Busca.Sorted = true;
		}

		private class ItemBox
		{
            public string id { get; set; }
            public string nome { get; set; }

			public override string ToString()
			{
				return this.nome;
			}
		}
	}
}
