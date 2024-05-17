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
	public partial class Frm_Cadastro_Cliente_UC : UserControl
	{
		public Frm_Cadastro_Cliente_UC()
		{
			InitializeComponent();

			//configura o nome dos labels
			Grp_Codigo.Text = "Código";
			Grp_DadosPessoais.Text = "Dados Pessoais";
			Grp_Endereco.Text = "Endereço";
			Grp_Outros.Text = "Outros";
			Grp_Genero.Text = "Genero";
			Lbl_Bairro.Text = "Bairro";
			Lbl_CEP.Text = "CEP";
			Lbl_Complemento.Text = "Complemento";
			Lbl_CPF.Text = "CPF";
			Lbl_Cidade.Text = "Cidade";
			Lbl_Estado.Text = "Estado";
			Lbl_Logradouro.Text = "Logradouro";
			Lbl_NomeCliente.Text = "Nome";
			Lbl_NomeMae.Text = "Nome da Mãe";
			Lbl_NomePai.Text = "Nome do Pai";
			Lbl_Profissao.Text = "Profissão";
			Lbl_RendaFamiliar.Text = "Renda Familiar";
			Lbl_Telefone.Text = "Telefone";
			Chk_TemPai.Text = "Pai desconhecido";
			Rdb_Masculino.Text = "Masculino";
			Rdb_Feminino.Text = "Feminino";
			Rdb_Indefinido.Text = "Indefinido";
		}

		private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
		{
			Txt_NomePai.Enabled = !Txt_NomePai.Enabled;
			if (!Txt_NomePai.Enabled && Txt_NomePai.Text.Length > 0)
			{
				Txt_NomePai.Text = "";
			}
		}
	}
}
