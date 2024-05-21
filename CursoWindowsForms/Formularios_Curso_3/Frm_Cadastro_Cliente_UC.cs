using CursoWindowsFormsBiblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

			Cmb_Estados.Items.Clear();
			Cmb_Estados.Items.Add("Acre (AC)");
			Cmb_Estados.Items.Add("Alagoas(AL)");
			Cmb_Estados.Items.Add("Amapá(AP)");
			Cmb_Estados.Items.Add("Amazonas(AM)");
			Cmb_Estados.Items.Add("Bahia(BA)");
			Cmb_Estados.Items.Add("Ceará(CE)");
			Cmb_Estados.Items.Add("Distrito Federal(DF)");
			Cmb_Estados.Items.Add("Espírito Santo(ES)");
			Cmb_Estados.Items.Add("Goiás(GO)");
			Cmb_Estados.Items.Add("Maranhão(MA)");
			Cmb_Estados.Items.Add("Mato Grosso(MT)");
			Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
			Cmb_Estados.Items.Add("Minas Gerais(MG)");
			Cmb_Estados.Items.Add("Pará(PA)");
			Cmb_Estados.Items.Add("Paraíba(PB)");
			Cmb_Estados.Items.Add("Paraná(PR)");
			Cmb_Estados.Items.Add("Pernambuco(PE)");
			Cmb_Estados.Items.Add("Piauí(PI)");
			Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
			Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
			Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
			Cmb_Estados.Items.Add("Rondônia(RO)");
			Cmb_Estados.Items.Add("Roraima(RR)");
			Cmb_Estados.Items.Add("Santa Catarina(SC)");
			Cmb_Estados.Items.Add("São Paulo(SP)");
			Cmb_Estados.Items.Add("Sergipe(SE)");
			Cmb_Estados.Items.Add("Tocantins(TO)");
			Tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo Cliente";
			Tls_Principal.Items[1].ToolTipText = "Capturar um Cliente já cadastrado na base";
			Tls_Principal.Items[2].ToolTipText = "Atualize o Cliente já existente";
			Tls_Principal.Items[3].ToolTipText = "Apaga o Cliente selecionado";
			Tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados";
		}

		private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
		{
			Txt_NomePai.Enabled = !Txt_NomePai.Enabled;
			if (!Txt_NomePai.Enabled && Txt_NomePai.Text.Length > 0)
			{
				Txt_NomePai.Text = "";
			}
		}

		private void NovoToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				Cliente.Unit cliente = new Cliente.Unit();
				cliente.Id = Txt_CodigoCliente.Text;
				cliente.ValidaClasse();
				MessageBox.Show("Classe foi inicializada sem erros.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (ValidationException ex)
			{
				MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AbrirToolStripButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Efetuei um click sobre o botão Abrir");
		}

		private void SalvarToolStripButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Efetuei um click sobre o botão Salvar");
		}

		private void ApagatoolStripButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Efetuei um click sobre o botão Excluir");
		}

		private void LimpartoolStripButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Efetuei um click sobre o botão Limpar");
		}
	}
}
