-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 11 oct. 2023 à 12:12
-- Version du serveur : 5.7.36
-- Version de PHP : 8.1.0

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
CREATE DATABASE IF NOT EXISTS `villedb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `villedb`;

-- --------------------------------------------------------

--
-- Structure de la table `ville`
--

DROP TABLE IF EXISTS `ville`;
CREATE TABLE IF NOT EXISTS `ville` (
  `idville` int(50) NOT NULL AUTO_INCREMENT,
  `nomVille` varchar(50) NOT NULL,
  `codePostal` varchar(5) NOT NULL,
  `superficie` int(50) NOT NULL,
  `nbrHabitant` int(50) NOT NULL,
  PRIMARY KEY (`idville`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ville`
--

INSERT INTO `ville` (`idville`, `nomVille`, `codePostal`, `superficie`, `nbrHabitant`) VALUES(1, 'lyon', '69000', 100000, 10000000);
INSERT INTO `ville` (`idville`, `nomVille`, `codePostal`, `superficie`, `nbrHabitant`) VALUES(2, 'paris', '75000', 200000, 60000000);
INSERT INTO `ville` (`idville`, `nomVille`, `codePostal`, `superficie`, `nbrHabitant`) VALUES(3, 'lille', '59000', 9000, 6000000);
INSERT INTO `ville` (`idville`, `nomVille`, `codePostal`, `superficie`, `nbrHabitant`) VALUES(4, 'nice', '06000', 50000, 750000);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
