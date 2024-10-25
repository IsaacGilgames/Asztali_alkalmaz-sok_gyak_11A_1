using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kiírás a konzolra
            Console.WriteLine("Hello World!");


            //1. Változók létrehozása
            int firstVariable; //deklaráció
            firstVariable = 10; //definíció
            int secondVariable = 20; //deklaráció és definíció
            Console.WriteLine(firstVariable);

            //2. Matematikai operátorok
            int x = 10;
            int y = 3;
            int z = x + y; //Összeadás
            Console.WriteLine(z);
            z = x - y;      //Kivonás
            Console.WriteLine(z);
            z = x * y;      //Szorzás
            Console.WriteLine(z);
            z = x / y;      //Osztás
            Console.WriteLine(z);
            z = x % y;      //Maradékos osztás
            Console.WriteLine(z);


            //3. Relációs operátorok
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);


            //4. Rövid forma és inkrementálás
            x = 10;
            x = x + 5; //normál forma
            x += 5;     //rövid forma

            x = 1;
            Console.WriteLine(++x);     //2 (prefix inkrementálás)
            Console.WriteLine(x);       //2

            x = 1;
            Console.WriteLine(x++);     //1 (postfix inkrementálás)
            Console.WriteLine(x);       //2


            //5. Szöveg összefűzés (konkatenáció)
            int osztaly = 11;
            Console.WriteLine("Ez a" + osztaly + " A. osztály");

            //6. Beolvasás a konzolról
            string strInput = Console.ReadLine();
            int intInput1 = int.Parse(strInput); //kizárólag string konvertálás
            int intInput2 = Convert.ToInt32(strInput); //bármilyen változot konvertál

            int intInput3 = int.Parse(Console.ReadLine());

            Console.WriteLine(intInput1);
            Console.WriteLine(intInput2);
            Console.WriteLine(intInput3);







            //A végén legyen mindig
            Console.ReadKey();
        }
    }
}
