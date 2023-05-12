using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Delegado
    {
        public int Candidato1 { get; set; }
        public int Candidato2 { get; set; }
        public int Candidato3 { get; set; }
        public int Votos { get; set; }

        public int Electores { get; set; }


        public void Votacion()
        {
            Delegado del = new Delegado();
            del.Candidato1 = 0;
            del.Candidato2 = 0;
            del.Candidato3 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("digite su candidato a dar el voto");
                del.Votos = int.Parse(Console.ReadLine());
                switch (del.Votos)
                {
                    case 1:
                        del.Candidato1++;
                        break;
                    case 2:
                        del.Candidato2++;
                        break;
                    case 3:
                        del.Candidato3++;
                        break;
                }

            }
            Console.WriteLine("Votos del candidato 1: " + del.Candidato1);
            Console.WriteLine("votos del candidato 2: " + del.Candidato2);
            Console.WriteLine("Votos del candidato 3: " + del.Candidato3);
            Console.ReadKey();
        }
    }
   
}
