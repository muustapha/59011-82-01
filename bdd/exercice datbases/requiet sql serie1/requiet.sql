select * from employee

select name from department;

select last_name,hiring_date,superior_id,salary  from employee;

select title from employee;

select distinct title from employee;

select * from employee
where salary>2500

select last_name,id,department_id from employee
where title='secrétaire' 

select name,department_id from employee,department
where department_id >40

select last_name,first_name from employee