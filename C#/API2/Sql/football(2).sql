-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 29 nov. 2023 à 16:08
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `football`
--

-- --------------------------------------------------------

--
-- Structure de la table `arbitres`
--

DROP TABLE IF EXISTS `arbitres`;
CREATE TABLE IF NOT EXISTS `arbitres` (
  `idArbitre` int(5) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Age` int(5) NOT NULL,
  `Poste` varchar(50) NOT NULL,
  PRIMARY KEY (`idArbitre`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `arbitres`
--

INSERT INTO `arbitres` (`idArbitre`, `Nom`, `Prenom`, `Age`, `Poste`) VALUES
(1, 'Smith', 'John', 42, 'Arbitre principal'),
(2, 'Garcia', 'Maria', 30, 'Arbitre assistant'),
(3, 'Müller', 'Hans', 38, 'Arbitre principal');

-- --------------------------------------------------------

--
-- Structure de la table `equipes`
--

DROP TABLE IF EXISTS `equipes`;
CREATE TABLE IF NOT EXISTS `equipes` (
  `IdEquipe` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Ville` varchar(50) NOT NULL,
  `Pays` varchar(50) NOT NULL,
  `StadePrincipal` varchar(50) NOT NULL,
  `SiteWeb` char(50) NOT NULL,
  PRIMARY KEY (`IdEquipe`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `equipes`
--

INSERT INTO `equipes` (`IdEquipe`, `Nom`, `Ville`, `Pays`, `StadePrincipal`, `SiteWeb`) VALUES
(1, 'Paris Saint-Germain', 'Paris', 'France', 'Parc des Princes', 'https://www.psg.fr'),
(2, 'Olympique Lyonnais', 'Lyon', 'France', 'Groupama Stadium', 'https://www.ol.fr'),
(3, 'Olympique de Marseille', 'Marseille', 'France', 'Stade Vélodrome', 'https://www.om.net'),
(4, 'Real Madrid', 'Madrid', 'Espagne', 'Santiago Bernabéu', 'https://www.realmadrid.com'),
(5, 'Manchester City', 'Manchester', 'Angleterre', 'Etihad Stadium', 'https://www.mancity.com'),
(6, 'Inter Miami', 'Miami', 'États-Unis', 'DRV PNK Stadium', 'https://www.intermiamicf.com'),
(7, 'Al-Nassr', 'Riyad', 'Arabie saoudite', 'Stade Roi Fahd', 'https://www.alnassrclub.com');

-- --------------------------------------------------------

--
-- Structure de la table `joueurs`
--

DROP TABLE IF EXISTS `joueurs`;
CREATE TABLE IF NOT EXISTS `joueurs` (
  `idJoueur` int(5) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Age` int(50) NOT NULL,
  `Poste` varchar(50) NOT NULL,
  `nationalite` varchar(50) NOT NULL,
  PRIMARY KEY (`idJoueur`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `joueurs`
--

INSERT INTO `joueurs` (`idJoueur`, `Nom`, `Prenom`, `Age`, `Poste`, `nationalite`) VALUES
(1, 'Ronaldo', 'Cristiano', 36, 'Attaquant', 'Portugal'),
(2, 'Mbappe', 'Kylian', 23, 'Attaquant', 'France'),
(3, 'Hakimi', 'Achraf', 25, 'Défenseur', 'Maroc'),
(4, 'De Bruyne', 'Kevin', 30, 'Milieu de terrain', 'Belgique'),
(5, 'Messi', 'Lionel', 34, 'Attaquant', 'Argentine');

-- --------------------------------------------------------

--
-- Structure de la table `partita`
--

DROP TABLE IF EXISTS `partita`;
CREATE TABLE IF NOT EXISTS `partita` (
  `IdPartita` int(5) DEFAULT NULL,
  `Date` datetime(6) NOT NULL,
  `ligue` varchar(50) NOT NULL,
  `VideoAssistantReferees` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `relation`
--

DROP TABLE IF EXISTS `relation`;
CREATE TABLE IF NOT EXISTS `relation` (
  `IdRelation` int(11) NOT NULL AUTO_INCREMENT,
  `IdEquipe` int(11) NOT NULL,
  `IdJoueur` int(11) NOT NULL,
  `DateDebutContract` datetime(6) NOT NULL,
  `NumeroDeMaillot` int(11) NOT NULL,
  `Salaire` int(100) NOT NULL,
  PRIMARY KEY (`IdRelation`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
