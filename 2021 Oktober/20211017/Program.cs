// berek2020.txt http://www.infojegyzet.hu/vizsgafeladatok/okj-programozas/rendszeruzemelteto-210511/
//Név;Neme;Részleg;Belépés;Bér
//Beri Dániel;férfi;beszerzés;1979;222943
using System;                     // Console
using System.IO;                  // StreamReader 
using System.Text;                // Encoding
using System.Collections.Generic; // List<>, Dictionary<>
using System.Linq;                // from where select

class Dolgozo
{                    // "Minimalista" osztály definíció
    public string nev;
    public string neme;
    public string reszleg;
    public string belepes;
    public int ber;
}

class Program
{
    public static void Main(string[] args)
    {
        var lista = new List<Dolgozo>();              // üres lista létrehozása

        var f = new StreamReader("berek2020.txt", Encoding.UTF8); // a "berek2020.txt" fájl megnyitása f néven 
        var elsosor = f.ReadLine();                   // az elsosorba kerül a fájl első sora.

        while (!f.EndOfStream)
        {              // amig a fájl végére nem érünk addig imétlünk
            var dolgozo = new Dolgozo();              // létrehozunk egy dolgozo-t a Dolgozó osztály alapján
            var s = f.ReadLine().Split(';');          // az s változóba kerül a beolvasott és a pontosvessző mentén feldarabolt sor       
            dolgozo.nev = s[0];                       // a dolgozo.nev-be      kerül az s lista nulladik eleme
            dolgozo.neme = s[1];                      // a dolgozo.neme-be     kerül az s lista nulladik eleme
            dolgozo.reszleg = s[2];                   // a dolgozo.reszleg-be  kerül az s lista nulladik eleme
            dolgozo.belepes = s[3];                   // a dolgozo.belepes-be  kerül az s lista nulladik eleme
            dolgozo.ber = int.Parse(s[4]);            // a dolgozo.nev -be     kerül az s lista nulladik eleme egész számmá alaítva
            lista.Add(dolgozo);                       // a lista-hoz adjuk a dolgozo példányt.
        }
        f.Close();                           // bezárjuk az f fájlt

        // 3. feladat: Dolgozók száma: ? 
        Console.WriteLine($"3. feladat: Dolgozók száma: {lista.Count} fő");

        // 4. feladat: Bérek átlaga: ####,# eFt
        var atlag = (from sor in lista select sor.ber).Average() / 1000;
        Console.WriteLine($"4. feladat: Bérek átlaga: {atlag:0.#} eFt");

        // 5. feladat: Kérem egy részleg nevét:
        Console.Write("5. feladat: Kérem egy részleg nevét: ");
        var reszlegneve = Console.ReadLine();

        // 6. feladat: A legtöbbet kereső dolgozó a megadott részlegen
        var res = (from sor in lista where (sor.reszleg == reszlegneve) select (sor.ber, sor)); 
       
        if (res.Count() > 0)
        {
            Console.WriteLine(res.Max().Item1);
            Console.WriteLine(res.Max().Item2);
            var maxi = res.Max().Item2;
            Console.WriteLine(maxi.nev);
            Console.WriteLine($"6. feladat: A legtöbbet kereső dolgozó a megadott részlegen");
            Console.WriteLine($"        Név: {maxi.nev}");
            Console.WriteLine($"        Neme: {maxi.neme}");
            Console.WriteLine($"        Belépés: {maxi.belepes}");
            Console.WriteLine($"        Bér: {maxi.ber} Forint");
        }
        else
        {
            Console.WriteLine($"6. feladat: A megadott részleg nem létezik a cégnél!");
        }

        //7. feladat: Statisztika
        var statisztika = new Dictionary<string, int>();
        foreach (var sor in lista)
        {
            if (statisztika.ContainsKey(sor.reszleg))
            {
                statisztika[sor.reszleg]++;
            }
            else
            {
                statisztika[sor.reszleg] = 1;
            }
        }
        Console.WriteLine($"7. feladat: Statisztika");
        foreach (KeyValuePair<string, int> item in statisztika)
        {
            Console.WriteLine($"        {item.Key} - {item.Value} ");
        }

        Console.ReadLine();
    }
}