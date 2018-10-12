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

CREATE TABLE [dbo].[Equipos] ( 
	[Id_Equ] [Decimal](4) NOT NULL,
	[Id_Usu] [Decimal](4) NOT NULL,
	[Nombre] [varchar](50),
	[Fabricante] [varchar](50),
	[Modelo] [varchar](50),
	[NoSerie] [varchar](50),
	[NoParte] [varchar](50),
	[Status] [int] DEFAULT 0,		--0: Eliminado, 1: No Eliminado
	[Activo] [int] DEFAULT 0,		--0: Usuario No Activo, 1: Usuario Activo
) ON [PRIMARY]

DELETE [Usuarios]

ALTER TABLE Usuarios ADD CONSTRAINT PK_Usuarios
PRIMARY KEY (Id_Usu)

ALTER TABLE Equipos ADD CONSTRAINT PK_Equipos
PRIMARY KEY (Id_Equ)

ALTER TABLE Equipos ADD CONSTRAINT FK_Equipos_Usuario
FOREIGN KEY (ID_Usu) REFERENCES Usuarios (ID_Usu)

insert into Usuarios(id_usu, nombre, apellidos, email, rfc, sueldo, status, activo) values (1, 'Peter', 'Parker', 'peterparker@gmail.com', 'ABCD800808XYZ', 90, 1, 1);
insert into Equipos(id_equ, id_usu, nombre, fabricante, modelo, noserie, noparte, status, activo) 
	values (1, 1, 'Laptop', 'Apple', 'MacBook Pro 13"', 'NS000000001', 'NP000000001', 1, 1);