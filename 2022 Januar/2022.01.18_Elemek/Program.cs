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
            public int rendszam;
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
            var sr = new StreamReader("felfedezesek.csv", Encoding.GetEncoding("iso_8859-2"));
            var lista = new List<Kemia>();
            var elso = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Kemia(sr.ReadLine()));
            }
            Console.WriteLine($"3. feladat: Elemek szama {lista.Count()}");
            var okorban = (
                from sor in lista
                where sor.kor == "Ókor"
                select sor);
            /*  foreach (var item in lista)
              {
                  Console.WriteLine(item.kor);
              }
              Console.WriteLine(okorban.Count());*/

            string bevegy = "";
            int szam;
            var tomb = new char[] { 'á', 'é', 'ó', 'ú', 'ű', 'ü', 'ő', 'ö' };
            do
            {


                Console.WriteLine("egy vegyjelet be");
                bevegy = (Console.ReadLine());
                bool success = int.TryParse(bevegy, out szam);
                if (success)
                {
                    //https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-6.0
                    Console.WriteLine("egy vegyjelet be");
                    bevegy = (Console.ReadLine());
                }
               
            } while (bevegy.Length != 1 && bevegy.Length != 2);
            var keres = (
                from sor in lista
                where sor.vegyjel.ToLower() == bevegy.ToLower()
                select sor);
            if (keres.Any())
            {
                foreach (var item in keres)
                {
                    Console.WriteLine(item.vegyjel);
                    Console.WriteLine(item.nev);
                    Console.WriteLine(item.rendszam);
                    Console.WriteLine(item.kor);
                    Console.WriteLine(item.felfedezo);
                }
            }
            else
            {
                Console.WriteLine("ilyen nem volt");
            }
            var kulonb = new List<int>();
            Console.WriteLine();
            for (int i = 0; i < lista.Count()-1; i++)
            {
                if (lista[i].kor=="Ókor")
                {

                }
                else
                {
                    kulonb.Add(int.Parse(lista[i+1].kor) - int.Parse(lista[i].kor));
                }
            }
            Console.WriteLine(kulonb.Max());
            /*foreach (var item in kulonb)
             {
                 Console.WriteLine(item);
             }*/
            var stat = (
                 from sor in lista
                 where sor.kor!="Ókor"
                 group sor by sor.kor
                 );
            foreach (var item in stat)
            {
                if (item.Count()>3)
                {
                    Console.WriteLine(item.Key + "    " + item.Count());
                }
               
            }
            Console.ReadKey();
        }
    }
}
