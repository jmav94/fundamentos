using System;

namespace _5_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Gerente = new Empleado();
            Empleado Supervisor = new Empleado();
            Empleado Operario = new Empleado();
            int Opcion;
            do{
            Console.WriteLine("1.- Capturar datos del gerente\n2.- Capturar datos del supervisor\n3.- Capturar datos del operario\n4.- Imprimir reporte\n0.- Salir");
            Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
                {
                    case 1: CapturarDatosEmpleado(out Gerente);break;
                    case 2: CapturarDatosEmpleado(out Supervisor);break;
                    case 3: CapturarDatosEmpleado(out Operario);break;
                    case 4: ImprimirReporte();break;
                    case 0: Console.WriteLine("Saliendo de la aplicacion");break;
                    default: Console.WriteLine("Capturo una opcion incorrecta"); break;
                }
            }while(Opcion != 0);
            
            // Metodo para caoturar datos del empleado
            void CapturarDatosEmpleado(out Empleado unEmpleado){
                unEmpleado = new Empleado();
                Console.Write("Capture el numero de empleado: ");
                unEmpleado.Numero = int.Parse(Console.ReadLine());
                Console.Write("Capture el apellido paterno de empleado: ");
                unEmpleado.ApellidoP = Console.ReadLine();
                Console.Write("Capture el apellido materno de empleado: ");
                unEmpleado.ApellidoM = Console.ReadLine();
                Console.Write("Capture los nombres  de empleado: ");
                unEmpleado.Nombre = Console.ReadLine();
                Console.Write("Capture las horas trabajadas de empleado: ");
                unEmpleado.Horastrabajadas = int.Parse(Console.ReadLine());
                Console.Write("Capture el sueldo por hora de empleado: ");
                unEmpleado.SueldoPHora = double.Parse(Console.ReadLine());
            }

            // Metodo para imprimir reporte
            void ImprimirReporte(){
                Console.WriteLine("\a\t\t\t\t\tEmpresa Tec Laredo");
                Console.WriteLine("\t\t\t\t\tAv. Reforma 2007 sur");
                Console.WriteLine("\t\t\t\t\tNuevo Laredo, Tam\n");
                Console.WriteLine("Num. Empleado\t Nombre completo\t Horas trabajadas\t Sueldo por hora\t Sueldo Neto");
                Console.WriteLine("__________________________________________________________________________________________________________________");
                Console.WriteLine($"{Gerente.Numero}\t\t {Gerente.Nombre} {Gerente.ApellidoP} {Gerente.ApellidoM}\t {Gerente.Horastrabajadas}\t {Gerente.SueldoPHora}\t {Gerente.SueldoNeto()}");

                Console.WriteLine($"{Supervisor.Numero}\t\t {Supervisor.Nombre} {Supervisor.ApellidoP} {Supervisor.ApellidoM}\t {Supervisor.Horastrabajadas} \t{Supervisor.SueldoPHora}\t {Supervisor.SueldoNeto()}");

                Console.WriteLine($"{Operario.Numero}\t\t {Operario.Nombre} {Operario.ApellidoP} {Operario.ApellidoM}\t {Operario.Horastrabajadas}\t{Operario.SueldoPHora}\t {Operario.SueldoNeto()}");
                Console.WriteLine("__________________________________________________________________________________________________________________");
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\t Total: {Gerente.SueldoNeto() + Supervisor.SueldoNeto() + Operario.SueldoNeto()}");
            }
        }
    }
}
