--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers 

Select * from Customers where City='London'

-- case insentive = Duyarsız 
select * from Products where CategoryID = 1 or CategoryID=3

select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by UnitPrice desc

Select count(*) from Products where CategoryID=2

select categoryID,COUNT(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID


select * from Products inner join [Order Details] on Products.ProductID = [Order Details].ProductID

select * from Customers c left join Orders o 
on c.CustomerID= o.CustomerID
where o.CustomerID is null