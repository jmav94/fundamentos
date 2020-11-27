using System;

namespace Ejemplo_Burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miArreglo = null;
            int intOpcion;
            do
            {
                Console.WriteLine("1.- Generar aleatoriamente datos del arreglo\n2.- Imprimir el arreglo\n3.- Ordenar mediante el método de la burbuja\n0.- Salir");
                intOpcion = int.Parse(Console.ReadLine());
                switch (intOpcion)
                {
                    case 1: GenerarArregloAleatorio(ref miArreglo); break;
                    case 2: ImprimirArreglo(miArreglo); break;
                    case 3: Burbuja(ref miArreglo);break;
                    case 0: Console.WriteLine("Saliendo de la aplicacion");break;
                    default: Console.WriteLine("La opcion que seleccionaste no es correcta");break;
                }
            } while (intOpcion != 0);

            // Metodo para generar numeros aletorios en el arreglo.
            void GenerarArregloAleatorio(ref int[] miArreglo2){
                // Declaracion de objetos y variables
                Random aleatorio = new Random();
                int intTamanio;
                int intCelda;

                Console.WriteLine("Teclee la cantidad de celdas del arreglo");
                // Captura del tamaño del arreglo
                intTamanio = int.Parse(Console.ReadLine());
                // Creacion del arreglo en base al tamaño dado por el usuario
                miArreglo2 = new int[intTamanio];
                // Ciclo para generar numeros aleatorios en nuestro arreglo
                for (intCelda = 0; intCelda< intTamanio; intCelda++)
                {
                    // Asignacion de numero aleatorio a la celda del arreglo
                    miArreglo2[intCelda] = aleatorio.Next(10,21);
                }
            }

            // Metodo para imprimir los valores del arreglo.
            void ImprimirArreglo(int[] miArreglo3){
                foreach (int intNumero in miArreglo3)
                {
                    Console.Write($"| {intNumero}");
                }
                Console.Write("\n");
            }

            void Burbuja(ref int[] miArreglo4){
                // variables que usaremos para el intercambio
                int intTemporal, i, j;
                for (i = 0; i < miArreglo4.Length - 1; i++)
                {
                    for (j = miArreglo4.Length -1; j > i  ; j--)
                    {
                        if (miArreglo4[j]< miArreglo4[j-1])
                        {
                            intTemporal = miArreglo4[j];
                            miArreglo4[j] = miArreglo4[j-1];
                            miArreglo4[j-1] = intTemporal;
                        }
                    }
                }
            }

        }
    }
}
