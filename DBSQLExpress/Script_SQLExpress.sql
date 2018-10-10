/**
 * @file:   Script_SQLExpress.sql
 * @author: Alejandro Molina Pulido
 * @email:  am.alex09@gmail.com
 * @date:   Octubre 2018
 * @brief:  This file exposes the SQL instructions to create the TestSQLExpress database.
 */

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'TestSQLExpress')
	DROP DATABASE [TestSQLExpress]
GO

CREATE DATABASE [TestSQLExpress]  
	ON (
	NAME = N'TestSQLExpress_Data', 
	FILENAME = N'c:\DataBase\TestSQLExpress\TestSQLExpress_Data.MDF', 
	SIZE = 5, FILEGROWTH = 10%) 
	LOG ON (
	NAME = N'TestSQLExpress_Log', 
	FILENAME = N'c:\DataBase\TestSQLExpress\TestSQLExpress_Log.LDF', 
	SIZE = 5, FILEGROWTH = 10%)
	COLLATE SQL_Latin1_General_CP1_CI_AS
GO

USE [TestSQLExpress]
GO

CREATE TABLE [dbo].[Usuarios] ( 
	[Id_Usu] [Decimal](4) NOT NULL,
	[Nombre] [varchar](50),
	[Apellidos] [varchar](100),
	[Direccion] [varchar](100),
	[Telefono] [varchar](50),
	[Email] [varchar](50),
	[RFC] [varchar](50),
	[Sueldo] [float] DEFAULT 0,
	[Status] [int] DEFAULT 0,		--0: Eliminado, 1: No Eliminado
	[Activo] [int] DEFAULT 0,		--0: Usuario No Activo, 1: Usuario Activo
) ON [PRIMARY]

DELETE [Usuarios]

ALTER TABLE Usuarios ADD CONSTRAINT PK_Usuarios
PRIMARY KEY (Id_Usu)

--ALTER TABLE Ventas ADD CONSTRAINT FK_Ventas_Usuario
--FOREIGN KEY (ID_Usuario) REFERENCES Usuarios (ID_Usuario)

insert into usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (1, 'Peter', 'Parker', 'peterparker@gmail.com', 'ABCD800808XYZ', 90, 1, 1);