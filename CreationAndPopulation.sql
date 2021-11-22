CREATE DATABASE MyShop;
GO

USE MyShop;

CREATE TABLE Suppliers
(
	SupplierID INT PRIMARY KEY IDENTITY,
	SupplierName NVARCHAR(50),
	City NVARCHAR(25),
	Country NVARCHAR(25)
);

CREATE TABLE Categories
(
	CategoryID INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(25),
	Description NVARCHAR(100)
);

CREATE TABLE Products
(
	ProductID INT PRIMARY KEY IDENTITY,
	ProductName NVARCHAR(50),
	SupplierID INT,
	CategoryID INT,
	Price DECIMAL(13,2),
	FOREIGN KEY (SupplierID) REFERENCES Suppliers (SupplierID),
	FOREIGN KEY (CategoryID) REFERENCES Categories (CategoryID)
);

GO

INSERT INTO Suppliers
VALUES
('Exotic Liquid', 'London', 'UK'),
('New Orleans Cajun Delights', 'New Orleans', 'USA'),
('Grandma Kelly’s Homestead', 'Ann Arbor', 'USA'),
('Tokyo Traders', 'Tokyo', 'Japan'),
('Cooperativa de Quesos ‘Las Cabras’', 'Oviedo', 'Spain')


INSERT INTO Categories
VALUES
('Beverages', 'Soft drinks, coffees, teas, beers, and ales'),
('Condiments', 'Sweet and savory sauces, relishes, spreads, and seasonings'),
('Confections', 'Desserts, candies, and sweet breads'),
('Dairy Products', 'Cheeses'),
('Grains/Cereals', 'Breads, crackers, pasta, and cereal')


INSERT INTO Products
VALUES
('Chais', 1, 1, 18.00),
('Chang', 1, 1, 19.00),
('Aniseed Syrup', 1, 2, 10.00),
('Chef Anton’s Cajun Seasoning', 2, 2, 22.00),
('Chef Anton’s Gumbo Mix', 2, 2, 21.35)


