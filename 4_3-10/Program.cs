using System;

namespace _4_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebe unBebe;
            int intCantidadBebes, intCantidadNinos = 0, intCantidadNinas = 0;
            Console.Write("Capture la cantidad de nacimientos:");
            intCantidadBebes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= intCantidadBebes ; i++)
            {
                unBebe = new Bebe();
                Console.Write("Capture el nombre del bebe:");
                unBebe.Nombre = Console.ReadLine();
                do
                {
                    Console.Write("Capture el sexo del bebe:");
                    unBebe.Sexo = char.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------");
                } while (unBebe.Sexo != 'F' && unBebe.Sexo != 'M');
                if (unBebe.Sexo == 'F')
                {
                    intCantidadNinas++;
                }else
                {
                    intCantidadNinos++;
                }
            }
            Console.WriteLine($"La cantidad de bebes niñas es de {intCantidadNinas} , y la cantidad de bebes niños es de {intCantidadNinos}");
        }
    }
}
