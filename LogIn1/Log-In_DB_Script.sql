use master
go

-- creacion de DB.
create database CUENTA_DB
go

use CUENTA_DB
go


CREATE TABLE [dbo].[cuentas]
(
	[Nombre] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Datos] [varchar](200) NOT NULL,
)
GO