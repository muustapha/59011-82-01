-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 11 oct. 2023 à 19:14
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `villedb`
--

-- --------------------------------------------------------

--
-- Structure de la table `ville`
--

DROP TABLE IF EXISTS `ville`;
CREATE TABLE IF NOT EXISTS `ville` (
  `idVille` int NOT NULL AUTO_INCREMENT,
  `nomVille` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `codePostal` varchar(5) NOT NULL,
  `superficie` int NOT NULL,
  `nbHabitant` int NOT NULL,
  PRIMARY KEY (`idVille`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `ville`
--

INSERT INTO `ville` (`idVille`, `nomVille`, `codePostal`, `superficie`, `nbHabitant`) VALUES(1, 'Lyon', '69000', 4787000, 100000);
INSERT INTO `ville` (`idVille`, `nomVille`, `codePostal`, `superficie`, `nbHabitant`) VALUES(2, 'Paris', '75000', 10600000, 5555);
INSERT INTO `ville` (`idVille`, `nomVille`, `codePostal`, `superficie`, `nbHabitant`) VALUES(3, 'Lille', '59000', 3481000, 4445);
INSERT INTO `ville` (`idVille`, `nomVille`, `codePostal`, `superficie`, `nbHabitant`) VALUES(4, 'Nice', '06000', 7192000, 22556);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
