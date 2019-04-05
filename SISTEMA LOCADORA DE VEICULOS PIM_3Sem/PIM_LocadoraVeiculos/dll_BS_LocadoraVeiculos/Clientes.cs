using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_LocadoraVeiculos
{
    public class Clientes
    {
        #region SETTERS/GETTERS
        public int codcli;
        private string Nome;
        public string nome
        {
            get { return Nome; }

            set { Nome = value; }
        
        }

        public void setCodigo(int Codcli)
        {
            codcli = Codcli;
        }

        public int getCodigo()
        {
            return codcli;
        }
                
            
            
            
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string email { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public DateTime datanasc { get; set; }
        public DateTime datacadastro { get; set; }
        public string CNH { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string numcasa { get; set; }
        #endregion

        #region CONSTRUTOR
        public Clientes()
        {

            /*nome
            logradouro = " Avenida dos Palmares";
            cidade = "São Paulo";
            estado = "SP";
            bairro = "Jaguaré";
            email = "teste@hotmail.com";
            rg = "11.111.111-2";
            cpf = "111.111.111-2";
            datanasc = System.DateTime.Now;
            CNH = "11111111111";
            telefone = "1111x1111";
             */
        #endregion
        }


    }
}
