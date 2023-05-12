using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sueldo_Diario { get; set; }

        public void Calcula_sueldo()
        {
            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();
            Empleado empleado3 = new Empleado();

            empleado1.Sueldo_Diario = 500;
            empleado2.Sueldo_Diario = 400;
            empleado3.Sueldo_Diario = 300;

            Console.WriteLine("Digite su numero de empleado: ");
            int empleado = int.Parse(Console.ReadLine());
            int dias;
            switch (empleado)
            {
                case 1:
                    Console.WriteLine("Digite su nombre: ");
                    empleado1.Nombre = Console.ReadLine();

                    Console.WriteLine("Digite su apellido: ");
                    empleado1.Apellido = Console.ReadLine();

                    Console.WriteLine("Dias trabajados");
                    dias = int.Parse(Console.ReadLine());

                    int sueldo1 = empleado1.Sueldo_Diario * dias;
                    Console.WriteLine("Empleado 1: " + empleado1.Nombre + " " + empleado1.Apellido + " Su sueldo es :" + sueldo1);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Digite su nombre: ");
                    empleado2.Nombre = Console.ReadLine();

                    Console.WriteLine("Digite su apellido: ");
                    empleado2.Apellido = Console.ReadLine();


                    Console.WriteLine("Dias trabajados");
                    dias = int.Parse(Console.ReadLine());
                    int sueldo2 = empleado2.Sueldo_Diario * dias;
                    Console.WriteLine("Empleado 2: " + empleado2.Nombre + " " + empleado2.Apellido + " Su sueldo es :" + sueldo2);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Digite su nombre: ");
                    empleado3.Nombre = Console.ReadLine();

                    Console.WriteLine("Digite su apellido: ");
                    empleado3.Apellido = Console.ReadLine();


                    Console.WriteLine("Dias trabajados");
                    dias = int.Parse(Console.ReadLine());
                    int sueldo3 = empleado3.Sueldo_Diario * dias;
                    Console.WriteLine("Empleado 3: " + empleado3.Nombre + " " + empleado3.Apellido + " Su sueldo es :" + sueldo3);
                    Console.ReadKey();
                    break;
            }
            

         
            

           
        }
    }

   
}
