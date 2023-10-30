
l. Affichez l'ancienneté des clients.
SELECT `nomClient`,floor(datediff(now(), `dateEntreeClient`)/365) as anciennete FROM `clients` ORDER by anciennete
SELECT `nomClient`,round(datediff(now(), `dateEntreeClient`)/365) as anciennete FROM `clients` ORDER by anciennete
SELECT idClient, nomClient, prenomClient, TIMESTAMPDIFF(YEAR, dateEntreeClient, CURRENT_TIMESTAMP) AS Anciennete FROM Clients;



i. Affichez les noms des clients qui commencent par « t » ou qui ont un « l » en troisième position.
SELECT `nomClient` FROM `clients` WHERE `nomClient` like "__l%" or "t%"
SELECT `nomClient` FROM `clients` WHERE substring(`nomClient`,1,1) ="t" or substring(`nomClient`,3,1) ="l"
SELECT `nomClient` FROM `clients` WHERE nomClient like "t%" or substring(`nomClient`,3,1) ="l"