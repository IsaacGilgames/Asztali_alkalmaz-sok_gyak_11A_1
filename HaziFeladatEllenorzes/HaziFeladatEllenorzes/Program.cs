using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaziFeladatEllenorzes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1-től 100-ig a számok, amelyek nem oszthatók 8-cal, de 2-vel igen: ");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0 && i % 8 != 0)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine("Adj meg egy számot!");
            int num = int.Parse(Console.ReadLine());
            int x = 1;
            for (int i = num; i > 1; i--)
            {   if(i-1 != 1)
                {
                    x *= i;
                    Console.WriteLine($"{num}! = {x} * {i - 1}!");
                }
                else
                {
                    x *= i;
                    Console.WriteLine($"{num}! = {x}");
                }
               
            }

            int honap = int.Parse(Console.ReadLine());
            switch (honap)
            {
                case 1:
                case 3:
                    Console.WriteLine("31 napos");
                    break;
            }


            //Gyakorlas1104
            //100-90 5
            //89-70 4
            //69-50 3
            //49-30 2
            //29-0 1

            //Kérd be a dolgozat hány százalékos lett (kerekítve)
            //és írd ki az eredmény!


            int gondoltam = 42;
            //Készíts egy programot, amely addig kér be számot
            //ameddig a gondolt számot nem írod be!




            Console.ReadKey();
        }
    }
}
