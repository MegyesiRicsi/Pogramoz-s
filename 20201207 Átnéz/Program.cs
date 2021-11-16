using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20201207
{
    class Szakasz
    {
        public string kiindulo, vegpont;
        public double hossz;
        public int emelkedes, lejtes;
        public bool pecsetelo;
        public Szakasz(string egysor)
        {

            string[] darabok = egysor.Split(';');
            kiindulo = darabok[0];
            vegpont = darabok[1];
            hossz = double.Parse(darabok[2]);
            emelkedes = int.Parse(darabok[3]);
            lejtes = int.Parse(darabok[4]);
            if (darabok[5] == "n")
            {
                pecsetelo = false;
            }
            else
            {
                pecsetelo = true;
            }
            
        }
        
        class Program
        {
            static void Main(string[] args)
            {
                string[] beolvas = File.ReadAllLines("kektura.csv");
                int tengerszint = int.Parse(beolvas[0]);
                Szakasz[] szakaszok = new Szakasz[beolvas.Length - 1];
                for (int i = 0; i < szakaszok.Length; i++)
                {
                    szakaszok[i] = new Szakasz(beolvas[i + 1]);
                }
                Console.WriteLine("3. Feladat {0}", szakaszok.Length);
                List<double> ossz = new List<double>();
                for (int i = 0; i < szakaszok.Length; i++)
                {
                   ossz.Add(szakaszok[i].hossz);
                }
                Console.WriteLine();
                Console.WriteLine("4. Feladat {0}", ossz.Sum());


                Console.WriteLine( );
                for (int i = 0; i < szakaszok.Length; i++)
                {
                    if (szakaszok[i].hossz==ossz.Min())
                    {
                        Console.WriteLine("5. Feladat" );

                        Console.WriteLine("Kezdete {0}", szakaszok[i].kiindulo);

                        Console.WriteLine("Vege {0}", szakaszok[i].vegpont);

                        Console.WriteLine("tavolsag {0}", szakaszok[i].hossz);
                    }
                }
                Console.WriteLine();



                
                Console.WriteLine();
                Console.WriteLine("7. feladatot hogyan kene kiszamolni<???");

                string[] beolvas2 = beolvas;
                int db = 0;
                for (int i = 0; i < szakaszok.Length; i++)
                {
                    if (szakaszok[i].pecsetelo)
                    {
                        if (HianyosNev(szakaszok[i].vegpont))
                        {
                            Console.WriteLine("\t{0}", szakaszok[i].vegpont);
                            db++;
                           
                        }
                    }
                }
                if (db==0)
                {
                    Console.WriteLine("");
                }
                Console.WriteLine(tengerszint+"  aaaaaaaa");
                List<int> tenger = new List<int>();
                for (int i = 0; i < szakaszok.Length; i++)
                {
                    tengerszint = tengerszint + szakaszok[i].emelkedes - szakaszok[i].lejtes;
                    tenger.Add(tengerszint);
                }
                int maxindex = tenger.IndexOf(tenger.Max());
                Console.WriteLine("8.{0}", szakaszok[maxindex].vegpont);
                Console.WriteLine("8.{0}", szakaszok[maxindex].emelkedes);
                Console.WriteLine("8.{0}", szakaszok[maxindex].lejtes);
                Console.WriteLine("8.{0}", szakaszok[maxindex].kiindulo);

                Console.WriteLine("8. {0} ddd", tenger[maxindex]);
                Console.WriteLine();
                    File.WriteAllLines("kektura2.csv", beolvas2);

                Console.WriteLine("Nyomj egy billentyűt");
                Console.ReadKey();
            }
            static bool HianyosNev(string vegpont)
            {
                if (!vegpont.Contains("pecsetelohely"))
                {
                    return true;
                }
                else { return false; }
            }
        }
    }
}
