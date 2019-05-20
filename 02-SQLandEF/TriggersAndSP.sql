create table tblArchiveRestaurant(
  Id int identity (1,1) not null,
  DateModified date default getdate() not null,
  Comment varchar(100) not null
)

create trigger OnRestaurantinsert
on dbo.Restaurant
for insert
as
begin
  insert into tblArchiveRestaurant values(GETDATE(),'Inserted 1 Restaurant')
end

alter trigger OnRestaurantUpdate
on dbo.Restaurant
for Update
as
begin 
declare @id int;
 select @id=id from inserted
  insert into tblArchiveRestaurant values(GETDATE(),'Updated Restaurant with id '+convert(varchar,@id))
end

insert into Restaurant values ('Tex Mex')

update dbo.Restaurant 
set Name ='tex Cantinna'
where Id = 4

select * from tblArchiveRestaurant 


-- Stored Procedure
--Built in SP->
execute sp_help Restaurant

Create procedure sp_GetRestaurants
As 
begin
select r.id,r.Name,rv.Rating,dbo.GetAddress(l.Address1,l.Address2,l.City,l.State,l.Country,l.Zipcode) as Address
from [Restaurant] r 
    left outer join [Review] rv
    on r.Id=rv.RestaurantId
    left outer join [Location] AS l
    on r.Id=l.RestaurantId 
end

exec sp_GetRestaurants

alter procedure sp_GetRestaurantsById
@id int 
As
begin
select r.id,r.Name,rv.Rating,dbo.GetAddress(l.Address1,l.Address2,l.City,l.State,l.Country,l.Zipcode) as Address
from [Restaurant] r 
    left outer join [Review] rv
    on r.Id=rv.RestaurantId
    left outer join [Location] AS l
    on r.Id=l.RestaurantId 
	where r.Id=@id
end

declare @id int
set @id=1;
exec sp_GetRestaurantsById @id

