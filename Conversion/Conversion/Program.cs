using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Implicit típus konverzió
            int numInt = 500;
            Type n = numInt.GetType();

            double numDouble = numInt;
            Type n1 = numDouble.GetType();

            Console.WriteLine(numInt);
            Console.WriteLine(n);
            Console.WriteLine(numDouble);
            Console.WriteLine(n1);

            //2. Castolás
            int szam1 = 5;
            int szam2 = 120;
            double maradeknincs = szam1 / szam2;
            double vanmaradek1 = Convert.ToDouble(szam1) / szam2; //konvertálás
            double vanmaradek2 = (double)szam1 / szam2; 
            Console.WriteLine(vanmaradek2);

            //3. Explicit típus konverzió
            numDouble = 3.14;
            numInt = (int)numDouble;

            Console.WriteLine(numDouble);
            Console.WriteLine(numInt);
            Console.WriteLine(n);


            //4. Cm-ből m (magasság)
            //Bekérsz egy cm-t
            //Átalakítód méterré
            //Kiírod, hogy ennyi cm hány m








            Console.ReadKey();


        }
    }
}
