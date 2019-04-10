using System;
using System.Collections.Generic;
using System.Text;

namespace TareaNueva
{
    class Proveedor : PersonaBase
    {
        public string NombreComercial { set; get; }        
        public DateTime FechaUltimaCompra { set; get; }
        public int TotalCompras { set; get; }

        public override int ObtenerTotal()
        {
            return TotalCompras;
        }

        public DateTime UltimaCompra()
        {
            return FechaUltimaCompra;
        }




    }
}
