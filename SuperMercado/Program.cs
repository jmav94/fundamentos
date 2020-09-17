using System;

namespace SuperMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulo miArticulo  = new Articulo();
            Console.WriteLine("Capure la clave numerica del ariculo:");
            miArticulo.ClaveNumerica = int.Parse(Console.ReadLine());
            Console.WriteLine("Capure la descripcion del ariculo:");
            miArticulo.Descripcion = Console.ReadLine();
            Console.WriteLine("Capture el precio del articulo");
            miArticulo.Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Capture la cantidad en existencia.");
            miArticulo.CantidadEnExistencia = double.Parse(Console.ReadLine());

            Console.WriteLine($"Clave numerica: {miArticulo.ClaveNumerica}\nDecripcion: {miArticulo.Descripcion}\nPrecio: {miArticulo.Precio}\nCantidad en Existenia:  {miArticulo.CantidadEnExistencia}");
        }
    }
}
