-- Demonstration C

-- Step 1: Filtering Groups with HAVING
-- Change to AdventureWorks database
USE AdventureWorks;
GO

-- Step 2a: Using the HAVING clause
-- Select and execute the following query to show
-- The use of a HAVING clause. This query has no HAVING clause:
SELECT CustomerID, COUNT(*) AS count_orders
FROM SalesLT.SalesOrderHeader
GROUP BY CustomerID;

-- Step 2b: This query uses a HAVING clause to filter out customers with fewer than 10 orders
SELECT CustomerID, COUNT(*) AS count_orders
FROM SalesLT.SalesOrderHeader
GROUP BY CustomerID
HAVING COUNT(*) >= 1

-- Step 2c: Review the logical order of operations
-- the column alias for COUNT(*) hasn't been processed yet
-- when HAVING refers to it
-- THIS WILL FAIL
SELECT CustomerID, COUNT(*) AS count_orders
FROM SalesLT.SalesOrderHeader
GROUP BY CustomerID
HAVING count_orders >= 10

-- Step 2f: Select and execute the following query to show
-- All customers and how many orders they have placed

SELECT c.CustomerID, COUNT(*) AS No_Of_Orders
FROM SalesLT.Customer AS c
JOIN SalesLT.SalesOrderHeader AS o
ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID
ORDER BY No_Of_Orders DESC;

-- Step 2g: Use HAVING to filter only customers who have placed more than 20 orders
SELECT c.CustomerID, COUNT(*) AS No_Of_Orders
FROM SalesLT.Customer AS c
JOIN SalesLT.SalesOrderHeader AS o
ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID
HAVING COUNT(*) > 20
ORDER BY No_Of_Orders DESC;

-- Step 2h: Select and execute the following query to show
-- All products and in how many orders they appear
SELECT p.ProductID, COUNT(*) AS cnt
FROM SalesLT.Product AS p
JOIN SalesLT.SalesOrderDetail AS od
ON p.ProductID = od.Productid
GROUP BY p.ProductID
ORDER BY cnt DESC;

-- Step 2i: Use HAVING to filter only products which have been ordered less than 20 times
-- 9 rows returned
SELECT p.ProductID, COUNT(*) AS cnt
FROM SalesLT.Product AS p
JOIN SalesLT.SalesOrderDetail AS od
ON p.ProductID = od.Productid
GROUP BY p.ProductID
HAVING COUNT(*) < 20
ORDER BY cnt DESC;