using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using dll_DB_LocadoraVeiculos;


namespace dll_DB_LocadoraVeiculos
{
    public class Executa
    {
        RecuperaConexao con = new RecuperaConexao();
        

        public void Executar(string query)
        {


            SqlConnection conexao = new SqlConnection(con.RecuperaCNN());
            SqlCommand comando = new SqlCommand(query, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public string ExecutarConsulta(string query)
        {
            string retorno = string.Empty;
            SqlConnection conexao = new SqlConnection(con.RecuperaCNN());

            try
            {
                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    retorno = leitor[0].ToString();                 //Nome do Funcionário
                    retorno = retorno + "," + leitor[1].ToString(); //Perfil do Usuário
                    retorno = retorno + "," + leitor[2].ToString(); //Codigo do Funcionário
                }


            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                conexao.Close();
                conexao.Dispose();
            }

            return retorno; 

        }
        public string ExecutarLeituraRNS(string query)
        {
            string retorno = string.Empty;
            SqlConnection conexao = new SqlConnection(con.RecuperaCNN());

            try
            {
                SqlCommand comando = new SqlCommand(query, conexao);
                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    retorno = leitor[0].ToString();                 

                }


            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                conexao.Close();
                conexao.Dispose();
            }

            return retorno;

        }

    }
        
    
}
