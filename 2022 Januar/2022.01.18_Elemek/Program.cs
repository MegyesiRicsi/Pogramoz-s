using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022._01._18_Elemek
{
    class Program
    {
        class Kemia
        {
            public string kor, nev, vegyjel, felfedezo;
            public int rendszam, evszam;
            public Kemia(string sor)
            {
                var s = sor.Split(';');
                kor = s[0];
                nev = s[1];
                vegyjel = s[2];
                rendszam = int.Parse(s[3]);
                felfedezo = s[4];
            }
        }
        static void Main(string[] args)
        {
            var sr = new StreamReader("felfedezesek.csv");
            var lista = new List<Kemia>();
            var elso = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Kemia(sr.ReadLine()));
            }
            Console.WriteLine(lista.Count());
            var okorban = (
                from sor in lista
                where sor.kor == "Ókor"
                select sor).Count();
            Console.WriteLine(okorban);
            string bevegy;
            do
            {
                
                Console.WriteLine("egy vegyjelet be");
               bevegy=(Console.ReadLine());

            } while (bevegy.Length==1 || bevegy.Length==2);
            Console.ReadKey();
        }
    }
}
