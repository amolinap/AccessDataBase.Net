drop table usuarios;

select * from usuarios;

create table usuarios
	(id_usu numeric(4),
	Nombre varchar(50),
	Apellidos varchar(100),
	Direccion varchar(100),
	Telefono varchar (50),
	Email varchar (50),
	RFC varchar (50),
	Sueldo decimal(4,2) DEFAULT 0,
	Status numeric(1) DEFAULT 0,	--0: Eliminado, 1: No Eliminado
	Activo numeric(1) DEFAULT 0, 	--0: Usuario No Activo, 1: Usuario Activo
	primary key (id_usu));

	insert into usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (1, 'Peter', 'Parker', 'peterparker@gmail.com', 'ABCD800808XYZ', 90, 1, 1);