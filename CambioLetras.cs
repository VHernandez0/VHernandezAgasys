using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CambioLetras
    {
        public void SopaLetras()
        {
            Console.WriteLine("Digite una palabra");
            string palabra = Console.ReadLine();

            string orden = new string(palabra.OrderBy(x => x).ToArray());
            Console.WriteLine(orden);
            Console.ReadKey();
        }
    }
}
