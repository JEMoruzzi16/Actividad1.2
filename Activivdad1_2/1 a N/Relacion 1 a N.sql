--Creamos dos nuevas tablas en la misma base de datos, Persona y Automovil
--La tabla persona tiene Dni como clave primaria y la tabla Automovil tiene Patente como clave primaria
--Ambas tablas se relacionan a traves de Dni, que en la tabla automovil es una clave foranea.
--De esta manera podemos tener una persona con varios autos distintos, pero cada auto solo tiene una persona como dueño

use Actividad1_2
go
create table Persona(
Dni Int primary key,
Nombre varchar(20) not null,
Apellido varchar(20) not null,
Nacimiento date not null,
)
go
create table Automovil(
Patente varchar(10) primary key,
DniTitular int foreign key references Persona(Dni),
Marca varchar(10) not null,
Modelo tinyint not null,
)
