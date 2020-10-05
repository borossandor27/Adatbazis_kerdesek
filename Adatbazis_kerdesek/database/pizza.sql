-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Okt 04. 21:55
-- Kiszolgáló verziója: 10.1.36-MariaDB
-- PHP verzió: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `pizza2`
--
CREATE DATABASE IF NOT EXISTS `pizza2` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `pizza2`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pfutar`
--

CREATE TABLE `pfutar` (
  `fazon` int(11) NOT NULL,
  `fnev` varchar(25) NOT NULL DEFAULT '',
  `ftel` varchar(12) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `pfutar`
--

INSERT INTO `pfutar` (`fazon`, `fnev`, `ftel`) VALUES
(1, 'Hurrikán', '123456'),
(2, 'Gyalogkakukk', '666666'),
(3, 'Gömbvillám', '888888'),
(4, 'Szélvész', '258369'),
(5, 'Imperial', '987654');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ppizza`
--

CREATE TABLE `ppizza` (
  `pazon` int(11) NOT NULL,
  `pnev` varchar(15) NOT NULL DEFAULT '',
  `par` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `ppizza`
--

INSERT INTO `ppizza` (`pazon`, `pnev`, `par`) VALUES
(1, 'Capricciosa', 900),
(2, 'Frutti di Mare', 1100),
(3, 'Hawaii', 780),
(4, 'Vesuvio', 890),
(5, 'Sorrento', 990);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `prendeles`
--

CREATE TABLE `prendeles` (
  `razon` int(11) NOT NULL,
  `vazon` int(11) NOT NULL,
  `fazon` int(11) NOT NULL,
  `datum` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `prendeles`
--

INSERT INTO `prendeles` (`razon`, `vazon`, `fazon`, `datum`) VALUES
(1, 5, 4, '2020-04-23 16:15:24'),
(2, 3, 3, '2020-04-23 16:15:24'),
(3, 6, 2, '2020-04-23 16:15:24'),
(4, 5, 1, '2020-04-23 16:15:24'),
(5, 2, 4, '2020-04-23 16:15:24'),
(6, 1, 2, '2020-04-23 16:15:24'),
(7, 5, 3, '2020-04-23 16:15:24'),
(13, 5, 4, '2020-04-23 16:24:41'),
(14, 4, 1, '2020-04-23 16:24:41'),
(15, 3, 1, '2020-04-23 16:24:41'),
(16, 2, 3, '2020-04-23 16:24:41'),
(17, 1, 2, '2020-04-23 16:24:41');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ptetel`
--

CREATE TABLE `ptetel` (
  `razon` int(11) NOT NULL,
  `pazon` int(11) NOT NULL,
  `db` int(3) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `ptetel`
--

INSERT INTO `ptetel` (`razon`, `pazon`, `db`) VALUES
(1, 3, 2),
(2, 4, 1),
(2, 5, 1),
(3, 3, 1),
(3, 3, 2),
(3, 3, 1),
(3, 1, 1),
(4, 4, 2),
(4, 1, 2),
(4, 4, 1),
(4, 2, 1),
(5, 1, 1),
(5, 2, 2),
(5, 3, 2),
(5, 3, 1),
(6, 1, 2),
(6, 4, 2),
(6, 3, 1),
(7, 1, 2),
(7, 5, 2),
(13, 4, 2),
(13, 5, 2),
(13, 3, 1),
(14, 2, 1),
(14, 1, 2),
(14, 4, 1),
(14, 1, 2),
(15, 4, 2),
(15, 3, 1),
(16, 3, 1),
(16, 1, 2),
(16, 4, 2),
(17, 4, 1),
(17, 3, 1),
(17, 4, 2),
(17, 4, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pvevo`
--

CREATE TABLE `pvevo` (
  `vazon` int(11) NOT NULL,
  `vnev` varchar(30) NOT NULL DEFAULT '',
  `vcim` varchar(30) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `pvevo`
--

INSERT INTO `pvevo` (`vazon`, `vnev`, `vcim`) VALUES
(1, 'Hapci', ''),
(2, 'Vidor', ''),
(3, 'Tudor', ''),
(4, 'Kuka', ''),
(5, 'Szende', ''),
(6, 'Szundi', ''),
(7, 'Morgó', '');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `pfutar`
--
ALTER TABLE `pfutar`
  ADD PRIMARY KEY (`fazon`);

--
-- A tábla indexei `ppizza`
--
ALTER TABLE `ppizza`
  ADD PRIMARY KEY (`pazon`);

--
-- A tábla indexei `prendeles`
--
ALTER TABLE `prendeles`
  ADD PRIMARY KEY (`razon`);

--
-- A tábla indexei `ptetel`
--
ALTER TABLE `ptetel`
  ADD KEY `fk_REndeles` (`razon`),
  ADD KEY `fk_Pizza` (`pazon`);

--
-- A tábla indexei `pvevo`
--
ALTER TABLE `pvevo`
  ADD PRIMARY KEY (`vazon`),
  ADD UNIQUE KEY `vnev` (`vnev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `pfutar`
--
ALTER TABLE `pfutar`
  MODIFY `fazon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `ppizza`
--
ALTER TABLE `ppizza`
  MODIFY `pazon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `prendeles`
--
ALTER TABLE `prendeles`
  MODIFY `razon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT a táblához `pvevo`
--
ALTER TABLE `pvevo`
  MODIFY `vazon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `ptetel`
--
ALTER TABLE `ptetel`
  ADD CONSTRAINT `fk_Pizza` FOREIGN KEY (`pazon`) REFERENCES `ppizza` (`pazon`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_REndeles` FOREIGN KEY (`razon`) REFERENCES `prendeles` (`razon`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
