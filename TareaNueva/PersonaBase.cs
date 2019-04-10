using System;
using System.Collections.Generic;
using System.Text;

namespace TareaNueva
{
    class PersonaBase
    {               
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public bool EsPersonaFisica { set; get; }
        public string CuitCuil { set; get; }

        public virtual int ObtenerTotal()
        {
            return 0;
        }



        //public void Saludar()
        //{
        //    Console.WriteLine("Hola " + Nombre);
        //}



        //public void Despedir()
        //{
        //    Console.WriteLine("Hasta luego " + Apellido);
        //}


    }
}
