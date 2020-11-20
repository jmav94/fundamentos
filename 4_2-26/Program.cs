using System;

namespace _4_2_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Poliza unaPoliza = new Poliza();
            Console.Write("Capture el nombre del cliente: ");
            unaPoliza.Nombre = Console.ReadLine();
            Console.Write("Capture la edad del cliente: ");
            unaPoliza.Edad = int.Parse(Console.ReadLine());
            Console.Write("Capture el valor del auto: ");
            unaPoliza.ValorAuto = double.Parse(Console.ReadLine());
            Console.Write("Capture el modelo del auto: ");
            unaPoliza.Modelo = int.Parse(Console.ReadLine());
            Console.Write("Capture el numero de accidentes: ");
            unaPoliza.NumeroAccidentes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hola {unaPoliza.Nombre} el costo de su poliza es de {unaPoliza.CalcularCosto()}");
        }
    }
}
