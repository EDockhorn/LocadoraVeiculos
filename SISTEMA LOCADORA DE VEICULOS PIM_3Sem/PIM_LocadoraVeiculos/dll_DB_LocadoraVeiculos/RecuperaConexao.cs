using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace dll_DB_LocadoraVeiculos
{
    public class RecuperaConexao
    {
        public RecuperaConexao()
        {
            string strCon = string.Empty;
        }

        public string RecuperaCNN()
        {

            string strCon = string.Empty;
        
            try
            {
                StreamReader sr = File.OpenText("str.txt");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    strCon = input;
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                strCon = err;
            }

            return strCon;
        }
        public Boolean TestaConexao()
        {
            SqlConnection con = null;
            SqlCommand command = null;
            string Query = "";

            bool retorno = false;

            try
            {
                con = new SqlConnection(RecuperaCNN());

                command = new SqlCommand(Query, con);
                con.Open();

                retorno = true;

                return retorno;

            }


            catch (Exception ex)
            {
                string err = ex.Message;
                return retorno;
            }
            finally
            {
                if (con != null) con.Close(); con.Dispose();

            }


        }
    }
}
