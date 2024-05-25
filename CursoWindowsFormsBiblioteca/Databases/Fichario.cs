using System;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
	public class Fichario
	{
		public string diretorio;
		public string mensagem;
		public bool status;

		public Fichario(string diretorio)
		{
			this.status = true;
			try
			{
				if (!Directory.Exists(diretorio))
				{
					Directory.CreateDirectory(diretorio);
				}

				this.diretorio = diretorio;
				this.mensagem = "Conexão com o Fichario criada com sucesso";
			}
			catch (Exception ex)
			{
				this.status = false;
				this.mensagem = $"Conexão com o Fichario com erro: \n {ex.Message}";
			}
		}
	}
}
