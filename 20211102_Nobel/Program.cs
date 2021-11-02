using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211102_Nobel
{
    class Program
    {
        class Elethossz
        {
            private int Tol { get; set; }
            private int Ig { get; set; }
            public int ElethosszEvekben => Tol == -1 || Ig == -1 ? -1 : Ig - Tol;

            public bool IsmertAzElethossz => ElethosszEvekben != -1;

            public Elethossz(string SzuletesHalalozas)
            {
                string[] m = SzuletesHalalozas.Split('-');
                try
                {
                    Tol = int.Parse(m[0]);
                }
                catch (Exception)
                {
                    Tol = -1;
                }
                try
                {
                    Ig = int.Parse(m[1]);
                }
                catch (Exception)
                {
                    Ig = -1;
                }
            }
        }
        static void Main(string[] args)
        {
            //Év;Név;SzületésHalálozás;Országkód
            //1932; Adrian, lord Edgar Douglas; 1889 - 1977; GB
            var 
        }
    }
}
