--Utilizamos la misma base de dato y creamos las tablas Materia y Alumno_Materia, tambien volvemos a utilizar la tabla Alumno ya existente en la base de datos.
--La tabla materia podee Nombre como clave primaria, la tabla Alumno_Materia que es la utilizamos para relacionar ambas tablas(Alumno y Materia) posee una clave primaria compuesta
--De esta manera podemos tener una tabla con un legajo inscripto para varias materias y una materia con varios alumnos inscriptos en ella 

Use Actividad1_2
go
create table Materia(
Nombre varchar(20) primary key,
Profesor Varchar(30) not null,
Turno char check((Turno = 'M') or (Turno = 'N') or (Turno = 'T')),
)
go
create table Alumno_Materia(
Legajo int foreign key references Alumno(Legajo),
Nombre varchar(20)foreign key references Materia(Nombre),
Primary key(Legajo, Nombre),
)
