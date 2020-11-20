using System;

namespace _4_2_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante unEstudiante = new Estudiante();
            Console.Write("Capture el promedio del alumno: ");
            unEstudiante.Promedio = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"El grupo del estudiante es {unEstudiante.VerificarGrupo()}");
        }
    }
}
