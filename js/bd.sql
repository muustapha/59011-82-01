-- Insérer au moins 2 stations
INSERT INTO stations (nom, adresse)
VALUES
    ('Station A',""),
    ('Station B', '');

-- Insérer au moins 2 hôtels par station
INSERT INTO hotels (nom,id_station,categorie ,adresse,city)
VALUES
    ('Hôtel Station A 1', 1, 3,"",""),
    ('Hôtel Station A 2', 1, 4,"",""),
    ('Hôtel Station B 1', 2, 2,"",""),
    ('Hôtel Station B 2', 2, 3,"","");

-- Insérer au moins 2 chambres par hôtel
INSERT INTO room (hotel_id,number,capacity,)
VALUES
    (101, 1, '', 150),
    (102, 1, '', 150),
    (201, 2, '', 250),
    (202, 2, '', 250),
    (101, 3, '', 100),
    (102, 3, '', 100),
    (201, 4, '', 175),
    (202, 4, '', 175);

-- Insérer au moins 2 clients
INSERT INTO clients (first_name, last_naname, city)
VALUES
    ('',"",""),
    ('',"",""),
    ('',"",""),
    ('',"","");







