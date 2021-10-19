using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211019_dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat1();
            feladat2();
           feladat3();
            Feladat4();
            feladat5();
            Console.ReadKey();
        }
        static void feladat1()
        {
            try
            {
                
                Console.WriteLine("Add meg az (a) élének hosszát");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Add meg az (b) élének hosszát");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Add meg az (c) élének hosszát");
                double c = double.Parse(Console.ReadLine());
                if (a<1 || b<1 || c<1)
                {
                    Console.WriteLine("\n Hibás bemeneti adatok/adatok");
                }
                else
                {
                    double A = 2 * a * b + 2 * a * c + 2 * b * c;//Felszin
                    double v = a * b * c;//Térfogat
                    Console.Clear();
                    Console.WriteLine($"A Téglatest felszine: {A} \nA téglatest Térfogata: {v}");
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("\n Hibás bemeneti adatok/adatok");
                
            }
           
        }
        static void feladat2()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Adj meg 1 számot 1-7 ig");                
                int nap = int.Parse(Console.ReadLine());
                if (nap > 0 && nap < 8)
                {
                    if (nap == 1)
                    {
                        Console.WriteLine($"Az {nap} nap a héten az a hétfő");
                    }
                    else if (nap == 2)
                    {
                        Console.WriteLine($"Az {nap} nap a héten az a Kedd");
                    }
                    else if (nap == 3)
                    {
                        Console.WriteLine($"Az {nap} nap a héten az a szerda");
                    }
                    else if (nap == 4)
                    {
                        Console.WriteLine($"Az {nap} nap a héten az a csütörtök");
                    }
                    else if (nap == 5)
                    {
                        Console.WriteLine($"Az {nap} nap a héten az a Péntek");
                    }
                    else if (nap == 6)
                    {
                        Console.WriteLine($"Az {nap} nap a héten az a Szombat");
                    }
                    else if (nap == 7)
                    {
                        Console.WriteLine($"Az {nap} nap a héten az a Vasárnap");
                    }
                }
                else
                {
                    Console.WriteLine("Túl nagy vagy kicsi a megadott szám!");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Hibás bemeneti adat");
            }
           
            
        }
        static void feladat3()
        {
            try
            {
                Console.WriteLine("Adj meg 1 számot!");
                int szam = int.Parse(Console.ReadLine());
                if (szam > -50 && szam < 70)
                {
                    Console.WriteLine($"A(z) {szam} -50 és 70 között van!");
                }
                else
                {

                    Console.WriteLine($"A(z) {szam} nincs -50 és 70 között!");
                    
                }

            }
            catch (FormatException)
            {

                Console.WriteLine("Hibás bemeneti adat");
            }
            
           
        }
        static void Feladat4()
        {
            Console.WriteLine("Számok 120 tól 40 ig tizenötösével.");
            for (int i = 120; i >= 40; i-=15)
            {
                Console.WriteLine(i);
            }
        }
        static void feladat5()
        {
            List<int> szamok = new List<int>();
            var szam = 0;
            while (szamok.Count!=40)
            {
                if (szam%7==0)
                {
                    szamok.Add(szam);
                }
                szam++;
            }
            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }

        }
    }
}
