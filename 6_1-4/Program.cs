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

                Console.WriteLine("1.- Limpiar datos de estudiantes.\n2.- Capturar datos de estudiantes.\n3.- Calcular promedio de calificaciones.\n4.- Calcular estudiantes aprobados.\n5.- Mostrar estudiante con mayor calificacion\n0.- Salir.");

                intOpcion = int.Parse(Console.ReadLine());

                switch (intOpcion)
                {
                    case 1: {
                        LimpiarEstudiantes(ref Estudiantes);
                    } break;
                    case 2: {
                        CapturarEstudiantes(ref Estudiantes);
                     } break;
                    case 3: {
                        Console.WriteLine("El promedio de califiaciones es {0}", CalcularPromedio(Estudiantes));
                    }  break;
                    // case 3: Console.WriteLine($"El promedio de califiaciones es {CalcularPromedio(Estudiantes)}"); break;
                    case 0: Console.WriteLine("Saliendo de la aplicacion."); break;
                    case 4: {
                        Console.WriteLine("La cantidad estudiantes aprobados es de {0}", CalcularEstudiantesAprobados(Estudiantes));
                    } break;
                    case 5: {
                        //Console.WriteLine("El estudiante con mayor calificacion es {0} y su numerto de control es {1} y tiene una calificacion de {2}",CalcularEstudianteMayor(Estudiantes).Nombre,CalcularEstudianteMayor(Estudiantes).NControl,CalcularEstudianteMayor(Estudiantes).Calificacion);
                        /*Console.WriteLine($"El estudiante con mayor calificacion es {CalcularEstudianteMayor(Estudiantes).Nombre} y su numerto de control es {CalcularEstudianteMayor(Estudiantes).NControl} y tiene una calificacion de {CalcularEstudianteMayor(Estudiantes).Calificacion}");*/
                        Estudiante unEstudiante = CalcularEstudianteMayor(Estudiantes);
                        Console.WriteLine($"El estudiante con mayor calificacion es {unEstudiante.Nombre} y su numerto de control es {unEstudiante.NControl} y tiene una calificacion de {unEstudiante.Calificacion}");
                    } break;
                    default: Console.WriteLine("Capture una opcion correcta."); break;
                }                
                Console.WriteLine("Capture cualquier letra para continuar");
                        Console.ReadKey();
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
    
        static Estudiante CalcularEstudianteMayor(Estudiante[] miArregloEstudiantes){
            /*Estudiante EstudianteMayor = new Estudiante();
            EstudianteMayor = miArregloEstudiantes[0];*/
            Estudiante EstudianteMayor = miArregloEstudiantes[0];

            foreach (Estudiante unEstudiante in miArregloEstudiantes)
            {
                if (unEstudiante.Calificacion > EstudianteMayor.Calificacion)
                {
                    EstudianteMayor = unEstudiante;
                }
            }
            return EstudianteMayor;
        }
    }
}
