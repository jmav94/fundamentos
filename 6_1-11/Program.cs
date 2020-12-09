using System;

namespace _6_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta VentaAnual = new Venta();
            Console.Write("Capture la cantidad de celdas del arreglo: ");
            int intCantidad = int.Parse(Console.ReadLine());
            VentaAnual.CrearArreglo(intCantidad);

            for (int i = 0; i < intCantidad; i++)
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
            Console.WriteLine($"\nEl mes con la mayor venta es {VentaAnual.MostrarMesMayor()}.");
        }
    }
}


