using System;

namespace SuperMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion del objeto
            Articulo miArticulo  = new Articulo();
            // Solicitar al usuario teclear la clave numerica
            Console.WriteLine("Capure la clave numerica del ariculo:");
            // Leemos la clave numerica y la asigamos al atributo por medio de su propiedad
            miArticulo.ClaveNumerica = int.Parse(Console.ReadLine());
            // Solicitamos al usuario que capture la descripcion
            Console.WriteLine("Capure la descripcion del ariculo:");
            // Leemos el valor y lo asignamos por medio de su propiedad
            miArticulo.Descripcion = Console.ReadLine();
            //
            Console.WriteLine("Capture el precio del articulo");
            miArticulo.Precio = double.Parse(Console.ReadLine());
            //
            Console.WriteLine("Capture la cantidad en existencia.");
            miArticulo.CantidadEnExistencia = double.Parse(Console.ReadLine());

            Console.WriteLine("\n====================================================\n");

            // Imprimir los valores de los atributos (utilizando string template)
            Console.WriteLine($"Clave numerica: {miArticulo.ClaveNumerica}\nDecripcion: {miArticulo.Descripcion}\nPrecio: {miArticulo.Precio}\nCantidad en Existenia:  {miArticulo.CantidadEnExistencia}");
            // Imprimir los valores de los atributos (utilizando el metodo convencional)
            Console.WriteLine("Clave numerica: "+ miArticulo.ClaveNumerica + "\nDescripcion: "+ miArticulo.Descripcion + "\nPrecio: " + miArticulo.Precio + "\nCantidad en existencia: " + miArticulo.CantidadEnExistencia);

        }
    }
}
