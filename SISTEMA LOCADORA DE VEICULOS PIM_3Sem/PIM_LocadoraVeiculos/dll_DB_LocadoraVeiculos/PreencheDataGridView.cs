using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dll_DB_LocadoraVeiculos
{
    public class PreencheDataGridView
    {
        RecuperaConexao conexao = new RecuperaConexao();
        public DataSet PrencherDados(string consulta, string tabela)
        {
            var con = new SqlConnection(conexao.RecuperaCNN());

            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable(tabela);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(SqlDataAdapter);
            DataSet ds = new DataSet();
            SqlDataAdapter.Fill(ds);
            return ds;


        
           
        }
    }
}
