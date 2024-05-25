using System;
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
	}
}
