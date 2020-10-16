using System;

namespace _4_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta miVenta = new Venta();
            Console.Write("Capture la venta del mes Enero: ");
            miVenta.VentaMayor = double.Parse(Console.ReadLine());
            Console.Write("Capture la venta del mes Febrero: ");
            miVenta.VentaMes = double.Parse(Console.ReadLine());
            miVenta.EvaluarMayor();
            Console.Write("Capture la venta del mes Marzo: ");
            miVenta.VentaMes = double.Parse(Console.ReadLine());
            miVenta.EvaluarMayor();
            Console.Write("Capture la venta del mes Abril: ");
            miVenta.VentaMes = double.Parse(Console.ReadLine());
            miVenta.EvaluarMayor();
            Console.Write("Capture la venta del mes Diciembre: ");
            miVenta.VentaMes = double.Parse(Console.ReadLine());
            miVenta.EvaluarMayor();
            Console.WriteLine($"La venta mayor es de: {miVenta.VentaMayor}");
        }
    }
}
