﻿using System.Collections.Generic;

namespace CursoWindowsFormsBiblioteca.Classes
{
	public class Cliente
	{
		public class Unit
		{
            public string Id { get; set; }
            public string Nome { get; set; }
            public string NomePai { get; set; }
            public string NomeMae { get; set; }
            public bool TemPai { get; set; }
            public string Cpf { get; set; }
            public int Genero { get; set; }
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            public double RendaFamiliar { get; set; }
        }

		public class List
		{
            public List<Unit> ListUnit { get; set; }
        }
	}
}
