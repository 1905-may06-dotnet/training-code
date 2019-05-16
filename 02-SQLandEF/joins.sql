--  Demonstration C

--  Step 1: Open a new query window to the AdventureWorks database
USE AdventureWorks;
GO

-- Step 2: Join 2 tables
-- Select and execute the following query
-- to show only matching customers and orders
select * from SalesLT.Customer
-- (847 row(s) affected)
select * from SalesLT.SalesOrderHeader
-- (32 row(s) affected)

SELECT c.CustomerID, soh.SalesOrderID
FROM SalesLT.Customer c JOIN SalesLT.SalesOrderHeader soh
ON c.CustomerID = soh.CustomerID;
-- (32 row(s) affected)

-- Step 3: Join 2 tables
-- Select and execute the following query
-- to show all customers and any matching orders
SELECT *
FROM SalesLT.Customer c LEFT OUTER JOIN SalesLT.SalesOrderHeader soh
ON c.CustomerID = soh.CustomerID;
-- (847 row(s) affected)