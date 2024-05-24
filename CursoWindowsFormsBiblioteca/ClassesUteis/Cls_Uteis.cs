using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.ClassesUteis
{
    public class Cls_Uteis
    {
        public static bool ValidaSenhaLogin(string senha)
        {
            if (senha == "curso") 
            { 
                return true;
            }

            return false;
        }

		public static string GeraJSONCEP(string CEP)
		{
			HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
			HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

			int cont;
			byte[] buffer = new byte[1000];
			StringBuilder sb = new StringBuilder();
			string temp;
			Stream stream = resposta.GetResponseStream();

			do
			{
				cont = stream.Read(buffer, 0, buffer.Length);
				temp = Encoding.UTF8.GetString(buffer, 0, cont).Trim();
				sb.Append(temp);

			} while (cont > 0);
			
			return sb.ToString();
		}
	}
}
