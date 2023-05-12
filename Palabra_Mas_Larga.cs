using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Palabra_Mas_Larga
    {
        public void Palabra()
        {
            string str;
            Console.WriteLine("Digite su cadena");
            str = Console.ReadLine();

            string[] cadena = str.Split(' ');

            int cont = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                cont++;
                Console.WriteLine("array "+cont+" tiene :" + cadena[i].Length+" Palabras");
               
            }
           

            Console.ReadKey();

        }
    }
}
