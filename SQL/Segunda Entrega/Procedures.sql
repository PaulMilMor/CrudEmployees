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