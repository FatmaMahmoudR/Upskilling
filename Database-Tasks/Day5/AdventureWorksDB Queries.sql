--1
select s.SalesOrderID,s.ShipDate
from Sales.SalesOrderHeader s
where s.ShipDate>'7/28/2002' and s.ShipDate<'7/29/2014'

--2
select ProductID,Name
from Production.Product
where StandardCost<110

--3
select ProductID,Name
from Production.Product
where Weight is null

--4
select *
from Production.Product
where Color in ('Silver','Black','Red')

--5
select *
from Production.Product
where Name like 'B%'

--6
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select *
from Production.ProductDescription  
where Description like '%[_]%'

--7
select sum(TotalDue),OrderDate
from Sales.SalesOrderHeader
where OrderDate between '07-01-2001' and '07-31-2014' 
group by OrderDate

--8
select distinct(HireDate) 
from HumanResources.Employee

--9
select AVG(distinct(ListPrice))
from Production.Product

--10
select 'The ' + name + ' is only! ' + CAST(ListPrice as nvarchar)  
from Production.Product  
where ListPrice between 100 and 120  
order by ListPrice;


----11
--a
select rowguid, Name, SalesPersonID, Demographics  
into Sales.store_Archive  
from Sales.Store;

--b
select rowguid, Name, SalesPersonID, Demographics  
from Sales.Store;


--12
select convert(varchar, getdate(), 120) 
union 
select convert(varchar, getdate(), 110)  
union  
select format(getdate(), 'yyyy/MM/dd')  
union  
select format(getdate(), 'MMM dd, yyyy')
union
SELECT format(getdate(), 'dddd, MMMM dd, yyyy')  
union  
SELECT format(getdate(), 'MM-dd-yyyy hh:mm:ss tt');
