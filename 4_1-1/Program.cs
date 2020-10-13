using System;

namespace _4_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carretera miCarretera;
            miCarretera = new Carretera();
            Console.Write("Capture la longitd de la carretera en Kilometros: ");
            miCarretera.Longitud = double.Parse(Console.ReadLine());
            Console.WriteLine($"La longitud capturada en es de: {miCarretera.Longitud} km\ny en metros su carretera es de: {miCarretera.ConvertirAMetros() } mts.");
        }
    }
}
