using System;

namespace TareaNueva
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Sofia";
            empleado1.Salario = 23000;

            Console.WriteLine("Su sueldo minimo: $" + empleado1.ObtenerTotal());

            Proveedor proveedor1 = new Proveedor();
            proveedor1.Nombre = "Hector";
            proveedor1.TotalCompras = 34;
            Console.WriteLine("Su total de compras es: " + proveedor1.ObtenerTotal());
            proveedor1.FechaUltimaCompra = new DateTime(2018, 07, 21);
            Console.WriteLine("Su ultim compra fue el: " + proveedor1.UltimaCompra());

            Cliente Cliente1 = new Cliente();
            Cliente1.Nombre = "Hector";
            Cliente1.TotalVentas = 53;
            Console.WriteLine("Su total de compras es: " + Cliente1.ObtenerTotal());



            Console.ReadKey();
        }
    }
}
