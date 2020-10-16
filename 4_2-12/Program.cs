using System;

namespace _4_2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno almuno = new Alumno();
            Console.Write("Capture la calificacion 1: ");
            almuno.C1 = int.Parse(Console.ReadLine());
            Console.Write("Capture la calificacion 2: ");
            almuno.C2 = int.Parse(Console.ReadLine());
            Console.Write("Capture la calificacion 3: ");
            almuno.C3 = int.Parse(Console.ReadLine());
            Console.WriteLine(almuno.Aprobado());
        }
    }
}
