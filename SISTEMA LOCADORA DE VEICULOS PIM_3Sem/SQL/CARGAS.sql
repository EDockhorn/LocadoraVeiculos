
--################################
--########## CARGAS ###############
--################################

INSERT INTO CLIENTES 
(nomeCLI,cepCLI,rgCLI,cpfCLI,cnhCLI,datanascCLI,
telefonecelularCLI,emailCLI,enderCLI,cidadeCLI,bairroCLI,
estadoCLI,telefonefixoCLI,numcasaCLI)
VALUES( 'Roberto Souza Figueiredo','05351-080',
'43,912,019-2','419,335,698-16','10293043430',
'27/11/1980 00:00:00','(11) 96728-2891','robertosouza@hotmail.com',
'Otávio de Morais','São Paulo','Cidade São Francisco','SP',
'(11) 3719-0840',214)

GO

INSERT INTO CLIENTES 
(nomeCLI,cepCLI,rgCLI,cpfCLI,cnhCLI,datanascCLI,telefonecelularCLI
,emailCLI,enderCLI,cidadeCLI,bairroCLI,estadoCLI,telefonefixoCLI,
numcasaCLI)VALUES( 'Dorksons Lima',
'05351-060','42,768,291-0','847,591,921-16',
'19294839439','27/11/1960 00:00:00','(11) 95839-3103',
'lima_dk@hotmail.com','Coronel Jaime Americano','São Paulo',
'Vila São Francisco','SP','(11) 4334-0006',123)

GO

INSERT INTO VEICULOS (chasVEIC,fabricanteVEIC,placaVEIC,
marcaVEIC,corVEIC,kmVEIC,datafabrVEIC,datacompraVEIC,ultimarevisaoVEIC,
imgVEIC,descVEIC)VALUES( 
'2010s0s1203010101','FORD ECOSPORT','103-9202','FORD','Vermelho','12000',
'27/11/1980','27/11/2016','30/11/2016','C:\Users\Dockhorn\Desktop\SISTEMA LOCADORA DE VEICULOS PIM_3Sem\Veiculos\EcoEsport.jpg','')

GO

INSERT INTO VEICULOS (chasVEIC,fabricanteVEIC,placaVEIC,marcaVEIC,corVEIC,kmVEIC,datafabrVEIC,
datacompraVEIC,ultimarevisaoVEIC,imgVEIC,descVEIC)
VALUES( '10230s0s010102030','Fiat','abc-1004','Uno','amarelho','35600','27/11/1980',
'27/11/2016','30/11/2016',
'C:\Users\Dockhorn\Desktop\SISTEMA LOCADORA DE VEICULOS PIM_3Sem\Veiculos\FiatUno_Economy.jpg','Veículo em ótimo estado')

GO