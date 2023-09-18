1 select *
from employee,department;

1 select *
from employee e 
join department d
on e.department_id=d.id;


2 select e.last_name as "nom_employé",
e.department_id as "nb_of_dep",
d.name as "dep"
from employee e
JOIN department d on e.department_id = d.id 
order by department_id ;

3 select last_name
from employee e 
join department d ON department_id =d.id 
where name like 'distribution';

 select e1.last_name as name_employee,
e1.salary as salary_employee,
e2.last_name as name_superior,
e2.salary as salary_superieur
from employee e1
join employee e2
ON e1.salary = e2.salary  
where e1.salary>e2.salary

 select*
from employee e1 
join employee e2
on e1.id = e2.superior_id

4 select e1.last_name as name_superior,
e1.salary as salary_superior,
e2.last_name as name_employee,
e2.salary as salary_employee
from employee e1
join employee e2
ON e1.id = e2.superior_id  
where e1.salary<e2.salary

 select title ,avg(salary)
from employee e 
group by title 

14select title ,count(id)
from employee e 
group by title 


16 SELECT title, COUNT(*)
FROM employee
GROUP BY title
HAVING count(*) > 2;

17 select substring(last_name,1,1) as initial, count(*)
from employee e 
group by initial 
having count(*)>=3

18 select avg(salary),sum(salary)
from employee e 
join department d ON d.id = e.department_id 
group by region_id


19 select  e.title
from employee e 
group by e.title


 20 select title ,count(*)
from employee e 
group by title 

21 select d.name,count(*) 
from department d 
group by d.name

22 select e.title,avg(salary)
from employee e 
group by title 
having avg(salary) > (select avg (salary) from employee e  where title='représentant' ); 

--title='représentant'
23 select count(salary) as nb_salary,count(commission_rate ) as nb_commission_rate
 from employee e 






SELECT s.name, COUNT(r.id) AS Nbr_of_room
FROM room r
join hotel h ON r.hotel_id = h.id
join station s on h.id_station = s.id
GROUP BY
s."name" ;

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
where b.client_id='Squire'

select  s.name, avg(stay_end_date-stay_start_date)as duree_moyenne
FROM station s
JOIN hotel h ON s.id = h.station_id
JOIN room r ON h.id = r.hotel_id
JOIN booking b ON r.id = b.room_id
GROUP BY s.name;