create table Rentals
(
Id int identity(1,1) not null,
CarId int not null,
CustomerId int not null,
RentDate datetime not null,
ReturnDate datetime,
primary key(Id),
foreign key(CarId) references Cars(CarId),
foreign key(CustomerId) references Customers(Id)
)

create table Customers
(
Id int identity(1,1) not null,
UserId int not null,
CompanyName nvarchar(255) not null,
primary key(Id),
foreign key(UserId) references Users(Id)
)
create table Users
(
Id int identity(1,1) not null,
FirstName nvarchar(255) not null,
LastName nvarchar(255) not null,
Email nvarchar(255) not null,
Password nvarchar(255) not null,
primary key(Id)
)