using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022._01._17_Nobel
{
    class Nobel
    {
        
        public string tipus, kereszt, vezetek;
        public int ev;
        public Nobel(string sor)
        {
            var s = sor.Split(';');
            ev = Convert.ToInt32(s[0]);
            tipus = s[1];
            kereszt = s[2];
            vezetek = s[3];
        }
           
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Nobel>();
            var sr = new StreamReader("nobel.csv");
            var elso = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Nobel(sr.ReadLine()));
            }
            var McDonald = (
                from sor in lista
                where sor.vezetek == ("McDonald")
                where sor.kereszt == ("Arthur B.")
                select sor);
            Console.WriteLine(McDonald.First().tipus);
            var irdoalmi = (
                 from sor in lista
                 where sor.ev == 2017
                 where sor.tipus == "irodalmi"
                 select sor);
            //4. Feladat
            foreach (var item in irdoalmi)
            {
                Console.WriteLine(item.kereszt+" "+ item.vezetek);
            }
            //5. Feladat
            
            var nobel = (
                from sor in lista
                where sor.ev >= 1990
                where sor.tipus=="béke"
                where sor.vezetek==""
                select sor);
            foreach (var item in nobel)
            {
                Console.WriteLine(item.ev+": "+item.kereszt);
            }
            //6. Feladat
            var curie = (
                from sor in lista
                where sor.vezetek.Contains("Curie")
                select sor);
            Console.WriteLine();
            foreach (var item in curie)
            {
                Console.WriteLine(item.ev+" "+item.kereszt+" "+item.vezetek+"("+item.tipus+")");
            }
            //7. Feladat
            var stat = (
                from sor in lista
                group sor by sor.tipus
                );
            foreach (var item in stat)
            {
                Console.WriteLine("\t" +item.Key+"    "+item.Count());
            }
            Console.ReadKey();
        }
    }
}
