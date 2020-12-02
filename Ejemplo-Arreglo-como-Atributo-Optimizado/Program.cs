using System;

namespace Ejemplo_Arreglo_como_Atributo_Optimizado
{
    class Program
    {
        static Estudiante [] miArregloEstudiantes = null;
        static void Main(string[] args)
        {
            int intOpcion;
            do
            {
                Console.WriteLine("Menu de opciones\n");
                Console.WriteLine("1- Capturar los datos de los estudiantes");
                Console.WriteLine("2- Buscar el nombre del estudiante con Mayor promedio");
                Console.WriteLine("0- Salir");
                Console.Write("\nSeleccione la opcion que desea realizar: ");
                
                intOpcion = int.Parse(Console.ReadLine());

                switch (intOpcion)
                {
                    case 1: CapturarArreglo();break;
                    case 2: {
                        /*string resultado = BuscarEstudianteConPromedioMayor(miArregloEstudiantes);
                        Console.WriteLine(resultado);*/
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(BuscarEstudianteConPromedioMayor(miArregloEstudiantes));
                        Console.WriteLine("----------------------------------");
                    };break;
                    case 0: Console.WriteLine("Saliendo de la aplicacion");break;
                    default: Console.WriteLine("Capture una opcion Correcta");break;
                }

            } while (intOpcion != 0);
        }
        
        static void CapturarArreglo(){
                int intCantidadEstudiantes;
                Console.Write("Capture la cantidad de estudiantes: ");
                intCantidadEstudiantes = int.Parse(Console.ReadLine());
                miArregloEstudiantes = new Estudiante[intCantidadEstudiantes];
                for (int intCelda = 0; intCelda < intCantidadEstudiantes; intCelda++)
                {
                    Estudiante unEstudiante = new Estudiante();
                    Console.WriteLine("\nCapturando los datos del estudiante {0}\n",intCelda+1);
                    Console.Write("Numero de control: ");
                    unEstudiante.NoCtrl = Console.ReadLine();
                    Console.Write("Nombre: ");
                    unEstudiante.Nombre = Console.ReadLine();
                    
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write("Capture la calificacion {0}: ", c+1);
                       
                        /*int Calificacion;
                        Calificacion = int.Parse(Console.ReadLine());
                        unEstudiante[c] = Calificacion;*/
                        unEstudiante[c] = int.Parse(Console.ReadLine());   
                    }
                    miArregloEstudiantes[intCelda] = unEstudiante;
                    Console.WriteLine("\n--------------------------------\n");
                    
                }
            }    
        static string BuscarEstudianteConPromedioMayor(Estudiante[] miArreglo){
                Estudiante unEstudiante = new Estudiante();
                unEstudiante = miArreglo[0];

                foreach (Estudiante miEstudiante in miArreglo)
                {
                    if (miEstudiante.CalcularPromedio() > unEstudiante.CalcularPromedio())
                    {
                        unEstudiante = miEstudiante;
                    }
                }

                return $"El nombre del estudiante con promedio mayor es {unEstudiante.Nombre} y su promedio es de {unEstudiante.CalcularPromedio()} ";
            }
        }
        
    }
