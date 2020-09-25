using System;

namespace _2_1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulo unArticulo = new Articulo();

            Console.Write("Capture el nombre del articulo:");
            unArticulo.Nombre = Console.ReadLine();
            Console.Write("Capture el precio del articulo:");
            unArticulo.Precio = double.Parse(Console.ReadLine());
            Console.Write("Capture la cantidad vendida del articulo:");
            unArticulo.CantidadVendida = int.Parse(Console.ReadLine());

            Console.WriteLine($"El iva del articulo es de: {unArticulo.CalcularIVA()}");
            Console.WriteLine($"El descuento del articulo es de: {unArticulo.CalcularDescuento()}");
            Console.WriteLine($"El subtotal del articulo es de: {unArticulo.CalcularSubtotal()}");
            Console.WriteLine($"El total dela compra es de: {Math.Round(unArticulo.CalcularTotal())}");
        }
    }
}
