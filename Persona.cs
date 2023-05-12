using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public int ContadorMayores { get; set; }
        public int ContadorMenores { get; set; }

        public void CalcularEdad()
        {
            Persona edad = new Persona();
            Persona Nombre = new Persona();

            Persona Contmayores = new Persona();
            Persona ContMenores = new Persona();
            Contmayores.ContadorMayores = 0;
            ContMenores.ContadorMenores = 0;

            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine("Digite su nombre");
                Nombre.Nombre = Console.ReadLine();
                Console.WriteLine("Digite su edad");
                edad.Edad = int.Parse(Console.ReadLine());
                if (edad.Edad > 18)
                {
                    Contmayores.ContadorMayores++;
                }
                else
                {
                    Contmayores.ContadorMenores++;
                }
            }
            Console.WriteLine("El numero de personas mayores de edad son: " + Contmayores.ContadorMayores);
            Console.WriteLine("El numero de personas menores de edad son: " + Contmayores.ContadorMenores);
            Console.ReadKey();
        }
    }


}
