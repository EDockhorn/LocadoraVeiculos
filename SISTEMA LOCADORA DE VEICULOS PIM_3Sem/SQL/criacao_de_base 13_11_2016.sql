
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
	senhaUSU CHAR(7) NOT NULL,
	perfilUSU VARCHAR(20) NOT NULL, 
	CONSTRAINT pk_codUSU PRIMARY KEY  (codUSU) 

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
	datacadastroCLI DATETIME DEFAULT GETDATE(),
	senhaCLI VARCHAR(50) NOT NULL DEFAULT(0)
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
	chasVEIC NVARCHAR(200) NOT NULL ,
	corVEIC NVARCHAR(20) NOT NULL,
	placaVEIC NVARCHAR(20) NOT NULL,
	marcaVEIC NVARCHAR (50) NOT NULL,
	datafabrVEIC DATETIME NOT NULL,
	fabricanteVEIC NVARCHAR(30) NOT NULL,
	datacompraVEIC DATETIME NOT NULL,
	ultimarevisaoVEIC DATETIME NOT NULL,
	kmVEIC NUMERIC(18,2) NOT NULL,
	imgVEIC NVARCHAR(200) NULL ,
	descVEIC NVARCHAR(200),
	CONSTRAINT pk_codVEIC PRIMARY KEY  (codVEIC)
);


--Cria��o da tabela de Funcion�rios

IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'FUNCIONARIOS')
	DROP TABLE FUNCIONARIOS
GO

CREATE TABLE FUNCIONARIOS(
	codFUNC INT NOT NULL IDENTITY,
	nomeFUNC NVARCHAR(50) NOT NULL,
	cepFUNC NVARCHAR(50) NOT NULL,
	enderFUNC NVARCHAR(250) NOT NULL,
	cidadeFUNC NVARCHAR(100) NOT NULL,
	estadoFUNC CHAR(2) NOT NULL,
	bairroFUNC NVARCHAR(100) NOT NULL,
	telefoneFUNC VARCHAR(20) NOT NULL,
	datanascFUNC DATETIME NOT NULL,
	rgFUNC VARCHAR(12) NOT NULL,
	cpfFUNC VARCHAR(20) NOT NULL,
	dataadmiss DATETIME NOT NULL,
	datademiss DATETIME NULL,
	perfilusuFUNC NVARCHAR(100) NULL,
	numcasaFUNC INT NULL,
	CONSTRAINT pk_codFUNC PRIMARY KEY  (codFUNC)
	

);

--Cria��o da tabela de Reservas de ve�culos:
IF EXISTS(SELECT * FROM SYS.TABLES WHERE NAME LIKE 'RESERVAS')
	DROP TABLE RESERVAS
GO

CREATE TABLE RESERVAS(
	codRES INT NOT NULL IDENTITY,
	valordiariaRES NVARCHAR(10) NOT NULL,
	diasRES NVARCHAR(10) NOT NULL,
	dataRES DATETIME DEFAULT GETDATE(),
	datadevolucaoRES DATETIME,
	cliRES INT NOT NULL,
	veicRES INT NOT NULL,
	funcRES INT NOT NULL,
	situacaoRES CHAR(2) DEFAULT 'A', --INDICA SE EST� RESERVADO OU DEVOLVIDO --  A: ALUGADO, D: DISPON�VEL
	protocoloRES  NVARCHAR(100) NOT NULL
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
	valorPGTO NVARCHAR(50),
	qtdparcelasPGTO INT NULL,
	statuscartaoPGTO CHAR(2) NULL,
	resPGTO INT NOT NULL,
	dataPGTO DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_codPGTO PRIMARY KEY (codPGTO),
	FOREIGN KEY (resPGTO) REFERENCES RESERVAS(codRES)
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
	motivoMULT VARCHAR(150) NOT NULL,
	valorMULT VARCHAR(150) NOT NULL,
	resMULT INT NOT NULL,
	--conMULT INT NOT NULL,
	--cliMULT INT NOT NULL,
	--veicMULT INT NOT NULL,
	situacaoMULT CHAR(2) NOT NULL, --INDICA SE EST� PAGO
	CONSTRAINT pk_codMULT PRIMARY KEY (codMULT),
	FOREIGN KEY (resMULT) REFERENCES RESERVAS(codRES)
	--FOREIGN KEY (cliMULT) REFERENCES CLIENTES(codCLI),
	--FOREIGN KEY (conMULT) REFERENCES CONTRATOS(codCON),
	--FOREIGN KEY (veicMULT) REFERENCES VEICULOS(codVEIC)
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

--################################
--########## VIEWS ###############
--################################

IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'CarregarCLI')
	DROP VIEW CarregarCLI
GO

CREATE VIEW CarregarCLI
AS

	SELECT *
	FROM CLIENTES

GO

IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaCLI')
	DROP VIEW ConsultaCLI
GO

CREATE VIEW ConsultaCLI
AS


	SELECT codCLI AS CODIGO, nomeCLI AS NOME,rgCLI AS RG,
	cpfCLI AS CPF,CNHCLI AS CNH,enderCLI AS LOGRADOURO,
	cidadeCLI AS CIDADE,estadoCLI AS ESTADO,
	CASE WHEN telefonefixoCLI = '(  )      -' THEN telefonecelularCLI ELSE telefonefixoCLI END CONTATO ,
	datacadastroCLI AS [DATA CADASTRO]
	FROM CLIENTES


GO

IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaFUNC')
	DROP VIEW ConsultaFUNC
GO
CREATE VIEW ConsultaFUNC
AS
		SELECT codFUNC AS CODIGO,nomeFUNC AS NOME,cpfFUNC AS CPF,rgFUNC AS RG 
		,enderFUNC AS ENDERECO, estadoFUNC AS ESTADO,dataadmiss AS [DATA ADMISSAO]
		,COALESCE(perfilUSU,'Sem acesso ao sistema') AS [Perfil Usuario]
		FROM FUNCIONARIOS
		LEFT JOIN USUARIOS ON perfilUSU = perfilusuFUNC

GO
IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaVEIC')
	DROP VIEW ConsultaVEIC
GO
CREATE VIEW ConsultaVEIC
AS
		SELECT codVEIC AS CODIGO,marcaVEIC AS MARCA,fabricanteVEIC AS FABRICANTE,kmVEIC AS KM
		,datacompraVEIC AS [COMPRADO], datafabrVEIC AS [FABRICADO], ultimarevisaoVEIC AS [DATA DA ULTIMA REVISAO]
		FROM VEICULOS

GO


IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaVeicDispon')
	DROP VIEW ConsultaVeicDispon
GO
CREATE VIEW ConsultaVeicDispon
		AS
		
		SELECT * 
		FROM ConsultaVEIC
		WHERE CODIGO 
		NOT IN (
				SELECT codVEIC
				FROM RESERVAS 
				INNER JOIN VEICULOS ON veicRES = codVEIC  
				WHERE situacaoRES = 'A'
			)
GO

IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME LIKE 'ConsultaReservados')
	DROP VIEW ConsultaReservados
GO

CREATE VIEW ConsultaReservados

AS
	SELECT codRES AS CODIGO,
	nomeCLI AS CLIENTE, cpfCLI AS CPF,
	marcaVEIC AS VEICULO,
	valordiariaRES AS DIARIA,dataRES AS DATA_RESERVA,datadevolucaoRES AS DATA_DEVOLUCAO, protocoloRES AS PROTOCOLO
	FROM RESERVAS
	INNER JOIN CLIENTES ON cliRES = codCLI 
	INNER JOIN VEICULOS ON veicRES = codVEIC
	AND situacaoRES = 'A' 
GO

INSERT INTO CLIENTES (nomeCLI,cepCLI,rgCLI,cpfCLI,cnhCLI,datanascCLI,telefonecelularCLI,
emailCLI,enderCLI,cidadeCLI,bairroCLI,estadoCLI,telefonefixoCLI,numcasaCLI)
VALUES( 'Cliente Johnny Dockhorn','05351-080','10,101,010-1','001,100,010-10','11010101010',
'15/11/1993 00:00:00','(10) 11010-1010','josajs@','Ot�vio de Morais','S�o Paulo','Cidade S�o Francisco','SP','(10) 1010-1010',110)

GO
-- CARGAS PARA DESENVOLVIMENTO
INSERT INTO USUARIOS
VALUES('admin',123,'admin')
GO
INSERT INTO USUARIOS
VALUES('Ana',123,'Atendente')
GO
INSERT INTO USUARIOS
VALUES('Ze',123,'Gestor de frota')
GO
INSERT INTO USUARIOS
VALUES('Lucas',123,'Gerente geral')
GO
INSERT INTO USUARIOS
VALUES('Batma',123,'Gestor de RH')
GO


INSERT INTO FUNCIONARIOS
(nomeFUNC,enderFUNC,cepFUNC,cidadeFUNC,estadoFUNC,bairroFUNC,telefoneFUNC,datanascFUNC,rgFUNC,cpfFUNC,dataadmiss,datademiss,perfilusuFUNC)
VALUES ('Johnny','Rua coronel Jaime Americano',11111,'S�o Paulo','SP','Vila S�o Franscisco',111,GETDATE(),111,111,GETDATE(),GETDATE(),'admin')

GO


INSERT INTO FUNCIONARIOS
(nomeFUNC,enderFUNC,cepFUNC,cidadeFUNC,estadoFUNC,bairroFUNC,telefoneFUNC,datanascFUNC,rgFUNC,cpfFUNC,dataadmiss,datademiss,perfilusuFUNC)
VALUES ('Ana','Rua coronel Jaime Americano',11111,'S�o Paulo','SP','Vila S�o Franscisco',111,GETDATE(),111,111,GETDATE(),GETDATE(),'Atendente')

GO
INSERT INTO FUNCIONARIOS
(nomeFUNC,enderFUNC,cepFUNC,cidadeFUNC,estadoFUNC,bairroFUNC,telefoneFUNC,datanascFUNC,rgFUNC,cpfFUNC,dataadmiss,datademiss,perfilusuFUNC)
VALUES ('ZE','Rua coronel Jaime Americano',11111,'S�o Paulo','SP','Vila S�o Franscisco',111,GETDATE(),111,111,GETDATE(),GETDATE(),'Gestor de frota')

GO
INSERT INTO FUNCIONARIOS
(nomeFUNC,enderFUNC,cepFUNC,cidadeFUNC,estadoFUNC,bairroFUNC,telefoneFUNC,datanascFUNC,rgFUNC,cpfFUNC,dataadmiss,datademiss,perfilusuFUNC)
VALUES ('Lucas','Rua coronel Jaime Americano',11111,'S�o Paulo','SP','Vila S�o Franscisco',111,GETDATE(),111,111,GETDATE(),GETDATE(),'Gerente geral')

GO
INSERT INTO FUNCIONARIOS
(nomeFUNC,enderFUNC,cepFUNC,cidadeFUNC,estadoFUNC,bairroFUNC,telefoneFUNC,datanascFUNC,rgFUNC,cpfFUNC,dataadmiss,datademiss,perfilusuFUNC)
VALUES ('Batma','Rua coronel Jaime Americano',11111,'S�o Paulo','SP','Vila S�o Franscisco',111,GETDATE(),111,111,GETDATE(),GETDATE(),'Gestor de RH')

GO

INSERT INTO VEICULOS (chasVEIC,fabricanteVEIC,placaVEIC,marcaVEIC,corVEIC,kmVEIC,datafabrVEIC,
datacompraVEIC,ultimarevisaoVEIC,imgVEIC,descVEIC)VALUES( '10101010101010101','fABRIUCANTE',
'10101010','Marca','preto','10000','13/11/2016','13/11/2016','13/11/2016',
'C:\Users\Dockhorn\Desktop\SISTEMA LOCADORA DE VEICULOS PIM_3Sem\Veiculos\FiatUno_Economy.jpg',
'observa��es')

GO


INSERT INTO PGTOS (formaPGTO,valorPGTO,qtdparcelasPGTO,statuscartaoPGTO,resPGTO,dataPGTO)
VALUES ('Dinheiro','100,00',1,'A',1,GETDATE());

GO



INSERT INTO MULTAS (motivoMULT,valorMULT,resMULT,situacaoMULT)
VALUES ('Ja�un�ada','100.00',1,'P')

GO


INSERT INTO RESERVAS
(valordiariaRES,diasRES,dataRES,datadevolucaoRES,cliRES,veicRES,funcRES,situacaoRES,protocoloRES) 
VALUES(100.00,30,GETDATE(),GETDATE(),1,1,1,'D','123456789')

GO
-- 1) OS RELAT�RIOS SER�O CONSULTAS NO BANCO DE DADOS 


--SELECT *
--FROM PGTOS



--SELECT *
--FROM RESERVAS

--INSERT INTO PGTOS (formaPGTO,valorPGTO,qtdparcelasPGTO,resPGTO)VALUES( 'D�bito','0','1',1)


--SELECT *
--FROM PGTOS


--		UPDATE RESERVAS
--		SET situacaoRES = 'D'
--		WHERE codRES IN ( SELECT codRES FROM RESERVAS  INNER JOIN VEICULOS ON veicRES = codVEIC WHERE codVEIC = 2 AND situacaoRES = 'A' )
				