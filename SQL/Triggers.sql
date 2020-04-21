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
 
CREATE TRIGGER update_title
    BEFORE INSERT
    ON titles FOR EACH ROW
BEGIN
	
    IF(NEW.emp_no IN (SELECT emp_no FROM current_titles) AND NEW.from_date >= (SELECT to_date FROM current_titles WHERE emp_no = NEW.emp_no)) THEN
		UPDATE titles SET to_date = NEW.from_date WHERE from_date IN (SELECT from_date FROM current_titles WHERE emp_no = NEW.emp_no);
    END IF;
		
END$$    
 
DELIMITER ;


#///////////////////////////////////////////////////

DELIMITER $$
 
CREATE TRIGGER update_salary
    BEFORE INSERT
    ON salaries FOR EACH ROW
BEGIN
	
    IF(NEW.emp_no IN (SELECT emp_no FROM current_salaries) AND NEW.from_date >= (SELECT to_date FROM current_salaries WHERE emp_no = NEW.emp_no)) THEN
		UPDATE salaries SET to_date = NEW.from_date WHERE from_date IN (SELECT from_date FROM current_salaries WHERE emp_no = NEW.emp_no);
    END IF;
		
END$$    
 
DELIMITER ;

#///////////////////////////////////////////////////

DELIMETER $$

CREATE TRIGGER update_deptemp
    BEFORE INSERT
    ON dept_emp FOR EACH ROW
BEGIN
	
    IF(NEW.emp_no IN (SELECT emp_no FROM current_dept_emp) AND NEW.from_date >= (SELECT to_date FROM current_dept_emp WHERE emp_no = NEW.emp_no)) THEN
		UPDATE dept_emp SET to_date = NEW.from_date WHERE from_date IN (SELECT from_date FROM current_dept_emp WHERE emp_no = NEW.emp_no);
    END IF;
		
END$$    
 
DELIMITER ;

#//////////////////////////////////////////////////////



DELIMITER $$
 
CREATE TRIGGER update_manager
    BEFORE INSERT
    ON dept_manager FOR EACH ROW
BEGIN
	
    IF(NEW.dept_no IN (SELECT dept_no FROM current_managers) AND NEW.from_date >= (SELECT to_date FROM current_managers WHERE dept_no = NEW.dept_no)) THEN
		UPDATE dept_manager SET to_date = NEW.from_date WHERE from_date IN (SELECT from_date FROM current_dept_emp WHERE dept_no = NEW.dept_no);
    END IF;
		
END$$    
 
DELIMITER ;
