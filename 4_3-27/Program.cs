using System;

namespace _4_3_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno unAlumno;
            bool otroAlumno;
            do{
                unAlumno = new Alumno();
                Console.WriteLine("Captura el numero de control:");
                unAlumno.NumControl = int.Parse(Console.ReadLine());
                Console.WriteLine("Captura la calificacion 1");
                unAlumno.Cal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Capture la calificacion 2");
                unAlumno.Cal2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Capture la calificacon 3");
                unAlumno.Cal3 = int.Parse(Console.ReadLine());
                
                
                if (CalcularPromedio() >= 80)
                {
                    Console.WriteLine(unAlumno.NumControl);
                }
                Console.WriteLine("¿Desea capturar otro alumno?");
                otroAlumno = bool.Parse(Console.ReadLine());

            }while(otroAlumno);
        }
        public double CalcularPromedio(){
            double Promedio = (unAlumno.Cal1*.3) +(unAlumno.Cal2*.35)+(unAlumno.Cal3*.35);
            return Promedio;
        }
    }
}
