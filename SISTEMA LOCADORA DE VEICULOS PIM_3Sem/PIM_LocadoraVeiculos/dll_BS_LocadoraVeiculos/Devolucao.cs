using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_LocadoraVeiculos
{
    class Devolucao : Reservas
    {
        #region SETTERS/GETTERS
        public string responsavelchecagem { get; set; }
        public DateTime data { get; set; }
        #endregion


        #region CONSTRUTOR
        public Devolucao()
        {
            responsavelchecagem = "Gestor";
            data = System.DateTime.Now;
        }
        #endregion

    
    }
}
