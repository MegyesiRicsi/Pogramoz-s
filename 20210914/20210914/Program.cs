using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210914
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat
            Console.WriteLine("Hello World");
            //2. Feladat
            Console.WriteLine("Add meg a nevedet");
            string nev = Console.ReadLine();
            Console.WriteLine("Halo {0}", nev);
            //3. Feladat
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            int nehossz = nev.Length;
             Console.SetCursorPosition(szelesseg/2-nehossz/2, magassag/2);
            Console.WriteLine(nev);
            //4. Feladat
            Console.WriteLine("Adj egy számot");
            double szam = double.Parse(Console.ReadLine());
            Console.WriteLine("A megadott aszám 2x-e {0}", szam*2);
            //5. Feladat
            Console.WriteLine("Add meg az első számot");
            double szam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot");
            double szam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("A 2 szám összege{0}", szam1+szam2);
            Console.WriteLine("A 2 szám különbségük {0}", szam1-szam2);
            Console.WriteLine("A 2 szám szorzata {0}", szam1*szam2);
            Console.WriteLine("A 2 szám hányadosa {0}", szam1/szam2);
            Console.WriteLine("A 2 szám hányadosa {0}", szam1%szam2);
            //6. Feladat
            Console.WriteLine("Add meg a négyzet oldalát!");
            double negyzeta = double.Parse(Console.ReadLine());
            Console.WriteLine("A négyzet kerülete: {0} \n A négyzet területe: {1} ", negyzeta*4, negyzeta*negyzeta);
            //7. Feladat
            Console.WriteLine("Add meg a tágélalap A oldalát!");
            double teglaA = double.Parse(Console.ReadLine());
            //8. Feladat


            Console.WriteLine("Program vége");
            Console.ReadKey();
        }
       
    }
}
