#Las primeras dos vistas ya venían por defecto en la base de dato, pero fueron utilizadas en los triggers

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `dept_emp_latest_date` AS 
select `dept_emp`.`emp_no` AS `emp_no`,max(`dept_emp`.`from_date`) AS `from_date`,max(`dept_emp`.`to_date`) AS `to_date` 
from `dept_emp` group by `dept_emp`.`emp_no`;

#////////////////////////////////////////////////////////////////////////////

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `current_dept_emp` AS 
select `l`.`emp_no` AS `emp_no`,`d`.`dept_no` AS `dept_no`,`l`.`from_date` AS `from_date`,`l`.`to_date` AS `to_date` 
from (`dept_emp` `d` join `dept_emp_latest_date` `l` 
on(((`d`.`emp_no` = `l`.`emp_no`) and (`d`.`from_date` = `l`.`from_date`) and (`l`.`to_date` = `d`.`to_date`))));

#De aquí en adelante fueron hechas por nosotros 

CREATE VIEW current_titles AS
SELECT latest_date.emp_no, titles.title, latest_date.from_date, latest_date.to_date
FROM titles JOIN (SELECT emp_no, MAX(from_date) AS from_date, MAX(to_date) AS to_date 
FROM titles GROUP BY emp_no) as latest_date
ON titles.emp_no = latest_date.emp_no AND titles.from_date = latest_date.from_date AND titles.to_date = latest_date.to_date;

#//////////////////////////////////////////////////////////////////////////////



CREATE VIEW current_salaries AS
SELECT latest_date.emp_no, salaries.salary, latest_date.from_date, latest_date.to_date
FROM salaries JOIN (SELECT emp_no, MAX(from_date) AS from_date, MAX(to_date) AS to_date
FROM salaries GROUP BY emp_no) AS latest_date
ON salaries.emp_no = latest_date.emp_no AND salaries.from_date = latest_date.from_date AND salaries.to_date = latest_date.to_date;


#//////////////////////////////////////////////////////////////////////////////


CREATE VIEW current_managers AS
SELECT dept_manager.emp_no, latest_date.dept_no, latest_date.from_date, latest_date.to_date
FROM dept_manager JOIN (SELECT dept_no, MAX(from_date) AS from_date, MAX(to_date) AS to_date
FROM dept_manager GROUP BY dept_no) AS latest_date
ON dept_manager.dept_no = latest_date.dept_no AND dept_manager.from_date = latest_date.from_date AND dept_manager.to_date = latest_date.to_date;




