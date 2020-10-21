using System;

namespace _4_2_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora unaCalculadora = new Calculadora();
            int Operacion;

            Console.Write("Capture el primer numero: ");
            unaCalculadora.N1 = int.Parse(Console.ReadLine());
            Console.Write("Capture el segundo numero: ");
            unaCalculadora.N2 = int.Parse(Console.ReadLine());
            Console.Write("Seleccione la operacion que desea realizar: \n1.- Suma \n2.- Resta \n3.- Multiplicacion \n4.- Divison Entera \n5.- Division Real \n6.- Potencia \nTeclee su opcion: ");
            
            Operacion = Convert.ToInt32(Console.ReadLine());
            Console.Write("El resultado de su operacion es: ");
            switch (Operacion)
            {   
                case 1: Console.Write($"{unaCalculadora.Suma()}");break;
                case 2: Console.Write($"{unaCalculadora.Resta()}");break;
                case 3: Console.Write($"{unaCalculadora.Multiplicacion()}");break;
                case 4: Console.Write($"{unaCalculadora.DivisionEntera()}");break;
                case 5: Console.Write($"{unaCalculadora.Division()}");break;
                case 6: Console.Write($"{unaCalculadora.Potencia()}");break;
                default: Console.WriteLine("Selecciono una opcion incorrecta");break;
            }           
        }
    }
}
