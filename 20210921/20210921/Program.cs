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
           /* feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();*/
            feladat6();
            Console.ReadKey();
        }
        static void feladat1()
        {
            Console.WriteLine("Adj meg egy számot");
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
            Console.WriteLine("Adj meg egy számot");
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
            Console.WriteLine("Adj meg egy hőmérsékletet.");
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
            Console.WriteLine("Adj meg egy számot");
            double szam = double.Parse(Console.ReadLine());
            if (szam>=-30 || szam<=40)
            {
                Console.WriteLine("A szám -30 és 40 között van!");
            }
        }
        static void feladat5()
        {
            Console.WriteLine("Adj meg egy számot");
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
                Console.WriteLine(" Adj meg egy számot");
                
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
    }
}
