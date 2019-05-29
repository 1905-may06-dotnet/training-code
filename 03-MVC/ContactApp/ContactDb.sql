--create a database

create database ContactAppDb
go

--Create table
create table Contact(
Id int IDENTITY (1,1), 
FirstName varchar(30) not null,
MiddleName varchar(30) null,
LastName varchar (30) not null,
Mobile varchar (15) not null,
WorkPhone varchar(15) null,
HomePhone varchar(15) null,
Email varchar(50) NULL,
Created DATETIME DEFAULT getDate(),
Modified DATETIME null,

constraint PK_Contact_Id PRIMARY KEY(Id)
)
go

insert into Contact (FirstName,LastName,Mobile)
VALUES('Fred','Belotte','987456310')