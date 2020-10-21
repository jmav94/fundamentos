using System;

namespace _4_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase objeto = new Clase();
            Console.WriteLine($"Los numeros que existen entre 25 y 15 son los siguientes: {objeto.CadenaNumeros()}");
        }
    }
}
