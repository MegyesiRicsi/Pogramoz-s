SELECT beosztas, AVG(fizetes) FROM `alkalmazott` GROUP BY beosztas;

SELECT reszleg_kod,beosztas, AVG(fizetes), MIN(fizetes), MAX(fizetes)
FROM `alkalmazott`
WHERE reszleg_kod>10
GROUP BY beosztas HAVING MIN(fizetes)>=13000 
ORDER BY reszleg_kod

SELECT reszleg_kod,beosztas, round(AVG(fizetes)) as atlag, MIN(fizetes), MAX(fizetes)
 FROM `alkalmazott`
 WHERE reszleg_kod in (50,60)
 GROUP BY reszleg_kod HAVING atlag<20000
 ORDER by reszleg_kod DESC //visszafele  rendezve 
 
 SELECT a.beosztas, a.fizetes, r.reszleg_nev 
 FROM reszleg as r INNER JOIN alkalmazott as a on r.reszleg_kod=a.reszleg_kod
 
 SELECT * from autok a inner Join rendeles r on a.rendszam=r.rendszam
 inner join ugyfelek u on r.rendeles_szam=u.ugyfel_szam
 
 SELECT u.ugyfel_nev, a.rendszam, a.tipus_nev, r.kolcson_dij
 from autok a INNER JOIN rendeles r on a.rendszam=r.rendszam 
 INNER JOIN ugyfelek u on r.ugyfel_szam=u.ugyfel_szam
 
 SELECT r.reszleg_nev részlegNev, r.reszleg_kod Kód, a.alk_nev Név, a.fizetes Fizu
 FROM reszleg r INNER JOIN alkalmazott a on r.reszleg_kod=a.reszleg_kod
 WHERE r.reszleg_nev LIKE "AUTO"

SELECT COUNT(*) dbszám, reszleg_nev
FROM reszleg r 
INNER JOIN alkalmazott a on r.reszleg_kod=a.reszleg_kod
GROUP BY r.reszleg_nev

SELECT * FROM autok a INNER JOIN rendeles r on a.rendszam=r.rendszam INNER JOIN ugyfelek u on u.ugyfel_szam=r.ugyfel_szam --3 tábla

SELECT COUNT(*), a.rendszam FROM autok a INNER JOIN rendeles r on a.rendszam=r.rendszam GROUP BY a.rendszam

SELECT count(r.ugyfel_szam) FROM autok a 
INNER JOIN rendeles r on a.rendszam=r.rendszam 
GROUP BY r.ugyfel_szam HAVING COUNT(r.ugyfel_szam)>1

SELECT AVG(a.fizetes) atl from alkalmazott a GROUP BY a.reszleg_kod HAVING atl>20000