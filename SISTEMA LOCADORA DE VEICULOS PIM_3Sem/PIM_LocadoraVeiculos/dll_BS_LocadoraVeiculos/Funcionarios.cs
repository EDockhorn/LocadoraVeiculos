using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_LocadoraVeiculos
{
    public class Funcionarios : Usuarios
    {
        #region SETTERS/GETTERS
        public int codigofunc { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public DateTime datanasc { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public DateTime dataadmissao { get; set; }
        public DateTime datademissao { get; set; }
        #endregion

        #region CONSTRUTOR
        public Funcionarios()
        {
            nome = "José";
            endereco = " Avenida dos Palmares";
            cidade = "São Paulo";
            estado = "SP";
            bairro = "Jaguaré";
            telefone = "1111x1111";
            rg = "11.111.111-2";
            cpf = "111.111.111-2";
            datanasc = System.DateTime.Now;
            dataadmissao = System.DateTime.Now;
            datademissao = System.DateTime.Now;
            getLogin();
            getSenha();
        #endregion

        }

    }

}
