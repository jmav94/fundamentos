using System;

namespace _2_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha miFecha;
            miFecha = new Fecha();

            Console.Write("Capture el dia: ");
            miFecha.Dia = int.Parse(Console.ReadLine());
            Console.Write("Capture el mes: ");
            miFecha.Mes = int.Parse(Console.ReadLine());
            Console.Write("Capture el Año: ");
            miFecha.Anio = int.Parse(Console.ReadLine());

            Console.WriteLine($"\tLa fecha Capturada es: \n{miFecha.Dia}/{miFecha.Mes}/{miFecha.Anio}");
        }
    }
}
