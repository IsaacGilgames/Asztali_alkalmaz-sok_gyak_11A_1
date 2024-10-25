using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            double sugar;
            Console.WriteLine("Mennyi a kör sugara");
            sugar = double.Parse(Console.ReadLine());
            Console.WriteLine("Kerülete: " +
                2 * sugar * 3.1416 +
                ", Területe: " +
                sugar * sugar * 3.1416
                );

            double a;
            double b;
            Console.Write("Mekkora a téglalap egyik oldala?");
            a = double.Parse(Console.ReadLine());
            Console.Write("Mekkora a téglalap másik oldala?");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Kerülete: " +
                2 * (a + b) +
                " Területe: " +
                a * b);

            //1. String létrehozása
            string firsString = "Ez egy string";

            //2. Escape karakterek

            Console.WriteLine("Első sor.\nMásodik sor."); // \n --> új sor
            Console.WriteLine("Tabulátor előtt. \t Tabulátor után."); // \t --> vízszintes tabulátor
            Console.WriteLine("\"Ez egy idézet.\""); // \"idézőjel
            Console.WriteLine("\\\\HBSZF03");
            Console.Write("\a"); //alert hang

            //3. Verbatim string

            Console.WriteLine(@"
                    Első sor.
                    Második sor."); //tabulátor és sortörés
            Console.WriteLine(@"""Ez egy idézet!""");
            Console.WriteLine(@"\\HBSZF3");
            
            //4. String konkatenáció
            string iskola = "HBSZ";
            int ev = 2024;

            Console.WriteLine("A tanévnyitó  " + ev + ". szept. 2-án volt a " + iskola + "-ben.");

            //5. String interpoláció
            Console.WriteLine($"A tanévnyitó {ev}. szept. 2-án volt a {iskola}-ben");
            
            //6. Kompozit formázás
            Console.WriteLine("A tanévnyitó {0}. szept. 2-án a {1}-ben", ev, iskola);

            //7. Függvények
            
            //Substring

            string str = "Szoftverfejlesztés";
            string str2 = str.Substring(8, 3);
            Console.WriteLine(str2);

            //Hogy írassuk ki azt, hogy "tver"?
            Console.WriteLine(str.Substring(4, 4);
            //Hogy írassuk ki azt, hogy "ejleszt"?
            Console.WriteLine(str.Substring(9, 7);
            Console.ReadKey();
        }
    }
}
