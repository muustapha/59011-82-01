select
    *
from
    employee
select
    name
from
    department;

select
    last_name,
    hiring_date,
    superior_id,
    salary
from
    employee;

select
    title
from
    employee;

select
    distinct title
from
    employee;

select
    *
from
    employee
where
    salary > 2500
select
    last_name,
    id,
    department_id
from
    employee
where
    title = 'secrétaire'
select
    name,
    department_id
from
    employee,
    department
where
    department_id > 40
select
    last_name,
    first_name
from
    employee
order by
    last_name 'représentant'
    and department_id = 35
    and salary > 20000
select
    last_name,
    title,
    salary
from
    employee
where
    title like 'représentant'
    or title like 'président'
select
    last_name,
    title,
    department_id,
    salary
from
    employee
where
    department_id = 34
    and title like 'représentant'
    or title like 'président'
select
    last_name,
    title,
    department_id,
    salary
from
    employee
where
    title like 'représentant'
    or(
        title like 'secrétaire'
        and department_id = 34
    )
select
    last_name,
    salary
from
    employee
where
    salary >= 20000
    and salary <= 30000
select
    last_name
from
    employee
where
    last_name like 'h%';

select
    last_name
from
    employee
where
    last_name like '%n';

select
    last_name
from
    employee
where
    last_name like '__u%';

select
    salary,
    last_name
from
    employee
where
    department_id = 41
order by
    salary;

select
    salary,
    last_name
from
    employee
where
    department_id = 41
order by
    salary desc;

select
    title,
    salary,
    last_name
from
    employee
order by
    title asc,
    salary desc;

select
    commission_rate,
    salary,
    last_name
from
    employee
order by
    commission_rate asc;

select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate is null
select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate is not null
select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate < 15
select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate > 15
select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
SELECT
    last_name,
    salary,
    commission_rate,
    (salary * commission_rate) as commission
FROM
    employee
WHERE
    commission_rate IS NOT NULL;

SELECT
    last_name,
    salary,
    commission_rate,
    (salary * commission_rate) AS commission
FROM
    employee
WHERE
    commission_rate IS NOT null
order by
    commission_rate asc;

select
    concat (last_name, ' ', first_name) as nom_prénom
from
    employee;

SELECT
    SUBSTR(last_name, 0, 6) as cinq_premiere_lettres
FROM
    employee
select
    last_name,
    position ('r' in last_name) as rang_de_le_lettre_r
from
    employee;

select
    last_name,
    upper(last_name),
    lower(last_name)
from
    employee
where
    last_name = 'vrante'
    
select
    last_name,
    length(last_name)
from
    employee