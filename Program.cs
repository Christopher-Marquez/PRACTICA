using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._3_20253446
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatosOrdenador datosOrdenador = new DatosOrdenador("HP", "INTEL core 5", "1TB", "SSD");
            Console.WriteLine("Descripción del ordenador: ");
            Console.WriteLine("Marca " + datosOrdenador.Marca);
            Console.WriteLine("Procesador " + datosOrdenador.Procesador);
            Console.WriteLine("Memoria " + datosOrdenador.Memoria);
            Console.WriteLine("Discoduro " + datosOrdenador.Discoduro);

            datosOrdenador.MayorCapacidad("");
            datosOrdenador.MenorCapacidad("");
            Console.ReadKey();
        }
    }
}

