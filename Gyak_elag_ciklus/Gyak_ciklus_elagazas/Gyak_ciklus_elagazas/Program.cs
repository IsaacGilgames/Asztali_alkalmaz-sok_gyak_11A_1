using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_ciklus_elagazas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int db = 0;
            for (int i = 100; i <= 999; i++)
            {
                int elso = i / 100;
                int utso = i % 10;
                if (elso == utso)
                {
                    Console.Write($"{i}, ") ;
                    db++;
                }
            }
            Console.WriteLine(db);
            Console.ReadKey();
            */
            
            for(int i = 0; i < 10; i++)
            {
                for(int k = 1; k < 10; k++)
                {
                    Console.WriteLine($"{k}{i}{k}");
                }
            }
            Console.ReadKey();
        }
    }
}
