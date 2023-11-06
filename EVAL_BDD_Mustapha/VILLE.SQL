1. SELECT ville_nom FROM villes_france WHERE LENGTH (ville_nom)<40;
2.SELECT departement_nom FROM `departements` WHERE departement_code LIKE "97%"; 
3.SELECT departement_nom FROM `departements` WHERE departement_regionId = 7 GROUP BY departement_nom; 
4.SELECT ville_nom ,departement_nom FROM villes_france v INNER JOIN departements d ON v.ville_departement = d.departement_id ORDER BY 'ville_population_2012' DESC
5.SELECT `departement_nom`,`departement_code`,`ville_commune` FROM departements d INNER JOIN villes_france v ON d.departement_id=v.`ville_departement` ORDER BY ville_commune DESC; 
6.SELECT `departement_nom` FROM departements d INNER JOIN villes_france v ON d.departement_id=v.`ville_departement` ORDER BY ville_surface DESC;
7.SELECT COUNT(`ville_nom`)FROM `villes_france` WHERE `ville_nom_reel` like"saint%"; 
8.
9.SELECT `ville_nom` FROM `villes_france` WHERE `ville_surface`> (SELECT AVG(ville_surface) FROM villes_france); 
10.SELECT departements.departement_nom, SUM(villes_france.ville_population_2012) AS population_totale FROM departements INNER JOIN villes_france ON departements.departement_id = villes_france.ville_departement GROUP BY departements.departement_nom HAVING SUM(villes_france.ville_population_2012) > 1500000
13.ALTER TABLE regions ADD COLUMN region_nbDepartement VARCHAR(15);
14.DROP PROCEDURE `MajRegion`; CREATE DEFINER=`root`@`localhost` PROCEDURE `MajRegion`(IN `update` INT) NOT DETERMINISTIC CONTAINS SQL SQL SECURITY DEFINER update regions set region_nbDepartement = ''  
15.CREATE VIEW villes_france_departements AS SELECT `ville_id`, `ville_departement`, `ville_slug`, `ville_nom`, `ville_nom_simple`, `ville_nom_reel`, `ville_nom_soundex`, `ville_nom_metaphone`, `ville_code_postal`, `ville_commune`, `ville_code_commune`, `ville_arrondissement`, `ville_canton`, `ville_amdi`, `ville_population_2010`, `ville_population_1999`, `ville_population_2012`, `ville_densite_2010`, `ville_surface`, `ville_longitude_deg`, `ville_latitude_deg`, `ville_longitude_grd`, `ville_latitude_grd`, `ville_longitude_dms`, `ville_latitude_dms`, `ville_zmin`, `ville_zmax`, `departement_id`, `departement_code`, `departement_nom`, `departement_nom_uppercase`, `departement_slug`, `departement_nom_soundex`, `departement_regionId`, `region_id`, `region_nom`, `region_nbDepartement` 
FROM villes_france v INNER JOIN departements d ON v.ville_departement = d.departement_id INNER JOIN regions r ON d.departement_regionId = r.region_id; 
