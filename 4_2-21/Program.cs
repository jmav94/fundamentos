using System;

namespace _4_2_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadro unCuadro = new Cuadro();
            Console.Write("Capture la medida del cuadro: ");
            unCuadro.Medida = double.Parse(Console.ReadLine());
            if (unCuadro.VerificarMedida())
            {
                Console.WriteLine("Aceptado");
            }else
            {
                Console.WriteLine("No Aceptado");
            }
        }
    }
}
