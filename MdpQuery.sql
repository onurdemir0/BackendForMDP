CREATE TABLE [dbo].[Products]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryId] INT NOT NULL, 
    [ProductName] VARCHAR(50) NOT NULL, 
    [UnitsInStock] INT NOT NULL, 
    [UnitPrice] DECIMAL NOT NULL, 
    CONSTRAINT [FK_Products_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([CategoryId])
);
CREATE TABLE [dbo].[Categories]
(
	[CategoryId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryName] VARCHAR(50) NOT NULL
);
CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL
);
CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [OrderDate] DATETIME NOT NULL, 
    [ShipCity] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([CustomerId]), 
    CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([ProductId])
);