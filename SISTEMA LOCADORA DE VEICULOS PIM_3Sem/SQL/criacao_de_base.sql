
USE [MASTER]
GO


IF EXISTS(SELECT * FROM SYS.DATABASES WHERE NAME = 'PIM_ALOCAR')
	DROP DATABASE [PIM_ALOCAR]
GO

--Cria��o da base de dados: 
CREATE DATABASE [PIM_ALOCAR]
GO

USE [PIM_ALOCAR]
GO

--################################
--########## TABELAS #############
--################################

--Cria��o da tabela de Usu�rios:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'USUARIOS')
	DROP TABLE USUARIOS
GO

CREATE TABLE USUARIOS(
	codUSU INT NOT NULL IDENTITY,
	loginUSU VARCHAR(20) NOT NULL,
	senhaUSU CHAR(7) NOT NULL

);

--Cria��o da tabela de Clientes
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'CLIENTES')
	DROP TABLE CLIENTES
GO


--SELECT LEN('43.700.752-2')


--SELECT LEN('419.335.698-16')

CREATE TABLE CLIENTES(
	codCLI INT NOT NULL IDENTITY,
	nomeCLI NVARCHAR(50) NOT NULL,
	cepCLI NVARCHAR(20) NULL,
	enderCLI NVARCHAR(250) NOT NULL,
	cidadeCLI NVARCHAR(100) NOT NULL,
	estadoCLI CHAR(2) NOT NULL,
	bairroCLI NVARCHAR(100) NOT NULL,
	numcasaCLI INT NULL,
	emailCLI VARCHAR(50) NULL,
	rgCLI VARCHAR(20) NOT NULL,
	cpfCLI VARCHAR(20) NOT NULL,
	datanascCLI DATETIME NOT NULL,
	CNHCLI VARCHAR(20) NOT NULL,
	telefonefixoCLI VARCHAR(20) NULL,
	telefonecelularCLI VARCHAR(20) NULL,
	datacadastroCLI DATETIME DEFAULT GETDATE()
	CONSTRAINT pk_codCLI PRIMARY KEY  (codCLI) 

);

--CREATE TABLE TESTE(
--data DATETIME DEFAULT GETDATE()

--);

--INSERT INTO TESTE
--VALUES ('23-10-2016')

--SELECT *
--FROM TESTE


--Cria��o da tabela de Ve�culos
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'VEICULOS')
	DROP TABLE VEICULOS
GO

CREATE TABLE VEICULOS(
	codVEIC INT NOT NULL IDENTITY,
	descVEIC NVARCHAR(200),
	qtdVEIC INT NOT NULL,
	corVEIC NVARCHAR(20) NOT NULL,
	situacaoVEIC CHAR(2) NULL,
	placaVEIC NVARCHAR(20) NOT NULL,
	marcaVEIC NVARCHAR (50) NOT NULL,
	datafabrVEIC DATETIME NOT NULL,
	fabricanteVEIC NVARCHAR(30) NOT NULL,
	datacompraVEIC DATETIME NOT NULL,
	ultimarevisaoVEIC DATETIME NOT NULL,
	kmVEIC NUMERIC(18,2) NOT NULL,
	cliVEIC INT NOT NULL,
	CONSTRAINT pk_codVEIC PRIMARY KEY  (codVEIC),
	FOREIGN KEY (cliVEIC) REFERENCES CLIENTES(codCLI)
);


--Cria��o da tabela de Funcion�rios

IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'FUNCIONARIOS')
	DROP TABLE FUNCIONARIOS
GO

CREATE TABLE FUNCIONARIOS(
	codFUNC INT NOT NULL IDENTITY,
	nomeFUNC NVARCHAR(50) NOT NULL,
	enderFUNC NVARCHAR(250) NOT NULL,
	cidadeFUNC NVARCHAR(100) NOT NULL,
	estadoFUNC CHAR(2) NOT NULL,
	bairroFUNC NVARCHAR(100) NOT NULL,
	telefoneFUNC VARCHAR(20) NOT NULL,
	datanascFUNC DATETIME NOT NULL,
	rgFUNC VARCHAR(12) NOT NULL,
	cpfFUNC VARCHAR(13) NOT NULL,
	dataadmiss DATETIME NOT NULL,
	datademiss DATETIME NULL,
	CONSTRAINT pk_codFUNC PRIMARY KEY  (codFUNC) 

);

--Cria��o da tabela de Reservas de ve�culos:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'RESERVAS')
	DROP TABLE RESERVAS
GO

CREATE TABLE RESERVAS(
	codRES INT NOT NULL IDENTITY,
	valordiariaRES NUMERIC(18,2) NOT NULL,
	diasRES NVARCHAR(10) NOT NULL,
	dataRES DATETIME DEFAULT GETDATE(),
	datadevolucaoRES DATETIME,
	cliRES INT NOT NULL,
	veicRES INT NOT NULL,
	funcRES INT NOT NULL,
	situacaoRES CHAR(2) NOT NULL, --INDICA SE EST� RESERVADO OU DEVOLVIDO
	CONSTRAINT pk_codRES PRIMARY KEY (codRES),
	FOREIGN KEY (cliRES) REFERENCES CLIENTES(codCLI),
	FOREIGN KEY (veicRES) REFERENCES VEICULOS(codVEIC),
	FOREIGN KEY (funcRES) REFERENCES FUNCIONARIOS(codFUNC)
);

--Cria��o da tabela de Pagamentos:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'PGTOS')
	DROP TABLE PGTOS
GO

--ENGLOBA TABELA DE VALORES

CREATE TABLE PGTOS(
	codPGTO INT NOT NULL IDENTITY,
	formaPGTO NVARCHAR(50),
	valorPGTO NUMERIC(18,2),
	qtdparcelasPGTO INT NULL,
	statuscartaoPGTO CHAR(2) NULL,
	cliPGTO INT NOT NULL,
	dataPGTO DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_codPGTO PRIMARY KEY (codPGTO),
	FOREIGN KEY (cliPGTO) REFERENCES CLIENTES(codCLI)
);

--Cria��o da tabela de Contratos:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'CONTRATOS')
	DROP TABLE CONTRATOS
GO

CREATE TABLE CONTRATOS(
	codCON INT NOT NULL IDENTITY,
	dataemissao DATETIME DEFAULT GETDATE(),
	pgtoCON INT NOT NULL,
	cliCON INT NOT NULL,
	resCON INT NOT NULL,
	CONSTRAINT pk_codCON PRIMARY KEY (codCON),
	FOREIGN KEY (resCON) REFERENCES RESERVAS(codRES)
);

--Cria��o da tabela de Multas:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'MULTAS')
	DROP TABLE MULTAS
GO

CREATE TABLE MULTAS(
	codMULT INT NOT NULL IDENTITY,
	dataMULT DATETIME NOT NULL,
	motivoMULT VARCHAR(150) NOT NULL,
	valorMULT NUMERIC(18,2) NOT NULL,
	conMULT INT NOT NULL,
	cliMULT INT NOT NULL,
	veicMULT INT NOT NULL,
	situacaoMULT CHAR(2) NOT NULL, --INDICA SE EST� PAGO
	CONSTRAINT pk_codMULT PRIMARY KEY (codMULT),
	FOREIGN KEY (cliMULT) REFERENCES CLIENTES(codCLI),
	FOREIGN KEY (conMULT) REFERENCES CONTRATOS(codCON),
	FOREIGN KEY (veicMULT) REFERENCES VEICULOS(codVEIC)
);

--Cria��o da tabela de Ap�lice de Seguros:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'APOSEG')
	DROP TABLE APOSEG
GO

CREATE TABLE APOSEG(
	protAPOSEG NVARCHAR(20) NOT NULL,
	conAPOSEG INT NOT NULL IDENTITY,
	cliAPOSEG INT NOT NULL,
	CONSTRAINT pk_protAPOSEG PRIMARY KEY (protAPOSEG),
	FOREIGN KEY (conAPOSEG) REFERENCES CONTRATOS(codCON),
	FOREIGN KEY (cliAPOSEG) REFERENCES CLIENTES(codCLI),
);

GO

INSERT INTO USUARIOS
VALUES('admin',123)

GO

-- 1) OS RELAT�RIOS SER�O CONSULTAS NO BANCO DE DADOS 
