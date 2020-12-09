using System;

namespace _6_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta VentaAnual = new Venta();

            for (int i = 0; i < 12; i++)
            {
                double VentaMes = 0.0;
                Console.Write($"Capture la venta del mes {i+1}: ");
                VentaMes = int.Parse(Console.ReadLine());
                VentaAnual[i] = VentaMes;
            }
            Console.WriteLine("\nVentas capturadas correctamente.");
            Console.WriteLine($"\nEl promedio de ventas del año es de {VentaAnual.CalcularPromedio()}.");
            Console.WriteLine($"\nLa venta mayor fue de {VentaAnual.CalcularVentaMayor()}.");
            Console.WriteLine($"\nEl mes con la menor venta es {VentaAnual.MostrarMesMenor()}.");
        }
    }
}


