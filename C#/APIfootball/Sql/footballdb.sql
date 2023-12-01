DROP DATABASE [IF EXISTS] footballDb;
CREATE DATABASE IF NOT EXISTS `footballDb`;
USE `footballDb`;


DROP TABLE IF EXISTS `arbitres`;
CREATE TABLE IF NOT EXISTS `arbitres` (
  `idArbitre` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Age` int(11) NOT NULL,
  `Poste` varchar(50) NOT NULL,
  `IdPartita` int(11) NOT NULL,
  PRIMARY KEY (`idArbitre`),
  KEY `IdPartita` (`IdPartita`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `arbitres`
--

INSERT INTO `arbitres` (`idArbitre`, `Nom`, `Prenom`, `Age`, `Poste`, `IdPartita`) VALUES
(1, 'Smith', 'John', 42, 'Arbitre principal', 2),
(2, 'Garcia', 'Maria', 30, 'Arbitre assistant', 1),
(3, 'Müller', 'Hans', 38, 'Arbitre principal', 3);

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
  `IdPartita` int(11) NOT NULL,
  PRIMARY KEY (`IdEquipe`),
  KEY `IdPartita` (`IdPartita`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `equipes`
--

INSERT INTO `equipes` (`IdEquipe`, `Nom`, `Ville`, `Pays`, `StadePrincipal`, `SiteWeb`, `IdPartita`) VALUES
(1, 'Paris Saint-Germain', 'Paris', 'France', 'Parc des Princes', 'https://www.psg.fr', 1),
(2, 'Olympique Lyonnais', 'Lyon', 'France', 'Groupama Stadium', 'https://www.ol.fr', 2),
(3, 'Olympique de Marseille', 'Marseille', 'France', 'Stade Vélodrome', 'https://www.om.net', 3),
(4, 'Real Madrid', 'Madrid', 'Espagne', 'Santiago Bernabéu', 'https://www.realmadrid.com', 1),
(5, 'Manchester City', 'Manchester', 'Angleterre', 'Etihad Stadium', 'https://www.mancity.com', 2),
(6, 'Inter Miami', 'Miami', 'États-Unis', 'DRV PNK Stadium', 'https://www.intermiamicf.com', 3),
(7, 'Al-Nassr', 'Riyad', 'Arabie saoudite', 'Stade Roi Fahd', 'https://www.alnassrclub.com', 4);

-- --------------------------------------------------------

--
-- Structure de la table `joueurs`
--

DROP TABLE IF EXISTS `joueurs`;
CREATE TABLE IF NOT EXISTS `joueurs` (
  `idJoueur` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Age` int(11) NOT NULL,
  `Poste` varchar(50) NOT NULL,
  `nationalite` varchar(50) NOT NULL,
  PRIMARY KEY (`idJoueur`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `joueurs`
--

INSERT INTO `joueurs` (`idJoueur`, `Nom`, `Prenom`, `Age`, `Poste`, `nationalite`) VALUES
(1, 'Ronaldo', 'Cristiano', 36, 'Attaquant', 'Portugal'),
(2, 'Mbappe', 'Kylian', 23, 'Attaquant', 'France'),
(3, 'Hakimi', 'Achraf', 25, 'Défenseur', 'Maroc'),
(4, 'De Bruyne', 'Kevin', 30, 'Milieu de terrain', 'Belgique'),
(5, 'Messi', 'Lionel', 34, 'Attaquant', 'Argentine'),
(6, 'Marquinhos', '', 27, 'Défenseur', 'Brésil'),
(8, 'Ousmane', 'Dembélé', 24, 'Attaquant', 'France'),
(9, 'Gianluigi', 'Donnarumma', 22, 'Gardien de but', 'Italie'),
(10, 'Lucas', 'Hernández', 25, 'Défenseur', 'France'),
(11, 'Danilo', 'Pereira', 32, 'Milieu de terrain', 'Portugal'),
(12, 'Lee', 'Kang-in', 21, 'Milieu de terrain', 'Corée du Sud'),
(13, 'Laporte', 'Aymeric', 29, 'Défenseur', 'Espagnol'),
(14, 'Fofana', 'Sékou', 28, 'Milieu de terrain', 'Français'),
(15, 'Telles', 'Alex', 30, 'Défenseur', 'Brésilien'),
(16, 'Mane', 'Sadio', 31, 'Attaquant', 'Sénégalais'),
(17, 'Haaland', 'Erling', 23, 'Attaquant', 'Norvégien'),
(18, 'Foden', 'Phil', 23, 'Milieu de terrain', 'Anglais'),
(19, 'Gomez', 'Sergio', 23, 'Milieu de terrain', 'Espagnol');

-- --------------------------------------------------------

--
-- Structure de la table `partita`
--

DROP TABLE IF EXISTS `partita`;
CREATE TABLE IF NOT EXISTS `partita` (
  `IdPartita` int(11) NOT NULL AUTO_INCREMENT,
  `DateHeure` datetime(6) NOT NULL,
  `ligue` varchar(50) NOT NULL,
  `VideoAssitance` tinyint(1) NOT NULL,
  `Score` varchar(50) NOT NULL,
  PRIMARY KEY (`IdPartita`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `partita`
--

INSERT INTO `partita` (`IdPartita`, `DateHeure`, `ligue`, `VideoAssitance`, `Score`) VALUES
(1, '2023-11-28 21:00:00.000000', 'Championleague', 1, '0'),
(2, '2023-11-28 21:00:00.000000', 'Championleague', 1, '2'),
(3, '2023-11-29 21:00:00.000000', 'Championleague', 1, '-1'),
(4, '2023-11-29 21:00:00.000000', 'Championleague', 1, '6'),
(5, '2023-12-13 21:00:00.000000', 'Championleague', 1, '0'),
(6, '2023-12-13 21:00:00.000000', 'Championleague', 1, '-3'),
(7, '2023-12-12 21:00:00.000000', 'Championleague', 1, '0');

-- --------------------------------------------------------

--
-- Structure de la table `relation`
--

DROP TABLE IF EXISTS `relation`;
CREATE TABLE IF NOT EXISTS `relation` (
  `IdRelation` int(11) NOT NULL AUTO_INCREMENT,
  `IdEquipe` int(11) NOT NULL,
  `IdJoueur` int(11) NOT NULL,
  `DateDebutContract` date NOT NULL,
  `NumeroDeMaillot` int(11) NOT NULL,
  `Salaire` int(11) NOT NULL,
  PRIMARY KEY (`IdRelation`),
  KEY `IdEquipe` (`IdEquipe`,`IdJoueur`),
  KEY `IdJoueur` (`IdJoueur`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `relation`
--

INSERT INTO `relation` (`IdRelation`, `IdEquipe`, `IdJoueur`, `DateDebutContract`, `NumeroDeMaillot`, `Salaire`) VALUES
(1, 1, 2, '2018-08-09', 7, 6000000),
(2, 1, 3, '2021-11-13', 2, 1083000),
(3, 1, 6, '2013-08-19', 5, 780000),
(4, 1, 8, '2020-11-15', 10, 1666666),
(5, 1, 9, '2023-08-05', 1, 916000),
(6, 1, 10, '2020-11-07', 21, 871000),
(7, 1, 11, '2023-08-17', 15, 108000),
(8, 1, 12, '2023-08-03', 8, 100000),
(9, 7, 13, '2023-11-29', 3, 1400000),
(10, 7, 14, '2023-11-29', 7, 1000000),
(11, 7, 15, '2023-11-29', 6, 1100000),
(12, 7, 16, '2023-11-29', 9, 1600000),
(13, 7, 1, '2023-11-29', 10, 9000000),
(14, 5, 17, '2023-11-29', 9, 1800000),
(15, 5, 18, '2023-11-29', 47, 1200000),
(16, 5, 4, '2023-11-29', 47, 1200000),
(17, 5, 19, '2023-11-29', 21, 1300000);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `arbitres`
--
ALTER TABLE `arbitres`
  ADD CONSTRAINT `arbitres_ibfk_1` FOREIGN KEY (`IdPartita`) REFERENCES `partita` (`IdPartita`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `equipes`
--
ALTER TABLE `equipes`
  ADD CONSTRAINT `equipes_ibfk_1` FOREIGN KEY (`IdPartita`) REFERENCES `partita` (`IdPartita`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `relation`
--
ALTER TABLE `relation`
  ADD CONSTRAINT `relation_ibfk_1` FOREIGN KEY (`IdJoueur`) REFERENCES `joueurs` (`idJoueur`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `relation_ibfk_2` FOREIGN KEY (`IdEquipe`) REFERENCES `equipes` (`IdEquipe`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
