using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasslade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {     //Övning 1
              char tecken;
              for (int y = 0; y < 10; y++)
               {
               for (int i = 0; i < 10; i++)
               {
                    if (i % 2 == 0)
                        tecken = 'o';
                    else
                        tecken = '#';
                    Console.Write(tecken);
                }
                Console.WriteLine();
                }
            Console.WriteLine();

            //Övning 2
            char tecken1;
            for (int x = 0; x < 11; x++)
            {
                for (int o = 0; o < 11; o++)
                {
                    if ((o+x) % 2 == 0)
                        tecken1 = 'o';
                    else
                        tecken1 = '#';
                    Console.Write(tecken1);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Övning 3
            char tecken2;
            for (int z = 0; z < 10; z++)
            {
                for (int a = 0; a < 10-z; a++)
                {
                    if (z % 2 == 0)
                        tecken2 = '#';
                    else
                        tecken2 = '#';
                    Console.Write(tecken2);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Övning 4 
            char tecken3;
            for (int z1 = 0; z1 < 10; z1++)
            {
                for (int a1 = 0; a1 < 1 + z1; a1++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();

            }



        }
    }
}
