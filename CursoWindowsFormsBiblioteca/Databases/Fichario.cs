using System;
using System.Collections.Generic;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
	public class Fichario
	{
		public string diretorio;
		public string mensagem;
		public bool status;

		public Fichario(string Diretorio)
		{
			this.status = true;
			try
			{
				if (!Directory.Exists(Diretorio))
				{
					Directory.CreateDirectory(Diretorio);
				}

				this.diretorio = Diretorio;
				this.mensagem = "Conexão com o Fichario criada com sucesso";
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Conexão com o Fichario com erro: \n {ex.Message}";
			}
		}

		public void Incluir(string Id, string JSONUnit)
		{
			string pathArquivo = this.diretorio + $"\\{Id}.json";

			try
			{
				if (File.Exists(pathArquivo))
				{
					this.status = false;
					this.mensagem = $"Inclusão não permitida porque o identificador já existe: {Id}";
				}
				else
				{
					File.WriteAllText(pathArquivo, JSONUnit);
					this.status = true;
					this.mensagem = $"Inclusão efetuada com sucesso. Identificador: {Id}";
				}
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Conexão com o Fichario com erro: {ex.Message}";
			}
		}

		public string Buscar(string Id)
		{
			string pathArquivo = this.diretorio + $"\\{Id}.json";
			string conteudo = "";

			try
			{
				if (!File.Exists(pathArquivo))
				{
					this.status = false;
					this.mensagem = $"Identificador {Id} não existe.";
				}
				else
				{
					conteudo = File.ReadAllText(pathArquivo);
					this.status = true;
					this.mensagem = $"Identificado {Id} recuperado com sucesso.";
				}
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Erro ao buscar o conteúdo do identificador {Id}: {ex.Message}";
			}

			return conteudo;
		}

		public void Apagar(string Id)
		{
			string pathArquivo = this.diretorio + $"\\{Id}.json";

			try
			{
				if (!File.Exists(pathArquivo))
				{
					this.status = false;
					this.mensagem = $"Identificador {Id} não existe.";
				}
				else
				{
					File.Delete(pathArquivo);
					this.status = true;
					this.mensagem = $"Identificado {Id} excluído com sucesso.";
				}
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Erro ao buscar o conteúdo do identificador {Id}: {ex.Message}";
			}
		}

		public void Alterar(string Id, string JSONUnit)
		{
			string pathArquivo = this.diretorio + $"\\{Id}.json";

			try
			{
				if (!File.Exists(pathArquivo))
				{
					this.status = false;
					this.mensagem = $"Alteração não permitida porque o identificador não existe: {Id}";
				}
				else
				{
					File.Delete(pathArquivo);
					File.WriteAllText(pathArquivo, JSONUnit);
					this.status = true;
					this.mensagem = $"Alteração efetuada com sucesso. Identificador: {Id}";
				}
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Conexão com o Fichario com erro: {ex.Message}";
			}
		}

		public List<string> BuscarTodos()
		{
			string pathArquivo = this.diretorio;
			List<string> conteudo = new	List<string>();

			try
			{
				string[] listaArquivos = Directory.GetFiles(pathArquivo, "*.json");

				for (int i = 0; i < listaArquivos.Length; i++)
				{
					conteudo.Add(File.ReadAllText(listaArquivos[i]));
				}
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Erro ao buscar a lista de Clientes: {ex.Message}";
			}

			return conteudo;
		}
	}
}
