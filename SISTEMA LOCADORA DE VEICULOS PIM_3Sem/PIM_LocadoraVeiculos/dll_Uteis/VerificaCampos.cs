using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_BS_LocadoraVeiculos;
using dll_DB_LocadoraVeiculos;


namespace dll_Uteis
{
    public class VerificaCampos
    {
        RecuperaConexao con = new RecuperaConexao();
        Reservas reservar = new Reservas();
        Executa executar = new Executa();

        public string VerificaUsuario(string usu, string senha)
        {
            string retorno = string.Empty;
            if (usu == "") retorno = "Usuario";
            else if (senha == "") retorno = "Senha";

            return retorno;

        }
        public string VerificaClientes(string nome, string rg, string cpf, string cnh, string data
            , string celular, string email, string cep, string logradouro, string cidade, string bairro
            , string uf, string numerocasa,string telefone)
        {
            string retorno = string.Empty;
            if (nome == "") retorno = "nome";
            else if (nome.Length < 7) retorno = "nomecurto";
            else if (rg.Length != 12) retorno = "rg";
            else if (cpf.Length != 14) retorno = "cpf";
            else if (cnh.Length != 11) retorno = "cnh";
            else if (data.Length != 10) retorno = "data";
            else if (Convert.ToDateTime(data).AddYears(18) > DateTime.Now) retorno = "menoridade";
            else if (celular == "") retorno = "celular";
            else if (email == "") retorno = "email";
            else if (email.Contains('@') == false) retorno = "emailcom@";
            else if (cep.Length != 9) retorno = "cep";
            else if (logradouro == "") retorno = "logradouro";
            else if (cidade == "") retorno = "cidade";
            else if (bairro == "") retorno = "bairro";
            else if (uf == "") retorno = "uf";
            else if (numerocasa == "") retorno = "numerocasa";


            return retorno;
        }

        public string VerificaFuncionarios(string nome, string rg,string telefone, string cpf, bool ativo,string datanas
            , string dataAd, string dataDemi, string cep, string logradouro, string cidade, string bairro
            , string uf, string numerocasa,string usuario)
        {
            string retorno = string.Empty;
            if (nome == "") retorno = "nome";
            else if (nome.Length < 7) retorno = "nomecurto";
            else if (rg.Length != 12) retorno = "rg";
            else if (telefone.Length != 14) retorno = "telefone";
            else if (cpf.Length != 14) retorno = "cpf";
            else if (datanas.Length != 10) retorno = "datanas";
            else if (Convert.ToDateTime(datanas).AddYears(18) > DateTime.Now) retorno = "menoridade";
            else if (dataAd.Length != 10) retorno = "dataAd";
            else if (ativo == false && dataDemi.Length != 10)
            {
                retorno = "dataDemi";
            }
            else if (cep.Length != 9) retorno = "cep";
            else if (logradouro == "") retorno = "logradouro";
            else if (cidade == "") retorno = "cidade";
            else if (bairro == "") retorno = "bairro";
            else if (uf == "") retorno = "uf";
            else if (numerocasa == "") retorno = "numerocasa";
            else if (usuario == "") retorno = "usuario";


            return retorno;

        }

        public string VerificaVeiculos(string chas, string fabricante, string placa, string marca, string cor,string km,
            string datafab, string datacompra, string dataultimarevisao,string foto, string obs)
        {
            double saida;

            string retorno = string.Empty;
            if (chas.Length != 17) retorno = "chassis";
            else if (fabricante == "") retorno = "fabricante";
            else if (placa.Length != 8) retorno = "placa";
            else if (marca == "") retorno = "marca";
            else if (cor == "") retorno = "cor";
            else if (km == "") retorno = "km";
            else if (!double.TryParse(km, out saida))
            {
                retorno = "kmnum";
            }

            return retorno;
        }

        public string VerificaUsuario(string login, string senha, string perfil)
        {
            string retorno = string.Empty;
            if (login == "") retorno = "login";
            else if (senha == "") retorno = "senha";
            else if (perfil == "") retorno = "função";

            return retorno;
        }



        public string verificaReserva(int intVeic, int intCli, int intFunc, string dataReserva, string dataDev, double valordiaria, string protocolo, int comparacao)
        {
            string retorno = string.Empty;
            int resultado = comparacao; 

            resultado = DateTime.Compare(Convert.ToDateTime(dataReserva), Convert.ToDateTime(dataDev));


            if (intVeic == 0) retorno = "veiculo";
            else if (intCli == 0) retorno = "cliente";
            else if (intFunc == 0) retorno = "funcionario";
            else if (valordiaria == 0.00) retorno = "valordiaria";
            else if (protocolo == "") retorno = "protocolo";
            else if (resultado != -1) retorno = "datainvalida";

           
            return retorno;
            //else if (Convert.ToDateTime(datanas).AddYears(18) > DateTime.Now) retorno = "menoridade";

        }
        public string DB_ReservasPORCliente(Clientes clientes)
        {

            string exec = string.Empty;
            string retorno = string.Empty;
            string query = string.Empty;

            query = " SELECT COUNT(codRES) FROM RESERVAS INNER JOIN CLIENTES ON cliRES = codCLI WHERE situacaoRES = 'A' AND codCLI = " + clientes.getCodigo();
            exec = executar.ExecutarLeituraRNS(query);

            if (exec != "0")
            {
                retorno = "reservado";
            }

            return retorno;

        }
        public string DB_ReservasPORVeiculo(Veiculos veiculos)
        {

            string exec = string.Empty;
            string retorno = string.Empty;
            string query = string.Empty;

            query = " SELECT COUNT(codRES) FROM RESERVAS INNER JOIN VEICULOS ON veicRES = codVEIC  WHERE situacaoRES = 'A' AND codVEIC = " + veiculos.getCodigo();
            exec = executar.ExecutarLeituraRNS(query);

            if (exec != "0")
            {
                retorno = "veiculoreservado";
            }

            return retorno;


        }
    }
}
