#////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#VISTA PARA OBTENER LOS ÚLTIMOS DATOS REGISTRADOS EN LA TABLA paydetails

CREATE VIEW current_paydetails AS
	SELECT previous_date.emp_no, employees.first_name, employees.last_name, previous_date.start_date,
		paydetails.routing_number, paydetails.account_type, paydetails.bank_name, paydetails.bank_address, paydetails.pay_type_no 
		FROM paydetails 
			JOIN (
				SELECT emp_no, start_date 
					FROM paydetails 
						WHERE MONTH(start_date) = MONTH(current_date())
						AND YEAR(start_date) = YEAR(current_date())) as previous_date
			JOIN employees
			ON paydetails.emp_no = previous_date.emp_no
			AND previous_date.emp_no = employees.emp_no;

#/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#VISTA PARA OBTENER LOS DATOS REGISTRADOS EN LA TABLA paydetails el mes pasado

CREATE VIEW previous_paydetails AS
	SELECT previous_date.emp_no, employees.first_name, employees.last_name, previous_date.start_date,
		paydetails.routing_number, paydetails.account_type, paydetails.bank_name, paydetails.bank_address, paydetails.pay_type_no 
		FROM paydetails 
			JOIN (
				SELECT emp_no, start_date 
					FROM paydetails 
						WHERE MONTH(start_date) = MONTH(current_date())-1
						AND YEAR(start_date) = YEAR(current_date())) as previous_date
			JOIN employees
			ON paydetails.emp_no = previous_date.emp_no
			AND previous_date.emp_no = employees.emp_no
			AND paydetails.start_date = previous_date.start_date;


#/////////////////////////////////////////////////////////////////
#Nueva vista para los managers, ya que la anterior era poco efectiva

CREATE VIEW current_managers AS
	SELECT emp_no, (
					SELECT first_name 
                    FROM employees
                    WHERE employees.emp_no = dept_manager.emp_no
                    ) AS first_name,
                    ( 
                    SELECT last_name
                    FROM employees
                    WHERE employees.emp_no = dept_manager.emp_no
                    ) AS last_name, dept_no, from_date, to_date
				FROM dept_manager;