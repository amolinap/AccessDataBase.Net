
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

CREATE TABLE usuarios (
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

--Alter table Usuarios add foreign key (id_usualta) references Usuarios (id_usu) on update restrict on delete restrict;

insert into usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (1, 'Peter', 'Parker', 'peterparker@gmail.com', 'ABCD800808XYZ', 90, 1, 1);