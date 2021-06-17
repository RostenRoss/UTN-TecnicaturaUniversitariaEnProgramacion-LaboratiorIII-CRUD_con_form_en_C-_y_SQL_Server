
/****** Casa ******/

USE [BarrioDB]
GO

INSERT INTO [dbo].[casas]
           ([manzana]
           ,[parcela]
           ,[calle]
           ,[altura])
     VALUES
           (<manzana, int,>
           ,<parcela, int,>
           ,<calle, nchar(20),>
           ,<altura, int,>)
GO

/****** Exterior ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[exterior]
           ([tipo]
           ,[metrosCuadrados]
           ,[id_casa])
     VALUES
           (<tipo, nchar(15),>
           ,<metrosCuadrados, float,>
           ,<id_casa, bigint,>)
GO

/****** Habitacion ******/

USE [BarrioDB]
GO

INSERT INTO [dbo].[habitacion]
           ([tipo]
           ,[metrosCuadrados]
           ,[id_casa])
     VALUES
           (<tipo, nchar(15),>
           ,<metrosCuadrados, float,>
           ,<id_casa, bigint,>)
GO

/****** Padre ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[padres]
           ([nombre]
           ,[sexo]
           ,[edad]
           ,[fechaNacimiento]
           ,[trabajo]
           ,[id_casa])
     VALUES
           (<nombre, nchar(30),>
           ,<sexo, bit,>
           ,<edad, int,>
           ,<fechaNacimiento, datetime,>
           ,<trabajo, nchar(15),>
           ,<id_casa, bigint,>)
GO

/****** HIJO ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[hijos]
           ([nombre]
           ,[gradoEscuela]
           ,[sexo]
           ,[edad]
           ,[fechaNacimiento]
           ,[id_padre]
           ,[id_casa])
     VALUES
           (<nombre, nchar(30),>
           ,<gradoEscuela, int,>
           ,<sexo, bit,>
           ,<edad, int,>
           ,<fechaNacimiento, datetime,>
           ,<id_padre, bigint,>
           ,<id_casa, bigint,>)
GO

/****** Mueble ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[muebles]
           ([nombre]
           ,[id_lugar])
     VALUES
           (<nombre, nchar(20),>
           ,<id_lugar, bigint,>)
GO

/****** Mascota ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[mascota]
           ([familia]
           ,[dieta]
           ,[nombre]
           ,[tipo]
           ,[edad]
           ,[id_casa])
     VALUES
           (<familia, nchar(15),>
           ,<dieta, nchar(15),>
           ,<nombre, nchar(15),>
           ,<tipo, nchar(15),>
           ,<edad, int,>
           ,<id_casa, bigint,>)
GO

/****** Servicio Agua ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[servicioAgua]
           ([tipo]
           ,[empresa]
           ,[precio]
           ,[fechaInstalado]
           ,[id_casa])
     VALUES
           (<tipo, nchar(10),>
           ,<empresa, nchar(10),>
           ,<precio, float,>
           ,<fechaInstalado, datetime,>
           ,<id_casa, bigint,>)
GO

/****** Servicio Luz ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[servicioElectricidad]
           ([esTrifasica]
           ,[precio]
           ,[empresa]
           ,[fechaInstalado]
           ,[id_casa])
     VALUES
           (<esTrifasica, bit,>
           ,<precio, float,>
           ,<empresa, nchar(10),>
           ,<fechaInstalado, datetime,>
           ,<id_casa, bigint,>)
GO

/****** Servicio Cable ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[servicioCable]
           ([tipo]
           ,[esHd]
           ,[precio]
           ,[empresa]
           ,[limiteDeDatos]
           ,[fechaInstalado]
           ,[id_casa])
     VALUES
           (<tipo, nchar(10),>
           ,<esHd, bit,>
           ,<precio, float,>
           ,<empresa, nchar(10),>
           ,<limiteDeDatos, float,>
           ,<fechaInstalado, datetime,>
           ,<id_casa, bigint,>)
GO

/****** Servicio Internet ******/
USE [BarrioDB]
GO

INSERT INTO [dbo].[servicioInternet]
           ([tipo]
           ,[velocidad]
           ,[precio]
           ,[empresa]
           ,[limiteDeDatos]
           ,[fechaInstalado]
           ,[id_casa])
     VALUES
           (<tipo, nchar(10),>
           ,<velocidad, int,>
           ,<precio, float,>
           ,<empresa, nchar(10),>
           ,<limiteDeDatos, nchar(10),>
           ,<fechaInstalado, datetime,>
           ,<id_casa, bigint,>)
GO

