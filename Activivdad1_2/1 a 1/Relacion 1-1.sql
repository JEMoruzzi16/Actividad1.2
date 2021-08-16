--Referencia 1:1 para para actividad 1.2
--Tenemos 2 tablas relacionas por el campo legajo que en ambas tablas es la clave primaria.
-- y en la tabla Alumno es una clave foranea de Legajo en la tabla Libreta.
--Esto mantiene la relacion de 1:1 ya que para cada Alumno solo va a haber una Libreta
--y lo mismo a la inversa.
create database Actividad 1_2
go
use Actividad1_2
go
create table Libreta(
Legajo int primary key,
Dni tinyint not null,
Carrera varchar(20) not null,
Nombre Varchar(15) not null,
Apellido Varchar(15) not null,
)
go
Create table Alumno(
Legajo int primary key foreign key references Libreta(Legajo),
Dni int not null,
Nombre Varchar(15) not null,
Apellido Varchar(15) not null,
Inscripcion date not null,
)
