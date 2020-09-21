using System;

namespace _2_1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion y creacion del objeto 
            LlamadaTelefonica unaLlamada = new LlamadaTelefonica();
            // Solicitar al usuario teclear la duracion
            Console.Write("Capture la duracion de la llamada: ");
            // Leer la duracion y asignarla al atributo por medio de la propiedad
            unaLlamada.Duracion = double.Parse(Console.ReadLine());
            // Declaracion de variable double
            double resultado;
            // Asignacion de el resultado del metodo Calcular costo en la variable resultado
            resultado = unaLlamada.CalcularCosto();
            // Impresion del resultado.
            Console.WriteLine($"El costo de la llamada es de: ${resultado}");
        }
    }
}
