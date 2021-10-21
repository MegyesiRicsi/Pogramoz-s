using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("asd");
            var szam = int.Parse(Console.ReadLine());
            switch (8>szam && szam>0)
            {
                case  1:
                    Console.WriteLine("asd");
                    break;
                case 2:
                    Console.WriteLine("béja");
                    break;
            }
            Console.ReadKey();
        }
    }
}
