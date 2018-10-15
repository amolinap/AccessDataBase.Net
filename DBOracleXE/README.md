# Oracle

Esta sección describe el uso de la Base de Datos **Oracle XE 11g**

## 1. Descargas

A continuación se exponen las direcciones para la descarga.

> 1. [Sitio de Descarga Oracle](https://www.oracle.com/technetwork/database/database-technologies/express-edition/downloads/index-083047.html)
> 2. [Descarga Oracle](http://download.oracle.com/otn/nt/oracle11g/xe/OracleXE112_Win64.zip)

## 2. Durante la instalación

A continuación se mencionan algunas recomendaciones durante la instalación:

```
1. Recuerde que la cuenta creada después de la instalación de Oracle es para el usuario system.
```

## 3. Posterior a la instalación

A continuación se mencionan algunas recomendaciones posterior a la instalación:

```
1. Verificar que los servicios de Oracle se están ejecutando.
2. Crear un nuevo usuario (ejemplo: Admin, Administrador) para el acceso a Oracle.
3. Agregar referencia a Oracle.DataAccess.dll de C:\oraclexe\app\oracle\product\11.2.0\server\odp.net\bin\4.
```

Tome como guía el archivo **Script_Oracle.sql** para comenzar su desarrollo.