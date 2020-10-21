EmpId Name Salary
1  A    5
2  B    3
3  C    10
4  D    8

Employee city
EmpId City
1  Bangalore
2  Hyderabad
3  Bangalore
4  Delhi


Create DATABASE Test

CREATE TABLE Employee2 (
    EmpId int not null primary KEY,
    EmpName VARCHAR(100),
    Salary INT
)

CREATE TABLE EmployeeCity (
    EmpId int FOREIGN KEY REFERENCES Employee2(EmpId),
    EmpCity VARCHAR(100)
)

INSERT Into Employee2
(EmpId,EmpName,Salary) 
VALUES (1,'A',5), (2,'B',3), (3,'C',10), (4,'D',8)

Insert into EmployeeCity (EmpId, EmpCity)
Values (1, 'Bangalore'), (2, 'Hyderabad'), (3, 'Bangalore'), (4, 'Delhi')

SELECT COUNT(*) as EmpCount, EmpCity
FROM  EmployeeCity
GROUP By EmpCity

SELECT COUNT(*) as EmpCount, EmpCity
FROM  EmployeeCity
GROUP By EmpCity
HAVING COUNT(*) > 1

SELECT COUNT(*) as EmpCount, EmpCity
FROM  EmployeeCity
Inner Join Employee2 
ON EmployeeCity.EmpId = Employee2.EmpId
Where Employee2.Salary > 5
GROUP By EmpCity