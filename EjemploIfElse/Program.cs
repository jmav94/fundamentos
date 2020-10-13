using System;

namespace EjemploIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            LlamadaTelefonica miLlamadaTelefonica = new LlamadaTelefonica();
            int intCostoLlamada;
            Console.Write("Teclee la duracion de la llamada en minutos: ");
            miLlamadaTelefonica.Duracion = int.Parse(Console.ReadLine());
            intCostoLlamada = miLlamadaTelefonica.CalcularCosto();
            Console.WriteLine($"Costo = {intCostoLlamada}");
        }
    }
}
