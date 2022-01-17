INSERT INTO employees(firstName,lastName,city) 
VALUES("winch","Eszter","Vác");

INSERT INTO employees 
VALUES(1,"winch","Eszter","Vác","2012-1-1",2110);

UPDATE employees SET salary=salary*2 WHERE city="Budapest"

UPDATE employees SET city="Eger" WHERE firstName="Bartos"

UPDATE employees SET hireDate="2012-12-01" WHERE id=7
