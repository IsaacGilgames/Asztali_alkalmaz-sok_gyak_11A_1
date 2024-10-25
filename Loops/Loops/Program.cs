using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. Számláló ciklus - for ciklus
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //int i = 10;

            for (int i = 0; i < 10; i += 2)
            { 

            }
            Console.WriteLine();

            for (int i = 0; i < 10 && i != 4; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //2. while ciklus - Elöltesztelős ciklus
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine();

            //3. do while - hátultesztelős ciklus
            j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);

            Console.WriteLine();

            //4. foreach ciklus
            string text = "abcdefghijklmnopqrstuvwxyz";
            foreach (char ch in text) 
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine();*/

            /*1. Feladat

            for (int i = 1; i < 4; i++)
            {
                for (int k = 1; k < i + 1; k++)
                {
                    Console.WriteLine("X");
                }
            } */

            /*2. Feladat
            Console.WriteLine("Szám");
            int szam = int.Parse(Console.ReadLine());

            bool prim = true;

            for (int i = 2; i < (szam - 1); i++)
            {
                if (szam % i == 0)
                {
                    prim = false;
                }

            }

            if (szam > 1)
            {
                if (prim)
                {
                    Console.WriteLine($"A(z) {szam} prímszám");
                }

                else
                {
                    Console.WriteLine($"A(z) {szam} nem prímszám");
                }
            }
            else
            {
                Console.WriteLine($"Az egy kivétel");
            }

            /* 3. Feladat */
            /*
            Console.WriteLine("Szám");
            int szam = int.Parse(Console.ReadLine());
            int count = 2;

            while (szam != 1)
            {
                if (szam % count == 0)
                {
                    Console.Write($"{szam, 5}|{count}\n");
                    szam /= count;
                }
                else 

                {
                    count++;
                }
            }
            Console.Write($"{szam, 5}|1\n");

            */
            Console.Write("Egész szám: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Művelet (*, /, + , -): ");
            string muv = Console.ReadLine();

            Console.Write("Egész szám: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A kért művelet: {num1}{muv}{num2}");

            int er = 0;
            bool correct = true;
            switch (muv)
            {
               case "*":
                   er = num1 * num2;
                   break; 
               case "/":
                   er = num1 / num2;
                   break;
               case "-":
                   er = num1 - num2;
                   break;
               case "+":
                   er = num1 + num2;
                   break;
                default:
                    correct = false;
                    break;
            }
            if (correct)
            {
                Console.WriteLine($"Az eredmény(egész számban): {er}");
                
            }
            else
            {
                Console.WriteLine("Nem müveletet adtál meg!");
            }
            




            Console.ReadKey();
        }
    }
}
