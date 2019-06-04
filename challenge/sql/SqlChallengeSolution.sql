-- create DB
create DATABASE EMSDb;
go;
-- tables

--DROP TABLE Department
CREATE TABLE Department
(
	ID int IDENTITY NOT NULL,
	Name nvarchar(128) NOT NULL,
	Location nvarchar(512) NOT NULL
)
GO

--DROP TABLE Employee
CREATE TABLE Employee
(
	ID int IDENTITY NOT NULL,
	FirstName nvarchar(128) NOT NULL,
	LastName nvarchar(128) NOT NULL,
	SSN varchar(32) NOT NULL,
	DeptID int NOT NULL
)
GO

--DROP TABLE EmpDetails
CREATE TABLE EmpDetails
(
	ID int IDENTITY NOT NULL,
	EmployeeID int UNIQUE NOT NULL,
	Salary money NOT NULL,
	Address1 nvarchar(512) NOT NULL,
	Address2 nvarchar(512) NOT NULL,
	City nvarchar(128) NOT NULL,
	State nvarchar(128) NOT NULL,
	Country nvarchar(128) NOT NULL
)
GO

-- primary keys

ALTER TABLE Department ADD
	CONSTRAINT PK_Department_ID PRIMARY KEY (ID);
GO

ALTER TABLE Employee ADD
	CONSTRAINT PK_Employee_ID PRIMARY KEY (ID);
GO

ALTER TABLE EmpDetails ADD
	CONSTRAINT PK_EmpDetails_ID PRIMARY KEY (ID);
GO

-- foreign keys

--ALTER TABLE Employee DROP CONSTRAINT FK_Employee_Department
ALTER TABLE Employee ADD
	CONSTRAINT FK_Employee_Department
		FOREIGN KEY (DeptID) REFERENCES Department (ID);
GO

--ALTER TABLE EmpDetails DROP CONSTRAINT FK_EmpDetails_Employee
ALTER TABLE EmpDetails ADD
	CONSTRAINT FK_EmpDetails_Employee
		FOREIGN KEY (EmployeeID) REFERENCES Employee (ID);
GO

-- add three records into each table

INSERT INTO Department (Name, Location) VALUES
('R&D', '3rd floor'),
('Sales', '2nd floor'),
('HR', '1st floor');
INSERT INTO Employee (FirstName, LastName, SSN, DeptID) VALUES
('John', 'Connor', '123456789', (SELECT TOP(1)ID FROM Department WHERE Name = 'Sales')),
('Sarah', 'Connor', '987654321', (SELECT TOP(1)ID FROM Department WHERE Name = 'Sales')),
('Arnold', 'Schwarzenegger', '192837465', (SELECT TOP(1)ID FROM Department WHERE Name = 'HR'));
INSERT INTO EmpDetails (EmployeeID, Salary, Address1, Address2, City, State, Country) VALUES
((SELECT TOP(1)ID FROM Employee WHERE FirstName = 'John'), 35000.00, '123 Red Rd', '', 'Seattle', 'WA', 'USA'),
((SELECT TOP(1)ID FROM Employee WHERE FirstName = 'Sarah'), 25000.00, '456 Blue Rd', '', 'New York City', 'NY', 'USA'),
((SELECT TOP(1)ID FROM Employee WHERE FirstName = 'Arnold'), 60000.00, '456 Blue Rd', '', 'New York City', 'NY', 'USA');

-- add employee Tina Smith
INSERT INTO Employee (FirstName, LastName, SSN, DeptID) VALUES
('Tina', 'Smith', '111111111', (SELECT TOP(1)ID FROM Department WHERE Name = 'Sales'));

-- add department Marketing
INSERT INTO Department (Name, Location) VALUES
('Marketing', '4th floor');

-- list all employees in Marketing
SELECT ID, FirstName AS [First Name], LastName AS [Last Name] FROM Employee
WHERE DeptID IN (SELECT ID FROM Department WHERE Name = 'Marketing');

-- total salary of Marketing
SELECT COALESCE(SUM(EmpDetails.Salary),0.00) AS [Total Salary] FROM EmpDetails
JOIN Employee ON Employee.ID = EmpDetails.EmployeeID
WHERE Employee.DeptID IN (SELECT ID FROM Department WHERE Name = 'Marketing');

-- total employees per department
SELECT Department.ID AS [Department ID], Department.Name AS [Department Name], COUNT(*) AS [Employees] FROM Department
JOIN Employee on Employee.DeptID = Department.ID
GROUP BY Department.ID, Department.Name;

-- increase Tina Smith salary to 90000
UPDATE EmpDetails
SET Salary = 90000.00
WHERE EmployeeID IN (SELECT ID FROM Employee WHERE FirstName = 'Tina' AND LastName = 'Smith');