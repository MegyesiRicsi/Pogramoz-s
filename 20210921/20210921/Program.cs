using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210921
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
           
            Console.ReadKey();
        }
        static void feladat1()
        {
            Console.WriteLine("1.Feladat:\tAdj meg egy számot és eldöntjük hogy páros vagy páratlan!");
            double szam = double.Parse(Console.ReadLine());
            if (szam%2==0)
            {
                Console.WriteLine("A megadott szám páros\t{0} ",szam);
            }
            else
            {
                Console.WriteLine("A megadott szám páratlan\t{0} ", szam);
            }
        }
        static void feladat2()
        {
            Console.WriteLine("2.Feladat:\tAdj meg egy számot és eldöntjük az előjelét");
            double szam = double.Parse(Console.ReadLine());
            if (szam>=0)
            {
                Console.WriteLine("A megadott szám pozitiv");
            }
            else
            {
                Console.WriteLine("A megadott szám negativ.");
            }
        }
        static void feladat3()
        {
            Console.WriteLine("3.Feladat:\tAdj meg egy hőmérsékletet.");
            double szam = double.Parse(Console.ReadLine());
            if (szam<=0)
            {
                Console.WriteLine("Fagy van kint!");
            }
            else
            {
                Console.WriteLine("Nincsen kint fagy!");
            }
        }
        static void feladat4()
        {
            //hibás
            Console.WriteLine("4.Feladat:\tAdj meg egy számot és eldöntjük hogy -30 és 40 között van e");
            double szam = double.Parse(Console.ReadLine());
            if (szam>=-30 || szam<=40)
            {
                Console.WriteLine("A szám -30 és 40 között van!");
            }
        }
        static void feladat5()
        {
            Console.WriteLine("5.Feladat:\tAdj meg egy számot");
            double szam = double.Parse(Console.ReadLine());
            double ujszam = 0;
            if (szam<16)
            {
                ujszam = szam * 10;
                Console.WriteLine("A szám 16 nál kissebb igy megszoroztuk 10-el:\t{0}", ujszam);
            }
            else if(szam>=16)
            {
                ujszam = szam / 3;
                Console.WriteLine("A szám 16 nál nagyobb igy elosztottuk 3-al:\t{0}", ujszam);
            }

        }
        static void feladat6()
        {
            Console.WriteLine("Feladat6");
            int szam = 0;
            while (szam==0)
            {
                Console.WriteLine(" Adj meg egy számot és eldöntjük 10 eseke szerint hova tartozik");
                
                szam = int.Parse(Console.ReadLine());
                int maradek = 0;
                if (szam>10 || szam<40)
                {
                    maradek = szam / 10;
                    Console.WriteLine("A megadott számnak a tizedes jegyénél {0} áll", maradek);
                }
                else
                {
                    szam = 0;
                }
                
            }
        }
        static void feladat7()
        {
            Console.WriteLine("7.Feladat:\tAdj meg egy számot eldöntjük hogy 25>12> és páros-e");
            double szam = double.Parse(Console.ReadLine());
            if (szam>12 && szam<25 && szam%2==0)
            {
                Console.WriteLine("Ez a szám páros és 25>12> A megadott szám {0}", szam);
            }
            else
            {
                Console.WriteLine("A szám nem felel meg a feltételeknek");
            }
        }
        static void feladat8()
        {
            Console.WriteLine("8.Feladat:\tAdj meg egy számot és megnézzük milyen halmazállapotú a víz!");
            double szam = double.Parse(Console.ReadLine());
            if (szam>0 && szam<100)
            {
                Console.WriteLine("A viz folyékony halmazállapotu");
            }
            else if (szam>100)
            {
                Console.WriteLine("A viz gáz halmazállapotu");
            }
            else
            {
                Console.WriteLine("A viz szilárd halmazállapotu");
            }
        }
        static void feladat9()
        {
            Console.WriteLine("9.Feladat:\tAdj meg egy számot és eldöntjük hogy osztható e 9-4-3 al.");
            double szam = double.Parse(Console.ReadLine());
            if (szam%9==0)
            {
                Console.WriteLine("A szám 9 al osztható!");
            }
            else if (szam%4==0)
            {
                Console.WriteLine("A szám 4 al osztható!");
            }
            else if (szam%3==0)
            {
                Console.WriteLine("A szám 3 al osztható!");
            }
            else if (szam%3==0 && szam%9==0)
            {
                Console.WriteLine("A zám osztható 9 el és 3 al is.");
            }
            else
            {
                Console.WriteLine("A szám nem osztható 3,4 se 9 el");
            }
        }
        static void feladat10()
        {
            Console.WriteLine("10.Feladat:");
            int szam = 0;
            while (szam<=0)
            {
                Console.WriteLine("Adj meg egy évszámot és eldöntjük hogy szökő év e!");
                szam = int.Parse(Console.ReadLine());
                if (szam%4==0)
                {
                    Console.WriteLine("Ez az év szökőév");
                }
                else
                {
                    Console.WriteLine("Ez az évn em szökőév");
                }
            }
        }
        
    }
}
