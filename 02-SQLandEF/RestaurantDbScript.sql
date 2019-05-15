--DDL : Create, drop, truncate

CREATE DATABASE RestaurantDb;
Go

--Datatypes:
--Numeric - tinyint, byte, int, decimal, money, float, real
--String - char(20), varchar (20), nchar, nvarchar, text
--Date and time - date, time, datetime, datetimeoffset 

--CONSTRAINTS
-- Not Null - which means value for this field canot be null
-- Primary Key -(not null and unique)
-- unique Key - Applied to Columns
-- Default - 
-- Check - 
-- Foreign Key - which association of parent to child table
create table Restaurant(
    Id int IDENTITY(1,1), --Primary key,
    Name varchar(50)
    --PRIMARY Key(Id)
    )

go 

alter table Restaurant Add
    CONSTRAINT PK_Restaurant_Id
    PRIMARY KEY(Id)

drop table LOCATION
drop table Restaurant
     --Column Id
Create table Location(
 Id int IDENTITY,
 Address1 VARCHAR(30) not null,
 Address2 VARCHAR(30),
 City VARCHAR(50) not null,
 State VARCHAR(30) not null,
 Country varchar(3) DEFAULT('US'),
 Zipcode nvarchar(10),
 RestaurantId int,
-- Primary key(Id),
-- FOREIGN key (RestaurantId) REFERENCES Restaurant(Id)
)

alter table LOCATION Add
    Constraint PK_Location_Id PRIMARY KEY(Id),
    CONSTRAINT FK_Location_Restaurant FOREIGN KEY(RestaurantId) REFERENCES Restaurant(Id)
