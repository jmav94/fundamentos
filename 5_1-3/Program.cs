using System;

namespace _5_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendario c = new Calendario();
            bool blMesCorrecto = false;
            do{
                Console.Write("Capture el numero del mes que desea mostrar con letras: ");
                c.Mes = int.Parse(Console.ReadLine());
                if (c.Mes < 1 || c.Mes > 12) Console.WriteLine("Capture un mes correcto!!");
                else blMesCorrecto = true;
            }while(blMesCorrecto == false);
            Console.WriteLine($"El mes seleccionado es {c.MesConLetra()}");

            for (int i = 1; i <= 12; i++)
            {
                c.Mes = i;
                Console.WriteLine($"El mes seleccionado es {c.MesConLetra()}");
            }

        }
    }
}
