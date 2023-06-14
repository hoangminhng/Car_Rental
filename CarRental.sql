


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
  BrandID INT IDENTITY(1,1) PRIMARY KEY,
  BrandName VARCHAR(50),
  Logo VARCHAR(MAX)
)

CREATE TABLE Car
(
	Car_ID int IDENTITY(1,1) PRIMARY KEY,
	Model nvarchar(50),
	BrandID int FOREIGN KEY REFERENCES Brand(BrandID) NOT NULL,
	Account_ID int FOREIGN KEY REFERENCES [User](Account_ID) NOT NULL,
	Type varchar(50),
	Images varchar(500),
	Seats int,
	Transmission varchar(50),
	Fuel varchar(50),
	Consumption int,
	Describe nvarchar(100),
	Price DECIMAL(10,2),
	Status int CHECK (Status = 0 or Status = 1)
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
	RentalDetail_ID int PRIMARY KEY,
	PickupDate DATE,
	PickupTime TIME,
	PickupLocation VARCHAR(100),
	DropOffDate DATE,
	DropOffTime TIME,
	DropOffLocation VARCHAR(100),
	FOREIGN KEY (RentalDetail_ID) REFERENCES Rental(Rental_ID)
)

CREATE TABLE Payment (
  Payment_ID INT PRIMARY KEY,
  Account_ID INT FOREIGN KEY REFERENCES Account(Account_ID),
  Total_price DECIMAL(10, 2),
  Status INT check(Status = 0 or Status = 1 or Status = 2), --cancel:0, pending: 1, successed: 2
  FOREIGN KEY (Payment_ID) REFERENCES [RentalDetail](RentalDetail_ID)
)

INSERT INTO [dbo].[User](Username, Password, Role, Status) VALUES
	('admin', 123, 0, 0),
	('lessee', 123, 2, 0),
	('renter', 123, 1, 0),
	('lessee2', 123, 2, 0),
	('renter2', 123, 1, 0)


INSERT INTO [dbo].[Account] ([Account_ID], [Fullname], [Phone], [Email], [Address]) VALUES
(1, 'Admin Khang', '0923123122', 'admin@gmail.com', 'Binh Chanh'),
(2, 'Lessee 1', '012341234', 'lessee1@gmail.com', 'Quan 1'),
(3, 'Renter 1', '012341233', 'renter1@gmail.com', 'Quan 2'),
(4, 'Lessee 2', '012343134', 'lessee2@gmail.com', 'Quan 3'),
(5, 'Renter 2', '012344333', 'renter2@gmail.com', 'Quan 4')

INSERT INTO [dbo].[Brand] ([BrandName], [Logo]) VALUES
('Toyota', 'C:\Users\khang\Downloads\CarRental\Logo\toyota.png'),
('Porsche', 'C:\Users\khang\Downloads\CarRental\Logo\porsche.jpg'),
('Mazda', 'C:\Users\khang\Downloads\CarRental\Logo\mazda.png'),
('KIA', 'C:\Users\khang\Downloads\CarRental\Logo\kia.png'),
('VinFast', 'C:\Users\khang\Downloads\CarRental\Logo\vinfast.jpg'),
('Audi', 'C:\Users\khang\Downloads\CarRental\Logo\audi.jpg'),
('Mercedes', 'C:\Users\khang\Downloads\CarRental\Logo\merc.png')

INSERT INTO [dbo].[Car] ([Model], [BrandID], [Account_ID], [Type], [Images], [Seats],
						[Transmission], [Fuel], [Consumption], [Describe], [Price], [Status])
VALUES
('Camry 2023', 1, 3, 'Sedan', 'C:\Users\khang\Downloads\CarRental\Car1.jpg', 4, 'Automatic', 'Gasonline', 7, 'Toyota nhu ba gia', 123, 1),
('C300 AMG', 7, 3, 'sedan', 'C:\Users\khang\Downloads\CarRental\Car2.jpg', 4, 'Automatic', 'Gasonline', 9, 'Mercedes C300 AMG', 900, 1),
('Macan', 2, 5, 'SUV', 'C:\Users\khang\Downloads\CarRental\Car3.jpg', 7, 'Automatic', 'Gasonline', 8, 'SUV gi ma ki', 500, 1)

INSERT INTO [dbo].[Rental] ([Account_ID], [Car_ID], [Status]) VALUES 
(2, 1, 0),
(2, 3, 0),
(4, 2, 0)

INSERT INTO [dbo].[RentalDetail] ([RentalDetail_ID], [PickupDate], [PickupTime], [PickupLocation], [DropOffDate], [DropOffTime], [DropOffLocation]) VALUES 
(1, '2023-06-24', '06:30:00', 'Dictrict 1', '2023-06-26', '06:30:00', 'Dictrict 1')
