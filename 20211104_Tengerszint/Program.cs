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
            var sr = new StreamReader("tengerszint.txt", Encoding.GetEncoding("ISO8859-1"));
            var lista = new List<Magasság>();

            while (!sr.EndOfStream)
            {
                lista.Add(new Magasság(sr.ReadLine()));
            }
            Console.WriteLine($"2. Feladat: {lista.Count} darab sor van megadva ");
            var felett5k = (from sor in lista where sor.magas > 5000   select sor).Count();
            Console.WriteLine($"3. Feladat:5000 felett ennyi van: {felett5k}");
            var svedmax = (
                from sor in lista
                where sor.orszag.Contains("Svédország")                
                select sor.magas).Max();
            Console.WriteLine($"4. Feladat: Svédország legmasabb pontja:{svedmax}");
            var maxo = (
                from sor in lista
                orderby sor.magas
                select sor.magas).Max();

            var max2 = (
                from sor in lista
                where sor.magas == maxo
                select sor.orszag).ToList();
            foreach (var item in max2)
            {
                Console.WriteLine($"5. Feladat: A legmagasabb hegy {item}-ban/ben talalhato");
            }
            /* var mb = (
                 from sor in lista
                 where sor.hegy == "Mont Blanc"
                 select sor.magas).Max();
             Console.WriteLine($"6. Feladat: Mont Blanc {mb} m magas");
             var tengf = (
                 from sor in lista
                 where sor.magas<1000
                 select sor
                         ).ToList();
                Console.WriteLine($"7. Feladat: {tengf} Ország nem éri el az 1000m-t");*/
            var k3 = (
                 from sor in lista
                 where sor.magas == 3000
                 select sor.orszag).Single();//erdekes
             if (k3.Any()) 
             {
                 Console.WriteLine($"8. Feladat: van 3000m legmagasabb orszag megpedig {k3}");
            }
            else
            {
                Console.WriteLine("nincs ilyen orszag");
            }
            var kancs = (
               from sor in lista
               where sor.hegy == "Kancsendzönga"
               orderby sor.magas
               select sor.orszag).Single();
            Console.WriteLine($"9. Feladat: {kancs} legmagasabb pontya Kancsendzönga");
            var vic = (
                from sor in lista
                where sor.hegy == "Victoria-csúcs"
                select sor.magas).Max();
            Console.WriteLine(vic);
            var nevt = (
                from sor in lista
                where sor.hegy == "névtelen hely"
                select sor).Count();
            Console.WriteLine(nevt);
            var k7 = (
                from sor in lista
                where sor.magas > 7500
                select sor).ToList();
            var sw = new StreamWriter("magasok.txt");
            foreach (var item in k7)
            {               
                sw.WriteLine($"{item.orszag};{item.hegy};{item.magas}");
                Console.WriteLine(item.orszag);
            }
            sw.Close();
            Console.ReadKey();
        }
    }
}
