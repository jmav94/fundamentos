using System;

namespace _2_1_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisa divisa = new Divisa();

            Console.Write("Capture la cantidad en pesos:");
            divisa.Cantidad = int.Parse(Console.ReadLine());
            Console.Write("Capture el tipo de cambio:");
            divisa.TipoCambio = double.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de su conversion es de: {divisa.ConvertirADolares()} dolares");
        }
    }
}
