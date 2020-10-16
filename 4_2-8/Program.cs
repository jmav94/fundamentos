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
            // Validacion e impresion con operador condicional e interpolacion.
            Console.WriteLine(unNumero.EsPar() ? $"{unNumero.Valor} es par" : $"{unNumero.Valor} es impar");
            // Validacion e impresion con operador condicional e interpolacion doble.
            Console.WriteLine( $"{unNumero.Valor} es {(unNumero.EsPar() ? "par" : "impar")}");
        }
    }
}
