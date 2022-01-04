using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211102_Orvosi_nobeldij_home
{
    class Elethossz
    {
        private int Tol { get; set; }
        private int Ig { get; set; }
        public int ElethosszEvekben => Tol == -1 || Ig == -1 ? -1 : Ig - Tol;

        public bool IsmertAzElethossz => ElethosszEvekben != -1;

        public Elethossz(string SzuletesHalalozas)
        {
            string[] m = SzuletesHalalozas.Split('-');
            try
            {
                Tol = int.Parse(m[0]);
            }
            catch (Exception)
            {
                Tol = -1;
            }
            try
            {
                Ig = int.Parse(m[1]);
            }
            catch (Exception)
            {
                Ig = -1;
            }
        }
    }
    class Nobel
    {
        public int ev;
        public string nev;
        public string sz_h;
        public string kod;
       // public int elethossz_evekben;
       // public bool ismert;
        public Nobel(string sor)
        {
            var s = sor.Split(';');
            ev =int.Parse( s[0]);
            nev = s[1];
            sz_h = s[2];
            kod = s[3];
          //  elethossz_evekben = new Elethossz(sz_h).ElethosszEvekben;
         //   ismert = new Elethossz(sz_h).IsmertAzElethossz;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("orvosi_nobeldijak.txt");
            var elsosor = sr.ReadLine();
            var lista = new List<Nobel>();
            while (!sr.EndOfStream)
            {
                lista.Add(new Nobel(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine($"3. Feladat: Dijazottak szama: {lista.Count} fo");

            var utolsoev = ( 
                from sor in lista                  
                select sor.ev).Max();
            Console.WriteLine($"4. feladat: utolso ev: {utolsoev}");

            Console.Write(            $"5. feladat: Kerem adja meg egy orszag kodjat: ");
            var kod = Console.ReadLine();
            var dijazottak = (
                from sor in lista
                where sor.kod == kod
                select sor);
            switch (dijazottak.Count())
            {
                case 0:
                    Console.WriteLine($"A megadott országból nem volt díjazott!");
                    break;
                case 1:
                    Console.WriteLine($"        A megadott orszag dijazottja:");
                    Console.WriteLine($"        Nev: {dijazottak.First().nev}");
                    Console.WriteLine($"        Ev: {dijazottak.First().ev}");
                    Console.WriteLine($"        Sz/h: {dijazottak.First().sz_h}");
                    break;                 
                default:
                    Console.WriteLine($"        A megadott országból {dijazottak.Count()} fő díjazott volt!");
                    break;
            }

            var stat = (
                from sor in lista
                group sor by sor.kod
                into res
                where res.Count() > 5
                select res);
            Console.WriteLine(    $"6. Statisztika");
            foreach (var item in stat)
            {
                Console.WriteLine($"        {item.Key} : {item.Count()} fo");
            }

           var atlag = (
                from sor in lista
                where new Elethossz(sor.sz_h).IsmertAzElethossz
                select new Elethossz(sor.sz_h).ElethosszEvekben).Average();
            Console.WriteLine($"7. Feladat: A keresett atlag: {atlag:.#} ev");
            Console.ReadKey();
        }
    }
}
