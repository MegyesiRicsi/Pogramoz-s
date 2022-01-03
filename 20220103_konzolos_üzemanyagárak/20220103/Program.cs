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
        public int benzin, olaj;
        public Anyag(string sor)
        {
            var s = sor.Split(';');
            date = s[0];
            benzin = int.Parse(s[1]);
            olaj = int.Parse(s[2]);

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
            Console.WriteLine(lista.Count());

            var kul = new List<int>();
            foreach (var item in lista)
            {
                kul.Add(item.benzin % item.olaj);
               // Console.WriteLine(item.benzin % item.olaj);
            }
            Console.WriteLine(kul.Min());
            int db = 0;
            for (int i = 0; i < kul.Count(); i++)
            {
                if (kul.Min()==kul[i])
                {
                    db++;
                }
            }
            Console.WriteLine(db);
            
            

            

            Console.ReadKey();

        }
    }
}
