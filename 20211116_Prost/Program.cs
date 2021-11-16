using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211116_Prost
{
    class Pros {
        public string date, nev;
        public int helyezes, pont;
        public Pros(string sor)
            {
            var s=sor.Split('\t');
            date = s[0];
            nev = s[1];
            helyezes = int.Parse(s[2]);
            pont = int.Parse(s[3]);
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("Prost.csv", Encoding.UTF8);
            var lista = new List<Pros>();
            var elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Pros(sr.ReadLine()));
            }
            var bef = (from sor in lista
                       where sor.helyezes != -1
                       select sor).Count();

            Console.WriteLine($"3. feladat: {bef}/{lista.Count()}");

            var elso = (from sor in lista
                        where sor.date.Contains("1988") && sor.helyezes == 1
                        select sor);
            Console.WriteLine("4. feladat:");

            foreach (var item in elso)
            {
                Console.WriteLine($"\t{item.nev}");
            }
            Console.WriteLine("5. feladat:");

            var san_marino = (from sor in lista
                              orderby sor.pont
                              where sor.nev == "San Marino Grand Prix"
                              select sor).Last();

            Console.WriteLine($"\t{san_marino.date}");
            Console.WriteLine($"\t{san_marino.helyezes}. helyezés");
            Console.WriteLine($"\t{ san_marino.pont} pont");
            
            Console.ReadKey();
        }
    }
}
