
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

CREATE TABLE Empleados (
    id_emp Integer NOT NULL,
    Nombre Varchar(50),
    Apellidos Varchar(100),
    Direccion Varchar(100),
    Telefono Varchar(50),
    Email Varchar(50),
    RFC Varchar(50),
    Sueldo Double precision DEFAULT 0,
    Status Integer DEFAULT 0,
    Activo Integer DEFAULT 0,
    Foto bytea,
    PRIMARY KEY (id_emp)
)  With Oids;