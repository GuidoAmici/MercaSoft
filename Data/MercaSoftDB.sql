USE master
GO

DROP database MercaSoftDB
GO

CREATE database MercaSoftDB
GO

USE MercaSoftDB
GO

Create table Users(
	ID int not null identity,
	Username varchar(30) not null unique,
	Password varchar(30) not null,
	Email varchar (50) not null unique,
	RegistrationDate DateTime not null default getdate(),
	PRIMARY KEY (ID)
)
GO

Insert into Users (Username, Password, Email) values 
('adz','adz','adz@adz.com'),
('asd','asd','asdasd.com')
Go

Create table Companies(
	ID int not null identity,
	Name varchar(50) not null,
	IsClient bit not null,
	IsSupplier bit not null,
	PRIMARY KEY (ID)
)
GO

Insert into Companies(Name,IsClient,IsSupplier) values
('Grow Sweet Grow',1,1),
('Arbol Viejo',1,0),
('Buen Consejo',1,0)
GO

Create table Invoices(
	ID int not null identity,
	Date DateTime not null default getdate(),
	CompanyID int not null,
	IsSale bit not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (CompanyID) references Companies(ID)
)
GO

Create table ItemCategories(
	ID int not null identity,
	Name varchar(30) not null,
	IsActive bit not null
	PRIMARY KEY (ID)
)
GO

insert into ItemCategories (Name, IsActive) values 
	('Medición', 1),
	('Accesorios', 1),
	('Merchandising', 1),
	('Insumos', 1)
GO

Create table Items(
	ID int not null identity,
	Name varchar(50) not null,
	Price float,
	ItemCategoryID int,
	Producible bit not null,
	IsForSale bit not null,
	Stock int not null,
	Description varchar(100),
	CodeName varchar(30),
	BarCode int,
	PRIMARY KEY (ID),
	FOREIGN KEY (ItemCategoryID) references ItemCategories(ID)
)
GO

Insert into Items (Name,ItemCategoryID,Producible,IsForSale,Stock) values
	('Buffer pH 4.01 (50 ml)',1,1,1,12),
	('Buffer pH 6.86 (50 ml)',1,1,1,24),
	('Buffer pH 9.18 (50 ml)',1,1,1,36),
	('Buffer pH 4.01 (100 ml)',1,1,1,6),
	('Buffer pH 6.86 (100 ml)',1,1,1,12),
	('Buffer pH 9.18 (100 ml)',1,1,1,18),
	('Frasco etiquetado - Buffer pH 4.01 (50 ml)',4,1,0,120),
	('Frasco etiquetado - Buffer pH 6.86 (50 ml)',4,1,0,240),
	('Frasco etiquetado - Buffer pH 9.18 (50 ml)',4,1,0,3600),
	('Frasco etiquetado - Buffer pH 4.01 (100 ml)',4,1,0,60),
	('Frasco etiquetado - Buffer pH 6.86 (100 ml)',4,1,0,120),
	('Frasco etiquetado - Buffer pH 9.18 (100 ml)',4,1,0,180),
	('Etiqueta - Buffer pH 4.01 (50 ml)',4,0,0,5000),
	('Etiqueta - Buffer pH 6.86 (50 ml)',4,0,0,6000),
	('Etiqueta - Buffer pH 9.18 (50 ml)',4,0,0,7000),
	('Etiqueta - Buffer pH 4.01 (100 ml)',4,0,0,500),
	('Etiqueta - Buffer pH 6.86 (100 ml)',4,0,0,600),
	('Etiqueta - Buffer pH 9.18 (100 ml)',4,0,0,700),
	('Envase LevePET (50 ml - ambar)',4,0,0,480),
	('Envase LevePET (100 ml - ambar)',4,0,0,4800),
	('Tapa RP28 (blanca)',4,0,0,2800),
	('Vaso medidor',4,0,0,1800),
	('Solución (ml) - Buffer pH 4.01',4,0,0,100),
	('Solución (ml) - Buffer pH 6.86',4,0,0,200),
	('Solución (ml) - Buffer pH 9.18',4,0,0,300)
GO

Create table SupplyItems(
	ID int not null identity,
	ProducedItemID int not null,
	SupplyItemID int not null,
	Quantity int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (ProducedItemID) references Items(ID),
	FOREIGN KEY (SupplyItemID) references Items(ID)
)
GO

Insert into SupplyItems (ProducedItemID,SupplyItemID,Quantity) values
	(7,13,1),
	(7,19,1),
	(1,7,1),
	(1,21,1),
	(1,22,1),
	(1,23,50)
GO

Create table SupplierItems(
	ID int not null identity,
	ItemID int not null,
	Price float not null,
	Date DateTime not null default getdate(),
	PRIMARY KEY (ID),
	FOREIGN KEY (ItemID) references Items(ID)
)
GO

Create table ReferencePriceHistory(
	ID int not null identity,
	ReferencePrice float not null,
	Date DateTime default getdate()
	PRIMARY KEY (ID)
)
GO

Create table ItemPriceHistory(
	ID int not null identity,
	ItemID int not null,
	AdditionDate DateTime not null default getdate(),
	Price float not null,
	AdditionReferencePriceID int not null,
	DischargeDate DateTime,
	DischargeReferencePriceID int,
	PRIMARY KEY (ID),
	FOREIGN KEY (ItemID) references Items(ID),
	FOREIGN KEY (AdditionReferencePriceID) references ReferencePriceHistory(ID),
	FOREIGN KEY (DischargeReferencePriceID) references ReferencePriceHistory(ID)
)
GO

Create table InvoiceItems(
	ID int not null identity,
	InvoiceID int not null,
	ItemID int not null,
	Price float not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (InvoiceID) references Invoices(ID),
	FOREIGN KEY (ItemID) references Items(ID)
)
GO

Create table LogHistory(
	ID int not null identity,
	UserID int not null,
	LogType varchar(7) not null,
	Date DateTime not null default getdate(),
	PRIMARY KEY (ID),
	FOREIGN KEY (UserID) references Users(ID),
)
GO

Create table ProductionOrders(
	ID int not null identity,
	UserID int not null,
	ProducedItemID int not null,
	Quantity int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (UserID) references Users(ID),
	FOREIGN KEY (ProducedItemID) references Items(ID)
)

Create table ProductionRows(
	ID int not null identity,
	UserID int not null,
	ProductionOrderID int not null,
	ProducedItemID int not null,
	Quantity int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (UserID) references Users(ID),
	FOREIGN KEY (ProductionOrderID) references ProductionOrders(ID),
	FOREIGN KEY (ProducedItemID) references Items(ID)
)

select * from LogHistory

select * from items where IsForSale = 1