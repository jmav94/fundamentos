using System;

namespace _5_1_2
{
    class Program
    {
        static GalletaCircular gc;
        static GalletaCuadrada gcu;
        static GalletaRectangular gr;
        static void Main(string[] args)
        {
            int intOpcion;
            bool blSalir = false;
            Console.WriteLine("Bienvenido!!");
            do
            {
                Console.WriteLine("---------------------------------\nCaptura la opcion en base al siguiente menu \n1- Capturar Galleta circular \n2- Capturar Galleta cuadrada \n3- Capturar Galleta rectangular \n4- Imprimir los datos de todas las galletas \n5- Mostrar galleta de mayor área \n0.- Salir \n---------------------------------");

                intOpcion = int.Parse(Console.ReadLine());

                switch (intOpcion)
                {
                    case 1: GalletaCircular(); break;
                    case 2: GalletaCuadrada(); break;
                    case 3: GalletaRectangular(); break;
                    case 4: ImprimirGalletas(); break;
                    case 5: CalcularGalletaMasGrande(); break;
                    case 0: blSalir = true; break;
                    default: Console.WriteLine("Seleccione una opcion correcta!!");break;
                }

            } while (blSalir == false);
        }
        static void GalletaCircular(){
            gc = new GalletaCircular();

            Console.Write("Capture el radio de la galleta circular: ");
            gc.Radio = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area de la galleta es de {gc.CalcularArea()}");
        }
        static void GalletaCuadrada(){
            gcu = new GalletaCuadrada();

            Console.Write("Capture el lado de la galleta cuadrada: ");
            gcu.Lado = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area de la galleta es de {gcu.CalcularArea()}");
        }
        static void GalletaRectangular(){
            gr = new GalletaRectangular();

            Console.Write("Capture la base de la galleta rectangular: ");
            gr.Base = double.Parse(Console.ReadLine());
            Console.Write("Capture la altura de la galleta rectangular: ");
            gr.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area de la galleta es de {gr.CalcularArea()}");
        }
        static void ImprimirGalletas(){
            Console.WriteLine($"Galleta Circular: Radio {gc.Radio} Area: {gc.CalcularArea()} \nGalleta Cuadrada: Lado {gcu.Lado} Area: {gcu.CalcularArea()} \nGalleta Rectangular: Base {gr.Base}  Altura {gr.Altura} Area: {gr.CalcularArea()}");
        }
        static void CalcularGalletaMasGrande(){
            double dblAreaGc = gc.CalcularArea();
            double dblAreaGcu = gcu.CalcularArea();
            double dblAreaGr = gr.CalcularArea();

            if (dblAreaGc >= dblAreaGcu && dblAreaGc >= dblAreaGr)
            {
                Console.WriteLine($"La galleta circular es la mas grande con un area de {dblAreaGc}");
            }else if(dblAreaGcu >= dblAreaGr){
                Console.WriteLine($"La galleta cuadrada es la mas grande con un area de {dblAreaGcu}");

            }else{
                Console.WriteLine($"La galleta rectangular es la mas grande con un area de {dblAreaGr}");
            }
        }

    }
}
