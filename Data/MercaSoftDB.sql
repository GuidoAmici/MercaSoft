﻿USE master
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

Create table Categories(
	ID int not null identity,
	Name varchar(30) not null,
	IsActive bit not null
	PRIMARY KEY (ID)
)
GO

insert into Categories (Name, IsActive) values 
	('Medición', 1),
	('Accesorios', 1),
	('Merchandising', 1)
GO

Create table Items(
	ID int not null identity,
	Name varchar(50) not null,
	SalePrice float,
	CategoryID int,
	IsForSale bit not null,
	Description varchar(100),
	CodeName varchar(30),
	BarCode int,
	PRIMARY KEY (ID),
	FOREIGN KEY (CategoryID) references Categories(ID)
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

Create table ConsumableItems(
	ID int not null identity,
	ConsumableItemID int not null,
	ProducedItemID int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (ConsumableItemID) references Items(ID),
	FOREIGN KEY (ProducedItemID) references Items(ID)
)
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

select * from LogHistory