USE MyShop;

SELECT * FROM Products 
WHERE SUBSTRING(ProductName, 1, 1) = 'C'

SELECT * FROM Products
WHERE Price = (SELECT MIN(Price) FROM Products)  

SELECT SUM(Price) FROM Products

SELECT * FROM Suppliers
WHERE SupplierID IN (SELECT DISTINCT SupplierID FROM Products
WHERE CategoryID  = (SELECT CategoryID FROM Categories WHERE CategoryName = 'Condiments'))


INSERT INTO Suppliers
VALUES
('Norske Meierier', 'Lviv', 'Ukraine')

DECLARE @supplierId  INT,
		@categoryId INT

SET @supplierId = (SELECT TOP 1 SupplierID FROM Suppliers WHERE SupplierName = 'Norske Meierier') 
SET @categoryId = (SELECT TOP 1 CategoryID FROM Categories WHERE CategoryName = 'Beverages')

INSERT INTO Products
VALUES
('Green tea', @supplierId, @categoryId, 10.00)