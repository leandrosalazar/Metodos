using System;
using System.Collections.Generic;
using System.Text;

namespace TareaNueva
{
    class Cliente : PersonaBase
    {
        public int TotalVentas { set; get; }
        public string EsClientePreferencial { set; get; }
        public decimal LimiteDeCuentaCorriente { set; get; }


        public override int ObtenerTotal()
        {
            return TotalVentas;
        }

    }
}
