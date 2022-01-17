using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20220111_tarsalgo
{
    class Beki
    {
        public int ora, perc, id, oraperc;
        public string hely;
        public Beki(string s)
        {
            var sor = s.Split(' ');
            ora = int.Parse(sor[0]);
            perc = int.Parse(sor[1]);
            id= int.Parse(sor[2]);
            hely = sor[3];
            oraperc = ora * 60+perc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("ajto.txt");
            var lista = new List<Beki>();
            while (!sr.EndOfStream)
            {
                lista.Add(new Beki(sr.ReadLine()));
            }
            Console.WriteLine("2. Feladat");
            var elso = (
                from sor in lista
                orderby sor.hely
                select sor);
           /* foreach (var item in elso)
            {
                Console.WriteLine(item.hely);
            }*/
            Console.WriteLine($"Az első belépő: {elso.First().id}");
            Console.WriteLine($"Az utoló kilépő: {elso.Last().id}");
            var stat = (
                from sor in lista
                orderby sor.id
                group sor by sor.id);
            var sw = new StreamWriter("athaladas.txt");
            foreach (var item in stat)
            {
                sw.WriteLine($"{item.Key} {item.Count()}");
            }
            sw.Close();
            //4 es feladat
            
            Console.WriteLine("\n4. Feladat\n");
            foreach (var item in stat)
            {
                if (item.Count()%2!=0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            //5 os feladat
            Console.WriteLine("\n\n5. feladat");
            var dblista = new List<int>();
            int db = 0;
            
            foreach (var item in lista)
            {
                if (item.hely=="be")
                {
                    db++;
                    dblista.Add(db);
                }
                else
                {
                    db--;
                    dblista.Add(db);
                }
            }

            db = 0;
            foreach (var item in lista)
            {
                if (item.hely == "be")
                {
                    db++;                    
                }
                else
                {
                    db--;                   
                }
                if (db==dblista.Max())
                {
                    Console.WriteLine($"Például {item.ora}:{item.perc}-kor voltak a legtöbben a társalgóban.");
                }
            }
            Console.Write("\n6. feladat\nAdja meg a személy azonositoját! ");
            int az = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var hetedik = (
                from sor in lista
                where sor.id == az
                select sor).ToList();
            Console.WriteLine("7. feladat");
            for (int i = 0; i < hetedik.Count(); i++)
            {
                
                if (i%2!=0)
                {//ki
                    
                    Console.WriteLine(hetedik[i].ora+":"+hetedik[i].perc);
                }
                else
                {//be 
                    
                    Console.Write(+hetedik[i].ora + ":" + hetedik[i].perc+"-");
                }
            }
            Console.WriteLine("\n\n8. feladat");
            var be = (
                 from sor in lista
                 where sor.hely == "be"
                 where sor.id == az
                 select sor.oraperc).Sum();
            var ki = (
                 from sor in lista
                 where sor.hely == "ki"
                 where sor.id == az
                 select sor.oraperc).Sum();
            int ossz = ki - be;
            if (ossz<0)
            {
               ossz= ossz + 15 * 60;
                Console.WriteLine($"A(z) {az}. személy összesen  { ossz} percet volt bent, a megfigyelés végén a társalgóban volt. ");
            }
            else
            {
                Console.WriteLine($" A(z) {az}. személy összesen  { ossz} percet volt bent. ");
            }
            
           







            // Console.WriteLine((from sor in dblista orderby sor select sor).Last());
            Console.ReadKey();
        }
    }
}
