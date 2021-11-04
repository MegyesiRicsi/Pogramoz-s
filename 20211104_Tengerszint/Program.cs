using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211104_Tengerszint
{
    class Magasság
    {
        public string orszag, hegy;
        public int magas;
        public Magasság(string sor)
            {
            var db= sor.Trim().Split('\t');
            orszag = db[0];
            hegy = db[1];
            magas = int.Parse(db[2]);
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("tengerszint.txt");
            var lista = new List<Magasság>();

            while (!sr.EndOfStream)
            {
                lista.Add(new Magasság(sr.ReadLine()));
            }
            Console.WriteLine($"2. Feladat: {lista.Count} darab sor van megadva ");
            var felett5k = (from sor in lista
                            where sor.magas > 5000
                            select sor).Count();
            Console.WriteLine($"3. Feladat:5000 felett ennyi van: {felett5k}");
            var svedmax = (
                from sor in lista
                where sor.orszag.Contains("Svédország")
                orderby sor.magas
                select sor.magas).First();
            Console.WriteLine($"4. Feladat: Svédország legmasabb pontja:{svedmax}");


            Console.ReadKey();
        }
    }
}
