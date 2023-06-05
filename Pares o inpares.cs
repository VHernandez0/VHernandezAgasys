using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public  class Pares_o_inpares
    {
        public void numeros()
        {
            Console.WriteLine("Digite su Primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int res1 = num1 % 2;
            int res2 = num2 % 2;
            if (res1==0)
            {
                Console.WriteLine("El valor: "+num1+" es par");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El valor: " + num1 + " es inpar");
                Console.ReadKey();
            }
            
            if (res2==0)
            {
                Console.WriteLine("El valor: " + num2 + " es par");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El valor: " + num2 + " es inpar");
                Console.ReadKey();
            }
        }
    }
}
