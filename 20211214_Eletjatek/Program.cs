using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _20211214_Eletjatek
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var veletlenek = new List<int>();
            var parosok = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                veletlenek.Add(rnd.Next(10, 50));
            }
            foreach (var item in veletlenek)
            {
                Console.Write(item+" ");
                if (item % 2 == 0)
                {
                    parosok.Add(item);
                }
            }
            
            Console.WriteLine(veletlenek.Max());
            Console.WriteLine(veletlenek.Min());
            Console.WriteLine(veletlenek.Sum());
            Console.WriteLine(veletlenek.Average());
            Console.WriteLine(veletlenek.Max()-veletlenek.Min());
            foreach (var item in parosok)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine(parosok.Count());
            Console.WriteLine(parosok.Max());
            Console.WriteLine(parosok.Min());
            Console.WriteLine(parosok.Sum());
            Console.WriteLine(parosok.Average());
            Console.WriteLine(parosok.Max() - veletlenek.Min());


            var sw = new StreamWriter("s.txt");
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                sw.Write(i);
            }
            int sor = 1;
            while (sor<=5)
            {
                int oszlop = 1;
                while (oszlop<= 5)
                {
                    Console.Write("0 ");
                    oszlop++;
                }
                Console.WriteLine();
                    sor++;
            }
            Console.ReadKey();
        }
    }
}
