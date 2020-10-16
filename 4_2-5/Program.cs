using System;

namespace _4_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            AgenteVentas unAgente = new AgenteVentas();
            Console.Write("Capture el nombre del Agente: ");
            unAgente.Nombre = Console.ReadLine();
            Console.Write("Capture la cantidad de autos vendidos en el mes: ");
            unAgente.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nombre: {unAgente.Nombre} \n{unAgente.CalcularSueldo()}");
        }
    }
}
