#Esta primera ya estaba hecha por defecto

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `dept_emp_latest_date` AS 
select `dept_emp`.`emp_no` AS `emp_no`,max(`dept_emp`.`from_date`) AS `from_date`,max(`dept_emp`.`to_date`) AS `to_date` 
from `dept_emp` group by `dept_emp`.`emp_no`;

#////////////////////////////////////////////////////////////////////////////

CREATE VIEW current_deptemp AS
SELECT latest_date.emp_no AS emp_no, employees.first_name AS first_name, employees.last_name AS last_name, dept_emp.dept_no AS dept_no, 
latest_date.from_date AS from_date, latest_date.to_date AS to_date
FROM dept_emp JOIN dept_emp_latest_date AS latest_date JOIN employees
ON dept_emp.emp_no = latest_date.emp_no AND latest_date.emp_no = employees.emp_no AND dept_emp.from_date = latest_date.from_date
AND latest_date.to_date = dept_emp.to_date;

#/////////////////////////////////////////////////////////////////////////////

CREATE VIEW current_titles AS
SELECT latest_date.emp_no, employees.first_name, employees.last_name, titles.title, latest_date.from_date, latest_date.to_date
FROM titles JOIN (SELECT emp_no, MAX(from_date) AS from_date, MAX(to_date) AS to_date 
FROM titles GROUP BY emp_no) as latest_date JOIN employees
ON titles.emp_no = latest_date.emp_no AND latest_date.emp_no = employees.emp_no
AND titles.from_date = latest_date.from_date AND titles.to_date = latest_date.to_date;

#//////////////////////////////////////////////////////////////////////////////



CREATE VIEW current_salaries AS
SELECT latest_date.emp_no, employees.first_name, employees.last_name, salaries.salary, latest_date.from_date, latest_date.to_date
FROM salaries JOIN (SELECT emp_no, MAX(from_date) AS from_date, MAX(to_date) AS to_date
FROM salaries GROUP BY emp_no) AS latest_date JOIN employees
ON salaries.emp_no = latest_date.emp_no AND latest_date.emp_no = employees.emp_no
AND salaries.from_date = latest_date.from_date AND salaries.to_date = latest_date.to_date;


#//////////////////////////////////////////////////////////////////////////////


CREATE VIEW current_managers AS
SELECT dept_manager.emp_no, employees.first_name, employees.last_name, latest_date.dept_no, latest_date.from_date, latest_date.to_date
FROM dept_manager JOIN (SELECT dept_no, MAX(from_date) AS from_date, MAX(to_date) AS to_date
FROM dept_manager GROUP BY dept_no) AS latest_date JOIN employees
ON dept_manager.dept_no = latest_date.dept_no AND dept_manager.emp_no = employees.emp_no
AND dept_manager.from_date = latest_date.from_date AND dept_manager.to_date = latest_date.to_date;



