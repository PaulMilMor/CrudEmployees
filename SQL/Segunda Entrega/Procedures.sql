--Procedimiento para obtener los bonus de un empleado específico
--en el mes que se va a pagar

DELIMITER //
CREATE PROCEDURE get_current_bonus(IN selectedemp INTEGER)
BEGIN 
	SELECT 
		(SELECT bonus_description FROM bonustype WHERE bonustype.bonus_type_no = bonus.bonus_type_no) 
        AS currentbonus, bonus_amount
		FROM bonus 
			WHERE MONTH(bonus_date) = MONTH(current_date()) 
			AND YEAR(bonus_date) = YEAR(current_date()) 
			AND emp_no = selectedemp;
END //
DELIMITER ;

--Procedimiento para obtener las deducciones de un empleado específico
--en el mes que se va a pagar



DELIMITER //
CREATE PROCEDURE get_current_deducts(IN selectedemp INTEGER)
BEGIN 
	SELECT 
		(SELECT deduct_description FROM deducttype WHERE deducttype.deduct_type_no = deduction.deduct_type_no) 
        AS currentdeduct, deduct_amount
		FROM deduction 
			WHERE MONTH(deduct_date) = MONTH(current_date()) 
			AND YEAR(deduct_date) = YEAR(current_date()) 
			AND emp_no = selectedemp;
END //
DELIMITER ;

--Procedimiento para obtener los datos que se muestran en la nómina

DELIMITER //
CREATE PROCEDURE get_payroll_details(IN deptno VARCHAR(4))
BEGIN
	
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
	FROM current_paydetails  WHERE emp_no in (SELECT emp_no FROM current_deptemp WHERE dept_no = deptno);

END //
DELIMITER ;