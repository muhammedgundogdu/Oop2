select * from Products order by UnitPrice
select count(*) adı from Products where CategoryID=3
select categoryId,count(*) from Products group by CategoryID

select Products.ProductID,Products.ProductName,Categories.CategoryName from Products inner join Categories on Products.CategoryID=Categories.CategoryID

select * from Products p left join [Order Details] od on p.ProductID=od.ProductID

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null	