using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211102_Nobel
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
    class Nobel
    {
        public int ev;
        public string nev;
        public int eletkor;
        public string orszagkod;
        public Nobel(string egysor)
        {
            string[] darabok = egysor.Split(';');
            ev = int.Parse(darabok[0]);
            nev = darabok[1];
            eletkor = new Elethossz(darabok[2]).ElethosszEvekben;
            orszagkod = darabok[3];
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
