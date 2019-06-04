--Create database ContactDb
--go
Create TABLE Contact(
    Id int IDENTITY(1,1),
    FirstName VARCHAR(100) not null,
    MiddleName VARCHAR(100) null,
    LastName VARCHAR(100) not null,
    Email varchar(150) null,
    Mobile varchar(15) not null,
    Work varchar(15) not null,
    Home varchar(15) not null,
    created DATETIME DEFAULT getdate(),
    Modified DATETIME null,
    CONSTRAINT PK_Contact_Id PRIMARY Key(Id)
)
go 
Create Table MoreInfo(
    Id int IDENTITY(1,1),
    ContactId int null,
    Company varchar(30) null,
    Title varchar(30) null,
    Dob DATE null,
    Relationship VARCHAR(20) null,
    Notes VARCHAR(100)  null,
    CONSTRAINT PK_MoreInfo_Id PRIMARY Key(Id),
    CONSTRAINT FK_MoreInfo_Contact FOREIGN KEY(ContactId) 
        REFERENCES Contact(Id)
)
go

Create table Address(
Id int IDENTITY(1,1),
ContactId int null,
AddressType char(5),
Add1 varchar(50),
Add2 varchar(50),
City varchar(50),
State varchar(5),
Country varchar(50),
Zip varchar(9),
CONSTRAINT PK_Address_Id PRIMARY Key(Id),
    CONSTRAINT FK_Address_Contact FOREIGN KEY(ContactId) 
        REFERENCES Contact(Id)
)
go
alter table Contact
alter COLUMN
 Home varchar(15)  null

alter table MoreInfo
    add  created DATETIME DEFAULT getdate(),
    Modified DATETIME null

GO
ALTER table Address
add created DATETIME DEFAULT getdate(),
    Modified DATETIME null

go 

INSERT into CONTACT(FirstName,LastName,Email,Mobile) VALUES('Fred','Belotte', 'fred@revature.com','9876543210' )
select  * from Contact  
truncate table Contact