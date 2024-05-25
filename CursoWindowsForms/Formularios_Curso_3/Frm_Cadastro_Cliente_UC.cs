using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca.ClassesUteis;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
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

			LimparFormulario();
		}

		private void LimparFormulario()
		{
			Txt_CodigoCliente.Text = "";
			Txt_Bairro.Text = "";
			Txt_CEP.Text = "";
			Txt_Complemento.Text = "";
			Txt_CPF.Text = "";
			Txt_Cidade.Text = "";
			Cmb_Estados.SelectedIndex = -1;
			Txt_Logradouro.Text = "";
			Txt_NomeCliente.Text = "";
			Txt_NomeMae.Text = "";
			Txt_NomePai.Text = "";
			Txt_Profissao.Text = "";
			Txt_RendaFamiliar.Text = "";
			Txt_Telefone.Text = "";
			Chk_TemPai.Checked = false;
			Rdb_Masculino.Checked = false;
			Rdb_Feminino.Checked = false;
			Rdb_Indefinido.Checked = false;
		}

		private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
		{
			Txt_NomePai.Enabled = Chk_TemPai.Checked ? false: true ;
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
				cliente = LeituraFormulario();
				cliente.Id = Txt_CodigoCliente.Text;
				cliente.ValidaClasse();
				cliente.ValidaComplemento();
				MessageBox.Show("Classe foi inicializada sem erros.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (ValidationException ex)
			{
				MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
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
			LimparFormulario();
		}

		private Cliente.Unit LeituraFormulario()
		{
			Cliente.Unit cliente = new Cliente.Unit();

			cliente.Id = Txt_CodigoCliente.Text;
			cliente.Nome = Txt_NomeCliente.Text;
			cliente.NomePai = Txt_NomePai.Text;

			if (Chk_TemPai.Checked || !string.IsNullOrWhiteSpace(Txt_NomePai.Text))
			{
				cliente.NaoTemPai = true;
			}
			else
			{
				cliente.NaoTemPai = false;
			}

			cliente.NomeMae = Txt_NomeMae.Text;

			if (Rdb_Masculino.Checked)
			{
				cliente.Genero = 0;
			}

			if (Rdb_Feminino.Checked)
			{
				cliente.Genero = 1;
			}

			if (Rdb_Indefinido.Checked)
			{
				cliente.Genero = 3;
			}

			cliente.Cpf = Txt_CPF.Text;
			cliente.Cep = Txt_CEP.Text;
			cliente.Logradouro = Txt_Logradouro.Text;
			cliente.Complemento = Txt_Complemento.Text;
			cliente.Cidade = Txt_Cidade.Text;
			cliente.Bairro = Txt_Bairro.Text;

			if (Cmb_Estados.SelectedIndex < 0)
			{
				cliente.Estado = "";
			}
			else
			{
				cliente.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
			}

			cliente.Telefone = Txt_Telefone.Text;
			cliente.Profissao = Txt_Profissao.Text;

			if (Information.IsNumeric(Txt_RendaFamiliar.Text))
			{
				double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);

				if (vRenda < 0) 
				{
					cliente.RendaFamiliar = 0;
				}
				else
				{
					cliente.RendaFamiliar = vRenda;
				}
			}

			return cliente;
		}

		private void Txt_CEP_Leave(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(Txt_CEP.Text) && Txt_CEP.Text.Length == 8 && Information.IsNumeric(Txt_CEP.Text))
			{
				var vJSON = Cls_Uteis.GeraJSONCEP(Txt_CEP.Text);
				Cep.Unit cep = new Cep.Unit();
				cep = Cep.DesSerializedClassUnit(vJSON);

				Txt_Logradouro.Text = cep.logradouro;
				Txt_Bairro.Text = cep.bairro;
				Txt_Cidade.Text	= cep.localidade;
				string vEstado = $"({cep.uf})";
				Cmb_Estados.SelectedIndex = -1;

				for (int i = 0; i < Cmb_Estados.Items.Count - 1; i++)
				{
					var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(),vEstado);

					if (vPos > 0)
					{
						Cmb_Estados.SelectedIndex = i;
						break;
					}
				}
			}
		}
	}
}
