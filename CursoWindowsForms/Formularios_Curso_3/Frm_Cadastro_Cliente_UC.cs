using CursoWindowsForms.Formularios_Curso_1;
using CursoWindowsForms.Formularios_Curso_5;
using CursoWindowsFormsBiblioteca.Classes;
using CursoWindowsFormsBiblioteca.ClassesUteis;
using CursoWindowsFormsBiblioteca.Databases;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Windows.Forms;

namespace CursoWindowsForms
{
	public partial class Frm_Cadastro_Cliente_UC : UserControl
	{
		private static readonly string _diretorio = Path.GetDirectoryName(Application.ExecutablePath).Replace("bin\\Debug", "Fichario");

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

			Btn_Busca.Text = "Buscar";
			Grp_DataGrid.Text = "Clientes";

			AtualizaGrid();
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

			Txt_CodigoCliente.Focus();
		}

		private void EscreveFormulario(Cliente.Unit dadosDoCliente)
		{
			Txt_CodigoCliente.Text = dadosDoCliente.Id;
			Txt_NomeCliente.Text = dadosDoCliente.Nome;
			Txt_NomeMae.Text = dadosDoCliente.NomeMae;

			if (String.IsNullOrWhiteSpace(dadosDoCliente.NomePai))
			{
				Chk_TemPai.Checked = true;
				Txt_NomePai.Text = "";
			}
			else
			{
				Chk_TemPai.Checked = false;
				Txt_NomePai.Text = dadosDoCliente.NomePai;
			}
			
			Txt_CPF.Text = dadosDoCliente.Cpf;

			switch (dadosDoCliente.Genero)
			{
				case 0:
					Rdb_Masculino.Checked = true;
					break;
				case 1:
					Rdb_Feminino.Checked = true;
					break;
				default:
					Rdb_Indefinido.Checked = false;
					break;
			}

			Txt_CEP.Text = dadosDoCliente.Cep;
			Txt_Bairro.Text = dadosDoCliente.Bairro;
			Txt_Logradouro.Text = dadosDoCliente.Logradouro;
			Txt_Complemento.Text = dadosDoCliente.Complemento;
			Txt_Cidade.Text = dadosDoCliente.Cidade;

			if (String.IsNullOrWhiteSpace(dadosDoCliente.Estado))
			{
				Cmb_Estados.SelectedIndex = -1;
			}
			else
			{
				for (int i = 0; i <= Cmb_Estados.Items.Count -1; i++)
				{
					if (dadosDoCliente.Estado.Equals(Cmb_Estados.Items[i].ToString()))
					{
						Cmb_Estados.SelectedIndex = i;
					}
				}
			}
			
			Txt_Telefone.Text = dadosDoCliente.Telefone;
			Txt_Profissao.Text = dadosDoCliente.Profissao;
			Txt_RendaFamiliar.Text = dadosDoCliente.RendaFamiliar.ToString();
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
				//cliente.IncluirFichario(_diretorio);
				//cliente.IncluirFicharioDB("Cliente");
				//cliente.IncluirFicharioSQL("Cliente");
				cliente.IncluirFicharioSQLREL();
				MessageBox.Show("Código do Cliente incluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
				AtualizaGrid();
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
			if (String.IsNullOrWhiteSpace(Txt_CodigoCliente.Text))
			{
				MessageBox.Show("Código do Cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Txt_CodigoCliente.Focus();
			}
			else
			{
				try
				{
					Cliente.Unit cliente = new Cliente.Unit();
					//cliente = cliente.BuscarFichario(Txt_CodigoCliente.Text, _diretorio);
					//cliente = cliente.BuscarFicharioDB(Txt_CodigoCliente.Text, "Cliente");
					//cliente = cliente.BuscarFicharioSQL(Txt_CodigoCliente.Text, "Cliente");
					cliente = cliente.BuscarFicharioSQLREL(Txt_CodigoCliente.Text);

					if (cliente != null)
					{
						EscreveFormulario(cliente);
					}
					else
					{
						throw new Exception($"O Cliente {Txt_CodigoCliente.Text} não existe.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void SalvarToolStripButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(Txt_CodigoCliente.Text))
			{
				MessageBox.Show("Código do Cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Txt_CodigoCliente.Focus();
			}
			else
			{
				try
				{
					Cliente.Unit cliente = new Cliente.Unit();
					cliente = LeituraFormulario();
					cliente.Id = Txt_CodigoCliente.Text;
					cliente.ValidaClasse();
					cliente.ValidaComplemento();
					//cliente.AlterarFichario(_diretorio);
					//cliente.AlterarFicharioDB("Cliente");
					//cliente.AlterarFicharioSQL("Cliente");
					cliente.AlterarFicharioSQLREL();
					MessageBox.Show("Código do Cliente alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
					AtualizaGrid();
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
		}

		private void ApagatoolStripButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(Txt_CodigoCliente.Text))
			{
				MessageBox.Show("Código do Cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Txt_CodigoCliente.Focus();
				AtualizaGrid();
			}
			else
			{
				Cliente.Unit dadosDoCliente = new Cliente.Unit();
				//dadosDoCliente = dadosDoCliente.BuscarFichario(Txt_CodigoCliente.Text, _diretorio);
				//dadosDoCliente = dadosDoCliente.BuscarFicharioDB(Txt_CodigoCliente.Text, "Cliente");
				//dadosDoCliente = dadosDoCliente.BuscarFicharioSQL(Txt_CodigoCliente.Text, "Cliente");
				dadosDoCliente = dadosDoCliente.BuscarFicharioSQLREL(Txt_CodigoCliente.Text);

				if (dadosDoCliente != null)
				{
					EscreveFormulario(dadosDoCliente);

					Frm_Questao frm = new Frm_Questao("icons8_question_96", $"Você quer excluir o Cliente?");
					frm.ShowDialog();

					if (frm.DialogResult == DialogResult.Yes)
					{
						//dadosDoCliente.ApagarFichario(_diretorio);
						//dadosDoCliente.ApagarFicharioDB("Cliente");
						//dadosDoCliente.ApagarFicharioSQL("Cliente");
						dadosDoCliente.ApagarFicharioSQLREL();
						MessageBox.Show($"OK: Código {Txt_CodigoCliente.Text} do Cliente apagado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
						LimparFormulario();
					}
				}
				else
				{
					MessageBox.Show($"Erro: O Código {Txt_CodigoCliente.Text} do Cliente não existe", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
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

		private void Btn_Busca_Click(object sender, EventArgs e)
		{
			try
			{
				Cliente.Unit cliente = new Cliente.Unit();
				//List<string> listaFichario = cliente.ListarFichario(_diretorio);
				List<string> listaFichario = cliente.ListarFicharioSQL("Cliente");
				//List<List<string>> listaFichario = cliente.ListarFicharioSQLREL();

				if (listaFichario == null || listaFichario.Count == 0)
				{
					MessageBox.Show($"Não existe nenhum Cliente no fichario.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					List<List<string>> listabusca = new List<List<string>>();

					for (int i = 0; i < listaFichario.Count; i++)
					{
						cliente = Cliente.DesSerializedClassUnit(listaFichario[i]);
						listabusca.Add(new List<String> { cliente.Id, cliente.Nome });
					}

					Frm_Busca frm = new Frm_Busca(listabusca);
					frm.ShowDialog();

					if (frm.DialogResult == DialogResult.OK)
					{
						//cliente = cliente.BuscarFichario(frm.idSelect, _diretorio);
						//cliente = cliente.BuscarFicharioDB(frm.idSelect, "Cliente");
						cliente = cliente.BuscarFicharioSQL(frm.idSelect, "Cliente");

						if (cliente == null)
						{
							throw new Exception($"Cliente {frm.idSelect} não encontrado.");
						}
						else
						{
							EscreveFormulario(cliente);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message} ", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AtualizaGrid()
		{
			try
			{
				Cliente.Unit cliente = new Cliente.Unit();
				List<List<string>> listaFichario = cliente.ListarFicharioSQLREL();
				Dg_Clientes.Rows.Clear();

				for(int i = 0; i < listaFichario.Count; i++)
				{
					DataGridViewRow row = new DataGridViewRow();
					row.CreateCells(Dg_Clientes);
					row.Cells[0].Value = listaFichario[i][0].ToString();
					row.Cells[1].Value = listaFichario[i][1].ToString();
					Dg_Clientes.Rows.Add(row);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro: {ex.Message} ", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Dg_Clientes_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow row = new DataGridViewRow();
				row = Dg_Clientes.SelectedRows[0];
				string Id = row.Cells[0].Value.ToString();
				Cliente.Unit cliente = new Cliente.Unit();
				cliente = cliente.BuscarFicharioSQLREL(Id);

				if (cliente != null)
				{
					EscreveFormulario(cliente);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
