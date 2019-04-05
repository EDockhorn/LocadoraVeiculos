using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_LocadoraVeiculos
{
    public class Veiculos : Clientes
    {
        #region SETTERS/GETTERS
        private int codigo;

        public void setCodigo(int Codigo)
        {
            codigo = Codigo;
        }

        public int getCodigo()
        {
            return codigo;
        }
        
        public string chassis { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public string cor { get; set; }
        public string modelo { get; set; }
        public string situacao { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public DateTime datafabricacao { get; set; }
        public string fabricante { get; set; }
        public DateTime datacompra { get; set; }
        public DateTime dataultimarevisao { get; set; }
        public double km { get; set; }
        #endregion

        #region CONSTRUTOR
        public Veiculos()
        {
            chassis = "";
            descricao = "";
            quantidade = 1;
            cor = "preto";
            modelo = "celta";
            situacao = "";
            placa = "xxx-xxxx";
            marca = "chevrolet";
            datafabricacao = System.DateTime.Now;
            fabricante = "nenhum";
            dataultimarevisao = System.DateTime.Now;
            km = 10.000;
        #endregion
        }

    }


        



}
