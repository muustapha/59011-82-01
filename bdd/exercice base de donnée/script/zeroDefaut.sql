CREATE TABLE produit(
   Id_produit COUNTER,
   modèle_associé VARCHAR(50),
   numéro_série INT,
   numero_max VARCHAR(50),
   année_production DATE,
   PRIMARY KEY(Id_produit)
);

CREATE TABLE faute(
   Id_faute COUNTER,
   code_unique VARCHAR(50),
   titre VARCHAR(50),
   date_détection DATE,
   commentaire VARCHAR(50),
   date_réparation DATE,
   Id_produit INT NOT NULL,
   PRIMARY KEY(Id_faute),
   FOREIGN KEY(Id_produit) REFERENCES produit(Id_produit)
);

CREATE TABLE categorie(
   Id_categorie COUNTER,
   nomCatégorie VARCHAR(50),
   descriptionCatégorie VARCHAR(50),
   nomSousCatégorie VARCHAR(50),
   descriptionSous_Catégorie VARCHAR(50),
   PRIMARY KEY(Id_categorie)
);

CREATE TABLE modele(
   Id_modele COUNTER,
   code INT,
   nom VARCHAR(50),
   date_mise_sur_le_marché DATE,
   PRIMARY KEY(Id_modele)
);

CREATE TABLE classifier(
   Id_faute INT,
   Id_categorie INT,
   PRIMARY KEY(Id_faute, Id_categorie),
   
);

CREATE TABLE base(
   Id_produit INT,
   Id_modele INT,
   PRIMARY KEY(Id_produit, Id_modele),

);

CREATE TABLE fait_partie(
   Id_categorie INT,
   Id_categorie_1 INT,
   PRIMARY KEY(Id_categorie, Id_categorie_1),
);


ALTER TABLE faute ADD CONSTRAINT FK_faute__produit FOREIGN KEY(id_produit) REFERENCES produit(id_produit);
ALTER TABLE base 
ADD CONSTRAINT FK_basé_modele FOREIGN KEY(id_modele) REFERENCES modele(id_modele),
ADD CONSTRAINT FK_basé_produit FOREIGN KEY(id_produit) REFERENCES produit(id_produit),
ALTER TABLE concerne
ADD CONSTRAINT FK_concerne_produit FOREIGN KEY(id_produit) REFERENCES produit(id_produit),
ADD CONSTRAINT FK_concerne_faute FOREIGN KEY(id_faute) REFERENCES faute(id_faute);
ALTER TABLE classifié 
ADD CONSTRAINT FK_classifié_faute FOREIGN KEY(id_faute) REFERENCES faute(id_faute),
ADD CONSTRAINT FK_classifié_catégorie FOREIGN KEY(id_catégorie) REFERENCES catégorie(id_catégorie),
ALTER TABLE fait_partie
ADD CONSTRAINT FK_fait_partie FOREIGN KEY(id_categorie)REFERENCES categorie(id_catégorie),
alter table