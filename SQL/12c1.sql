-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Sze 20. 09:18
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `12c1`
--
CREATE DATABASE IF NOT EXISTS `12c1` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `12c1`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `konyvek`
--

CREATE TABLE `konyvek` (
  `konyvAz` int(11) NOT NULL,
  `szerzo` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `cim` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `kiado` text COLLATE utf8_hungarian_ci NOT NULL,
  `megjelenes` date DEFAULT NULL,
  `oldalszam` int(11) DEFAULT NULL,
  `nettoAr` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `konyvek`
--

INSERT INTO `konyvek` (`konyvAz`, `szerzo`, `cim`, `kiado`, `megjelenes`, `oldalszam`, `nettoAr`) VALUES
(1, 'Gárdonyi Géza', 'Egri Csillagok', 'Móra', '2012-07-09', 550, 2300),
(2, 'Fekete István', 'Tüskevár', 'Móra', '2020-05-17', 302, 3390),
(3, 'Fekete István', 'Vuk', 'Kossuth', '2010-02-14', NULL, 2200),
(4, 'Móricz Zsigmond', 'Légy Jó Mindhalálig', 'Európa', '2010-02-14', 284, 1800),
(5, 'Molnár Ferenc', 'A Pál Utcai Fiúk', 'Kossuth', NULL, 216, 2150),
(6, 'Gárdonyi Géza', 'A Láthatatlan Ember', 'Móra', '2014-03-25', 328, 3900);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `konyvek`
--
ALTER TABLE `konyvek`
  ADD PRIMARY KEY (`konyvAz`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `konyvek`
--
ALTER TABLE `konyvek`
  MODIFY `konyvAz` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
