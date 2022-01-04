using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211102_Nobel
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
        public int eletkor;
        public string orszagkod;
        public string sz_h;
        public Nobel(string egysor)
        {
            string[] darabok = egysor.Split(';');
            ev = int.Parse(darabok[0]);
            nev = darabok[1];
            eletkor = new Elethossz(darabok[2]).ElethosszEvekben;
            orszagkod = darabok[3];
            sz_h = darabok[2];
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("orvosi_nobeldijak.txt");
            Nobel[] dijazott = new Nobel[beolvas.Length - 1];
            for (int i = 0; i < dijazott.Length; i++)
            {
                dijazott[i] = new Nobel(beolvas[i+1]);//mert az első sor más igy i+1
            }
            Console.WriteLine($"3. Feladat: Dijazottak száma: {dijazott.Length} fő");
            var evszamok = new int[dijazott.Length];
            for (int i = 0; i < dijazott.Length; i++)
            {
                evszamok[i] = dijazott[i].ev; i++;
            }
            Console.WriteLine($"4. Feladat: Utolsó év: {evszamok.Max()}");
            Console.Write($"5. feladat: Kérem adja meg egy ország kódját:");
            var kod = Console.ReadLine();
            var db_5 = 0;
            var index_5 = -1;
            for (int i = 0; i < dijazott.Length; i++)
            {
                if (dijazott[i].orszagkod==kod)
                {
                    db_5++;
                    index_5 = i;
                }
            }
            switch (db_5)
            {
                case 0:
                    Console.WriteLine("A megadott országból nem volt díjazott!");
                    break;
                case 1:
                    Console.WriteLine($"\tA megadott ország díjazottja:");
                    Console.WriteLine($"\tNév: {dijazott[index_5].nev}");
                    Console.WriteLine($"\tNév: {dijazott[index_5].ev}");
                    Console.WriteLine($"\tNév: {dijazott[index_5].sz_h}");
                    break;
                
                default:
                    Console.WriteLine($"\tA megadott országból {db_5} fődijazott volt");
                    break;
            }
            //feladat
            var orszag = new List<string>();
            var db_6 = new List<int>();
            for (int i = 0; i < dijazott.Length; i++)
            {
                if (orszag.Contains(dijazott[i].orszagkod))
                {
                    var index_6 = orszag.IndexOf(dijazott[i].orszagkod);
                    db_6[index_6]++;
                }
                else
                {
                    orszag.Add(dijazott[i].orszagkod);
                    db_6.Add(1);
                }
                
            }
            Console.WriteLine("6. Satisztika");
            for (int i = 0; i < db_6.Count; i++)
            {
                if (db_6[i]>5)
                {
                    Console.WriteLine($"\t{orszag[i]} - {db_6[i]} fő");
                }
            }
            var atlag = new List<int>();
            for (int i = 0; i < dijazott.Length; i++)
            {
                if (dijazott[i].eletkor!=-1)
                {
                    atlag.Add(dijazott[i].eletkor);
                }
            }
            Console.WriteLine($"7. Feladat: A keresett átlag {Math.Round( atlag.Average(), 1)} év");
            Console.ReadKey();

        }
    }
}
