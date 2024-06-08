using CursoWindowsFormsBiblioteca.ClassesUteis;
using CursoWindowsFormsBiblioteca.Databases;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Text;

namespace CursoWindowsFormsBiblioteca.Classes
{
	public class Cliente
	{
		public class Unit
		{
            [Required(ErrorMessage ="Código do Cliente é obrigatório.")]
			[RegularExpression("([0-9]+)", ErrorMessage = "O Código do Cliente somente aceita valores númericos.")]
			[StringLength(6, MinimumLength =6, ErrorMessage = "Código do Cliente deve ter 6 digitos.")]
            public string Id { get; set; }

			[Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
			[StringLength(50, ErrorMessage = "O Nome do Cliente deve ter no máximo 50 Caracteres.")]
			public string Nome { get; set; }

			[StringLength(50, ErrorMessage = "O Nome do Pai deve ter no máximo 50 Caracteres.")]
			public string NomePai { get; set; }

			[Required(ErrorMessage = "Nome da Mãe é obrigatório.")]
			[StringLength(50, ErrorMessage = "O Nome da Mãe deve ter no máximo 50 Caracteres.")]
			public string NomeMae { get; set; }

            public bool NaoTemPai { get; set; }

			[Required(ErrorMessage = "CPF é obrigatório.")]
			[RegularExpression("([0-9]+)", ErrorMessage = "O CPF somente aceita valores númericos.")]
			[StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 digitos.")]
			public string Cpf { get; set; }

			[Required(ErrorMessage = "Genero é obrigatório.")]
			public int Genero { get; set; }

			[Required(ErrorMessage = "CEP é obrigatório.")]
			[RegularExpression("([0-9]+)", ErrorMessage = "O CEP somente aceita valores númericos.")]
			[StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP deve ter 8 digitos.")]
			public string Cep { get; set; }

			[Required(ErrorMessage = "O Logradouro é obrigatório.")]
			[StringLength(100, ErrorMessage = "O Logradouro deve ter no máximo 100 Caracteres.")]
			public string Logradouro { get; set; }

			[Required(ErrorMessage = "O Complemento é obrigatório.")]
			[StringLength(100, ErrorMessage = "O Complemento deve ter no máximo 100 Caracteres.")]
			public string Complemento { get; set; }

			[Required(ErrorMessage = "O Bairro é obrigatório.")]
			[StringLength(50, ErrorMessage = "O Bairro deve ter no máximo 50 Caracteres.")]
			public string Bairro { get; set; }

			[Required(ErrorMessage = "A Cidade é obrigatório.")]
			[StringLength(50, ErrorMessage = "A Cidade deve ter no máximo 50 Caracteres.")]
			public string Cidade { get; set; }

			[Required(ErrorMessage = "O Estado é obrigatório.")]
			[StringLength(50, ErrorMessage = "O Estado deve ter no máximo 50 Caracteres.")]
			public string Estado { get; set; }

			[Required(ErrorMessage = "O número do Telefone é obrigatório.")]
			[RegularExpression("([0-9]+)", ErrorMessage = "O número do Telefone somente aceita valores númericos.")]
			public string Telefone { get; set; }

            public string Profissao { get; set; }

			[Required(ErrorMessage = "A Renda Famíliat é obrigatória.")]
			[Range(0, double.MaxValue, ErrorMessage = "A Renda Famíliar deve ser uma valor positivo.")]
			public double RendaFamiliar { get; set; }
			
			public void ValidaClasse()
			{
				ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
				List<ValidationResult> results = new List<ValidationResult>();
				bool isValid = Validator.TryValidateObject(this, context, results, true);

				if (isValid == false)
				{
					StringBuilder sbrErrors = new StringBuilder();
					foreach (var validationResult in results)
					{
						sbrErrors.AppendLine(validationResult.ErrorMessage);
					}
					throw new ValidationException(sbrErrors.ToString());
				}
			}

			public void ValidaComplemento()
			{
				if (this.NomePai == this.NomeMae) 
				{
					throw new Exception("O nome do Pai e Mãe não podem ser iguais.");
				}

				if (String.IsNullOrWhiteSpace(this.NomePai))
				{
					if(this.NaoTemPai == false)
					{
						throw new Exception("O nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver marcado.");
					}
				}

				ValidaCPF validaCPF = new ValidaCPF();

				if (!validaCPF.Valida(this.Cpf))
				{
					throw new Exception("CPF Inválido.");
				}
			}

			#region "CRUD do Fichario"
			public void IncluirFichario(string Conexao)
			{
				string clienteJSON = SerializedClassUnit(this);
				Fichario fichario = new Fichario(Conexao);

				if (fichario.status)
				{
					fichario.Incluir(this.Id, clienteJSON);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public Unit BuscarFichario(string Id, string Conexao)
			{
				Fichario fichario = new Fichario(Conexao);

				if (fichario.status)
				{
					string clienteJSON = fichario.Buscar(Id);
					return Cliente.DesSerializedClassUnit(clienteJSON);
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public void AlterarFichario(string Conexao)
			{
				Fichario fichario = new Fichario(Conexao);
				string clienteJSON = Cliente.SerializedClassUnit(this);

				if (fichario.status)
				{
					fichario.Alterar(this.Id, clienteJSON);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public void ApagarFichario(string Conexao)
			{
				Fichario fichario = new Fichario(Conexao);
				if (fichario.status)
				{
					fichario.Apagar(this.Id);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public List<string> ListarFichario(string Conexao)
			{
				List<string> todosJSON;

				Fichario fichario = new Fichario(Conexao);

				if (fichario.status)
				{
					todosJSON = fichario.BuscarTodos();	
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}

				return todosJSON;
			}
			#endregion

			#region "CRUD do FicharioDB LocalDB"
			public void IncluirFicharioDB(string Conexao)
			{
				string clienteJSON = SerializedClassUnit(this);
				FicharioDB fichario = new FicharioDB(Conexao);

				if (fichario.status)
				{
					fichario.Incluir(this.Id, clienteJSON);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public Unit BuscarFicharioDB(string Id, string Conexao)
			{
				FicharioDB fichario = new FicharioDB(Conexao);

				if (fichario.status)
				{
					string clienteJSON = fichario.Buscar(Id);
					return Cliente.DesSerializedClassUnit(clienteJSON);
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public void AlterarFicharioDB(string Conexao)
			{
				FicharioDB fichario = new FicharioDB(Conexao);
				string clienteJSON = Cliente.SerializedClassUnit(this);

				if (fichario.status)
				{
					fichario.Alterar(this.Id, clienteJSON);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public void ApagarFicharioDB(string Conexao)
			{
				FicharioDB fichario = new FicharioDB(Conexao);
				if (fichario.status)
				{
					fichario.Apagar(this.Id);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public List<string> ListarFicharioDB(string Conexao)
			{
				List<string> todosJSON;

				FicharioDB fichario = new FicharioDB(Conexao);

				if (fichario.status)
				{
					todosJSON = fichario.BuscarTodos();
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}

				return todosJSON;
			}
			#endregion

			#region "CRUD do Fichario SQLServer"
			public void IncluirFicharioSQL(string Conexao)
			{
				string clienteJSON = SerializedClassUnit(this);
				FicharioSQLServer fichario = new FicharioSQLServer(Conexao);

				if (fichario.status)
				{
					fichario.Incluir(this.Id, clienteJSON);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public Unit BuscarFicharioSQL(string Id, string Conexao)
			{
				FicharioSQLServer fichario = new FicharioSQLServer(Conexao);

				if (fichario.status)
				{
					string clienteJSON = fichario.Buscar(Id);
					return Cliente.DesSerializedClassUnit(clienteJSON);
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public void AlterarFicharioSQL(string Conexao)
			{
				FicharioSQLServer fichario = new FicharioSQLServer(Conexao);
				string clienteJSON = Cliente.SerializedClassUnit(this);

				if (fichario.status)
				{
					fichario.Alterar(this.Id, clienteJSON);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public void ApagarFicharioSQL(string Conexao)
			{
				FicharioSQLServer fichario = new FicharioSQLServer(Conexao);
				if (fichario.status)
				{
					fichario.Apagar(this.Id);

					if (!fichario.status)
					{
						throw new Exception(fichario.mensagem);
					}
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}
			}

			public List<string> ListarFicharioSQL(string Conexao)
			{
				List<string> todosJSON;

				FicharioSQLServer fichario = new FicharioSQLServer(Conexao);

				if (fichario.status)
				{
					todosJSON = fichario.BuscarTodos();
				}
				else
				{
					throw new Exception(fichario.mensagem);
				}

				return todosJSON;
			}
			#endregion

			#region "CRUD do Fichario DB SQL Server Relacional"

			#region "Funções auxiliares"
			public string ToInsert()
			{
				string SQL = @"INSERT INTO TB_Cliente (Id, Nome, NomePai, NomeMae, NaoTemPai, Cpf, Genero, Cep, Logradouro, Complemento, Bairro, Cidade, Estado, Telefone, Profissao,RendaFamiliar) VALUES (";
				SQL += "'" + this.Id + "', ";
				SQL += "'" + this.Nome + "', ";
				SQL += "'" + this.NomePai + "', ";
				SQL += "'" + this.NomeMae + "', ";
				SQL += Convert.ToInt32(this.NaoTemPai).ToString() + ", ";
				SQL += "'" + this.Cpf + "', ";
				SQL += Convert.ToInt32(this.Genero).ToString() + ", ";
				SQL += "'" + this.Cep + "', ";
				SQL += "'" + this.Logradouro + "', ";
				SQL += "'" + this.Complemento + "', ";
				SQL += "'" + this.Bairro + "', ";
				SQL += "'" + this.Cidade + "', ";
				SQL += "'" + this.Estado + "', ";
				SQL += "'" + this.Telefone + "', ";
				SQL += "'" + this.Profissao + "', ";
				SQL += Convert.ToString(this.RendaFamiliar).Replace(",", ".") + ");";

				return SQL;
			}

			public string ToUpdate(string Id)
			{
				string SQL = @"UPDATE TB_Cliente SET ";
				SQL += $"Nome = '{this.Nome}', ";
				SQL += $"NomePai = '{this.NomePai}', ";
				SQL += $"NomeMae = '{this.NomeMae}', ";
				SQL += $"NaoTemPai = {Convert.ToInt32(this.NaoTemPai)}, ";
				SQL += $"Cpf = '{this.Cpf}', ";
				SQL += $"Genero = '{Convert.ToInt32(this.Genero)}', ";
				SQL += $"Cep = '{this.Cep}', ";
				SQL += $"Logradouro = '{this.Logradouro}', ";
				SQL += $"Complemento = '{this.Complemento}', ";
				SQL += $"Bairro = '{this.Bairro}', ";
				SQL += $"Cidade = '{this.Cidade}', ";
				SQL += $"Estado = '{this.Estado}', ";
				SQL += $"Telefone = '{this.Telefone}', ";
				SQL += $"Profissao = '{this.Profissao}', ";
				SQL += $"RendaFamiliar = {this.RendaFamiliar} ";
				SQL += $"WHERE Id = {Id};";
				return SQL;
			}

			public Unit DataRowToUnit(DataRow dr)
			{
				Unit retorno = new Unit()
				{
					Id = dr["Id"].ToString(),
					Nome = dr["Nome"].ToString(),
					NomePai = dr["NomePai"].ToString(),
					NomeMae = dr["NomeMae"].ToString(),
					NaoTemPai = Convert.ToBoolean(Convert.ToInt32(dr["NaoTemPai"])),
					Cpf = dr["Cpf"].ToString(),
					Genero = Convert.ToInt32(dr["Genero"]),
					Cep = dr["Cep"].ToString(),
					Logradouro = dr["Logradouro"].ToString(),
					Complemento = dr["Complemento"].ToString(),
					Bairro = dr["Bairro"].ToString(),
					Cidade = dr["Cidade"].ToString(),
					Estado = dr["Estado"].ToString(),
					Telefone = dr["Telefone"].ToString(),
					Profissao = dr["Profissao"].ToString(),
					RendaFamiliar = Convert.ToDouble(dr["RendaFamiliar"])
				};
				
				return retorno;
			}
			#endregion

			#region CRUD Funções de manipulação do banco de dados
			public void IncluirFicharioSQLREL()
			{
				SQLServerClass db = new SQLServerClass();

				try
				{
					string SQL = this.ToInsert();
					db.SqlCommand(SQL);
				}
				catch (Exception ex)
				{
					throw new Exception($"Inclusão não permitida. Cliente {this.Id}, Erro: {ex.Message}");
				}
				finally
				{
					db.Close();
				}
			}

			public Unit BuscarFicharioSQLREL(string Id)
			{
				SQLServerClass  db = new SQLServerClass();
				Unit retorno;

				try
				{
					string SQL = $"SELECT * FROM TB_Cliente WHERE Id= {Id};";
					DataTable dt = db.SQLQuery(SQL);

					if(dt.Rows.Count == 0)
					{
						throw new Exception($"Cliente '{Id}' não existente.");
					}

					retorno = this.DataRowToUnit(dt.Rows[0]);
				}
				catch (Exception ex)
				{
					throw new Exception($"Erro ao buscar o Cliente '{this.Id}': {ex.Message}");
				}
				finally
				{
					db.Close ();
				}

				return retorno;
			}

			public void AlterarFicharioSQLREL()
			{
				SQLServerClass db = new SQLServerClass();

				try
				{
					string SQL = $"SELECT * FROM TB_Cliente WHERE Id= {this.Id};";
					DataTable dt = db.SQLQuery(SQL);

					if (dt.Rows.Count == 0)
					{
						throw new Exception($"Cliente '{this.Id}' não existente.");
					}
					else
					{
						SQL = this.ToUpdate(this.Id);
						db.SqlCommand(SQL);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"Erro ao alterar o Cliente '{Id}', Mensagem: {ex.Message}.");
				}
				finally
				{
					db.Close();
				}
			}

			public void ApagarFicharioSQLREL()
			{
				SQLServerClass db = new SQLServerClass();

				try
				{
					string SQL = $"SELECT * FROM TB_Cliente WHERE Id= {this.Id};";
					DataTable dt = db.SQLQuery(SQL);

					if (dt.Rows.Count == 0)
					{
						throw new Exception($"Cliente '{this.Id}' não existente.");
					}
					else
					{
						SQL = $"DELETE FROM TB_Cliente WHERE Id = {this.Id};";
						db.SqlCommand(SQL);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"Erro ao excluir o Cliente '{Id}', Mensagem: {ex.Message}.");
				}
				finally
				{
					db.Close();
				}
			}

			public List<List<string>> ListarFicharioSQLREL()
			{
				SQLServerClass db = new SQLServerClass();
				List<List<string>> retorno = new List<List<string>>();

				try
				{
					string SQL = $"SELECT * FROM TB_Cliente;";
					DataTable dt = db.SQLQuery(SQL);

					if (dt.Rows.Count == 0)
					{
						throw new Exception($"Cliente '{this.Id}' não existente.");
					}
					else
					{
						foreach (DataRow dr in dt.Rows)
						{
							retorno.Add(new List<string> {dr["Id"].ToString(), dr["Nome"].ToString() });
						}
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"Erro ao buscar os Clientes, Mensagem: {ex.Message}.");
				}
				finally
				{
					db.Close();
				}

				return retorno;
			}
			#endregion
			#endregion
		}

		public class List
		{
            public List<Unit> ListUnit { get; set; }
        }

		public static Unit DesSerializedClassUnit(string vJSON)
		{
			return JsonConvert.DeserializeObject<Unit>(vJSON);
		}

		public static string SerializedClassUnit(Unit unit)
		{
			return JsonConvert.SerializeObject(unit);
		}
	}
}
