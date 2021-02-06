Create Table Cars(
CarId int,
BrandId int,
ColorId int,
CarModel nvarchar,
CarManufacturedYear Date,
Primary Key (CarId)
)


Create Table Brands(
BrandId int,
BrandName nvarchar,
Primary Key (BrandId)
)

Create Table Colors(
ColorId int,
ColorName nvarchar,
Primary Key (ColorId)
)

ALTER TABLE Brands
ALTER COLUMN BrandName varchar(30);

ALTER TABLE Colors
ALTER COLUMN ColorName varchar(20);

ALTER TABLE Cars
ALTER COLUMN CarModel varchar(20);



