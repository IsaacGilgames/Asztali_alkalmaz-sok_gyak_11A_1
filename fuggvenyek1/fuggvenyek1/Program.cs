using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuggvenyek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Szám: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktorialis(szam));

            Console.Write("\n\n\nKör sugara: ");
            double r = 0;
            beker(ref r);
            Console.WriteLine("A kör kerülete: {0} és területe: {1}", Kerulet(r),Terulet(r));
            //Console.WriteLine(r);

            Console.Write("Hány sort szeretnél a háromszögben: ");
            int sor = int.Parse(Console.ReadLine());
            HaromszogRajz(sor);
            //Önállóan
            /*
             

             * 
             **
             ***
             ****
             *****
             

             */
            Console.ReadKey();

        }

        static int Faktorialis(int sz)
        {
            int szorzat = 1;
            for (int i = 2; i <= sz; i++)
            {
                szorzat *= i;
            }
            return szorzat;
        }
        //bekérés
        static void beker(ref double r)
        {
            r = double.Parse(Console.ReadLine());
        }

        //kerület számítás
        static double Kerulet(double r)
        {
            double k = 2 * r * Math.PI;
            return k;
        }
        //terület számítás
        static double Terulet(double r)
        {
            double t = Math.Pow(r, 2) * Math.PI;
            return t;
        }


        

    }
}
