CREATE DATABASE TpCuatrimestralMoruzziQuinteros
GO
USE TpCuatrimestralMoruzziQuinteros
GO
CREATE TABLE TipoDeProducto(
     Id INT PRIMARY KEY NOT NULL Identity(1,1),
     Descripcion VARCHAR(50) NOT NULL,
     Estado bit not null DEFAULT 1
)
GO
CREATE TABLE Producto(
    Codigo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    IdTipoProducto INT FOREIGN KEY REFERENCES TipoDeProducto(Id) NOT NULL,
    Precio Money NOT NULL CHECK(Precio>0),
    Stock int NOT NULL CHECK(Stock>=0),
    Estado BIT NOT NULL DEFAULT 1, 
    DescripcionPlato VARCHAR(50) NOT NULL,
)
go
CREATE TABLE MetodoPago(
    Id int PRIMARY KEY NOT NULL ,
    Descripcion VARCHAR(20) NOT NULL UNIQUE,
    Estado BIT not null DEFAULT 1
)
go
CREATE TABLE DatosPersonales(
    Usuario VARCHAR(25) PRIMARY KEY NOT NULL,
    Nombre VARCHAR(20) NOT NULL,
    Apellido VARCHAR(20) NOT NULL,
    FechaNacimiento DATETIME NOT NULL,
    FechaIngreso DATETIME NOT NULL,
    Estado bit not NULL DEFAULT 1
)
go
CREATE TABLE Usuarios(
	Id int primary key identity(1,1),
    Usuario VARCHAR(25) FOREIGN KEY REFERENCES DatosPersonales(Usuario),
    Contrasena VARCHAR(10) NOT NULL,
    Tipo INT NOT NULL,
	Estado bit default 1 not null
)
GO
Create table Mesa(
    Nro int Primary key not null,
    Estado bit DEFAULT 0,
    Capacidad int not null,

)
go
create table Pedido(
    Nro int PRIMARY KEY IDENTITY(1,1) not null,
    IdMesero int FOREIGN KEY REFERENCES Usuarios(Id) not null,
    Fecha DATETIME not null,
    Monto Decimal (10,2) NOT null,
    IdMetodoPago int FOREIGN KEY REFERENCES MetodoPago(Id) not null,
	NroMesa int FOREIGN key REFERENCES Mesa(Nro),
	Estado bit DEFAULT 1 NOT NULL
)
GO
create table Pedido_Producto(
    NroPedido int FOREIGN KEY REFERENCES Pedido(Nro) null,
    CodigoProducto int FOREIGN KEY REFERENCES Producto(Codigo) not null
)
