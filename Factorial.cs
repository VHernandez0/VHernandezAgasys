using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Factorial
    {
        public void factorial()
        {
            Console.WriteLine("Digite el valor que desea factorizar");
            int val = int.Parse(Console.ReadLine());
            int sobrante = val % 2;
            if (sobrante == 0)
            {
                if (val > 1 && val < 18)
                {
                    int fac = 1;
                    for (int i = 1; i <= val; i++)
                    {
                        fac *= i;
                    }
                    Console.WriteLine("El factorial de: " + val + " es: " + fac);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No se ingreso un numero dentro del rango 1 - 18");
                }
            }
            else
            {
                Console.WriteLine("Digite un numero entero");
                Console.ReadKey();
            }
        }
    }
}
