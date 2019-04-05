using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_BS_LocadoraVeiculos;

namespace dll_DB_LocadoraVeiculos
{
    public class PreparaSQL
    {
        Usuarios usuarios = new Usuarios();
        public string ConsultaUsuario()
        {
            string consultaUsuario = string.Empty;

            consultaUsuario = " SELECT * FROM USUARIOS ";
            return consultaUsuario;
        }
        public string ConsultaCliente(int ID)
        {
            string consultacliente = string.Empty;

            consultacliente = " SELECT * FROM CarregarCLI WHERE codCLI = " + ID ;
            return consultacliente;
        }
        public string TentaLogin(string usuario, string senha)
        {
            string tentaLogin = String.Empty;

            tentaLogin = " SELECT loginUSU FROM USUARIOS WHERE loginUSU = " + "'" + usuario + "'" + " AND senhaUSU = " + "'" + senha + "'";

            return tentaLogin;


        }
        public string CarregaPerfil(string usuario, string senha)
        {
            string perfil = String.Empty;

            perfil = " SELECT perfilUSU FROM USUARIOS WHERE loginUSU = " + "'" + usuario + "'" + " AND senhaUSU = " + "'" + senha + "'";

            return perfil;


        }
        //CLIENTES
        public string PreparaCliente(string nome, string rg, string cpf, string cnh, string data
            , string celular, string email, string cep, string logradouro, string cidade, string bairro
            , string uf, string numerocasa,string telefone)
        {
            string preparacliente = string.Empty;

            preparacliente = "INSERT INTO CLIENTES (nomeCLI,cepCLI,rgCLI,cpfCLI,cnhCLI,datanascCLI,telefonecelularCLI,emailCLI,enderCLI,cidadeCLI,";
            preparacliente = preparacliente + "bairroCLI,estadoCLI,telefonefixoCLI,numcasaCLI)";
            preparacliente = preparacliente + "VALUES( " + "'" + nome + "'" + "," + "'" + cep + "'" + "," + "'" + rg + "'"; 
            preparacliente = preparacliente + "," + "'" + cpf + "'" + "," + "'" + cnh + "'" + "," + "'" + data + "'" + "," + "'" + celular + "'";
            preparacliente = preparacliente + "," + "'" + email + "'" + "," + "'" + logradouro + "'" + "," + "'" + cidade + "'";
            preparacliente = preparacliente + "," + "'" + bairro + "'" + "," + "'" + uf + "'" + "," + "'" + telefone + "'" + "," + numerocasa + ")"; 


            return preparacliente;
        }
        public string PreparaUPDATECliente(int codigo,string nome, string rg, string cpf, string cnh, string data
            , string celular, string email, string cep, string logradouro, string cidade, string bairro
            , string uf, string numerocasa, string telefone)
        {

            string preparaUPDATEcliente = string.Empty;
            preparaUPDATEcliente = "UPDATE CLIENTES SET nomeCLI = " + "'" + nome + "'" + "," + "cepCLI = " + "'" + cep + "'" + "," + "rgCLI = " + "'" + rg + "'" + ",";
            preparaUPDATEcliente = preparaUPDATEcliente + "cpfCLI = " + "'" + cpf + "'" + "," + "cnhCLI = " + "'" + cnh + "'" + "," + "datanascCLI = " + "'" + data + "'" + ",";
            preparaUPDATEcliente = preparaUPDATEcliente + "telefonecelularCLI = " + "'" + celular + "'" + "," + "telefonefixoCLI = " + "'" + telefone + "'" + "," + "emailCLI = " + "'" + email + "'" + ",";
            preparaUPDATEcliente = preparaUPDATEcliente + "enderCLI = " + "'" + logradouro + "'" + "," + "cidadeCLI = " + "'" + cidade + "'" + ",";
            preparaUPDATEcliente = preparaUPDATEcliente + "bairroCLI = " + "'" + bairro + "'" + "," + "estadoCLI = " + "'" + uf + "'" + "," + "numcasaCLI = " + numerocasa + "WHERE codCLI = " + codigo;


            return preparaUPDATEcliente;

        }

        //FUNCIONÁRIOS:
        public string ConsultaFunc(string ID)
        {
            string consultafunc = string.Empty;

            consultafunc = " SELECT nomeFUNC,perfilUSU,codFUNC FROM USUARIOS LEFT JOIN FUNCIONARIOS ON perfilusuFUNC = perfilUSU";
            consultafunc = consultafunc + " WHERE loginUSU = '" + ID + "'";
            return consultafunc;
        }

        public string PreparaFunc(string nome, string rg, string telefone, string cpf, bool ativo, string datanas
            , string dataAd, string dataDemi, string cep, string logradouro, string cidade, string bairro
            , string uf, string numerocasa, string usuario)
        {
            string preparafunc = string.Empty;

            if (ativo == true) dataDemi = ""; 


            preparafunc = "INSERT INTO FUNCIONARIOS";
            preparafunc = preparafunc + " (nomeFUNC,cepFUNC,enderFUNC,cidadeFUNC,estadoFUNC,bairroFUNC";
            preparafunc = preparafunc + " ,telefoneFUNC,datanascFUNC,rgFUNC,cpfFUNC,dataadmiss,datademiss,numcasaFUNC,perfilusuFUNC)";
            preparafunc = preparafunc + "VALUES( " + "'" + nome + "'" + "," + "'" + cep + "'" + "," + "'" + logradouro + "'";
            preparafunc = preparafunc + "," + "'" + cidade + "'" + "," + "'" + uf + "'" + "," + "'" + bairro + "'" + "," + "'" + telefone + "'";
            preparafunc = preparafunc + "," + "'" + datanas + "'" + "," + "'" + rg + "'" + "," + "'" + cpf + "'";
            preparafunc = preparafunc + "," + "'" + dataAd + "'" + "," + "'"+  dataDemi + "'" + ","  + numerocasa + "," +  "'" + usuario + "'" + ")"; 

            return preparafunc;
        }

        public string ConsultaFunc(int ID)
        {
            string consultafunc = string.Empty;

            consultafunc = " SELECT * FROM FUNCIONARIOS LEFT JOIN USUARIOS ON perfilUSU = perfilusuFUNC WHERE codFUNC = " + ID;
            return consultafunc;
        }

        public string PreparaUPDATEFunc(int codigo,string nome, string rg, string telefone, string cpf, bool ativo, string datanas
            , string dataAd, string dataDemi, string cep, string logradouro, string cidade, string bairro
            , string uf, string numerocasa,string usuario)
        {
            if (ativo == true) dataDemi = ""; 

            string PreparaUPDATEFunc = string.Empty;
            PreparaUPDATEFunc = "UPDATE FUNCIONARIOS SET nomeFUNC = " + "'" + nome + "'" + "," + "rgFUNC = " + "'" + rg + "'" + "," + "telefoneFUNC = " + "'" + telefone + "'" + ",";
            PreparaUPDATEFunc = PreparaUPDATEFunc + "cpfFUNC = " + "'" + cpf + "'" + "," + "datanascFUNC = " + "'" + datanas + "'" + "," + "dataadmiss = " + "'" + dataAd + "'" + "," + "datademiss = " + "'" + dataDemi + "'" + ","; 
            PreparaUPDATEFunc = PreparaUPDATEFunc + "enderFUNC = " + "'" + logradouro + "'" + "," + "cidadeFUNC = " + "'" + cidade + "'" + ",";
            PreparaUPDATEFunc = PreparaUPDATEFunc + "cepFUNC = " + "'" + cep + "'" + ",";
            PreparaUPDATEFunc = PreparaUPDATEFunc + "bairroFUNC = " + "'" + bairro + "'" + "," + "estadoFUNC = " + "'" + uf + "'" + "," + "numcasaFUNC = " + numerocasa + "," + "perfilusuFUNC = " + "'" + usuario + "'" + " WHERE codFUNC = " + codigo;

            return PreparaUPDATEFunc;
        }
        public string ConsultaUsuFUNC()
        {
            string consultausufunc = string.Empty;

            consultausufunc = "SELECT * FROM USUARIOS";
            return consultausufunc;
        }
        //Veículos
        public string PreparaVeiculo(string chas, string fabricante, string placa, string marca, string cor,string km,
            string datafab, string datacompra, string dataultimarevisao,string foto, string obs)
        {
            string preparaveiculo = string.Empty;

            preparaveiculo = "INSERT INTO VEICULOS (chasVEIC,fabricanteVEIC,placaVEIC,marcaVEIC";
            preparaveiculo = preparaveiculo + ",corVEIC,kmVEIC,datafabrVEIC,datacompraVEIC,";
            preparaveiculo = preparaveiculo + "ultimarevisaoVEIC,imgVEIC,descVEIC)";
            preparaveiculo = preparaveiculo + "VALUES( " + "'" + chas + "'" + "," + "'" + fabricante + "'" + "," + "'" + placa + "'";
            preparaveiculo = preparaveiculo + "," + "'" + marca + "'" + "," + "'" + cor + "'" + "," + "'" + Convert.ToDouble(km) + "'" + "," + "'" + datafab + "'";
            preparaveiculo = preparaveiculo + "," + "'" + datacompra + "'" + "," + "'" + dataultimarevisao + "'" + "," + "'" + foto + "'" + "," + "'" + obs + "'" + ")";

            return preparaveiculo;
        }

        public string PreparaUPDATEVeiculo(int codigo,string chas, string fabricante, string placa, string marca, string cor, string km,
            string datafab, string datacompra, string dataultimarevisao, string foto, string obs)
        {
            string preparaupdateveiculo = string.Empty;

            preparaupdateveiculo = "UPDATE VEICULOS SET chasVEIC = " + "'" + chas + "'" + "," + "fabricanteVEIC = " + "'" + fabricante + "'" + "," + "placaVEIC = " + "'" + placa + "'" + ",";
            preparaupdateveiculo = preparaupdateveiculo + "marcaVEIC = " + "'" + marca + "'" + "," + "corVEIC = " + "'" + cor + "'" + "," + "kmVEIC = " + km + "," + "datafabrVEIC = " + "'" + datafab + "'" + ",";
            preparaupdateveiculo = preparaupdateveiculo + "datacompraVEIC = " + "'" + datacompra + "'" + "," + "ultimarevisaoVEIC = " + "'" + dataultimarevisao + "'" + ",";
            preparaupdateveiculo = preparaupdateveiculo + "imgVEIC = " + "'" + foto + "'" + ",";
            preparaupdateveiculo = preparaupdateveiculo + "descVEIC = " + "'" + obs + "'" + " WHERE codVEIC = " + codigo;

            return preparaupdateveiculo;
        }
        public string ConsultaVeiculo(int ID = 0)
        {
            string consultafunc = string.Empty;

            consultafunc = " SELECT * FROM VEICULOS WHERE codVEIC = " + ID;

            return consultafunc;
        }

        public string PreparauUsuario(Usuarios usu)
        {
            string preparausuario = string.Empty;

            preparausuario = "INSERT INTO USUARIOS (loginUSU,senhaUSU,perfilUSU)";
            preparausuario = preparausuario + "VALUES( " + "'" + usu.getLogin() + "'" + "," + "'" + usu.getSenha() +"'" + "," + "'" + usu.getPerfil() + "'" + ")";

            return preparausuario;
        }
        // ## RESERVAS

        public string ConsultaInfoRESERVAS(int codigo)
        {
            string consultainforeservas = string.Empty;

            consultainforeservas = " SELECT codRES,cliRES,veicRES,funcRES,imgVEIC " ;
            consultainforeservas = consultainforeservas + ",dataRES,datadevolucaoRES,valordiariaRES,protocoloRES FROM RESERVAS ";
            consultainforeservas = consultainforeservas + "INNER JOIN CLIENTES ON cliRES = codCLI ";
            consultainforeservas = consultainforeservas + "INNER JOIN VEICULOS ON veicRES = codVEIC WHERE codRES = " + codigo;
            return consultainforeservas;
        }


        public string ConsultaVeiculoReserva(int codigo)
        {
            string consultaveicreserva = string.Empty;

            consultaveicreserva = " SELECT * FROM VEICULOS WHERE codVEIC = " + codigo;

            return consultaveicreserva;
        }



        public string ConsultaClienteReserva(int codigo)
        {
            string consultaclientereserva = string.Empty;

            consultaclientereserva = " SELECT * FROM CLIENTES WHERE codCLI = " + codigo;

            return consultaclientereserva;
        }

        public string preparaReserva(int intVeic, int intCli, int intFunc, string dataReserva, string dataDev, string valordiaria, string protocolo, string dias, string valortotal)
        {
            string preparareserva = string.Empty;

            preparareserva = " INSERT INTO RESERVAS (valordiariaRES,diasRES,dataRES,datadevolucaoRES,cliRES,veicRES,funcRES,protocoloRES,valortotalRES) ";
            preparareserva = preparareserva + "VALUES( " + "'" + valordiaria + "'" + "," + "'" + dias + "'" + "," + "'" + dataReserva + "'" + ",";
            preparareserva = preparareserva + "'" + dataDev + "'" + "," + intCli + "," + intVeic + "," + intFunc + "," + "'" + protocolo + "'" + "," + "'" + valortotal + "'"  + ")";

            return preparareserva;
        }

        public string Preparapgto(string forma, string valor,int qtdparcelas,int codigoreserva)
        {
            string pgto = string.Empty;
            pgto = "INSERT INTO PGTOS (formaPGTO,valorPGTO,qtdparcelasPGTO,resPGTO)";
            pgto = pgto + "VALUES( " + "'" + forma + "'" + "," + "'" + valor + "'" + "," + "'" + qtdparcelas + "'" + "," + codigoreserva + ")";

            return pgto;
        }
        public string PreparaDevolucao(int codigo)
        {
            string preparaDev = string.Empty;
            preparaDev = "UPDATE RESERVAS SET situacaoRES = 'D' WHERE codRES = " + codigo;
            return preparaDev; 
        }

    }
}
