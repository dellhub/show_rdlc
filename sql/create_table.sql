USE selldb

CREATE TABLE Customers
(CustomerID int not null,
CustomerName VARCHAR(40) not null,
Contact VARCHAR(20)
CONSTRAINT customers_pk PRIMARY KEY (CustomerID)
)

CREATE TABLE Products
(ProductID int not null,
ProductName VARCHAR(40) not null,
Price int not null,
CONSTRAINT products_pk PRIMARY KEY (ProductID)
)

CREATE TABLE Orders
(OrderID int not null,
CustomerID int not null,
OrderDate datetime not null,
CONSTRAINT orders_pk PRIMARY KEY (OrderID),
CONSTRAINT fk_customers
	FOREIGN KEY (CustomerID)
	REFERENCES Customers(CustomerID),
)

CREATE TABLE OrderDetails
(OrderID int not null,
ProductID int not null,
QTY int not null,
CONSTRAINT fk_orders
	FOREIGN KEY (OrderID)
	REFERENCES Orders(OrderID),
CONSTRAINT fk_products
	FOREIGN KEY (ProductID)
	REFERENCES Products(ProductID)
)