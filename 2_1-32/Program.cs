using System;

namespace _2_1_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil unAuto = new Automovil();

            Console.Write("Capture la marca del auto: ");
            unAuto.Marca = Console.ReadLine();

            Console.Write("Capturar el model del auto: ");
            unAuto.Modelo = Console.ReadLine();

            Console.Write("Capture el año del auto: ");
            unAuto.Anio = int.Parse(Console.ReadLine());

            Console.Write("Capture el costo del auto: ");
            unAuto.Costo = double.Parse(Console.ReadLine());

            double resultado;
            resultado = unAuto.CalcularCostoTotal();

            Console.Write($"El costo total de su auto es de: {resultado}");
        }
    }
}
