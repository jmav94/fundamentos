using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion de objeto
            TemperaturaGradosFarenheit miTemperatura = new TemperaturaGradosFarenheit();
            // Solicitar al usuario teclear temperarutra
            Console.Write("Teclee la temperatura en grados farenheit: ");
            // Leer temperatura
            miTemperatura.GradosFarenheit = double.Parse(Console.ReadLine());
            // Imprimir resultado de metodo.
            Console.WriteLine($"La temperatura en grados centigrados: { Math.Round(miTemperatura.ConvertiAGradosCentigrados())}");
        }     
    }
}
