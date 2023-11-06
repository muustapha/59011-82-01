DROP DATABASE IF EXISTS camping;
CREATE DATABASE camping DEFAULT CHARACTER SET Utf8;

Use camping;
CREATE TABLE client(
   Id_client COUNTER,
   nom VARCHAR(50),
   prénom VARCHAR(50),
   adresse VARCHAR(50),
   numeroTelephone VARCHAR(50),
   adresseElectronique VARCHAR(50),
   PRIMARY KEY(Id_client)
) ENGINE = InnoDB;

CREATE TABLE typage(
   Id_type COUNTER,
   vide VARCHAR(50),
   mobileHome VARCHAR(50),
   caravane VARCHAR(50),
   PRIMARY KEY(Id_type)
) ENGINE = InnoDB;

CREATE TABLE emplacement(
   Id_emplacement COUNTER,
   numéro VARCHAR(50),
   alOmbre LOGICAL,
   raccElectricite LOGICAL,
   zone VARCHAR(50),
   Id_type INT NOT NULL,
   PRIMARY KEY(Id_emplacement),
   
) ENGINE = InnoDB;

CREATE TABLE activité(
   Id_activité COUNTER,
   typeActivité VARCHAR(50),
   payante LOGICAL,
   zone VARCHAR(50),
   PRIMARY KEY(Id_activité)
) ENGINE = InnoDB;

CREATE TABLE paye(
   Id_emplacement INT,
   acompte VARCHAR(50),
   périodeAnnée VARCHAR(50),
   nombrePoint INT,
   Id_client INT NOT NULL,
   PRIMARY KEY(Id_emplacement),
   
) ENGINE = InnoDB;

CREATE TABLE participe(
   Id_client INT,
   Id_activité INT,
   PRIMARY KEY(Id_client, Id_activité),
  
) ENGINE = InnoDB;

CREATE TABLE reserve(
   Id_emplacement INT,
   dateDebut DATE,
   dateFin DATE,
   optionSouhaitees VARCHAR(50),
   dateReservation VARCHAR(50),
   annulee LOGICAL,
   Id_client INT NOT NULL,
   PRIMARY KEY(Id_emplacement),
   
) ENGINE = InnoDB;



ALTER TABLE
emplacement
ADD
    CONSTRAINT FK_emplacement_typage FOREIGN KEY(Id_type) REFERENCES typage(Id_type);


ALTER TABLE
    paye
ADD
    CONSTRAINT FK_paye_emplacement FOREIGN KEY(Id_emplacement) REFERENCES emplacement(Id_emplacement),
ADD
    CONSTRAINT FK_paye_client FOREIGN KEY(Id_client) REFERENCES client(Id_client);

ALTER TABLE
    participe
ADD
    CONSTRAINT FK_participe_client FOREIGN KEY(Id_client) REFERENCES client(Id_client),
ADD
    CONSTRAINT FK_participe_activité FOREIGN KEY(Id_activité) REFERENCES activité(Id_activité);
ALTER TABLE
    reserve
ADD
    CONSTRAINT FK_reserve_emplacement FOREIGN KEY(Id_emplacement) REFERENCES emplacement(Id_emplacement),
ADD
    CONSTRAINT FK_reserve_client FOREIGN KEY(Id_client) REFERENCES client(Id_client);
