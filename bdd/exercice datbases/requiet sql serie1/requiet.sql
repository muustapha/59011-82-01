1 select
    *
from
    employee
2 select
    name
from
    department;

3 select
    last_name,
    hiring_date,
    superior_id,
    salary
from
    employee;

4 select
    title
from
    employee;

5 select
    distinct title
from
    employee;

6 select
    *
 from
    employee
where
    salary > 2500
7 select
    last_name,
    id,
    department_id
from
    employee
where
    title = 'secrétaire'
8 select
    name,
    department_id
from
    employee,
    department
where
    department_id > 40
9 select
    last_name,
    first_name
from
    employee
order by
    last_name 'représentant'
    and department_id = 35
    and salary > 20000
10 select
    last_name,
    title,
    salary
from
    employee
where
    title like 'représentant'
    or title like 'président'
11 select
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
12 select
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
13 select
    last_name,
    salary
from
    employee
where
    salary >= 20000
    and salary <= 30000
14 select
    last_name
from
    employee
where
    last_name like 'h%';

15 select
    last_name
from
    employee
where
    last_name like '%n';

16 select
    last_name
from
    employee
where
    last_name like '__u%';

17 select
    salary,
    last_name
from
    employee
where
    department_id = 41
order by
    salary;

18 select
    salary,
    last_name
from
    employee
where
    department_id = 41
order by
    salary desc;

19 select
    title,
    salary,
    last_name
from
    employee
order by
    title asc,
    salary desc;

20 select
    commission_rate,
    salary,
    last_name
from
    employee
order by
    commission_rate asc;

21 select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate is null
22 select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate is not null
23 select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate < 15
24 select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
where
    commission_rate > 15
25 select
    last_name,
    salary,
    commission_rate,
    title
from
    employee
26 SELECT
    last_name,
    salary,
    commission_rate,
    (salary * commission_rate) as commission
FROM
    employee
WHERE
    commission_rate IS NOT NULL;

27 SELECT
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

28 select
    concat (last_name, ' ', first_name) as nom_prénom
from
    employee;

29 SELECT
    SUBSTR(last_name, 0, 6) as cinq_premiere_lettres
FROM
    employee
30 select
    last_name,
    position ('r' in last_name) as rang_de_le_lettre_r
from
    employee;

31 select
    last_name,
    upper(last_name),
    lower(last_name)
from
    employee
where
    last_name = 'vrante'
    
32 select
    last_name,
    length(last_name)
from
    employee

    