using System;

namespace _5_1_1
{
    class Program
    {
        // Declaracion de objeto Global
        static Estudiante unEstudiante = new Estudiante();
        static void Main(string[] args)
        {
            bool salir = false;
            do{
                Console.WriteLine("----------------------------------------\nBienvenido selecciona una opcion del siguiente menu.\n1.- Limpar Datos \n2.- Capturar Datos \n3.- Imprimir Datos \n4.- Salir\n------------------------------------");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: LimpiarDatos();break;
                    case 2: CapturarDatos();break;
                    case 3: Console.WriteLine(ImprimirDatos()); break;
                    case 4: salir = true;break;
                    default: Console.WriteLine("Opcion incorrecta!!");break;
                }
            }while (salir == false);
            
            
        }
        static void LimpiarDatos(){
            Console.Clear();
        }
        static void CapturarDatos(){
            Console.Write("Capture el numero de lista: ");
            unEstudiante.NLista = int.Parse(Console.ReadLine());
            Console.Write("Capture el apellido paterno: ");
            unEstudiante.APaterno = Console.ReadLine();
            Console.Write("Capture el apellido materno: ");
            unEstudiante.AMaterno = Console.ReadLine();
            Console.Write("Capture los nombres: ");
            unEstudiante.Nombres = Console.ReadLine();
            Console.Write("Capture el grupo: ");
            unEstudiante.Grupo = char.Parse(Console.ReadLine());
            Console.Write("Capture el promedio: ");
            unEstudiante.Promedio = double.Parse(Console.ReadLine());


        }
        static string ImprimirDatos(){
            return $"Numero de lista: {unEstudiante.NLista}\nNombre Completo: {unEstudiante.Nombres} {unEstudiante.APaterno} {unEstudiante.AMaterno} \nGrupo: {unEstudiante.Grupo} \nPromedio: {unEstudiante.Promedio}";
        }
    }
}
