-- Demonstration B

-- Step 1: Using GROUP BY
-- Change to AdventureWorks database

-- Step 4a: Using Aggregates with GROUP BY
-- Show an aggregate on the column used to group
SELECT CustomerID, COUNT(*) AS Total_Orders
FROM SalesLT.SalesOrderHeader
GROUP BY CustomerID;

-- Step 4b: Show an aggregate on a column not in GROUP BY list
SELECT ProductID, MAX(OrderQty) AS largest_order
FROM SalesLT.SalesOrderDetail
GROUP BY productid;