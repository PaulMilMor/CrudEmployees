--////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--VISTA PARA OBTENER LOS ÚLTIMOS DATOS REGISTRADOS EN LA TABLA paydetails

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
			AND previous_date.emp_no = employees.emp_no

--/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--VISTA PARA OBTENER LOS DATOS REGISTRADOS EN LA TABLA paydetails el mes pasado

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


--/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--VISTA PARA OBTENER LOS DATOS QUE SE MUESTRAN AL EJECUTAR EL PROGRAMA DE NÓMINA

CREATE VIEW payroll_details AS
SELECT current_paydetails.emp_no, current_paydetails.first_name, current_paydetails.last_name,
		(
		SELECT salary 
			FROM current_salaries
				WHERE current_salaries.emp_no = current_paydetails.emp_no
		) /12 AS salary,
		(
		SELECT SUM(bonus_amount) 
			FROM bonus 
				WHERE bonus.emp_no = current_paydetails.emp_no
					AND MONTH(bonus.bonus_date) = MONTH(current_date()) 
					AND YEAR(bonus.bonus_date) = YEAR(current_date())
				GROUP BY bonus.emp_no 
		) AS totalbonus,
		(
		SELECT SUM(deduct_amount) 
			FROM deduction 
				WHERE deduction.emp_no = current_paydetails.emp_no
					AND MONTH(deduction.deduct_date) = MONTH(current_date()) 
					AND YEAR(deduction.deduct_date) = YEAR(current_date())
				GROUP BY deduction.emp_no 

		) AS totaldeduct
	FROM current_paydetails WHERE emp_no in (SELECT emp_no FROM current_deptemp WHERE dept_no = 'd003');
