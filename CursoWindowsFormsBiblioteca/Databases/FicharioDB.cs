using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
	public class FicharioDB
	{
		public string mensagem;
		public bool status;
		public string tabela;
		public LocalDBClass db;

        public FicharioDB(string nomeTabela)
        {
            status = true;
			try
			{
				db = new LocalDBClass();
				tabela = nomeTabela;
				mensagem = $"Conexão com a Tabela '{nomeTabela}' criada com sucesso.";
			}
			catch (Exception ex)
			{
				status = false;
				mensagem = $"Conexão com a Tabela '{nomeTabela}' com erro: {ex.Message}.";
			}
        }

		public void Incluir(string Id, string JSONUnit)
		{

			try
			{
				string fraseSQL = $"INSERT INTO {tabela} (Id, json) VALUES ('{Id}', '{JSONUnit}')";
				db.SqlCommand(fraseSQL);
				status = true;
				mensagem = $"Inclusão efetuada com sucesso, Cliente: {Id} .";
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Conexão com o bamco de dados Fichario com erro: {ex.Message}";
			}
		}

		public string Buscar(string Id)
		{
			string conteudo = string.Empty;

			try
			{
				string fraseSQL = $"SELECT Id, json FROM {tabela} WHERE Id = '{Id}'";
				DataTable dt = db.SQLQuery(fraseSQL);

				if(dt.Rows.Count > 0)
				{
					status =true;
					conteudo = dt.Rows[0]["json"].ToString();
					mensagem = $"Cliente {Id} recuperado com sucesso.";
				}
				else
				{
					status= false;
					mensagem = $"O Cliente {Id} não existe.";
				}
			}
			catch (Exception ex)
			{
				status = false;
				mensagem = $"Erro ao buscar o conteúdo do Cliente {Id}: {ex.Message}";
			}

			return conteudo;
		}

		public List<string> BuscarTodos()
		{
			List<string> conteudo = new	List<string>();

			try
			{
				string fraseSQL = $"SELECT Id, json FROM {tabela}";
				DataTable dt = db.SQLQuery(fraseSQL);

				if (dt.Rows.Count > 0)
				{
					status = true;
					
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						conteudo.Add(dt.Rows[i]["json"].ToString());
					}

					mensagem = $"Foram retornados {dt.Rows.Count} Cliente(s), com sucesso.";
				}
				else
				{
					status = false;
					mensagem = $"Não existem Clientes na base de dados.";
				}
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Erro ao buscar a lista de Clientes: {ex.Message}";
			}

			return conteudo;
		}

		public void Apagar(string Id)
		{
			try
			{
				string fraseSQL = $"DELETE FROM {tabela} WHERE Id = '{Id}'";
				DataTable dt = db.SQLQuery(fraseSQL);

				if (dt.Rows.Count > 0)
				{
					status = true;
					mensagem = $"O Cliente '{Id}' foi excluído com sucesso.";
				}
				else
				{
					status = false;
					mensagem = $"Não existem o Cliente '{Id}' na base de dados.";
				}
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Erro ao apagar o Cliente '{Id}' na base de dados: {ex.Message}";
			}
		}


		public void Alterar(string Id, string JSONUnit)
		{
			try
			{
				string fraseSQL = $"SELECT Id, json FROM {tabela} WHERE Id = '{Id}'";
				DataTable dt = db.SQLQuery(fraseSQL);

				if (dt.Rows.Count > 0)
				{
					fraseSQL = $"UPDATE FROM {tabela} SET json = '{JSONUnit}' WHERE Id = '{Id}'";
					db.SqlCommand(fraseSQL);
					status = true;
					mensagem = $"O Cliente '{Id}' foi alterado com sucesso.";
				}
				else
				{
					status = false;
					mensagem = $"O Cliente '{Id}' não existe na base de dados, alteração não permitida.";
				}
			}
			catch (Exception ex)
			{
				status = false;
				mensagem = $"Ocorreu um erro ao tentar executar uma alteração no banco de dados Fichario: {ex.Message}";
			}
		}
	}
}
