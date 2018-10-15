# Microsoft SQL Server 2014 Express

Esta sección describe el uso de la Base de Datos **Microsoft SQL Server 2014 Express**

## 1. Descargas

A continuación se exponen las direcciones para la descarga.

> 1. [Sitio de Descarga SQL Server Express 2014](https://www.microsoft.com/es-mx/download/details.aspx?id=53167)
> 2. [Descarga SQL Server Express 2014](https://download.microsoft.com/download/E/7/F/E7F2DCDF-BB7A-4929-BCA6-90B25D504E4F/SQLEXPR_x64_ESN.exe)

**NOTA**: Por defecto Visual Studio incluye las librerías para trabajar con SQL Server, por lo que no es necesario descargarlas.

> System.Data.dll, C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.

## 2. Durante la instalación

A continuación se mencionan algunas recomendaciones durante la instalación:

```
1. En la configuración del nombre de la instancia acepte la denominación por defecto: SQLEXPRESS.
2. En la configuración del modo de autenticación active la opción de Mixed Mode y confirme el password.
3. Recuerde que la cuenta creada después de la instalación de SQL Server Express es para el usuario sa.
```

## 3. Posterior a la instalación

A continuación se mencionan algunas recomendaciones posterior a la instalación:

```
1. Verificar que los servicios de SQL Server se están ejecutando.
2. Para conexiones remotas verificar SQL Server Network Configuration, TCP/IP IP Addresses.
```

Tome como guía el archivo **Script_SQLExpress.sql** para comenzar su desarrollo.