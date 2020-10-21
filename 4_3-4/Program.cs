using System;

namespace _4_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase objeto = new Clase();
            Console.WriteLine($"El resultado de la suma de los numeros impares que existe entre 20 y 150 es {objeto.SumaImpares().ToString("N")}");
        }
    }
}
