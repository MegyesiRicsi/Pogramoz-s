using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211109_kektura
{
    class Szakasz
    {
        public string indulopont, vegpont;
        public double hossz ;
        public int emelkedes;
        public int leejtes;
        public char ph;
        public Szakasz(string sor)
        {
            var s=sor.Split(';');
            indulopont = s[0];
            vegpont = s[1];
            hossz = double.Parse(s[2]);
            emelkedes = int.Parse(s[3]);
            leejtes = int.Parse(s[4]);
            ph = char.Parse(s[5]);

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var sr = new StreamReader("kektura.csv", Encoding.GetEncoding("ISO8859-1"));
            var elsosor =int.Parse( sr.ReadLine());
            var lista = new List<Szakasz>();
            while (!sr.EndOfStream)
            {
                lista.Add(new Szakasz(sr.ReadLine()));
            }
            Console.WriteLine($"3. Feladat {lista.Count()}");
            var fulllen = (
                from sor in lista
                select sor.hossz).Sum();
            Console.WriteLine($"4. Feladat: {fulllen} km");
            var rovid = (
                from sor in lista
                orderby sor.hossz
                select sor).First();
            Console.WriteLine($"5. Feladat: A legrövidebb sor adatai:");
            Console.WriteLine($"\tKezdete {rovid.indulopont}");
            Console.WriteLine($"\tVége: {rovid.vegpont}");
            Console.WriteLine($"\tkezdete: {rovid.hossz} km");
            var HianyosNev = (
                from sor in lista
                where sor.ph=='i'                
                select sor);
            Console.WriteLine("7. Feladat Hiányos állomások");
            foreach (var item in HianyosNev)
            {
                if (!item.vegpont.Contains("pecsetelohely"))
                {
                    Console.WriteLine($"\t{item.vegpont}");
                }               
            }
            var pp = (
                from sor in lista
                orderby elsosor+sor.emelkedes - sor.leejtes
                
                select sor).Last();
          int szam = elsosor + pp.emelkedes-pp.leejtes;
            Console.WriteLine(pp.leejtes);
            Console.WriteLine(pp.emelkedes);
            Console.WriteLine(elsosor);
            Console.WriteLine($"{pp.vegpont} {szam} ");
           
          Console.ReadKey();
        }
    }
}
