using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _20220103
{
    class Anyag
    {
        public string date;
        public int benzin, olaj, ev, honap, nap;
        public Anyag(string sor)
        {
            var s = sor.Split(';');
            date = s[0];
            benzin = int.Parse(s[1]);
            olaj = int.Parse(s[2]);

            var ss = date.Split('.');
            ev = int.Parse(ss[0]);
            honap = int.Parse(ss[1]);
            nap = int.Parse(ss[2]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("uzemanyag.txt");
            var lista = new List<Anyag>();
            while (!sr.EndOfStream)
            {
                lista.Add(new Anyag(sr.ReadLine()));
            }
            Console.WriteLine($"3. feladat: Valtozasok szama: {lista.Count()}");

            var kul = new List<int>();
            foreach (var item in lista)
            {
               kul.Add(item.benzin % item.olaj);
               // Console.WriteLine(item.benzin % item.olaj);
            }
            Console.WriteLine($"4. feladat: A legkisebb kulonbseg {kul.Min()}");
            int db = 0;
            for (int i = 0; i < kul.Count(); i++)
            {
                if (kul.Min()==kul[i])
                {
                    db++;
                }
            }
            Console.WriteLine($"5. feladat: A lekgkisebb kulonbseg elorordulasa: {db}");
            //6. feladat
            var fs = false;
            foreach (var item in lista)
             {
                // Console.WriteLine(item.ev+" "+item.honap+" "+item.nap);
                 if (item.ev%4==0 && item.nap==24 && item.honap==2)
                 {

                     fs = true;
                 }
             }
            
            if (fs)
            {
                Console.WriteLine("6. feladat: Volt valtozas szokonapon!");
            }
            else
            {
                Console.WriteLine("6. feladat: Nem volt valtozas szokonapon!");
            }
            var sw = new StreamWriter("euro.txt");
            foreach (var item in lista)
            {
                sw.WriteLine(item.date+';'+Math.Round((double)item.benzin/307.7,2)+';'+Math.Round((double)item.olaj/307.7,2));
            }
            int szam = 1;
            do
            {
                Console.Write("8. feladat: Kerem adja meg ay evszamot [2011..2016]: ");
                szam = int.Parse(Console.ReadLine());
            } while (szam>2016 || szam<2011);
            var napokSzama = new int[] { 31, 28,31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            

            Console.ReadKey();

        }
    }
}
