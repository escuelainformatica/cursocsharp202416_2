using ConsoleApp5.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        /// <summary>
        /// Esta es la funcion de ejemplo del 16/10
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // primer ejercicio
            var mountain = new Bicicleta();
            mountain.nombre = "marca1";
            mountain.marca = "Oxford";
            mountain.velocidades = 10;

            Console.WriteLine(mountain.nombre);
            Console.WriteLine(mountain.marca);
            Console.WriteLine(mountain.velocidades);

            // ejercicio 2
            var fac1 = new Factura
            {
                numFactura = 1,
                nombreCliente = "vtr",
                fecha = "01/01/2010",
                monto = 434343
            };
            // ejercicio 3
            var peugeot = new Auto
            {
                patente="XXBB-33",
                marca="Peugeot",

            };




            Console.ReadKey();
        }
    }
}
