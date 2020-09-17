using System;

namespace TestPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona;
            unaPersona = new Persona();

            unaPersona.Edad = 50;

            //Console.WriteLine($"Hola tu edad es: {unaPersona.Edad}");
        }
    }
}
