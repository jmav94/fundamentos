using System;

namespace _6_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta VentaAnual = new Venta();

            for (int i = 0; i < 5; i++)
            {
                double VentaMes = 0.0;
                Console.WriteLine($"Capture la venta del mes {i+1}");
                VentaMes = int.Parse(Console.ReadLine());
                VentaAnual[i] = VentaMes;
            }
            Console.WriteLine("Ventas capturadas correctamente.");
            Console.WriteLine($"El promedio de ventas del año es de {VentaAnual.CalcularPromedio()}.");
            Console.WriteLine($"La venta mayor fue de {VentaAnual.CalcularVentaMayor()}.");
            Console.WriteLine($"El mes con la menor venta es {VentaAnual.MostrarMesMenor()}.");
        }
    }
}


