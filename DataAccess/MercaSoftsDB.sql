USE master
GO

DROP database MercaSoftDB
GO

CREATE database MercaSoftDB
GO

USE MercaSoftDB

Create table Users(
	ID int not null identity(1,1),
	Username varchar(30) not null unique,
	Password varchar(30) not null,
	Email varchar (50) not null unique,
	PRIMARY KEY (ID)
)
GO

Insert into Users (Username, Password, Email) values ('adz', 'adz', 'adz@adz.com')
Go

Create table Clients(
	ID int not null identity(1,1),
	Name varchar(50) not null,
	PRIMARY KEY (ID)
)
GO

Insert into Clients(Name) values
('Grow Sweet Grow'),
('Arbol Viejo'),
('Buen Consejo')
GO

Create table Invoices(
	ID int not null identity(1,1),
	ClientID int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (ClientID) references Clients(ID)
)
GO

Create table Items(
	ID int not null identity(1,1),
	Name varchar(50) not null,
	Price float not null,
	PRIMARY KEY (ID)
)
GO

Create table InvoiceItems(
	ID int not null identity(1,1),
	InvoiceID int not null,
	PRIMARY KEY (ID),
	FOREIGN KEY (InvoiceID) references Invoices(ID)
)
GO