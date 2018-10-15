# Clases de Acceso

Esta sección describe las clases hechas en C# para las conexiones a las **Bases de Datos**

## 1. Archivos

A continuación se enlistan las clases importantes y su descripción.

> 1. **SQLServer.cs**
> 	* Clase para trabajar con bases de datos SQL Server y SQL Server Express.
> 2. **Cadena de Conexión**
> 	* Data Source=localhost\\SQLExpress; Initial Catalog=TestDataBase; integrated security=yes; User Id=sa; Password=m1p4ssw0rd;

--
> 1. **PostgreSQL.cs**
> 	* Clase para trabajar con bases de datos PostgreSQL.
> 2. **Cadena de Conexión**
> 	* Server=127.0.0.1; Port=5432; User id=Admin; Password=m1p4ssw0rd; Database=TestDataBase;

--
> 1. **MySQL.cs**
> 	* Clase para trabajar con bases de datos MySQL.
> 2. **Cadena de Conexión**
> 	* Server=127.0.0.1; Port=3306; User id=Admin; Password=m1p4ssw0rd; Database=TestDataBase; sslmode=none; persistsecurityinfo=True;

--
> 1. **Oracle.cs**
> 	* Clase para trabajar con bases de datos Oracle XE.
> 2. **Cadena de Conexión**
> 	* Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE))); Password=m1p4ssw0rd; User ID=Admin;
