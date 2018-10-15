# PostgreSQL

Esta sección describe el uso de la Base de Datos **PostgreSQL 9.5**

## 1. Descargas

A continuación se exponen las direcciones para la descarga.

> 1. [Sitio de Descarga PostgreSQL](https://www.postgresql.org/download/)
> 2. [Descarga PostgreSQL 9.5](https://get.enterprisedb.com/postgresql/postgresql-9.5.14-2-windows-x64.exe)
> 3. [Descarga librerías Npgsql](https://github.com/npgsql/npgsql/releases/download/v2.1.0/Npgsql-2.1.0-net45.zip)
> 	* Agregar referencia a Npgsql.dll
> 	* Agregar referencia a Mono.Security.dll

## 2. Durante la instalación

A continuación se mencionan algunas recomendaciones durante la instalación:

```
1. En la configuración regional seleccione Configuración Regional por defecto.
2. Recuerde que la cuenta creada después de la instalación de PostgreSQL es para el usuario postgres.
```

## 3. Posterior a la instalación

A continuación se mencionan algunas recomendaciones posterior a la instalación:

```
1. Crear un nuevo usuario (ejemplo: Admin, Administrador) para el acceso a PostgreSQL.
2. Habilitar conexiones remotas usando el archivo pg_hba.conf.
```

Tome como guía el archivo **Script_PostgreSQL.sql** para comenzar su desarrollo.