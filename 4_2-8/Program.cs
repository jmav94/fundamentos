using System;

namespace _4_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero unNumero = new Numero();
            Console.Write("Capture un numero: ");
            unNumero.Valor = int.Parse(Console.ReadLine());
            if (unNumero.EsPar())
            {
                Console.WriteLine($"{unNumero.Valor} es par");
            }else
            {
                Console.WriteLine($"{unNumero.Valor} es impar");
            }
        }
    }
}
