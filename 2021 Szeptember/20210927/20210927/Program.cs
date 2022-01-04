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

          //  Feladat1();

            Feladat2();
              Feladat3();
            feladat4();
             feladat5();
            feladat6();
             feladat7();
            feladat8();
             feladat9();
             feladat10();
            feladat11();
            feladat12();
            feladat13();
            feladat14();
         feladat15();
           feladat16();
           feladat17();
            feladat18();
           feladat19();
            feladat20();

                
            Console.ReadKey();
        }
        static void Feladat1()
        {
            Console.WriteLine("1. Feladat");
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 21; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        static void Feladat2()
        {
            Console.WriteLine("2. Feladat");
            Console.WriteLine();
            for (int i = 15; i <= 92; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void Feladat3()
        {
            Console.WriteLine("3. Feladat");
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
            Console.WriteLine();
        }
        static void feladat4()
        {
            Console.WriteLine("4. Feladat");
            Console.WriteLine("Adj meg egy pozitiv egész számot");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                Console.Write(i+" ");
            }
        }
        static void feladat5()
        {
            Console.WriteLine();
            Console.WriteLine("5. Feladat");
            
            Console.WriteLine("Adj meg egy pozitiv egész számot");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void feladat6()
        {
            Console.WriteLine("6. Feladat");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Math.Pow(i, 2)); 
            }
        }
        static void feladat7()
        {
            Console.WriteLine("7. Feladat");
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
            Console.WriteLine();
            Console.WriteLine("8. Feladat");
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
            Console.WriteLine();
            Console.WriteLine("9. Feladat");
            for (int i = 150; i >= 40;)
            {
                Console.Write(i+" ");
                i = i - 12;
            }
        }
        static void feladat10()
        {
            Console.WriteLine();
            Console.WriteLine("10. Feladat");
            for (int i = 100; i > -100;)
            {
                if (i%9==0)
                {
                    Console.Write(i+" ");
                }
                i -= 1;
            }
            Console.WriteLine();
        }
        static void feladat11()
        {
            Console.WriteLine("11. Feladat");
            for (int i = -30; i <=30 ;)
            {
                Console.WriteLine(i);
                i += 5;
            }
        }
        static void feladat12()
        {
            Console.WriteLine("12. Feladat");
            for (int i = 1; i <= 17; i++)
            {
                Console.WriteLine(i*3);
            }
        }
        static void feladat13()
        {
            Console.WriteLine("13. Feladat");
            for (int i = 1; i <=16; i++)
            {
                Console.WriteLine(Math.Pow(2, i)); 
            }
        }
        static void feladat14()
        {
            Console.WriteLine("14. Feladat");
            int szam = 0;
            for (int i = 0; i < 26; i++)
            {
                szam = i * 7;
                if (szam%4==0)
                {
                    Console.WriteLine(szam);
                }
            }
        }
        static void feladat15()
        {
            Console.WriteLine("15. Feladat");
            int szam = 144;
            int oszto = 1;
            bool igaz = true;
            while (igaz)
            {
                if (szam%oszto==0)
                {
                    Console.WriteLine(oszto);
                }
                else if (oszto>szam+1)
                {
                    igaz = false;
                }
                oszto += 1;
            }
        }
        static void feladat16()
        {
            Console.WriteLine("16. Feladat");
            Console.WriteLine("Adj megy egy számot");
            int szam = int.Parse(Console.ReadLine());
            int oszto = 1;
            bool igaz = true;
            while (igaz)
            {
                if (szam % oszto == 0)
                {
                    Console.WriteLine(oszto);
                }
                else if (oszto > szam + 1)
                {
                    igaz = false;
                }
                oszto += 1;
            }
        }
        static void feladat17()
        {
            Console.WriteLine("17. Feladat");
            Console.WriteLine("Adj megy egy számot");
            int szam = int.Parse(Console.ReadLine());
            int oszto = 1;
            List<int> ossz = new List<int>();
            bool igaz = true;
            while (igaz)
            {
                if (szam % oszto == 0)
                {
                    ossz.Add(oszto);
                }
                else if (oszto > szam + 1)
                {
                    igaz = false;
                }
                oszto += 1;
            }
            Console.WriteLine(ossz.Sum());
        }
        static void feladat18()
        {
            Console.WriteLine("18. Feladat");
            int egyes = 0;
            int tizdes = 0;
            List<string> szam = new List<string>();
            for (int i = 0; i < 101; i++)
            {               
                if (egyes+tizdes==10)
                {
                    szam.Add(tizdes+""+egyes);
                }
                if (egyes==9)
                {
                    tizdes++;
                    egyes = 0;
                }
                egyes++;
            }
            for (int i = 0; i < szam.Count; i++)
            {
                Console.WriteLine(szam[i]);
            }
        }
        static void feladat19()
        {
            Console.WriteLine("19. Feladat");
            int szam1 = 1;
            int szam2 = -17;
            bool igaz = true;
            do
            {
                Console.WriteLine(szam1+" "+szam2);
                szam1++;
                szam2++;
                if (szam1>17 || szam2>17)
                {
                    igaz = false;
                }
            } while (igaz);
        }
        static void feladat20()
        {
            Console.WriteLine("20. Feladat");
            List<int> szamok = new List<int>();
            int szam = 1;
            while (szamok.Count<10)
            {
                szamok.Add(szam * 8);
                szam++;
            }
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write(szamok[i]+" ");
            }
        }
    }
}
