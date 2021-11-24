using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _20211123_Lift
{
    class Lift {
    
        public string date;
        public int karty, indulo, cel;
        public Lift(string sor)
        {
            var s = sor.Split(' ');
            date = s[0].Trim('.');
            karty = int.Parse(s[1]);
            indulo = int.Parse(s[2]);
            cel = int.Parse(s[3]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("lift.txt");
            var lista =new List<Lift>();
       //     var egy = sr.ReadLine();
          
            while (!sr.EndOfStream)
            {
                lista.Add(new Lift(sr.ReadLine()));
            }
            Console.WriteLine(lista.Count());
         
            var datum_max = (from sor in lista
                            orderby int.Parse(sor.date.Substring(8, 2))
                            select sor).ToList();
            Console.WriteLine($"{datum_max.First().date}    {datum_max.Last().date}");

            var celsz = (from sor in lista
                         orderby sor.cel
                         select sor).Last();
            Console.WriteLine(celsz.cel) ;
            
                Console.Write("\tA kárty száma: ");
                string kartya = Console.ReadLine();
                Console.Write("\tA célszint száma: ");
                string celszam =Console.ReadLine();
                int kartyaa, cell;
                try
                {
                    kartyaa = int.Parse(kartya);
               
                  
                }
                catch (Exception)
                {

                kartyaa = 5;
                }
            try
            {
                cell = int.Parse(celszam);
            }
            catch (Exception)
            {

                cell = 5;
            }
            var hasz = (from sor in lista
                        where sor.cel == cell && sor.karty == kartyaa
                        select sor);
            if (hasz.Any())
            {
                Console.WriteLine("ez má van");
            }
            else
            {
                Console.WriteLine("még nem vot");
            }
            var stat = (from sor in lista group sor by sor.date  );
            foreach (var item in stat)
            {
                Console.WriteLine($"{item.Key}      {item.Count()}");
            }

                

            
            
            


           
          











            Console.ReadKey();
        }
        
    }
}
