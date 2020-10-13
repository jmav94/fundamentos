using System;

namespace _4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiaDePago unDia = new DiaDePago();
            Console.Write("Capture el dia de la semana: ");
            unDia.Dia = Console.ReadLine();
            if (unDia.VerificarDia())
            {
                Console.WriteLine( $"{unDia.Dia} si es dia de pago");    
            }
            if (!unDia.VerificarDia())
            {
                Console.WriteLine( $"{unDia.Dia} no es dia de pago");    
            }
        }
    }
}
