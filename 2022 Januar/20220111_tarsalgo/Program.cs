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
        public int ora, perc, id;
        public string hely;
        public Beki(string s)
        {
            var sor = s.Split(' ');
            ora = int.Parse(sor[0]);
            perc = int.Parse(sor[1]);
            id= int.Parse(sor[2]);
            hely = sor[3];
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
            var elso = (
                from sor in lista
                orderby sor.hely
                select sor);
           /* foreach (var item in elso)
            {
                Console.WriteLine(item.hely);
            }*/
            Console.WriteLine(elso.First().id);
            Console.WriteLine(elso.Last().id);
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
            foreach (var item in stat)
            {
                if (item.Count()%2!=0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            //5 os feladat
            
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
                    Console.WriteLine(item.ora+":"+item.perc);
                }
            }
            Console.WriteLine("adj be egy azonostot");
            int az = int.Parse(Console.ReadLine());
           
            var hetedik = (
                from sor in lista
                where sor.id == az
                select sor).ToList();
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
            Console.WriteLine();
            
           

            // Console.WriteLine((from sor in dblista orderby sor select sor).Last());
            Console.ReadKey();
        }
    }
}
