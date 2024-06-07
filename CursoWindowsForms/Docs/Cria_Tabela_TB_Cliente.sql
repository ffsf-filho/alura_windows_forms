use ByteBank


CREATE TABLE TB_Cliente (
	Id nvarchar(6) Primary Key not null,
	Nome nvarchar(50) null,
	NomePai nvarchar(50) null,
	NomeMae nvarchar(50) null,
	NaoTemPai int null,
	Cpf nvarchar(11) null,
	Genero int null,
	Cep nvarchar(8) null,
	Logradouro nvarchar(100) null,
	Complemento nvarchar(100) null,
	Bairro nvarchar(50) null,
	Cidade nvarchar(50) null,
	Estado nvarchar(50) null,
	Telefone nvarchar(50) null,
	Profissao nvarchar(50) null,
	RendaFamiliar float null
)