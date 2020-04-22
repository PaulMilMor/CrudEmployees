DELIMITER $$
 
CREATE TRIGGER addemp_title
    AFTER INSERT
    ON employees FOR EACH ROW
BEGIN
    INSERT INTO titles(emp_no,title,from_date,to_date)
    VALUES (NEW.emp_no,'Trainee',NEW.hire_date, DATE_ADD(NEW.hire_date,INTERVAL 3 MONTH));
END$$    
 
DELIMITER ;


#//////////////////////////////////////////



DELIMITER $$
 
CREATE TRIGGER addemp_salary
    AFTER INSERT
    ON employees FOR EACH ROW
BEGIN
    INSERT INTO salaries(emp_no,salary,from_date,to_date)
    VALUES (NEW.emp_no,20000,NEW.hire_date, DATE_ADD(NEW.hire_date,INTERVAL 3 MONTH));
END$$    
 
DELIMITER ;


#//////////////////////////////////////////


DELIMITER $$
 
CREATE TRIGGER title_to_manager
    AFTER INSERT
    ON titles FOR EACH ROW
BEGIN
	
    IF(NEW.title = 'Manager') THEN
		INSERT INTO dept_manager(emp_no, dept_no, from_date, to_date)
		VALUES (NEW.emp_no,(SELECT dept_no FROM current_dept_emp),NEW.from_date, NEW.to_date);
    END IF;
		
END$$    
 
DELIMITER ;

#////////////////////////////////////////////


DELIMITER $$
 
CREATE TRIGGER manager_to_title
    AFTER INSERT
    ON dept_manager FOR EACH ROW
BEGIN
	
    
	INSERT INTO titles(emp_no, title, from_date, to_date)
	VALUES (NEW.emp_no,"Manager",NEW.from_date, NEW.to_date);
    
		
END$$    
 
DELIMITER ;




#//////////////////////////////////////////////////



DELIMITER $$
 
CREATE TRIGGER manager_to_deptemp
    BEFORE INSERT
    ON dept_manager FOR EACH ROW
BEGIN
	
    IF(SELECT NOT EXISTS(SELECT * FROM dept_emp WHERE emp_no = NEW.emp_no AND dept_no = NEW.dept_no)) THEN
		INSERT INTO dept_emp(emp_no,dept_no,from_date,to_date) VALUES(NEW.emp_no, NEW.dept_no, NEW.from_date, NEW.to_date);
    END IF;
		
END$$    
 
DELIMITER ;