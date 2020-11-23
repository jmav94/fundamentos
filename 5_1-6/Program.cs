using System;

namespace _5_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion o = new Operacion();
            double num1, num2;
            Console.Write("Captura el primer numero para la suma: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Captura el segundo numero para la suma: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es {o.Sumar(num1,num2)}"); 

        }
    }
}
