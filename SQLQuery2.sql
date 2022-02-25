--Select 
--ANSII
Select ContactName ,CompanyName ,City From customers


Select * From customers where City ='Berlin'

-- case  insensitive = buyuk kucuk harf duyarsız

select * from Products where CategoryID=1 or CategoryID=3


-- "<>"farklı olanları getir

select * from Products where CategoryID=1 and UnitPrice>=10

--order by sırala

select * from Products order by CategoryID,ProductName

--ascending = artan asc vermesekde olur  descending = azalan desc

select*from Products order by UnitPrice asc

select*from Products order by UnitPrice desc

--count(*) Products ta kac data oldugunu gosterıyor

select count(*) Adet from Products where CategoryID=2


--group by hangi kategoride kac farklı urunumuz var 



select  categoryID,count(*)  from products group by CategoryID --her bir grup elemanı ıcın ayrı bır grup elemanı hesaplanıyor

--Urun sayısı 10 dan az olan kategorileri listele having count(*)<10

select  categoryID,count(*)  from products group by CategoryID having count(*)<10

--Datayı filtrelemek istersek 

select  categoryID,count(*)  from products where  UnitPrice>20 group by CategoryID having count(*)<10


--Hem ürünlerle  kategorilerin bir araya getirilmiş şekli anlamına geliyor

--on = şartında

-- on Products.CategoryID = Categories.CategoryID eşitlerse yan yana getir

--inner join sadece iki tablodada eşleşenleri bir araya getirir
select  Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


--DTO Data Transformation object

--left solda olup sağda olmauyanlarıda getir demek

Select* from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

--left solda olup sağda olmayanlarıda getir demek

Select* from Products p left join [Order Details] od
on p.ProductID = od.ProductID

Select * from Customers c left join Orders o --832 Sonuc
on c.CustomerID = o.CustomerID

Select * from Customers c inner join Orders o   -- 830 Sonuc
on c.CustomerID = o.CustomerID


--null o datanın olmadııgnı gosterır

Select * from Customers c inner join Orders o   
on c.CustomerID = o.CustomerID
where o.CustomerID is null


--2 den fazla tabloyu joın etmek ıstersem 

Select* from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderId=od.OrderID


