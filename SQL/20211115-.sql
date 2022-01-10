SELECT konyvek.szerzo, kiadok.nev, konyvek.cim FROM konyvek, kiadok where konyvek.konyvAz=kiadok.kiadoAz;
SELECT k.szerzo, ki.nev, k.cim FROM konyvek AS k, kiadok as ki where k.konyvAz=ki.kiadoAz;
SELECT k.szerzo, ki.nev, k.cim FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz;
SELECT k.nettoAr*1.27, ki.nev, k.cim FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz WHERE ki.nev='Móra';
SELECT * FROM konyvek AS k RIGHT JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz;
SELECT k.szerzo, k.cim, ki.nev FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz;
--SELECT * from tábla1 inner join tabla2 on tábla1.Az=tabla2.Az
SELECT count(*) FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz WHERE ki.nev='Móra';
SELECT k.nev, ki.nev FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz where ki.nev='Móra' OR ki.nev='Kossuth';
SELECT * FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz where ki.nev in('Móra','Kossuth');--egyszerűbben

SELECT * FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz where k.nettoAr*1.27 between 1000 and 2000; 
SELECT min(k.oldalszam), max(k.oldalszam), avg(k.oldalszam), Sum(k.oldalszam), FROM konyvek AS k INNER JOIN kiadok as ki on k.kiadoAz=ki.kiadoAz 
