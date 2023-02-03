USE master
GO

DROP database MercaSoftDB
GO

CREATE database MercaSoftDB
GO

USE MercaSoftDB

Create table Clients(
	ID int not null,
	Name varchar(50) not null,
	PRIMARY KEY (ID)
)
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