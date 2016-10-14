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
        {   //Övning 1
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

        }
    }
}
