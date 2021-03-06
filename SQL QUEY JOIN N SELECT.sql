SELECT * FROM EMPLOYEES

SELECT * FROM DEPARTMENTS
WHERE DEPARTMENT_ID=60;

SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENTS

SELECT DEPARTMENT_ID AS "DEPARTMENT ID", DEPARTMENT_NAME AS "DEPARTMENT NAME" FROM DEPARTMENTS

SELECT * FROM DEPARTMENTS WHERE LOCATION_ID > 1700

SELECT * FROM DEPARTMENTS WHERE LOCATION_ID=1800 AND DEPARTMENT_ID=20

SELECT * FROM DEPARTMENTS WHERE DEPARTMENT_NAME = 'MARKETING'

SELECT * FROM DEPARTMENTS WHERE DEPARTMENT_ID=100 OR DEPARTMENT_ID=200

SELECT * FROM DEPARTMENTS WHERE MANAGER_ID IS NULL

SELECT * FROM DEPARTMENTS WHERE MANAGER_ID IS NOT NULL

SELECT * FROM DEPARTMENTS WHERE MANAGER_ID=200 OR MANAGER_ID=205 OR MANAGER_ID=145

SELECT * FROM DEPARTMENTS WHERE MANAGER_ID IN(200,205,145)

SELECT * FROM DEPARTMENTS WHERE DEPARTMENT_NAME IN('SALES', 'PURCHASING','ACCOUNTING')

SELECT * FROM DEPARTMENTS WHERE DEPARTMENT_ID>=40 AND DEPARTMENT_ID<=100

SELECT * FROM DEPARTMENTS WHERE DEPARTMENT_ID BETWEEN 40 AND 100

SELECT * FROM DEPARTMENTS WHERE DEPARTMENT_NAME LIKE 'H%'

SELECT * FROM DEPARTMENTS WHERE DEPARTMENT_NAME LIKE '%T___'

SELECT * FROM DEPARTMENTS WHERE (DEPARTMENT_NAME LIKE '%t___' OR MANAGER_ID=NULL) AND LOCATION_ID>=1800

SELECT DEPARTMENT_NAME + ',' + CONVERT(VARCHAR,MANAGER_ID) AS "DATA" FROM DEPARTMENTS

SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENTS

SELECT DEPARTMENT_ID, UPPER(DEPARTMENT_NAME) FROM DEPARTMENTS

SELECT DEPARTMENT_ID, LOWER(DEPARTMENT_NAME) AS 'DEPARTMENT NAME', LEN(DEPARTMENT_NAME) AS 'DEPARTMENT LENGTH' FROM DEPARTMENTS

SELECT SUBSTRING(DEPARTMENT_NAME, 1,4) AS 'DEPARTMENT NAME' FROM DEPARTMENTS

SELECT ('      COMPUTER')

SELECT TRIM(('      COMPUTER'))

SELECT LEFT('COMPUTER',4)

SELECT RIGHT('COMPUTER', 4)

SELECT REPLACE('COMPUTER', 'COMP', 'RAM')

SELECT GETDATE()

SELECT GETDATE()+1

SELECT GETDATE()-1

SELECT DATEPART(M, GETDATE())

SELECT DATEPART(DAY, GETDATE())

SELECT DATEPART(DW, GETDATE())

SELECT DATEPART(WEEKDAY, GETDATE())

SELECT DATEPART(ISO_WEEK, GETDATE())

SELECT DATEADD(M, 7,GETDATE())

SELECT * FROM EMPLOYEES

SELECT FIRST_NAME, HIRE_DATE, DATEDIFF(YEAR, HIRE_DATE, GETDATE()) AS "NO OF YEARS" FROM EMPLOYEES

SELECT FIRST_NAME, HIRE_DATE, DATEDIFF(MONTH, HIRE_DATE, GETDATE()) AS "NO OF MONTHS" FROM EMPLOYEES

SELECT ROUND(6.876766,2)

SELECT ROUND(6.826766,2)

SELECT RADIANS(150)

SELECT DEGREES(500)

SELECT 2%4

SELECT 4%2

SELECT 2+5

SELECT * FROM EMPLOYEES

SELECT SUM(SALARY) AS 'TOTAL SALARY', AVG(SALARY) AS 'AVERAGE' , COUNT(EMPLOYEE_ID) 'NO OF EMPLOYEES', MIN(SALARY) 'MINIMUM SALARY', MAX(SALARY) 'MAXIMUM SALARY' FROM EMPLOYEES GROUP BY DEPARTMENT_ID

SELECT DEPARTMENT_ID, JOB_ID, COUNT(EMPLOYEE_ID) AS "NO OF EMPLOYEES", SUM(SALARY) AS "TOTAL SALARY", MIN(SALARY) AS "MINIMUM SALARY", MAX(SALARY) "MAXIMUM SALARY", AVG(SALARY) "AVERAGE SALARY" FROM EMPLOYEES GROUP BY DEPARTMENT_ID, JOB_ID

SELECT * FROM DEPARTMENTS

SELECT SUM(SALARY) "TOTAL SALARY" FROM EMPLOYEES GROUP BY MANAGER_ID

SELECT COUNT(EMPLOYEE_ID) AS 'NO OF EMPLOYEES' FROM EMPLOYEES GROUP BY MANAGER_ID

SELECT DEPARTMENT_ID, COUNT(EMPLOYEE_ID) AS "NO OF EMPLOYEES", SUM(SALARY) AS "TOTAL SALARY", MIN(SALARY) AS "MINIMUM SALARY", MAX(SALARY) "MAXIMUM SALARY", AVG(SALARY) "AVERAGE SALARY" FROM EMPLOYEES GROUP BY DEPARTMENT_ID, MANAGER_ID HAVING SUM(SALARY) > 10000

--SUBQUERIES
SELECT * FROM EMPLOYEES WHERE MANAGER_ID = (SELECT MANAGER_ID FROM EMPLOYEES WHERE FIRST_NAME = 'BRUCE')

SELECT FIRST_NAME, LAST_NAME, PHONE_NUMBER FROM EMPLOYEES WHERE DEPARTMENT_ID=(SELECT DEPARTMENT_ID FROM EMPLOYEES WHERE FIRST_NAME='NANCY')

SELECT * FROM EMPLOYEES WHERE DEPARTMENT_ID = (SELECT DEPARTMENT_ID FROM DEPARTMENTS WHERE DEPARTMENT_NAME = 'IT')

SELECT * FROM EMPLOYEES WHERE SALARY > (SELECT SALARY FROM EMPLOYEES WHERE FIRST_NAME='NANCY')


SELECT * FROM EMPLOYEES WHERE SALARY > (SELECT AVG(SALARY) FROM EMPLOYEES WHERE DEPARTMENT_ID=30)
SELECT * FROM EMPLOYEES WHERE SALARY > ANY(SELECT SALARY FROM EMPLOYEES WHERE DEPARTMENT_ID=30)
SELECT * FROM EMPLOYEES WHERE SALARY < ANY(SELECT SALARY FROM EMPLOYEES WHERE DEPARTMENT_ID=30)

SELECT * FROM EMPLOYEES WHERE SALARY > ALL(SELECT SALARY FROM EMPLOYEES WHERE DEPARTMENT_ID=30)

SELECT * FROM EMPLOYEES WHERE SALARY < ALL(SELECT SALARY FROM EMPLOYEES WHERE DEPARTMENT_ID=30)

SELECT * FROM EMPLOYEES WHERE SALARY =ANY(SELECT SALARY FROM EMPLOYEES WHERE DEPARTMENT_ID=30)

SELECT * FROM EMPLOYEES WHERE SALARY IN(SELECT SALARY FROM EMPLOYEES WHERE DEPARTMENT_ID=30)

SELECT * FROM EMPLOYEES E1 WHERE SALARY > (SELECT SALARY FROM EMPLOYEES E2 WHERE E2.EMPLOYEE_ID = E1.MANAGER_ID)


--JOINS

SELECT * FROM EMPLOYEES
SELECT * FROM DEPARTMENTS
SELECT * FROM LOCATIONS
SELECT * FROM COUNTRIES
SELECT * FROM JOBS

SELECT FIRST_NAME, LAST_NAME, JOB_ID, DEPARTMENT_NAME FROM EMPLOYEES, DEPARTMENTS

SELECT FIRST_NAME, LAST_NAME, JOB_ID, DEPARTMENT_NAME FROM EMPLOYEES CROSS JOIN DEPARTMENTS

SELECT FIRST_NAME, LAST_NAME, JOB_ID, E.DEPARTMENT_ID, DEPARTMENT_NAME FROM EMPLOYEES E,DEPARTMENTS D WHERE E.DEPARTMENT_ID=D.DEPARTMENT_ID

SELECT * FROM job_grades;

SELECT FIRST_NAME, LAST_NAME, JOB_ID, SALARY, GRADE  FROM EMPLOYEES E JOIN job_grades J ON E.SALARY BETWEEN J.lowest_sal AND J.highest_sal

SELECT FIRST_NAME, LAST_NAME, JOB_ID, DEPARTMENT_NAME FROM EMPLOYEES E LEFT JOIN DEPARTMENTS D ON E.DEPARTMENT_ID=D.DEPARTMENT_ID

SELECT FIRST_NAME, LAST_NAME, JOB_ID, DEPARTMENT_NAME FROM EMPLOYEES E RIGHT JOIN DEPARTMENTS D ON E.DEPARTMENT_ID=D.DEPARTMENT_ID

SELECT FIRST_NAME, LAST_NAME, JOB_ID, DEPARTMENT_NAME FROM EMPLOYEES E FULL JOIN DEPARTMENTS D ON E.DEPARTMENT_ID=D.DEPARTMENT_ID

SELECT E.FIRST_NAME AS EMPLOYEE_NAME,E.JOB_ID,E.MANAGER_ID,M.FIRST_NAME AS MANAGER_NAME
FROM EMPLOYEES E JOIN EMPLOYEES M ON E.MANAGER_ID=M.EMPLOYEE_ID
