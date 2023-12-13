create database Restaurante
use Restaurante
drop database restaurante

create table roles (
	idRol int identity primary key,
	nombreRol varchar(50) not null,
	estado bit not null
)
create table Personal (
	idPersonal int primary key not null,
	nombrePersonal varchar(50) not null,
	rolPersonal int not null,
	fotoPersonal image not null,
	correoPersonal varchar(50),
	celularPersonal varchar(50),
	nacimientoPersonal varchar(50),
	contraseñaPersonal int not null,
	estado bit
	FOREIGN KEY (rolPersonal) REFERENCES roles(idRol)
)


SELECT nombrePersonal, fotoPersonal FROM Personal
inner join roles on personal.rolPersonal = roles.idRol WHERE personal.estado =1 and nombreRol LIKE '%meser%'