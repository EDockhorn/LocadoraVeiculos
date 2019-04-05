using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_LocadoraVeiculos
{
    class Contratos : Reservas
    {

        #region SETTERS/GETTERS
        public int codigocontrato { get; set; }
        public DateTime dataemissao { get; set; }
        #endregion

        #region CONSTRUTOR
        public Contratos()
        {
            dataemissao = System.DateTime.Now;
        }

        #endregion
    }
}
