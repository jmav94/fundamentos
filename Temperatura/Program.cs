using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperaturaGradosFarenheit miTemperatura = new TemperaturaGradosFarenheit();
            Console.Write("Teclee la temperatura en grados farenheit: ");
            miTemperatura.GradosFarenheit = double.Parse(Console.ReadLine());

            Console.WriteLine($"La temperatura en grados centigrados: { Math.Round(miTemperatura.ConvertiAGradosCentigrados())}");

        }

        
    }
}
