using System;

namespace _4_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase objeto = new Clase();
            Console.Write("Capture el numero limite para realizar la suma: ");
            objeto.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma de los numeros naturales de 1 hasta {objeto.Numero} es {objeto.Suma()}");
        }
    }
}
