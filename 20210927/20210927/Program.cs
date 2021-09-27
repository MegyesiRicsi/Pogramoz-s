using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {
        static void Main(string[] args)
        {

           // Feladat1();
         //   Feladat2();
          //  Feladat3();
           // feladat4();
           // feladat5();
           // feladat6();
           // feladat7();
          // feladat8();
          // feladat9();
           feladat10();
                
            Console.ReadKey();
        }
        static void Feladat1()
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 21; i++)
            {
                Console.Write(i);
            }
        }
        static void Feladat2()
        {
            for (int i = 15; i <= 92; i++)
            {
                Console.Write(i+" ");
            }
        }
        static void Feladat3()
        {

            for (int i = 1; i <= 30;i++)
            {
                if (i%2==0)
                {
                    Console.Write(i+" ");
                    

                }
                

            }
            Console.WriteLine();
            for (int i = 1; i <= 30;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }

        }
        static void feladat4()
        {
            Console.WriteLine("Adj meg egy pozitiv egész számot");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                Console.Write(i+" ");
            }
        }
        static void feladat5()
        {
            Console.WriteLine("Adj meg egy pozitiv egész számot");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void feladat6()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Math.Pow(i, 2)); 
            }
        }
        static void feladat7()
        {
            for (int i = 100; i <= 400; i++)
            {
                if (i%4==0)
                {
                    Console.Write(i+" ");
                }
            }
        }
        static void feladat8()
        {
            for (int i = 30; i <= 100;i++ )
            {
                if (i%9==0)
                {
                    Console.Write(i + " ");

                }
                
                
            }
        }
        static void feladat9()
        {
            for (int i = 150; i >= 40;)
            {
                Console.Write(i+" ");
                i = i - 12;
            }
        }
        static void feladat10()
        {
            for (int i = 100; i > -100;)
            {
                if (i%9==0)
                {
                    Console.Write(i+" ");
                }
                i -= 1;
            }
        }
    }
}
