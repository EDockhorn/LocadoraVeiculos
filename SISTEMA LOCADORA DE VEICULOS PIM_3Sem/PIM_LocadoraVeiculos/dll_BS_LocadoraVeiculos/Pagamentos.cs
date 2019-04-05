using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_LocadoraVeiculos
{
    public class Pagamentos : Reservas
    {
        #region SETTER/GETTERS
        public int codigopgto { get; set; }
        public string formapagamento { get; set; }
        public double valortotal { get; set; }
        public int qtdparcelas { get; set; }
        public string statuscartao { get; set; }
        public DateTime datapagamento { get; set; }
        #endregion

        #region CONSTRUTOR
        public Pagamentos()
        {
            formapagamento = "à vista";
            valortotal = 300.00;
            qtdparcelas = 1;
            statuscartao = "";
            datapagamento = System.DateTime.Now;
        }

        #endregion
    }
}
