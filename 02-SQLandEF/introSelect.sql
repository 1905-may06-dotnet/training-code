--comments by developer 
--author Pushpinder Kaur 03/05/2019
--start sql

/*
Welcome to Learn SQL :
	SQL have 5 set of queries:
		1. DDL
		2. DML
		3. DCL
		4. TCL
		5. DQL
*/
--end sql


/*
Numeric data types such as int, tinyint, bigint, float, real etc.
Date and Time data types such as Date, Time, Datetime etc.
Character and String data types such as char, varchar, text etc.
Unicode character string data types, for example nchar, nvarchar, ntext etc.
Binary data types such as binary, varbinary etc.
Miscellaneous data types – blob, xml, cursor, table etc.*/

--DQL: no modification only readings
SELECT 'Hello world!';

SELECT * FROM SalesLT.Customer;

-- commenting in SQL with --

-- in a SQL server... you have many databases.
-- within each database, we have many "schemas"
-- a schema is a namespace/scope for database objects

-- in AdventureWorksLT database, we have schema SalesLT
-- inside schemas, we have many db objects, incl. tables

-- this WOULD switch databases (from master),
-- but Azure SQL DB doesn't support it yet.
USE AdventureWorksLT;
-- have to use dropdown instead.

-- whitespace doesn't matter
SelecT                *
from

salesLt.Customer
-- semicolons aren't necessary
-- SQL syntax is case-insensitive

-- SQL's string comparison by default is also case-insensitive
-- but really that depends on the "collation" i.e. the
-- settings for datetime format, number format

-- the SELECT statement ...
-- doesn't even need to access the DB
SELECT 1;
SELECT CURRENT_TIMESTAMP;

select 'Pushpinder Kaur is a trainer for java batch'
--Alias
select 'Pushpinder' As 'FirstName', 'Kaur' As 'LastName'

-- the table
-- columns
select distinct AddressLine2 from SalesLT.Address
--we can compute new values from the column's values.
select AddressID, (AddressLine1+' '+City+' '+CountryRegion+' '+PostalCode) As fullAddress
from SalesLT.Address

SELECT * FROM SalesLT.Customer;

-- only the columns we want
SeLeCt FirstName, LastName
from SalesLT.Customer;

-- only the columns i want, only the rows i want
SELECT FirstName, LastName
FROM SalesLT.Customer
WHERE LastName = 'Adams';

-- everything that starts with c and has more letters too
-- sorts after 'c'

-- we can sort the results (they are in undefined order by default)
-- ORDER BY clause accomplishes this.

-- all customers first name starting with C
-- ordered by first name, with last name (descending order) as tiebreaker
SELECT *
FROM SalesLT.Customer
WHERE FirstName >= 'c' AND FirstName < 'd'
ORDER BY FirstName DESC;

-- ordered by first name, with last name (descending order) as tiebreaker
SELECT *
FROM SalesLT.Customer
WHERE FirstName >= 'c' AND FirstName < 'd'
ORDER BY FirstName, LastName DESC;

-- we can do regex-lite pattern matching on strings with LIKE operator.
-- [abc] for one character, either a, b, or c
-- % for any number of any characters

SELECT FirstName, LastName
FROM SalesLT.Customer
WHERE LastName like '[AB]%';

-- all customers with first name starting with c, then a vowel.
SELECT *
FROM SalesLT.Customer
WHERE FirstName LIKE 'C[aeoiu]%';

-- _ for one of any character

SELECT COUNT(*) AS 'AllAdams'
FROM SalesLT.Customer
WHERE LastName = 'Adams';

SELECT * FROM SalesLT.SalesOrderDetail
order by ProductID desc;

--AGGREGRATE FUNCTIONS - sum, count, avg, min ,max
-- total number of product 779 ordered ever
SELECT *
FROM SalesLT.SalesOrderDetail
WHERE ProductID = 779;

select avg(LineTotal) As 'Total'
from SalesLT.SalesOrderDetail

SELECT avg(OrderQty) As 'CountOrderQty'
FROM SalesLT.SalesOrderDetail
WHERE ProductID = 779;

SELECT (sum(OrderQty)/count(orderqty)) As 'CountOrderQty'
FROM SalesLT.SalesOrderDetail
WHERE ProductID = 779;

SELECT COUNT(LastName) as [dupe-count], FirstName, LastName
FROM SalesLT.Customer
WHERE LastName < 'B'
GROUP BY LastName
HAVING COUNT(LastName) > 1;

-- so we have boolean operators AND and OR and NOT, and
-- not-equals != (or... traditional SQL <>)

-- we have ordered comparison of numbers, dates, times, and strings
-- strings are ordered by "dictionary order" "lexicographic order"
-- but this is affected by collation.
-- with operators < <= > >=
SELECT *
FROM SalesLT.Address
WHERE countryregion !='United States';

SELECT *
FROM SalesLT.Customer
WHERE FirstName = 'Alice' AND LastName != 'Steiner';