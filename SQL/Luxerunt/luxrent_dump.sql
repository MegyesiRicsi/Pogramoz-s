--
-- Adatbázis: `luxrent`
--
CREATE DATABASE IF NOT EXISTS `luxrent` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `luxrent`;


CREATE TABLE `alkalmazott` (
  `alk_kod` int(8) NOT NULL,
  `alk_nev` varchar(20) DEFAULT NULL,
  `beosztas` varchar(16) DEFAULT NULL,
  `belepes` date DEFAULT NULL,
  `fizetes` int(8) DEFAULT NULL,
  `premium` int(8) DEFAULT NULL,
  `reszleg_kod` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `alkalmazott`
--

INSERT INTO `alkalmazott` (`alk_kod`, `alk_nev`, `beosztas`, `belepes`, `fizetes`, `premium`, `reszleg_kod`) VALUES
(1234, 'KOVACS', 'ELADO', '1992-12-10', 13000, 4000, 20),
(1235, 'MOLNAR', 'SZERELO', '1992-12-18', 18000, NULL, 30),
(1236, 'CSIKOS', 'ELADO', '1993-03-12', 13250, 5000, 30),
(1237, 'TOTH', 'VIZSGABIZTOS', '1993-04-22', 20000, NULL, 20),
(1238, 'NEMETH', 'TELEPHELYVEZETO', '1993-11-28', 29000, 14000, 30),
(1239, 'SZABO', 'IGAZGATO', '1992-05-01', 54000, 75000, 10),
(1240, 'BALOGH', 'SZERELO', '1992-06-02', 22000, 5000, 50),
(1241, 'TRENCSENI', 'ELADO', '1993-06-20', 12100, 7200, 60),
(1244, 'KIRALY', 'VIZSGABIZTOS', '1993-08-04', 21000, 8000, 20),
(1245, 'HERCEG', 'ELADO', '1993-11-12', 11000, 6000, 20),
(1246, 'BOGNAR', 'ELADO', '1992-10-08', 13000, 6000, 50),
(1247, 'HALASZ', 'SZERELO', '1993-05-23', 21000, 7000, 60),
(1248, 'HORVAT', 'TELEPHELYVEZETO', '1993-12-09', 25000, 12000, 60),
(1249, 'KISS', 'ELADO', '1993-12-23', 12500, 9500, 20);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `autok`
--

CREATE TABLE `autok` (
  `rendszam` varchar(7) NOT NULL,
  `tipus_nev` varchar(15) DEFAULT NULL,
  `auto_csop_nev` varchar(6) DEFAULT NULL,
  `vasarlas_datuma` date DEFAULT NULL,
  `ar` float DEFAULT NULL,
  `futott_km` int(8) DEFAULT NULL,
  `ut_szerviz` int(8) DEFAULT NULL,
  `allapot` varchar(1) DEFAULT NULL,
  `reszleg_kod` int(4) DEFAULT NULL,
  `alk_kod` int(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `autok`
--

INSERT INTO `autok` (`rendszam`, `tipus_nev`, `auto_csop_nev`, `vasarlas_datuma`, `ar`, `futott_km`, `ut_szerviz`, `allapot`, `reszleg_kod`, `alk_kod`) VALUES
('ABR-115', 'RENAULT 19', 'EXTRA', '1993-01-02', 1200000, 145097, 100000, 'X', 20, 1234),
('CDE-324', 'RENAULT NEVADA', 'EXTRA', '1993-06-01', 2473000, 42040, 100000, 'F', 20, 1234),
('DHV-123', 'RENAULT LAGUNA', 'EXTRA', '1993-06-05', 2346000, 73621, 100000, 'A', 20, 1245),
('PHD-100', 'RENAULT 19', 'EXTRA', '1993-06-30', 1329000, 151441, 120000, 'X', 20, 1249),
('PHD-610', 'RENAULT NEVADA', 'EXTRA', '1993-07-20', 2473000, 39066, 100000, 'F', 20, 1249),
('ABC-021', 'SKODA LX', 'NORMAL', '1993-10-01', 827000, 123212, 120000, 'F', 30, 1236),
('ABC-022', 'SKODA CL', 'NORMAL', '1993-10-01', 917000, 97081, 120000, 'S', 30, 1236),
('ABC-123', 'OPEL ASTRA', 'EXTRA', '1993-11-11', 1239000, 101978, 100000, 'A', 30, 1236),
('BAH-115', 'OPEL VECTRA', 'LUXUS', '1993-10-11', 3977000, 51007, 100000, 'A', 50, 1246),
('CIC-312', 'W VENTO CL', 'EXTRA', '1993-12-01', 1650000, 100021, 100000, 'F', 60, 1241),
('COD-705', 'W VENTO CL', 'EXTRA', '1993-12-01', 1650000, 91970, 100000, 'S', 60, 1241),
('CBN-301', 'OPEL CORSA', 'NORMAL', '1993-12-01', 917000, 28001, 120000, 'A', 60, 1241),
('CBN-302', 'OPEL ASTRA', 'EXTRA', '1993-12-01', 1239000, 87111, 100000, 'S', 60, 1241),
('CDD-115', 'FORD ESCORT', 'EXTRA', '1994-01-02', 1400000, 15901, 100000, 'A', 30, 1236),
('DCD-324', 'RENAULT LAGUNA', 'EXTRA', '1994-01-02', 2346000, 41061, 100000, 'A', 20, 1245),
('PDP-101', 'RENAULT ESPACE', 'LUXUS', '1994-01-02', 3530000, 7911, 100000, 'S', 20, 1249),
('CBN-001', 'W VENTO CL', 'EXTRA', '1994-01-02', 1999000, 152311, 100000, 'F', 60, 1241),
('CDD-115', 'RENAULT TWINGO', 'NORMAL', '1994-01-03', 955000, 8307, 120000, 'S', 20, 1234);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `auto_csop`
--

CREATE TABLE `auto_csop` (
  `auto_csop_nev` varchar(6) NOT NULL,
  `km_dij` int(4) DEFAULT NULL,
  `napi_dij` int(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `auto_csop`
--

INSERT INTO `auto_csop` (`auto_csop_nev`, `km_dij`, `napi_dij`) VALUES
('NORMAL', 80, 5000),
('EXTRA', 120, 7500),
('LUXUS', 300, 15000);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles`
--

CREATE TABLE `rendeles` (
  `rendeles_szam` varchar(5) NOT NULL,
  `ugyfel_szam` varchar(3) DEFAULT NULL,
  `rendeles_datum` date DEFAULT NULL,
  `rendelo_szemely` varchar(12) DEFAULT NULL,
  `kolcson_kezdete` date DEFAULT NULL,
  `napok` int(8) DEFAULT NULL,
  `rendszam` varchar(7) DEFAULT NULL,
  `tipus_nev` varchar(15) DEFAULT NULL,
  `km_kezdet` int(8) DEFAULT NULL,
  `km_veg` int(8) DEFAULT NULL,
  `kolcson_dij` int(8) DEFAULT NULL,
  `fizetes` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `rendeles`
--

INSERT INTO `rendeles` (`rendeles_szam`, `ugyfel_szam`, `rendeles_datum`, `rendelo_szemely`, `kolcson_kezdete`, `napok`, `rendszam`, `tipus_nev`, `km_kezdet`, `km_veg`, `kolcson_dij`, `fizetes`) VALUES
('12334', '348', '1993-12-01', 'NAGY TIBORNE', '1994-04-01', 5, 'ABC-123', 'OPEL ASTRA', 95308, 101978, 558600, 'Y'),
('12335', '342', '1994-02-02', 'HOTEL CIVIS', '1994-03-05', 2, 'ABR-115', 'RENAULT 19', 144102, 145097, 134400, 'Y'),
('12336', '342', '1994-02-02', 'HOTEL CIVIS', '1994-02-02', 21, 'PHD-100', 'RENAULT 19', 150871, 151441, 225900, 'Y'),
('12337', '344', '1994-03-30', 'HILTON', '1994-04-05', 30, 'ABR-047', 'FORD ESCORT', 141413, 151003, 1375800, 'N'),
('12338', '343', '1994-03-30', 'MATAV IG.', '1994-04-05', 5, 'ABC-123', 'OPEL ASTRA', 101978, 104965, 395940, 'N'),
('12339', '348', '1994-04-02', 'APEH IG.', '1994-04-10', 1, 'BAH-115', 'OPEL VECTRA', 50609, 51007, 55260, 'N'),
('12340', '345', '1994-02-03', 'HOTEL CIVIS', '1994-05-01', 5, 'ABR-047', 'FORD ESCORT', 151003, NULL, NULL, 'Y'),
('12341', '349', '1994-04-04', 'IBUSZ IG.', '1994-05-01', 10, 'ABC-123', 'W VENTO CL', 152311, NULL, NULL, 'Y'),
('12342', '344', '1994-04-04', 'HILTON', '1994-05-02', 5, 'PHD-610', 'RENAULT NEVADA', 39066, NULL, NULL, 'Y'),
('12343', '348', '1994-05-04', 'NAGY TIBORNE', '1994-04-10', 7, 'CDE-324', 'RENAULT NEVADA', 42040, NULL, NULL, 'N'),
('12344', '343', '1994-04-20', 'KOOS TIBOR', '1994-05-03', 10, 'ABC-123', 'SKODA LX', 123212, NULL, NULL, 'N'),
('12345', '342', '1994-04-21', 'HILTON', '1994-05-03', 3, 'CIC-312', 'W VENTO CL', 100021, NULL, NULL, 'Y');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `reszleg`
--

CREATE TABLE `reszleg` (
  `reszleg_kod` int(8) NOT NULL,
  `reszleg_nev` varchar(20) DEFAULT NULL,
  `reszleg_cim` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `reszleg`
--

INSERT INTO `reszleg` (`reszleg_kod`, `reszleg_nev`, `reszleg_cim`) VALUES
(10, 'KOZPONT', 'BUDAPEST'),
(20, 'AUTO-RENAULT', 'BUDAPEST'),
(30, 'AUTO', 'GYOR'),
(50, 'LUXUS-AUTO', 'BUDAPEST'),
(60, 'AUTO', 'DEBRECEN'),
(70, 'TEHERAUTO', 'BUDAPEST'),
(80, 'MUHELY', 'BUDAPEST'),
(90, 'MUHELY', 'BUDAPEST'),
(80, 'MUHELY', 'BUDAPEST'),
(90, 'MUHELY', 'BUDAPEST'),
(80, 'MUHELY', 'BUDAPEST'),
(90, 'MUHELY', 'BUDAPEST'),
(80, 'MUHELY', 'BUDAPEST'),
(90, 'MUHELY', 'BUDAPEST'),
(80, 'MUHELY', 'BUDAPEST'),
(90, 'MUHELY', 'BUDAPEST'),
(80, 'MUHELY', 'BUDAPEST'),
(90, 'MUHELY', 'BUDAPEST');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tipusok`
--

CREATE TABLE `tipusok` (
  `tipus_nev` varchar(15) NOT NULL,
  `auto_csop_nev` varchar(6) DEFAULT NULL,
  `leiras` varchar(30) DEFAULT NULL,
  `szerviz_km` int(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `tipusok`
--

INSERT INTO `tipusok` (`tipus_nev`, `auto_csop_nev`, `leiras`, `szerviz_km`) VALUES
('FORD ESCORT', 'EXTRA', 'CL 1.8 DSL 5-A', 15000),
('RENAULT 19', 'EXTRA', 'RL 1.4 L KAT 3-A', 5000),
('RENAULT NEVADA', 'EXTRA', 'RTD 2.1 L KAT 5-', 75000),
('RENAULT LAGUNA', 'EXTRA', 'RT 2.0 L KAT 5-A', 15000),
('SKODA LX', 'NORMAL', 'FAVORIT 1.3 L KAT', 5000),
('SKODA CL', 'NORMAL', 'FAVORIT 1.3 L KAT COMFORT LINE', 5000),
('OPEL ASTRA', 'EXTRA', 'CL 1.6 I 5-A', 10000),
('OPEL VECTRA', 'LUXUS', 'TURBO 2.0 I 4-A', 10000),
('W VENTO CL', 'EXTRA', 'TD 1.9 L KAT', 15000),
('OPEL CORSA', 'NORMAL', 'CITY 1.2 I 3-A', 10000),
('RENAULT TWINGO', 'NORMAL', '1.2 L KAT 3-A', 75000),
('RENAULT ESPACE', 'LUXUS', 'RN DT 2.1 L KAT', 15000);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ugyfelek`
--

CREATE TABLE `ugyfelek` (
  `ugyfel_szam` varchar(3) NOT NULL,
  `ugyfel_nev` varchar(20) DEFAULT NULL,
  `cim` varchar(15) DEFAULT NULL,
  `varos` varchar(10) DEFAULT NULL,
  `orszag` varchar(10) DEFAULT NULL,
  `iranyito_szam` varchar(6) DEFAULT NULL,
  `megbizott` varchar(15) DEFAULT NULL,
  `fizetesi_mod` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `ugyfelek`
--

INSERT INTO `ugyfelek` (`ugyfel_szam`, `ugyfel_nev`, `cim`, `varos`, `orszag`, `iranyito_szam`, `megbizott`, `fizetesi_mod`) VALUES
('342', 'MOLNAR PETER', 'HILTON PRK. 1.', 'NEW YORK', 'USA', '49928', 'HILTON', 'K'),
('343', 'PAPP ROBERT', 'PIAC U. 10.', 'DEBRECEN', 'MAGYAR', '4027', 'PINTER ATTILA', 'K'),
('344', 'ABEL ANETT', 'WIESZ STR 5', 'BECS', 'AUSZTRIA', '20800', 'HILTON', 'K'),
('345', 'TIBOR SMITH', 'LIGNOUN 15.', 'PARIZS', 'FRANCIA', '140010', 'HOTEL CIVIS', 'A'),
('346', 'PAPP AGNES', 'VEZER U. 19.', 'DEBRECEN', 'MAGYAR', '4032', NULL, 'A'),
('347', 'BIRO KATALIN', 'TESSEDIK U. 6.', 'DEBRECEN', 'MAGYAR', '4032', NULL, 'A'),
('348', 'KISS VIKTORIA', 'FO U. 8.', 'BUDAPEST', 'MAGYAR', '1221', 'NAGY TIBORNE', 'K'),
('349', 'LIGETI ZOLTAN', 'KIRALY U. 88.', 'BUDAPEST', 'MAGYAR', '1239', NULL, 'A'),
('350', 'TOTH KAROLYNE', 'DOMB U. 6.', 'BUDAPEST', 'MAGYAR', '1260', NULL, 'A');




