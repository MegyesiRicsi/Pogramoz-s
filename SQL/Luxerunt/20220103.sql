SELECT a.rendszam, t.tipus_nev,a.ar,t.szerviz_km
 from tipusok as t 
 INNER JOIN autok as a ON t.tipus_nev=a.tipus_nev
 
 --csoportositás, 1 nél több eleműek kiirása
 SELECT COUNT(t.tipus_nev), t.tipus_nev
 from tipusok as t INNER JOIN autok as a ON t.tipus_nev=a.tipus_nev
 GROUP by t.tipus_nev HAVING COUNT(t.tipus_nev)>1
 
 SELECT COUNT(t.tipus_nev), t.tipus_nev,SUM(a.futott_km) from tipusok as t
 INNER JOIN autok as a ON t.tipus_nev=a.tipus_nev 
 GROUP by t.tipus_nev HAVING SUM(a.futott_km)<100000
 
 
