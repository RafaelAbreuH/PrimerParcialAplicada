CREATE DATABASE Parcial1Db
GO
USE Parcial1Db
GO
CREATE TABLE Articulos
(
	ArticuloId int primary key identity(1,1),
	FechaVencimiento date,
	Descripcion varchar(40),
	Precio int,
	Existencia int,
	CantCotizada int,
);