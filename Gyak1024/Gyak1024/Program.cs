using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak1024
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-től 100-ig irattasd ki azokat a számokat
            //amelyek oszthatóak 3-mal
            //de nem oszthatóak 9-cel

            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 9 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Írd ki -100-tól 100-ig a számokat
            //A negatív és pozitív számpárok egymás
            ////mellett legyenek
            //pl -23 és 23

            for (int i = 0; i <= 100; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine($"{i} és {-i}");
                }
            }

            //Faktoriális
            //Eyy: Bekérsz egy egész számot!
            //Kettü: kiírod a faktoriálisát!
            //5! = 120

            Console.Write("Adj megy egy számot: ");
            long number = long.Parse(Console.ReadLine());
            long eredeti = number;
            for (long i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            Console.WriteLine($"{eredeti}! = {number}");


                Console.ReadKey();
        }
    }
}
