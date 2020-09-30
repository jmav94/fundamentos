using System;


namespace _2_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulo unArticulo = new Articulo();
            Console.Write("Capture la clave numerica: ");
            unArticulo.ClaveNumerica = int.Parse(Console.ReadLine());
            Console.Write("Capture la descripcion: ");                     
            unArticulo.Descripcion = Console.ReadLine();
            Console.Write("Capture el precio:");
            unArticulo.Precio = double.Parse(Console.ReadLine());
            Console.Write("Capture la cantidad en existencia:");
            unArticulo.CantidadEnExistencia = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"\n====================================\nDatos del articulo capturado \nClave numerica: {unArticulo.ClaveNumerica} \nDescripcion: {unArticulo.Descripcion} \nPrecio: {unArticulo.Precio} \nCantidad en existencia: {unArticulo.CantidadEnExistencia}");
        }
    }
}
