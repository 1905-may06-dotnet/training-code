--comments by developer 
--author Pushpinder Kaur 03/05/2019
--start sql
/*
Welcome to Learn SQL :
	SQL have 5 set of queries:
		1. DDL - Create, alter, drop
		2. DML - insert, update, delete
		3. DCL - Grant, Revoke
		4. TCL - commit, Rollback, savepoint
		5. DQL - select
*/
--end sql


/*
-> Numeric data types such as int, tinyint, bigint, float, real etc.
-> Date and Time data types such as Date, Time, Datetime etc.
- Character and String data types such as char, varchar, text, char, varchar  etc.
-> Unicode character string data types, for example nchar, nvarchar, ntext etc.
-> Binary data types such as binary, varbinary etc.
-> Miscellaneous data types – blob, xml, cursor, table etc.
*/

--DML-> DQL (-select-): no modification only readings
SELECT 'Hello world!' as Message 
SELECT * FROM SalesLT.Customer

-- commenting in SQL with --

-- in a SQL server... you have many databases.
-- within each database, we have many "schemas"
-- a schema is a namespace/scope for database objects

-- in AdventureWorksLT database, we have schema SalesLT
-- inside schemas, we have many db objects, incl. tables

-- this WOULD switch databases (from master),
-- but Azure SQL DB doesn't support it yet.
USE AdventureWorks;
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
SELECT CURRENT_TIMESTAMP as CurrentDateTime;

select 'Pushpinder Kaur is a trainer for .Net batch'
--Alias
select 'Pushpinder' As 'FirstName', 'Kaur' As 'LastName'

--Schema-> group of related tables
select AddressLine2 from SalesLT.Address
select distinct AddressLine2 from SalesLT.Address
SELECT * FROM SalesLT.Address
--we can compute new values from the column's values.
select AddressID as Id, AddressLine1+' '+AddressLine2+' '+City+' '+CountryRegion+' '+PostalCode As fullAddress
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
ORDER BY FirstName desc;

-- ordered by first name, with last name (descending order) as tiebreaker
SELECT *
FROM SalesLT.Customer
WHERE FirstName >= 'c' AND FirstName < 'd'
ORDER BY FirstName, LastName desc;

-- we can do regex-lite pattern matching on strings with LIKE operator.
-- [abc] for one character, either a, b, or c
-- % for any number of any characters
-- _ for any 1 character

SELECT FirstName, LastName
FROM SalesLT.Customer
WHERE LastName like '[AB]%'
order by lastname;

-- all customers with first name starting with c, then a vowel.
SELECT FirstName,LastName
FROM SalesLT.Customer
WHERE FirstName LIKE 'C[aeoiu]%';

select FIRSTName, Lastname 
from SalesLT.Customer
where FirstName like 'a_[aeiou]%'

select FIRSTName, lastname
from SalesLT.Customer
where LastName like '_dam_'

-- _ for one of any character



SELECT * FROM SalesLT.SalesOrderDetail
order by ProductID desc;

--AGGREGRATE FUNCTIONS - sum, count, avg, min ,max
-- total number of product 779 ordered ever
SELECT COUNT(*) AS 'AllAdams'
FROM SalesLT.Customer
WHERE LastName = 'Adams';

SELECT *
FROM SalesLT.SalesOrderDetail
WHERE ProductID = 779;

select avg(LineTotal) As 'Average Line Total'
from SalesLT.SalesOrderDetail

SELECT avg(OrderQty) As 'CountOrderQty'
FROM SalesLT.SalesOrderDetail
WHERE ProductID = 779;

SELECT (sum(OrderQty)/count(orderqty)) As 'CountOrderQty'
FROM SalesLT.SalesOrderDetail
WHERE ProductID = 779;

SELECT lastname, Count(LastName) as [dupe-count]
FROM SalesLT.Customer
WHERE LastName < 'B'
GROUP BY LastName
HAVING COUNT(LastName) > 2
order by [dupe-count] desc;

-- so we have boolean operators AND and OR and NOT, and
-- not-equals != (or... traditional SQL <>)

-- we have ordered comparison of numbers, dates, times, and strings
-- strings are ordered by "dictionary order" "lexicographic order"
-- but this is affected by collation.
-- with operators < <= > >=
SELECT *
FROM SalesLT.Address
--WHERE countryregion <> 'United States';
WHERE countryregion != 'United States';

SELECT *
FROM SalesLT.Customer
WHERE FirstName = 'Alice' AND LastName != 'Steiner';