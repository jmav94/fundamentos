using System;

namespace _5_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion o = new Operacion();
            Console.WriteLine("Capture el numero para calcular el factorial: ");
            /*
            int num;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado de la operacion es {o.Factorial(num)}");
            */
            Console.WriteLine(o.Factorial(int.Parse(Console.ReadLine())));
            }
    }
}
