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

INSERT INTO TB_Cliente(Id,Nome,NomePai,NomeMae,NaoTemPai,Cpf,Genero,Cep,Logradouro,Complemento,Bairro,Cidade,Estado,Telefone,Profissao,RendaFamiliar) 
VALUES ('000001','Rosa SQL Server','Jonas SQL Server','Maria SQL Server',1,'11430997885','1','01415001','Rua Bela Cintra,33','1º andar','Consolação','São Paulo','São Paulo(SP)','1133334444','Faxineira',2500.28);

Select * from TB_Cliente