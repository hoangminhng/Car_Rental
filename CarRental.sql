

CREATE DATABASE CarRental
USE CarRental

CREATE TABLE [User]
(
    Account_ID int IDENTITY(1,1) PRIMARY KEY,
    Username nvarchar(50),
    Password nvarchar(50),
    Role int CHECK(Role = 0 or Role = 1 or Role = 2), -- admin: 0, renter: 1, lessee: 2
    Status int CHECK(Status = 0 or Status = 1) -- active: 0, unactive: 1
)

CREATE TABLE Account
(
    Account_ID int PRIMARY KEY,
    Fullname nvarchar(50),
    Phone varchar(11),
    Email varchar(50) UNIQUE,
    Address nvarchar(100),
    FOREIGN KEY (Account_ID) REFERENCES [User](Account_ID)
)

CREATE TABLE Brand (
  BrandID INT PRIMARY KEY,
  BrandName VARCHAR(50),
  Logo VARCHAR(MAX)
)

CREATE TABLE Car
(
	Car_ID int IDENTITY(1,1) PRIMARY KEY,
	Model nvarchar(50),
	BrandID int FOREIGN KEY REFERENCES Brand(BrandID),
	Type varchar(50),
	Images varchar(500),
	Seats int,
	Transmission varchar(50),
	Fuel varchar(50),
	Consumption int,
	Describe nvarchar(100),
	Price int
)

CREATE TABLE Rental
(
	Rental_ID int IDENTITY(1,1) PRIMARY KEY,
	Account_ID int FOREIGN KEY REFERENCES Account(Account_ID),
	Car_ID int FOREIGN KEY REFERENCES Car(Car_ID),
	Status int check(Status = 0 or Status = 1 or Status = 2) -- 0:rented; 1: renting; 2: ready to rent
)

CREATE TABLE RentalDetail
(
	RentalDetail_ID int IDENTITY(1,1) PRIMARY KEY,
	Rental_ID int FOREIGN KEY REFERENCES Rental(Rental_ID),
	PickupDate DATE,
	PickupTime TIME,
	PickupLocation VARCHAR(100),
	DropOffDate DATE,
	DropOffTime TIME,
	DropOffLocation VARCHAR(100),
)

CREATE TABLE Payment (
  Payment_ID INT PRIMARY KEY,
  Account_ID INT FOREIGN KEY REFERENCES Account(Account_ID),
  Total_price DECIMAL(10, 2),
  Status INT check(Status = 0 or Status = 1 or Status = 2), --cancel:0, pending: 1, successed: 2
  FOREIGN KEY (Payment_ID) REFERENCES [RentalDetail](RentalDetail_ID)
)

INSERT INTO [dbo].[User](Username, Password, Role, Status) VALUES('admin', 123, 0, 0)