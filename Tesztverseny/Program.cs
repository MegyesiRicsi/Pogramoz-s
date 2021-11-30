using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tesztverseny
{
    class Valasz {
        public string nev, valaszok;
        public int pontszam;
        public Valasz(string sor)
            {
            var s = sor.Split(' ');
            nev = s[0];
            valaszok = s[1];
            pontszam = 0;
            }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var sr = new StreamReader("valaszok.txt");
            var lista = new List<Valasz>();
            var helyes = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Valasz(sr.ReadLine()));
            }
            Console.WriteLine($"1. feladat: Az adatok beolvasása");
            Console.WriteLine($"2. feladat: A vetélkedőn {lista.Count()} versenyző indult.");
            Console.Write($"3. feladat: A versenztő azonosítója = ");
            string harmadik = Console.ReadLine().ToUpper();
            var adott = (
                        from sor in lista
                        where sor.nev == harmadik
                        select sor).First();
            Console.WriteLine($"{adott.valaszok} (a versenyző válasza)");
            Console.WriteLine($"4. feladat: \n{helyes}  (a helyes megoldás)");
            for (int i = 0; i <helyes.Length; i++)
            {
                if (adott.valaszok[i] == helyes[i])
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("\t(a versenyző helyes válaszai)");
            Console.Write($"5. feladat: A feladat sorszáma = ");
            int szam =int.Parse( Console.ReadLine())-1;
            var fo = (
            from sor in lista
            where helyes[szam] == sor.valaszok[szam]
                select sor).ToList();
            double avg =(double)fo.Count/(double)lista.Count*100 ;
            Console.WriteLine($"A feladatra {fo.Count()} fő, a versenyzők {avg:0.00}%-a adott helyes választ.");
            int psz = 0;
            for (int i = 0; i < lista.Count(); i++)
            {
                psz = 0;
                for (int j = 0; j < helyes.Length; j++)
                {
                    if (helyes[j].ToString()==lista[i].valaszok)
                    {
                        switch (j)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                psz = psz + 3;
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                            case 10:
                            case 11:
                            case 12:
                            case 13:
                        

                            default:
                                break;
                        }
                    }
                }
            }


            /*   foreach (var item in fo)
            {
                Console.WriteLine(item.valaszok[szam]+" "+helyes[szam]);
            }*/




            Console.ReadKey();
        }
    }
}
