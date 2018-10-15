# Clases de Acceso

Esta sección describe las clases hechas en C# para las conexiones a las **Bases de Datos**

## 1. Archivos

A continuación se enlistan las clases importantes y su descripción.

### **SQLServer.cs**
> * Clase para trabajar con bases de datos SQL Server y SQL Server Express.
> * **Cadena de Conexión**
> 	* Data Source=localhost\\SQLExpress; Initial Catalog=TestDataBase; integrated security=yes; User Id=sa; Password=m1p4ssw0rd;

### **PostgreSQL.cs**
> * Clase para trabajar con bases de datos PostgreSQL.
> * **Cadena de Conexión**
> 	* Server=127.0.0.1; Port=5432; User id=Admin; Password=m1p4ssw0rd; Database=TestDataBase;

### **MySQL.cs**
> * Clase para trabajar con bases de datos MySQL.
> * **Cadena de Conexión**
> 	* Server=127.0.0.1; Port=3306; User id=Admin; Password=m1p4ssw0rd; Database=TestDataBase; sslmode=none; persistsecurityinfo=True;

### **Oracle.cs**
> * Clase para trabajar con bases de datos Oracle XE.
> * **Cadena de Conexión**
> 	* Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); Password=m1p4ssw0rd; User ID=Admin;
