-----------------------------------------------
--SELECT table_name FROM user_tables
--select instance_name,  status from  v$instance;

-- Nombre del Server Host
--SELECT SYS_CONTEXT ('USERENV', 'SERVER_HOST') FROM DUAL;  

-- Nombre del Servicio de Oracle XE
--select sys_context('userenv','instance_name') from dual;
--SELECT instance FROM v$thread;

-- Cambiar de Workspace
--ALTER SESSION SET CURRENT_SCHEMA = TESTDATABASE;

-- Ver versiones
--SELECT * FROM PRODUCT_COMPONENT_VERSION;

drop table equipos
drop table usuarios

create table Usuarios (
	Id_Usu int NOT NULL,
	Nombre varchar(50),
	Apellidos varchar(100),
	Direccion varchar(100),
	Telefono varchar(50),
	Email varchar(50),
	RFC varchar(50),
	Sueldo double precision DEFAULT 0,
	Status int DEFAULT 0,		--0: Eliminado, 1: No Eliminado
	Activo int DEFAULT 0, 	--0: Usuario No Activo, 1: Usuario Activo
	primary key (id_usu)
)

CREATE TABLE Equipos ( 
	Id_Equ int NOT NULL,
	Id_Usu int NOT NULL,
	Nombre varchar(50),
	Fabricante varchar(50),
	Modelo varchar(50),
	NoSerie varchar(50),
	NoParte varchar(50),
	Status int DEFAULT 0,		--0: Eliminado, 1: No Eliminado
	Activo int DEFAULT 0,		--0: Usuario No Activo, 1: Usuario Activo
	primary key (id_equ)
)

-- Creación de llaves foraneas
ALTER TABLE Equipos ADD CONSTRAINT FK_Equipos_Usuario
FOREIGN KEY (ID_Usu) REFERENCES Usuarios (ID_Usu)

--Insertar en Usuarios
insert into Usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (1, 'Peter', 'Parker', 'peterparker@gmail.com', 'ABCD800808XYZ', 90, 1, 1)
insert into Usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (2, 'Charles', 'Xavier', 'charlesxavier@gmail.com', 'ABCD800808XYZ', 90, 1, 1)

--Insertar en Equipos con referencia a Usuarios
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (1, 1, 'Laptop', 'Apple', 'MacBook Pro 13"', 'NS000000001', 'NP000000001', 1, 1)
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (2, 1, 'Mouse', 'Apple', 'USB"', 'NSM00000001', 'NPM00000001', 1, 1)
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (3, 1, 'Teclado', 'Apple', 'USB', 'NST00000001', 'NPT00000001', 1, 1)
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (4, 2, 'Laptop', 'Apple', 'USB', 'NS000000001', 'NP000000001', 1, 1)
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (5, 2, 'Teclado', 'Apple', 'USB', 'NST00000001', 'NPT00000001', 1, 1)

-- Consulta de equipos asignados
--select id_equ, equipos.id_usu, equipos.nombre, equipos.noserie, fabricante, (usuarios.nombre || ' ' || usuarios.apellidos) as asignado from equipos 
--INNER JOIN usuarios 
--on usuarios.id_usu = equipos.id_usu order by usuarios.nombre