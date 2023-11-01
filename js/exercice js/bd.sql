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









SELECT s.name, COUNT(r.id) AS Nbr_of_room
FROM room r
join hotel h ON r.hotel_id = h.id
join station s on h.id_station = s.id
GROUP BY
station s;

SELECT s.name, COUNT(r.id) AS Nbr_of_room
FROM room r
join hotel h ON r.hotel_id = h.id
join station s on h.id_station = s.id
where r.capacity>1
GROUP BY
s.name;


SELECT h.name
FROM hotel h
join room r ON h.id = r.hotel_id
join booking b on r.id = b.room_id
where b.client_id='squire'

select  s.name, avg(stay_end_date-stay_start_date)as duree_moyenne
FROM station s
JOIN hotel h ON s.id = h.id_station
JOIN room r ON h.id = r.hotel_id
JOIN booking b ON r.id = b.room_id
GROUP BY station;
