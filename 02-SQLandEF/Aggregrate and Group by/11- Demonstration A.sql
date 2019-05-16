-- Demonstration A

-- Step 1: Using built-in Aggregate functions
-- Change to AdventureWorks database
USE AdventureWorks;
GO

-- Step 2: Using built-in Aggregate functions
-- Select and execute the following query to show
-- the use of aggregate functions in the SELECT clause:

-- Step 2a: THIS WILL FAIL, since some columns are not aggregated
-- and there is no explicit GROUP BY clause
SELECT SalesOrderID, ProductID, AVG(UnitPrice), MIN(OrderQty), MAX(UnitPriceDiscount)
FROM SalesLT.SalesOrderDetail;

-- Step 2b: Select and execute the following query to show
-- This will succeed and return the AVG/MIN/MAX of all rows:
select AVG(UnitPrice), MIN(OrderQty), MAX(UnitPriceDiscount)
FROM SalesLT.SalesOrderDetail;

-- Step 2d: Select and execute the following query to show
-- The use of aggregates with non-numeric data types:
SELECT MIN(OrderDate)AS earliest_order,
MAX(OrderDate) AS latest_order
FROM SalesLT.SalesOrderHeader;

-- Step 2e: Select and execute the following query to show
-- the use of DISTINCT with aggregate functions:
SELECT YEAR(OrderDate) AS order_year,
COUNT(CustomerID) as all_customers,
COUNT(DISTINCT CustomerID) as unique_customers
FROM SalesLT.SalesOrderHeader
GROUP BY YEAR(OrderDate);

-- Step 3: (optional) The following section may be used to illustrate
-- the behavior of NULLs in aggregate functions:

-- Step 3a: Create an example table
CREATE TABLE dbo.t1(
	c1 INT IDENTITY NOT NULL PRIMARY KEY,
	c2 INT NULL);

-- Step 3b: Populate it	
INSERT INTO dbo.t1(c2)
VALUES(NULL),(10),(20),(30),(40),(50);

-- Step 3c: View the contents. Note the NULL
SELECT c1, c2
FROM dbo.t1;

-- Step 3d: Execute this query to compare the behavior of AVG to an aritmetic average (SUM/COUNT)
SELECT SUM(c2) AS sum_nonnulls, COUNT(*)AS count_all_rows, COUNT(c2)AS count_nonnulls, AVG(c2) AS [avg], (SUM(c2)/COUNT(*))AS arith_avg
FROM dbo.t1;

-- Step 3e: Clean up the created table
DROP TABLE t1;

-- Step 3f: Execute this query to demonstrate replacement of NULL before aggregating
-- Create test table
CREATE TABLE dbo.t2
    (
      c1 INT IDENTITY NOT NULL PRIMARY KEY,
      c2 INT NULL
    );

-- Step 3g: Populate test table
INSERT INTO dbo.t2
VALUES(1),(10),(1),(NULL),(1),(10),(1),(NULL),(1),(10),(1),(10);

-- Step 3h: Show table contents
SELECT c1, c2
FROM dbo.t2;

-- Step 3i: Show standard AVG versus replacement of NULL with zero
SELECT AVG(c2) AS AvgWithNULLs, AVG(COALESCE(c2,0)) AS AvgWithNULLReplace
FROM dbo.t2;


-- Step 4: clean up
DROP TABLE dbo.t2;