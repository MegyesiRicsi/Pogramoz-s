using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {


            //   feladat1();
            //     feladat2();
            //   feladat3();
            // feladat4();
            //    feladat5();

            feladat6();
         //   feladat7();
         //  feladat8();
         //   feladat9();
          //  feladat10();
            Console.ReadKey();

        }
        static void feladat1()
        {
            Console.WriteLine("Feladat 21");
            int sorsz = 1;
            while (5>=sorsz)
            {
                int db = 1;
                int szorzat = 1;
                while (db!=16)
                {
                    Console.Write(szorzat*sorsz+" ");
                    szorzat++;
                    db++;
                }
                Console.WriteLine();
                sorsz++;
            }
        }
        static void feladat2()
        {
            Console.WriteLine("Feladat 22");
            int a = 2;//+1
            int b = 3;//+2
            int c = 5;//+3
            int terfogat = 0;
            for (int i = 0; i < 6; i++)
            {
                terfogat = a * b * c;
                Console.WriteLine("Oldalainak nagysága: a={0} b={1} c={2}", a,b,c);
                Console.WriteLine("Térfogata:"+terfogat);
                a++;
                b += 2;
                c += 3;
            }

        }
        static void feladat3()
        {
            Console.WriteLine("Feladat 23");
            int a = 5;
            for (int i = 0; i <=10 ; i++)
            {
                Console.WriteLine("A kocka felszine {0} élhosszal: {1}", a, a*a*6);
                a += 2;
            }
        }
        static void feladat4()
        {
            Console.WriteLine("Feladat 24");
            Console.WriteLine("Adj meg 0 számot");
            int szam = int.Parse(Console.ReadLine());
           
            while (szam!=0)
            {
                Console.WriteLine("A megadott szám nem egyenlő 0 val");
                szam = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A szám egyenlő 0 val");
        }
        static void feladat5()
        {
            Console.WriteLine("Feladat 25");            
            Console.WriteLine("Adj meg egy pozitiv számot");
            int szam = int.Parse(Console.ReadLine());

            while (szam < 0)
            {
                Console.WriteLine("A megadott szám nem nagyobb 0 nál");
                szam = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A szám nagyobb 0 nál");

        }
        static void feladat6()
        {//hiba
            Console.WriteLine("Feladat 26");
            List<double> szamok = new List<double>();

            bool igaz = true;
            while (igaz)
            {
                Console.WriteLine("Adj meg 1 számot ami nagyobb mint 10");
                int szam = int.Parse(Console.ReadLine());
                if (szam <= 10)
                {
                    Console.WriteLine("A számok összege" + szamok.Sum());
                    igaz = false;
                   

                }
                else if( szam>10)
                {
                    szamok.Add(szam);
                   
                }
                
            }
        }
        static void feladat7()
        {
            Console.WriteLine("Feladat 27");
            Console.WriteLine("Ird be hogy alma");
            string alma = Console.ReadLine();
            while (alma!="alma")
            {
                Console.WriteLine("Ird be hogy alma");
                alma = Console.ReadLine();
            }
            Console.WriteLine("Az "+alma+" gyümölcs!");
        }
        static void feladat8()
        {
            Console.WriteLine("Feladat8");
            int szam = 1;
            int ossz = 0;
            for (int i = 0; i < 30; i++)
            {
               
                ossz = ossz + szam;
                szam++;
            }
            Console.WriteLine("Az első 30 szám összege "+ossz);
        }
        static void feladat9()
        {
            Console.WriteLine("Feladat9");
            Console.WriteLine("Add meg meddig adjuk össze a számokat");
            int szam = int.Parse(Console.ReadLine());
            int ossz = 0;
            for (int i = 1; i <= szam; i++)
            {
                
                ossz = ossz + i;
                
            }
            Console.WriteLine("Az első "+szam+"szám összege " + ossz);
        }
        static void feladat10()
        {
            Console.WriteLine("Feladat 30");
            Console.WriteLine("Add meg hogy mennyi számot akarsz beolvasni");
            int szam = int.Parse(Console.ReadLine());
            int ossz = 0;
            int number = 0;
            for (int i = 1; i <= szam; i++)
            {
                Console.WriteLine("Add meg az "+i+"-dik számot");
                number = int.Parse(Console.ReadLine());
                ossz = ossz +number;

            }
            Console.WriteLine("Az első " + szam + "szám összege " + ossz);
        }
    }
}
