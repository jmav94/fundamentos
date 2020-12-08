using System;

namespace _6_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] Estudiantes = null;
            int intOpcion = 0;
            do
            {
                Console.Clear();
                
                Console.WriteLine("Bienvenido, selecione la opcion que desea ejecutar.\n");

                Console.WriteLine("1.- Limpiar datos de estudiantes.\n2.- Capturar datos de estudiantes.\n3.- Calcular promedio de calificaciones.\n4.- Calcular estudiantes aprobados.\n0.- Salir.");

                intOpcion = int.Parse(Console.ReadLine());

                switch (intOpcion)
                {
                    case 1: {
                        LimpiarEstudiantes(ref Estudiantes);
                        Console.WriteLine("Capture cualquier letra para continuar");
                        Console.ReadKey();
                    } break;
                    case 2: {
                        CapturarEstudiantes(ref Estudiantes);
                        Console.WriteLine("Capture cualquier letra para continuar");
                        Console.ReadKey();
                     } break;
                    case 3: {
                        Console.WriteLine("El promedio de califiaciones es {0}", CalcularPromedio(Estudiantes));
                        Console.WriteLine("Capture cualquier letra para continuar");
                        Console.ReadKey();
                    }  break;
                    // case 3: Console.WriteLine($"El promedio de califiaciones es {CalcularPromedio(Estudiantes)}"); break;
                    case 0: Console.WriteLine("Saliendo de la aplicacion."); break;
                    case 4: {
                        Console.WriteLine("La cantidad estudiantes aprobados es de {0}", CalcularEstudiantesAprobados(Estudiantes));
                    Console.WriteLine("Capture cualquier letra para continuar");
                        Console.ReadKey();
                    } break;
                    default: Console.WriteLine("Capture una opcion correcta."); break;
                }                
            } while (intOpcion != 0);   
        }
        static void LimpiarEstudiantes(ref Estudiante[] ArregloEstudiantes){
            ArregloEstudiantes = null;
            Console.WriteLine("Los estudiantes han sido eliminados.");
        }

        static void CapturarEstudiantes(ref Estudiante[] ArregloEstudiantes){
            int intCantidadEstudiantes;
            Console.Write("Capture la cantidad de estudiantes: ");
            intCantidadEstudiantes = int.Parse(Console.ReadLine());

            ArregloEstudiantes = new Estudiante[intCantidadEstudiantes];

            for (int i = 0; i < ArregloEstudiantes.Length; i++)
            {
                Estudiante unEstudiante = new Estudiante();
                Console.WriteLine($"\nCapturando los datos del estudiante {i+1}\n");
                Console.Write("Capture el n. control: ");
                unEstudiante.NControl = int.Parse(Console.ReadLine());
                Console.Write("Capture el nombre: ");
                unEstudiante.Nombre = Console.ReadLine();
                Console.Write("Capture la calificacion: ");
                unEstudiante.Calificacion = double.Parse(Console.ReadLine());

                ArregloEstudiantes[i] = unEstudiante;
            }
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Estudiantes capturados correctamente.\n");
        }

        static double CalcularPromedio(Estudiante[] miArregloEstudiantes){
            double Promedio = 0.0;
            foreach (Estudiante unEstudiante in miArregloEstudiantes)
            {
                Promedio+= unEstudiante.Calificacion;
                //Promedio = Promedio + unEstudiante.Calificacion;
            }
            return Promedio / miArregloEstudiantes.Length;
        }

        static int CalcularEstudiantesAprobados(Estudiante[] miArregloEstudiantes){
            int CantidadAprobados = 0;
            
            foreach (Estudiante unEstudiante in miArregloEstudiantes)
            {
                if (unEstudiante.Calificacion >= 70)
                {
                    CantidadAprobados++;
                }
            }
            return CantidadAprobados;
        }
    }
}
