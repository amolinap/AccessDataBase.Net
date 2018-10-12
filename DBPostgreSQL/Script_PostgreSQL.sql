
--En la Base de Datos postgres ejecutar los siguientes comandos

--Crear usuario Admin/admin1234
CREATE ROLE "Admin" LOGIN ENCRYPTED PASSWORD 'admin1234'
  SUPERUSER CREATEDB CREATEROLE REPLICATION
   VALID UNTIL 'infinity' CONNECTION LIMIT -1;

--Crear Base de Datos
CREATE DATABASE "TestPostgreSQL"
  WITH OWNER = "Admin"
       ENCODING = 'LATIN9'
       TEMPLATE = template0
       TABLESPACE = pg_default
       LC_COLLATE = 'C'
       LC_CTYPE = 'C'
       CONNECTION LIMIT = -1;


--En la Base de Datos TestPostgreSQL ejecutar los siguientes comandos

CREATE TABLE Usuarios (
    id_usu Integer NOT NULL,
    Nombre Varchar(50),
    Apellidos Varchar(100),
    Direccion Varchar(100),
    Telefono Varchar(50),
    Email Varchar(50),
    RFC Varchar(50),
    Sueldo Double precision DEFAULT 0,
    Status Integer DEFAULT 0,
    Activo Integer DEFAULT 0,
    PRIMARY KEY (id_usu)
)  With Oids;

CREATE TABLE Equipos ( 
  Id_Equ Integer NOT NULL,
  Id_Usu Integer NOT NULL,
  Nombre varchar(50),
  Fabricante varchar(50),
  Modelo varchar(50),
  NoSerie varchar(50),
  NoParte varchar(50),
  Status Integer DEFAULT 0,   --0: Eliminado, 1: No Eliminado
  Activo Integer DEFAULT 0,   --0: Usuario No Activo, 1: Usuario Activo
  primary key (id_equ)
) With Oids;

-- Creación de llaves foraneas
ALTER TABLE Equipos ADD CONSTRAINT FK_Equipos_Usuario
FOREIGN KEY (ID_Usu) REFERENCES Usuarios (ID_Usu)

--Insertar en Usuarios
insert into Usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (1, 'Peter', 'Parker', 'peterparker@gmail.com', 'ABCD800808XYZ', 90, 1, 1);
insert into Usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (2, 'Charles', 'Xavier', 'charlesxavier@gmail.com', 'ABCD800808XYZ', 90, 1, 1);

--Insertar en Equipos con referencia a Usuarios
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (1, 1, 'Laptop', 'Apple', 'MacBook Pro 13"', 'NS000000001', 'NP000000001', 1, 1);
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (2, 1, 'Mouse', 'Apple', 'USB"', 'NSM00000001', 'NPM00000001', 1, 1);
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (3, 1, 'Teclado', 'Apple', 'USB', 'NST00000001', 'NPT00000001', 1, 1);
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (4, 2, 'Laptop', 'Apple', 'USB', 'NS000000001', 'NP000000001', 1, 1);
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) values (5, 2, 'Teclado', 'Apple', 'USB', 'NST00000001', 'NPT00000001', 1, 1);

-- Consulta de equipos asignados
--select id_equ, equipos.id_usu, equipos.nombre, equipos.noserie, fabricante, (tt.nombre || ' '|| tt.apellidos) as asignado from equipos 
--INNER JOIN(select id_usu, nombre, apellidos from usuarios) as tt 
--on tt.id_usu = equipos.id_usu order by tt.nombre;