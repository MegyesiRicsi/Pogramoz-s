SELECT *FROM konyvek;
SELECT szerzo,cim,kiado FROM konyvek;
SELECT  *FROM `konyvek` WHERE `kiado`="Móra";
SELECT `cim`,`szerzo` FROM konyvek WHERE `kiado`!="Móra";
SELECT `cim`,`szerzo` FROM konyvek WHERE `nettoAr`<3000;
SELECT `cim`,`megjelenes` FROM konyvek WHERE `megjelenes`>="2014-01-01";
SELECT `szerzo`,`megjelenes` FROM konyvek WHERE `szerzo` like "G%";
SELECT  *FROM konyvek WHERE `szerzo`="Fekete István" AND `kiado`="Móra";
SELECT * FROM `konyvek` WHERE `szerzo`='Gardonyi Geza' OR `szerzo`= "Fekete István";
SELECT * FROM `konyvek` WHERE `szero in ("Gardonyi Geza","Fekete István");
SELECT * FROM `konyvek` WHERE szerzo IN ("Gárdonyi Géza", "Fekete István");
SELECT * FROM `konyvek` WHERE szerzo NOT IN ("Gárdonyi Géza", "Fekete István");
SELECT * FROM konyvek WHERE oldalszam IS NULL;
SELECT * FROM konyvek WHERE nettoAr BETWEEN 2000 AND 3000;
SELECT * FROM konyvek WHERE megjelenes LIKE "2014%";
SELECT cim, nettoAr,round( nettoAr*1.27,1) AS BruttoAr FROM konyvek;
--Aggregátor függvények 
select count(oldalszam)as darab from konyvek;
select sum(nettoAr) as osszeg from konyvek;
select sum(nettoAr) as osszeg from konyvek WHERE kiado="Móra"
select MIN(oldalszam) as Minimum, MAX(oldalszam), round(SUM(oldalszam)/count(oldalszam)) FROM konyvek
select DISTINCT szerzo FROM konyvek--egyszer irjon ki mindent
select szerzo, count(*) from konyvek group by szerzo
--karakteres függvények
select upper(szerzo), lower(cim) from konyvek ;
SELECT concat(szerzo, " - ", cim) as összefűz FROM konyvek ;
select szerzo, substr(szerzo, 2,5) from konyvek;
select szerzo, substr(szerzo, 5) from konyvek;
select szerzo,length(szerzo) as hossz from konyvek;
select concat(lower(kiado), "@gmail.com") AS Email FROM konyvek;
SELECT RPAD(kiado, 25,"*") from konyvek;
-- SELECT RPAD(kiado,max(length(hossz)),"*") from konyvek where hossz=select length(kiado); NEM MŰKÖDIK where 
select trim(szero)from konyvek;
select sqrt(25),sqrt(-6), power(2,5);
SELECT nettoAr, round(sqrt(nettoAr), 2) FROM konyvek;
SELECT TRUNCATE(125.689, 2);
select ceil(6.1), floor(6.8);
select mod(10,3), mod(12, 3);
select megjelenes , dayname(megjelenes) from konyvek;
