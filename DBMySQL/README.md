# MySQL

Esta sección describe el uso de la Base de Datos **MySQL Community Server 5.7.23**

> [Youtube, instalación de MySQL](https://www.youtube.com/watch?v=ub4SFBoW2cE)

## 1. Descargas

A continuación se exponen las direcciones para la descarga.

> 1. [Sitio de Descarga MySQL](https://dev.mysql.com/downloads/windows/installer/5.7.html)
> 2. [Descarga MySQL 5.7](https://dev.mysql.com/get/Downloads/MySQLInstaller/mysql-installer-community-5.7.23.0.msi)
> 3. [Descarga librerías MySQL](https://downloads.mysql.com/archives/get/file/mysql-connector-net-6.9.5-noinstall.zip)
> 	* Agregar referencia a MySQL.Data.dll del directorio v4.5

**Nota**: Es posble que la instalación de MySQL nos pida actualizar el Framework.
> 1. [Sitio de Descarga Framework 4.5.2](https://www.microsoft.com/es-mx/download/details.aspx?id=42642)
> 2. [Descarga Framework 4.5.2](https://download.microsoft.com/download/E/2/1/E21644B5-2DF2-47C2-91BD-63C560427900/NDP452-KB2901907-x86-x64-AllOS-ENU.exe)


## 2. Durante la instalación

A continuación se mencionan algunas recomendaciones durante la instalación:

```
1. En la configuración verifique Config Type: Development Computer.
2. En la configuración verifique TCP/IP Port: 3306, X Protocol Port: 33060.
3. Recuerde que la cuenta creada después de la instalación de MySQL es para el usuario Root.
```

## 3. Posterior a la instalación

A continuación se mencionan algunas recomendaciones posterior a la instalación:

```
1. Crear un nuevo usuario (ejemplo: Admin, Administrador) para el acceso a MySQL.
2. Crear nuevo Schema de trabajo: Default Charset, Default Collation.
```

Tome como guía el archivo **Script_MySQL.sql** para comenzar su desarrollo.
