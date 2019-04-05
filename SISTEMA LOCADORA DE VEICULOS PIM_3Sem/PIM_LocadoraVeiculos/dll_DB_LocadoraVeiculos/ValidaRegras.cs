using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_BS_LocadoraVeiculos;


namespace dll_DB_LocadoraVeiculos
{
    public class ValidaRegras
    {
        RecuperaConexao con = new RecuperaConexao();
        Reservas reservar = new Reservas();
        Executa executar = new Executa();

        //Verifica se o cliente já reservou algum veículo
        // De acordo com a nossas RNs somente será aceito uma alocação
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
