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
            feladat14();
            feladat15();
            feladat16();
            feladat17();
            feladat18();

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
        static void feladat14()
        {            
            Console.WriteLine("14. Feladat!     Add meg a háromszög 2 befogólyát.");
            bool neg =true;
            double a = 0;
            double b = 0;
            do
            {               
                Console.WriteLine("Add meg az 'a' befogót!");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Add meg az 'b' befogót!");
                b = double.Parse(Console.ReadLine());
               
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("A számok nem lehetnek kissebbek vagy egyenlok 0 val");
                }
                else
                {
                    neg =false;
                    Console.WriteLine("A c átfoggó értéke {0:.00}", Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
                }
            } while (neg);
            
            
        }
        static void feladat15()
        {
            Console.WriteLine("15. Feladat: Kocka élének hosszából Felszin és térfogat");
            Console.WriteLine("Add meg a Kocka élének hosszát");
            double a = double.Parse(Console.ReadLine());
            double F = 6 * Math.Pow(a, 2);
            double V = Math.Pow(a, 3);
            Console.WriteLine("A kocka felszine:\t{0}\nA kocka térfogata:\t{1}", F, V);

        }
        static void feladat16()
        {
            Console.WriteLine("16. Feladat: Téglatest élének hosszaiból Felszin és térfogat");
            Console.WriteLine("Add meg az 'a' élének hosszát");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az 'b' élének hosszát");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az 'c' élének hosszát");
            double c = double.Parse(Console.ReadLine());
            double F = 2 * (a * b + a * c + b * c);
            double V = a * b * c;
            if (a>0 && b>0 && c>0)
            {
                Console.WriteLine("A Téglatest felszine:\t{0}\nA kocka térfogata:\t{1}", F, V);
            }
            else
            {
                Console.WriteLine("Nem tartalmazhat negativ szamot!");
            }
            

        }
        static void feladat17()
        {
            Console.WriteLine("17. Feladat: Kör területe és kerülete!");
            Console.WriteLine("Add meg a köt átmérőjét!");
            double r = double.Parse(Console.ReadLine())/2;
            double K = 2 * r * Math.PI;
            double T = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("A kör területe:\t{0}\nA kör területe\t{1}", T, K);
        }
        static void feladat18()
        {
            Console.WriteLine("Fokban vagy radiában");

            Console.WriteLine("A kör sugara");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("A középponti szög fokban");
            double fok = double.Parse(Console.ReadLine());

            double radian = fok * Math.PI / 180;

            double i = r * radian;//körív hossza
            double T = (r * i) / 2;//területe
            Console.WriteLine("18. Feladat:\nA köriv hossza:{0}\nA határoló iv területe {1}", r, T);
        }
    }
}
