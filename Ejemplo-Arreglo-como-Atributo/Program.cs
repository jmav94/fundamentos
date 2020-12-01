using System;

namespace Ejemplo_Arreglo_como_Atributo
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante [] miArregloEstudiantes = null;
            int intOpcion;
            do
            {
                Console.WriteLine("1- Capturar los datos de los estudiantes");
                Console.WriteLine("2- Buscar el nombre del estudiante con Mayor promedio");
                Console.WriteLine("0- Salir");
                Console.Write("\nSeleccione la opcion que desea realizar: ");
                
                intOpcion = int.Parse(Console.ReadLine());

                switch (intOpcion)
                {
                    case 1: CapturarArreglo();break;
                    case 2: BuscarEstudianteConPromedioMayor();break;
                    case 0: Console.WriteLine("Saliendo de la aplicacion");break;
                    default: Console.WriteLine("Capture una opcion Correcta");break;
                }

            } while (intOpcion != 0);
            
            void CapturarArreglo(){
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
                        Console.Write("Capture la calificacion {0}: ",c+1);
                       
                        /*int calificacion = int.Parse(Console.ReadLine());
                        unEstudiante[c] = calificacion;*/
                        unEstudiante[c] = int.Parse(Console.ReadLine());   
                    }
                    miArregloEstudiantes[intCelda] = unEstudiante;
                    Console.WriteLine("\n--------------------------------\n");
                    
                }
            }
            
            void BuscarEstudianteConPromedioMayor(){
                string strResultado;

                strResultado = BuscarPromedioMayor(miArregloEstudiantes);

                Console.WriteLine("El nombre del estudiante con promedio mayor es {0}",strResultado);
            }
        
            string BuscarPromedioMayor(Estudiante[] miArreglo){
                double dblPromedioMayor;
                string strNombre;

                dblPromedioMayor = miArreglo[0].CalcularPromedio();
                strNombre = miArreglo[0].Nombre;

                foreach (Estudiante miEstudiante in miArreglo)
                {
                    if (miEstudiante.CalcularPromedio() > dblPromedioMayor)
                    {
                        dblPromedioMayor = miEstudiante.CalcularPromedio();
                        strNombre = miEstudiante.Nombre;
                    }
                }
                return strNombre;
            }
        }
    }
}
