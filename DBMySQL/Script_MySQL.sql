
CREATE TABLE IF NOT EXISTS usuarios (
    id_usu INT NOT NULL,
    Nombre VARCHAR(50),
    Apellidos VARCHAR(100),
    Direccion VARCHAR(100),
    Telefono VARCHAR(50),
    Email VARCHAR(50),
    RFC VARCHAR(50),
    Sueldo float DEFAULT 0,
    Status INT DEFAULT 0,
    Activo INT DEFAULT 0,
    PRIMARY KEY (id_usu)
)  ENGINE=INNODB;

insert into usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (1, 'Peter', 'Parker', 'peterparker@gmail.com', 'ABCD800808XYZ', 90, 1, 1);