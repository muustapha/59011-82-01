
1_
SELECT`IdClient`, `NomClient`, `VilleClient` 
FROM`clients`

2_
SELECT SELECT `IdProduit`, `NomProduit` 
FROM `produits` 
WHERE CouleurProduit = "Rouge" && PoidsProduit>2000

3_
SELECT  NomRepres FROM `representants` r 
INNER JOIN ventes v 
ON r.IdRepres = v.IdRepres 
WHERE Quantite >= 1 
ORDER BY NomRepres ASC; 


4_
SELECT NomClient 
FROM clients c 
INNER JOIN ventes v 
ON c.IdClient = v.IdClient 
INNER JOIN produits p 
ON v.IdProduit = p.IdProduit 
WHERE villeclient = "Paris" && Quantite > 180 GROUP BY v.idProduit; 

5_
SELECT NomRepres, NomClient 
FROM clients c 
INNER JOIN ventes v 
ON c.IdClient = v.IdClient 
INNER JOIN representants r 
ON v.IdRepres = r.IdRepres 
INNER JOIN produits p 
ON v.IdProduit = p.IdProduit 
WHERE CouleurProduit = "rouge" && Quantite>100 
GROUP BY NomRepres; 


6_

SELECT Nomproduit,Quantite 
FROM produits p 
LEFT JOIN ventes v 
on p.idProduit = v.IdProduit; 

7_
SELECT NomClient
FROM clients c
INNER JOIN ventes v 
on c.IdClient = v.IdClient
WHERE  Quantite > (SELECT AVG (Quantite)FROM ventes);

8_

CREATE VIEW Clients_ventes as 
SELECT c.IdClient, c.NomClient, c.VilleClient,v.IdVente, v.IdRepres, v.IdProduit, v.Quantite 
FROM clients as c 
INNER JOIN ventes as v 
ON c.IdClient=v.IdClient; 
