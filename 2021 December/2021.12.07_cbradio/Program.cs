using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2021._12._07_cbradio
{
    class Adatok
    {
        public int ora, perc, adas,AtszamolPercre;
        public string nev;
        public Adatok(string sor)
            {
            var s = sor.Split(';');
            ora =int.Parse( s[0]);
            perc = int.Parse(s[1]);
            adas = int.Parse(s[2]);
            nev = s[3];
            AtszamolPercre = ora * 60 + perc;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("cb.txt");
            var lista = new List<Adatok>();
            var elso = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Adatok(sr.ReadLine()));
            }
            Console.WriteLine($"3. feladat: Bjegyzések száma: {lista.Count()} db");
           
         
           
            bool yes = false;
            foreach (var item in lista)
            {
                if (item.adas>=4)
                {
                    yes = true;
                }
            }
            if (yes)
            {
                Console.WriteLine("4. Feladat: volt ilyen adást inditó sofőr;");
            }
            else
            {
                Console.WriteLine("nem volt");
            }
            Console.Write("5. feladat: kérek egy nevet: ");
            string ember = Console.ReadLine();
            
            var otodik = (
                from sor in lista
                where sor.nev == ember
                select sor.adas).Sum();
            if (otodik==0)
            {
                Console.WriteLine("Nincs ilyen nevü sofőr");
            }
            else
            {
                Console.WriteLine($"\t{ember} {otodik}x használta a CB-rádiot.");
            }
           

            var sw = new StreamWriter("cb2.txt");
            for (int i = 0; i < lista.Count(); i++)
            {
                sw.WriteLine(lista[i].AtszamolPercre+";"+lista[i].nev+";"+lista[i].adas);
            }
            sw.Close();
            var db = (
                from sor in lista
                group sor by sor.nev).Count();
            Console.WriteLine($"8. feladat: Sofőrök száma: {db} fő");
            Console.WriteLine("9. feladat: Legtöbb adást inditó sofőr");
            var nevek = new List<string>();
            var szamok = new List<int>();
            foreach (var item in lista)
            {
                if (nevek.Contains(item.nev)) 
                {
                    szamok[nevek.IndexOf(item.nev)] = szamok[nevek.IndexOf(item.nev)] + item.adas;
                }
                else
                {
                    nevek.Add(item.nev);
                    szamok.Add(item.adas);
                }
            }
          /*  for (int i = 0; i < nevek.Count(); i++)
            {
                Console.WriteLine($"{nevek[i]} {szamok[i]}");
            }*/
            Console.WriteLine($"\t{nevek[szamok.IndexOf(szamok.Max())]}");
            Console.WriteLine($"\t{szamok[szamok.IndexOf(szamok.Max())]}");

            Console.ReadKey();
        }
    }
}
