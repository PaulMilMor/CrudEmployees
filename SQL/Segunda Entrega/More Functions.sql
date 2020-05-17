--Función para obtener el máximo número de pay_no e incrementarlo automáticamente al insertar

DELIMITER //

CREATE FUNCTION max_pay_no()
RETURNS INT DETERMINISTIC

BEGIN

   DECLARE max_number INT;

   SELECT IFNULL(MAX(pay_no),0) INTO max_number FROM payhistory;
   
   RETURN max_number+1;

END;


DELIMITER;


--////////////////////////////////////////////

--Función para obtener el máximo número de check_number e incrementarlo automáticamente al insertar

DELIMITER //

CREATE FUNCTION max_check_number()
RETURNS INT DETERMINISTIC

BEGIN

   DECLARE max_number INT;

   SELECT IFNULL(MAX(check_number),0) INTO max_number FROM payhistory;
   
   RETURN max_number+1;

END;


DELIMITER;