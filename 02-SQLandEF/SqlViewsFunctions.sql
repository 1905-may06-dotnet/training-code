--View - as a Virtual Table 
create View LowRatingRestaurants AS
    select r.id,r.Name,rv.Rating,l.Zipcode from [Restaurant] r 
    left outer join [Review] rv
    on r.Id=rv.RestaurantId
    left outer join [Location] AS l
    on r.Id=l.RestaurantId
    where rv.Rating<4
go;

select min(rating) as Average from LowRatingRestaurants
where Id=1
select Upper(name), rating from LowRatingRestaurants


--Functions :
/* 1- Built-in Functions
2- User Defined Funtions
*/
-- 1. Built- in functions
	/*
	1. Aggregrate functions - operates on Columns
	2. Scalar Functions - Operates on single value (String, Datetime)
	3. Tabular Funtions - Operates  on tables
	*/
--- STRING FUNCTIONS:
declare @name varchar(50);
set @name = '    Pushpinder   ';

--select len(Rtrim(Ltrim(@name)));
select len(trim(@name))

select Ascii('0')

select char(10)

declare @num int
set @num=48

while(@num<200)
begin
	print nchar(@num);
	set @num=@num+1;
end

select REVERSE('pizza')

select SoundEx('sun')
select CURRENT_TIMESTAMP
select getdate()

select SYSDATETIME()

select SYSDATETIMEOFFSET()


declare @dt date;
declare @dob date;
set @dt='2019/04/30';
set @dob='1980/02/29';
--Date Time functions
--select IsDate('2019/03/12')
--select IsDate(@dt)
--select MONTH(@dt)
--select DateName(weekday,@dt) as dateName 
--select DatePart(QQ,@dt) as datepart
select datediff(Year, @dob, '2019/02/25')

--create a UDF to calculate DOB

alter function CalculateAge(@dob date)
returns int
as
	begin
	declare @age int;
	set @age=datediff(Year, @dob, getdate()) -
	case
		when(Month(@dob)>month(getdate()) or
		 (Month(@dob)=Month(getdate()) and day(@dob)>day(getdate())))
			then 1
			else 0
	end
	  return @age
	end

select dbo.CalculateAge('1980/06/29')


alter function GetAddress(
@add1 varchar(50),
@add2 varchar(50),
@city varchar(50),
@state varchar(50),
@country varchar(50),
@zip varchar(10)
)
returns varchar(500)
as
begin
	return (@add1+' '+@add2+' '+@city+' '+@state+' '+@country+' '+@zip)
end


select dbo.GetAddress('123','plaza america','Reston','VA','US','12345') as Address

select r.id,r.Name,rv.Rating,dbo.GetAddress(l.Address1,l.Address2,l.City,l.State,l.Country,l.Zipcode) as Address
from [Restaurant] r 
    left outer join [Review] rv
    on r.Id=rv.RestaurantId
    left outer join [Location] AS l
    on r.Id=l.RestaurantId
    

