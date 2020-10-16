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
            Operacion = int.Parse(Console.ReadLine());
            switch (Operacion)
            {
                case 2: Console.WriteLine($"El resultado de su operacion es: {unaCalculadora.Resta()}");break;
                case 1: Console.WriteLine($"El resultado de su operacion es: {unaCalculadora.Suma()}");break;
                case 3: Console.WriteLine($"El resultado de su operacion es: {unaCalculadora.Multiplicacion()}");break;
                case 4: Console.WriteLine($"El resultado de su operacion es: {unaCalculadora.DivisionEntera()}");break;
                case 5: Console.WriteLine($"El resultado de su operacion es: {unaCalculadora.Division()}");break;
                case 6: Console.WriteLine($"El resultado de su operacion es: {unaCalculadora.Potencia()}");break;
                default: Console.WriteLine("Selecciono una opcion incorrecta");break;
            }
        }
    }
}
