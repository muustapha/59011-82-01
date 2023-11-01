-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 25 oct. 2023 à 14:34
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
-- Base de données : `exercice4`
--
CREATE DATABASE IF NOT EXISTS `exercice4` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `exercice4`;

DELIMITER $$
--
-- Procédures
--
DROP PROCEDURE IF EXISTS `augmentations`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `augmentations` (IN `prime` INT)   UPDATE employe set sala=(sala+prime)$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `departement`
--

DROP TABLE IF EXISTS `departement`;
CREATE TABLE IF NOT EXISTS `departement` (
  `noDep` int(11) NOT NULL,
  `nomDep` varchar(20) DEFAULT NULL,
  `ville` varchar(20) NOT NULL,
  PRIMARY KEY (`noDep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `departement`
--

INSERT INTO `departement` (`noDep`, `nomDep`, `ville`) VALUES(10, 'formation', 'Aix');
INSERT INTO `departement` (`noDep`, `nomDep`, `ville`) VALUES(20, 'ingenierie', 'PAris');
INSERT INTO `departement` (`noDep`, `nomDep`, `ville`) VALUES(30, 'industrie', 'Bordeaux');
INSERT INTO `departement` (`noDep`, `nomDep`, `ville`) VALUES(40, 'direction generale', 'Paris');

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

DROP TABLE IF EXISTS `employe`;
CREATE TABLE IF NOT EXISTS `employe` (
  `noEmp` int(11) NOT NULL,
  `nomEmp` varchar(20) DEFAULT NULL,
  `fonction` varchar(20) NOT NULL,
  `noResp` varchar(40) DEFAULT NULL,
  `datemb` date DEFAULT NULL,
  `sala` int(15) DEFAULT NULL,
  `comm` varchar(14) DEFAULT NULL,
  `noDep` int(11) DEFAULT NULL,
  PRIMARY KEY (`noEmp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `employe`
--

INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(1, 'constanza', 'psychologue', '8', '1994-10-19', 1790, '200€', 30);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(2, 'mioche', 'directeur', '6', '1990-03-15', 2200, '1000', 20);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(3, 'durand', 'responsable', '2', '1996-04-18', 3250, '', 10);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(4, 'xiong', 'vendeur', '5', '1994-12-15', 1150, '200', 30);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(5, 'manoukian', 'vendeur', '5', '1993-08-15', 2530, '500', 30);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(6, 'bourdais', 'directeur', '15', '2002-07-12', 3550, '850', 40);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(7, 'moreno', 'ouvrier', '3', '1999-05-05', 1075, '50', 10);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(8, 'perou', 'directeur', '2', '1995-07-05', 2450, '800', 10);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(9, 'bibaut', 'chef de service', '8', '1993-06-07', 2200, '', 20);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(10, 'manian', 'assistant', '9', '1996-10-18', 1000, '250', 10);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(11, 'colin', 'analyste', '2', '1992-07-05', 2703, '625', 30);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(12, 'coulon', 'ouvrier', '8', '2002-09-18', 585, '125', 20);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(13, 'roméo', 'assitant', '8', '2001-08-16', 1025, '1150', 10);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(14, 'solal', '', 'secrétaire', '1992-02-15', 1225, '', 20);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(15, 'bailly', 'président', '', '1985-01-05', 4275, '2000', 40);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(16, 'jazarin', 'ouvrier', '2', '2001-07-05', 875, '', 10);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(17, 'font', 'ouvrier', '2', '1990-08-04', 1200, '250', 10);
INSERT INTO `employe` (`noEmp`, `nomEmp`, `fonction`, `noResp`, `datemb`, `sala`, `comm`, `noDep`) VALUES(18, 'servel', 'ouvrier', '3', '1998-12-02', 1025, '55', 30);

-- --------------------------------------------------------

--
-- Structure de la table `grade`
--

DROP TABLE IF EXISTS `grade`;
CREATE TABLE IF NOT EXISTS `grade` (
  `noGrade` int(11) NOT NULL,
  `salMax` float DEFAULT NULL,
  `salMin` float NOT NULL,
  PRIMARY KEY (`noGrade`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `grade`
--

INSERT INTO `grade` (`noGrade`, `salMax`, `salMin`) VALUES(1, 1000, 0);
INSERT INTO `grade` (`noGrade`, `salMax`, `salMin`) VALUES(2, 2000, 1000.01);
INSERT INTO `grade` (`noGrade`, `salMax`, `salMin`) VALUES(3, 3000, 2000.01);
INSERT INTO `grade` (`noGrade`, `salMax`, `salMin`) VALUES(4, 4000, 3000.01);
INSERT INTO `grade` (`noGrade`, `salMax`, `salMin`) VALUES(5, 5000, 4000.01);
INSERT INTO `grade` (`noGrade`, `salMax`, `salMin`) VALUES(6, 6000, 5000.01);

-- --------------------------------------------------------

--
-- Structure de la table `histofonction`
--

DROP TABLE IF EXISTS `histofonction`;
CREATE TABLE IF NOT EXISTS `histofonction` (
  `idHistoFonction` int(11) NOT NULL AUTO_INCREMENT,
  `noEmp` int(11) DEFAULT NULL,
  `dateNom` date DEFAULT NULL,
  `fonction` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idHistoFonction`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `histofonction`
--

INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(1, 1, '1994-10-19', 'vendeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(2, 1, '1996-12-18', 'psychologue');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(3, 2, '1990-03-12', 'responsable');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(4, 2, '1994-10-18', 'directeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(5, 3, '1996-04-18', 'vendeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(6, 3, '1998-06-18', 'respopnsable');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(7, 4, '1994-12-15', 'vendeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(8, 5, '1993-08-15', 'vendeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(9, 6, '2002-07-12', 'directeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(10, 7, '1999-05-05', 'ouvrier');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(11, 8, '1995-07-05', 'vendeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(12, 8, '1997-04-15', 'responsable ');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(13, 8, '1999-10-18', 'directeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(14, 10, '1996-10-18', 'assistant');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(15, 11, '1992-07-05', 'vendeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(16, 11, '1995-07-15', 'responsable');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(17, 11, '1999-05-19', 'analyste');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(18, 12, '2002-09-18', 'ouvrier');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(19, 13, '2001-08-16', 'ouvrier');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(20, 13, '2003-07-17', 'assistant');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(21, 14, '1992-01-02', 'secrétaire');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(22, 15, '1985-01-05', 'directeur');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(23, 15, '1995-10-05', 'président');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(24, 16, '2001-07-05', 'ouvrier');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(25, 17, '1990-08-04', 'ouvrier');
INSERT INTO `histofonction` (`idHistoFonction`, `noEmp`, `dateNom`, `fonction`) VALUES(26, 18, '1998-12-02', 'ouvrier');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
