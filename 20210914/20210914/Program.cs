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

           feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();
            feladat9();
            feladat10();
            feladat11();
            feladat12and13();
         //   feladat14();


            Console.WriteLine("Program vége");
            Console.ReadKey();
        }
       
        static void feladat1()
         {
            Console.WriteLine("1.Feladat: ");
            Console.WriteLine("Hello World");
         }
        static void feladat2()
        {
            Console.WriteLine("2.Feladat: ");
            Console.WriteLine("Add meg a nevedet");
         string nev = Console.ReadLine();
        Console.WriteLine("Halo {0}", nev);
    }
        static void feladat3()
    {
            Console.WriteLine("3.Feladat: ");
            Console.WriteLine("Add meg a nevedet");
            string nev = Console.ReadLine();
            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;
            int nehossz = nev.Length;
        Console.SetCursorPosition(szelesseg/2-nehossz/2, magassag/2);
        Console.WriteLine(nev);
    }
        static void feladat4()
        {
            
            Console.WriteLine("4.Feladat: ");
            Console.WriteLine("Adj egy számot");
            double szam = double.Parse(Console.ReadLine());
        Console.WriteLine("A megadott aszám 2x-e {0}", szam*2);
    }
        static void feladat5()
        {
            //5. Feladat
            Console.WriteLine("5.Feladat: ");
            Console.WriteLine("Add meg az első számot");
            double szam1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Add meg a második számot");
            double szam2 = double.Parse(Console.ReadLine());
        Console.WriteLine("A 2 szám összege{0}", szam1+szam2);
        Console.WriteLine("A 2 szám különbségük {0}", szam1-szam2);
        Console.WriteLine("A 2 szám szorzata {0}", szam1*szam2);
        Console.WriteLine("A 2 szám hányadosa {0}", szam1/szam2);
        Console.WriteLine("A 2 szám hányadosa {0}", szam1%szam2);
    }
        static void feladat6()
        {
            Console.WriteLine("6.Feladat: ");
            Console.WriteLine("Add meg a négyzet oldalát!");
            double negyzeta = double.Parse(Console.ReadLine());
        Console.WriteLine("A négyzet kerülete: {0} \n A négyzet területe: {1} ", negyzeta*4, Math.Pow(negyzeta, 2));
    }
        static void feladat7()
        {
            //7. Feladat
            Console.WriteLine("7.Feladat: ");
            Console.WriteLine("Add meg a tágélalap A oldalát!");
            double teglaA = double.Parse(Console.ReadLine());
        Console.WriteLine("Add meg a tágélalap B oldalát!");
            double teglaB = double.Parse(Console.ReadLine());
        Console.WriteLine("A téglalap kerülete: {0} \n A négyzet területe: {1} ", teglaA*2+teglaB*2, (teglaB*teglaA));

    }
    static void feladat8()
        {

            Console.WriteLine("8.Feladat: ");
            Console.WriteLine("Adj meg 1 számot és utána eldöntjök melyik a nagyobb!");
            int nagy1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Addd meg a másik számot!");
            int nagy2 = int.Parse(Console.ReadLine());
            if (nagy1>nagy2)
            {
            Console.WriteLine("{0} nagyobb mint {1}", nagy1, nagy2);
        }
            else if (nagy2 > nagy1)
            {
            Console.WriteLine("{0} nagyobb mint {1}", nagy2, nagy1);
        }
            else
            {
            Console.WriteLine("{0} es {1} egyenlőek", nagy1, nagy2);
        }
    }
        static void feladat9()
        {
            Console.WriteLine("9.Feladat: ");
        List<int> min = new List<int>();
            int kicsiszam = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Adj meg 3 egész számot. Eddig ennyi szám van megadva: {0}", min.Count);
                kicsiszam = int.Parse(Console.ReadLine());
                min.Add(kicsiszam);

            }
            Console.WriteLine("A legkisebb szám ezek között! {0}", min.Min());

        }
        static void feladat10()
        {
            //10. Feladat
            Console.WriteLine("10.Feladat: ");
    Console.WriteLine("Add meg a háromszög a oldalát!");
            double haromszogA = double.Parse(Console.ReadLine());
    Console.WriteLine("Add meg a háromszög b oldalát!");
            double haromszogB = double.Parse(Console.ReadLine());
    Console.WriteLine("Add meg a háromszög c oldalát!");
            double haromszogC = double.Parse(Console.ReadLine());
            if (haromszogA>haromszogB+haromszogC || haromszogB>haromszogA+haromszogC || haromszogC>haromszogA+haromszogB)
            {
        Console.WriteLine("Ez a háromszög nem szerkezthető meg!");
    }
            else
            {
        Console.WriteLine("Ez a háromszög megszerkezthető!");
    }
}
        static void feladat11()
        {
            Console.WriteLine("11.Feladat: Adj meg 2 számot aminek kiszámoljuk a mértani és a számtani közepét");
            
            
                Console.WriteLine("Szám 1\t");
                Double szam1 = double.Parse(Console.ReadLine());
                while (szam1 < 0)
                {
                    if (szam1 < 0)
                    {
                        Console.WriteLine("Add meg még egyszer az első számot mert kissebb volt 0 nál!");
                        szam1 = Double.Parse(Console.ReadLine());
                    }
                }
                
                Console.WriteLine("Szám 2\t");
              double szam2 = double.Parse(Console.ReadLine());
            while (szam2 < 0)
            {
                if (szam2 < 0)
                {
                    Console.WriteLine("Add meg még egyszer a második számot mert kissebb volt 0 nál!");
                    szam2 = Double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("A(z) {0} és a(z) {1} számnak a számtani közepe: {2}\t Mértani közepe:  {3}", szam1, szam2, (szam1+szam2)/2, Math.Sqrt(szam1*szam2));
            
        }
        static void feladat12and13()
        {

            Console.WriteLine("12 és 13.Feladat: Add meg a másodfoku egyenlet eggyütthatóit!");
            Console.WriteLine("Add meg az ismeretlen négyzetszámot (a) ami nem lehet 0");
            double x1, x2 = 0;
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg (b) ismeretlent");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a (c)-t");
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2)-4*a*c;            
            if (a==0 || D<0)
            {
                Console.WriteLine("Az egyenletnek nincsen megoldása!");
            }
            else
            {
                Console.WriteLine("ezekkel az eggyüt hatókkal megoldható a másodfokú egyenlet!");
                 x1 = (-b + Math.Sqrt(D)) / (2*a);
                 x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("{0} {1}", x1, x2);
            }
            
        }
        

    }
}
