select *
from employee,department;

select *
from employee e 
join department d
on e.department_id=d.id;


select e.last_name as "nom_employé",
e.department_id as "nb_of_dep",
d.name as "dep"
from employee e
JOIN department d on e.department_id = d.id 
order by department_id ;

select last_name
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

ALTER TABLE public.employee ALTER COLUMN superior_id TYPE int USING superior_id::int;
