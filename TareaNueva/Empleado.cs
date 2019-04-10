using System;
using System.Collections.Generic;
using System.Text;

namespace TareaNueva
{
    class Empleado : PersonaBase
    {
        public DateTime FechaIngreso { set; get; }
        public int NumeroLegajo { set; get; }
        public int Salario { set; get; }

        public override int ObtenerTotal()
        {
            return Salario;
        }

    }
}
