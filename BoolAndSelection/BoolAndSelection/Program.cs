using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolAndSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Logikai változó
            bool b1 = true;
            bool b2 = false;

            //2. Feltételes operátorok
            Console.WriteLine(b1 && b2); //és = and
            Console.WriteLine(b1 || b2); //vagy = or

            Console.WriteLine(b1 == true && b2 == true);
            Console.WriteLine(b1 == true && b2 == false);
            Console.WriteLine(b1 == false && b2 == true);
            Console.WriteLine(b1 == false && b2 == false);

            /*
             *          A       B       &
             *          0       0       0
             *          1       0       0
             *          0       1       0
             *          1       1       1
             */

            Console.WriteLine(b1 == true || b2 == true); 
            Console.WriteLine(b1 == true || b2 == false);
            Console.WriteLine(b1 == false || b2 == true);
            Console.WriteLine(b1 == false || b2 == false);

        



                        /*
             *          A       B       ||
             *          0       0       0
             *          1       0       1
             *          0       1       1
             *          1       1       1
             */

            Console.WriteLine(!b1); 
            Console.WriteLine(!b2);

            //2. If-then-else elágazás
            int x = 10;

            if (x == 10)
            {
                Console.WriteLine("Az x az 10");
            }

            x = 11;

            if (x == 10)
            {
                Console.WriteLine("Az x az 10");
            }
            else
            {
                Console.WriteLine("Az x az nem 10");
            }

            if (x == 10)
            {
                Console.WriteLine("Az x az 10");
            }
            if(x != 10)
            {
                Console.WriteLine("Az x az nem 10");
            }

 

            if (x == 10)
            {
                Console.WriteLine("Az x az 10");
            }
            else if (x == 11)
            {
                Console.WriteLine("Az x az 11");
            }
            else
            {
                Console.WriteLine("Az x az nem 10 és 11");
            }




            //kér be egy kg és magasság cm
            //tti = kg/(m*m)
            /*Console.Write("Adjon meg egy testtömeget(kg): ");
            double tt = double.Parse(Console.ReadLine());
            Console.Write("Adjon meg egy magasságot(cm): ");
            double tm = double.Parse(Console.ReadLine())/100;
            Console.WriteLine($"Az ön testtömegindexe {tt/(tm*tm)}");

            //1,5 * (3/2)
          
            Console.WriteLine(1.5 * ((double)3/2));

            */

            Console.WriteLine(1.5*(4/3)); //1.5 
            Console.WriteLine(1.5*(7/3)); //3

            /*
            Console.WriteLine("Mekkora az autó tankja (l)?");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Mennyit fogyaszt km-ként?");
            double fogy = double.Parse(Console.ReadLine());
            Console.WriteLine($"Az autó kb {l/fogy} km-t tud megtenni egy tankkal!");
            */

            int y = 11;

            Console.WriteLine(y == 10 ? "Az y értéke 10" : "Az y értéke nem 10");
            // ?:

            Console.WriteLine(y == 10 ? "Az y értéke 10" : y > 10 ? "Az y értéke nagyobb, mint 10": "Az y értéke kisebb, mint 10");

            //3. switch

            Console.Write("Adj meg egy magánhagzót: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "A":
                case "a": 
                    Console.WriteLine("Ez egy a");
                    break;
                case "e":
                case "E":
                    Console.WriteLine("Ez egy e");
                    break;
                case "i":
                case "I":
                    Console.WriteLine("Ez egy i");
                    break;
                case "o":
                case "O":
                    Console.WriteLine("Ez egy o");
                    break;
                case "u":
                case "U":
                    Console.WriteLine("Ez egy u");
                    break;
                default:
                    Console.WriteLine("Ez nem magánhangzó!");
                    break;

            }

           





            Console.ReadKey();

        }
    }
}
