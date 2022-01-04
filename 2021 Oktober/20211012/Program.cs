using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211012
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
           // feladat31();
            // feladat48();
            //feladat49();
            // feladat39();
            //   feladat40();
            //  feladat41();
            feladat42();
            feladat43();
            Console.ReadKey();
        }
        static void feladat31()
        {
            Console.WriteLine("Adj meg 1 számot aminek vesszük a faktoriálisát");
            int szam = int.Parse(Console.ReadLine());
            int ertek = 1;
            for (int i = 1; i <=szam; i++)
            {
                ertek = ertek * i;
            }
            Console.WriteLine(ertek);
        }
        static void feladat48()
        {
            int gen = rnd.Next(10, 51);
            Console.Write(gen+" ");
            while (gen!=25)
            {
                gen = rnd.Next(10, 51);
                Console.Write(gen + " ");

            }
            Console.WriteLine();
            do
            {
                gen = rnd.Next(10, 51);
                Console.Write(gen + " ");
            } while (gen!=25);
            Console.WriteLine();
        }
        static void feladat49()
        {
            string szo = "Keresztül-kasul";
            for (int i = 1; i < 6; i++)
            {
                Console.Write(szo[rnd.Next(0,szo.Length)]);
            }
            Console.WriteLine();
        }
        static void feladat39()
        {
            Console.WriteLine("Kérek egy egésu számot! a=");
            int a = int.Parse(Console.ReadLine());
            List<int> szam = new List<int>();
            Console.Write(a+"=");
            while (a%2==0)
            {
                szam.Add(2);
                a = a / 2;
            }
            szam.Add(a);
            foreach (var item in szam)
            {
                if (item==szam.Last())
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(item+"*" );
                }
               
            }
        }
        static void feladat40()
        {
            Console.WriteLine("Kérekegy egész számot");
            int eredeti = int.Parse(Console.ReadLine());
            int valtozik = eredeti;
            while (valtozik>=3)
            {
                Console.Write(valtozik+" ");
                valtozik -= 3;
               
            }
            Console.WriteLine(valtozik);
            Console.WriteLine($"{eredeti}={eredeti/3}*3+{valtozik}");
        }
        static void feladat41()
        {
           int szam=rnd.Next(1,101);
            for (int i = 0; i < 10; i++)
            {
                szam = rnd.Next(1, 101);
                Console.WriteLine(szam);
            }
        }
        static void feladat42()
        {
            
            for (int i = 0; i < 20; i++)
            {
              int  szam = rnd.Next(0, 21);
                Console.Write(szam+",");
            }
        }
        static void feladat43()
        {
            for (int i = 0; i < 15; i++)
            {
                int szam = rnd.Next(25, 51);
                Console.Write(szam + ",");
            }
        }
        static void feladat44()
        {
            int szam1 = rnd.Next(10, 51);
            int szam2 = rnd.Next(10, 51);
            Console.WriteLine("A 2 szám szorzata: "+szam1*szam2);

        }
    }
}
