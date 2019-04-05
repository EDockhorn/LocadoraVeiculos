using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dll_BS_LocadoraVeiculos
{
    public class Reservas : Veiculos
    {
        
        #region SETTERS/GETTERS
        public int codigoreserva { get; set; }
        public string situacaoreserva { get; set; } // A = Alugado e D disponpivel
        public DateTime datareserva { get; set; }
        public DateTime datadevolucao { get; set; }
        public double valordiaria { get; set; }
        public int qtdreserva { get; set; }
        public string protoloco { get; set; }
        public double valortotal { get; set; }

        #endregion

        #region CONSTRUTOR
        public Reservas()
        {
            datareserva = System.DateTime.Now;
            valordiaria = 200.00;
            qtdreserva = 1;
            situacaoreserva = "Emprestado";
            
            
        #endregion
        }

        public string ReservasPORCliente(Clientes clientes)
        {
            
            string retorno = string.Empty;

            clientes.getCodigo();

            return retorno;
        }
    }

}
