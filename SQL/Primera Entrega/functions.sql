DELIMITER //

CREATE FUNCTION max_emp_no()
RETURNS INT DETERMINISTIC

BEGIN

   DECLARE max_number INT;

   SELECT MAX(emp_no) INTO max_number FROM employees;
   
   RETURN max_number;

END;


DELIMITER;


--////////////////////////////////////////////

