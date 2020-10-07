using System;

namespace _4_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo miTriangulo = new Triangulo();
            Console.Write("Capture L1: ");
            miTriangulo.L1 = int.Parse(Console.ReadLine());
            Console.Write("Capture L2: ");
            miTriangulo.L2 = int.Parse(Console.ReadLine());
            Console.Write("Capture L3: ");
            miTriangulo.L3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {miTriangulo.CalcularArea()}");
        }
    }
}
