select * from konyvek where kiado!="Móra";
select * from konyvek where Nettoar>2000;
select * from konyvek where szerzo like 'G%';
select * from konyvek where szerzo like 'G' kiado="Móra";
select * from konyvek where kiado IN ("Móra", "Kossuth");
select * from konyvek megjelenes is not null;
select * from konyvek where between 2000 and 3000;
select * from konyvek where between '2012-01-01' and '2012-12-31';
select * from konyvek order by szerzo;
select * from konyvek order by szerzo DESC;
select * from konyvek order by szerzo ASC;
SELECT COUNT(*) FROM konyvek;
select szerzo, substr(nev ,1, 3) from konyvek
select round(avg(Nettoar)) from konyvek; 