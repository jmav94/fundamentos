using System;

namespace _6_1_3
{
    class Program
    {
        static Temperatura[] misTemperaturas;
        static void Main(string[] args)
        {
            //misTemperaturas = new Temperatura[24];
            misTemperaturas = new Temperatura[5];
            Temperatura unaTemperatura;
            for (int i = 0; i < misTemperaturas.Length; i++)
            {
                unaTemperatura = new Temperatura();
                Console.Write($"Capture la temperatura de la hora {i+1}: ");
                unaTemperatura.Valor = double.Parse(Console.ReadLine());
                misTemperaturas[i] = unaTemperatura;
            }

            Console.WriteLine($"Promedio de temperatura del dia: {PromedioTemperatura()}");
            Console.WriteLine($"Numero de Celda con la temperatura mas Fria: {BuscarCeldaMasFria()}");
            Console.WriteLine($"Numero de Celda con la temperatura mas Caliente: {BuscarCeldaMasCaliente()}");
            Console.WriteLine($"Valor de la temperatura más fría: {BuscarTemperaturaMasFria().Valor}");
            Console.WriteLine($"Valor de la temperatura más caliente: {BuscarTemperaturaMasCaliente().Valor}");

        }

        static int BuscarCeldaMasFria(){
            int Celda = 0;
            double TempFria = misTemperaturas[0].Valor;
            for (int i = 0; i < misTemperaturas.Length; i++)
            {
                if ( misTemperaturas[i].Valor < TempFria)
                {
                    TempFria = misTemperaturas[i].Valor;
                    Celda = i;
                }
            }
            return Celda+1;
        }
        static int BuscarCeldaMasCaliente(){
            int Celda = 0;
            double TempCaliente = misTemperaturas[0].Valor;
            for (int i = 0; i < misTemperaturas.Length; i++)
            {
                if ( misTemperaturas[i].Valor > TempCaliente)
                {
                    TempCaliente = misTemperaturas[i].Valor;
                    Celda = i;
                }
            }
            return Celda+1;
        }
        static Temperatura BuscarTemperaturaMasFria(){
            Temperatura TempMasFria = new Temperatura();
            TempMasFria.Valor = 1000;
            foreach (var temp in misTemperaturas)
            {
                if (temp.Valor < TempMasFria.Valor)
                {
                    TempMasFria = temp;
                }
            }
            return TempMasFria;
        }

        static Temperatura BuscarTemperaturaMasCaliente(){
            Temperatura TempMasCaliente = new Temperatura();
            TempMasCaliente.Valor = -1000;
            foreach (var temp in misTemperaturas)
            {
                if (temp.Valor > TempMasCaliente.Valor)
                {
                    TempMasCaliente = temp;
                }
            }
            return TempMasCaliente;
        }
        static double PromedioTemperatura(){
            double dblPromedio = 0.0;
            foreach (Temperatura temp in misTemperaturas)
            {
                dblPromedio += temp.Valor;
                //dblPromedio = dblPromedio + temp.Valor;                
            }

            return dblPromedio / misTemperaturas.Length;
        }
    }
}
