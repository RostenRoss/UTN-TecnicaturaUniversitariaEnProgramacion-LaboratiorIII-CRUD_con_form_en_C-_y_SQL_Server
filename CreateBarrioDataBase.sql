USE [master]
GO
/****** Object:  Database [BarrioDB]    Script Date: 17/06/2021 18:55:23 ******/
CREATE DATABASE [BarrioDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BarrioDB', FILENAME = N'D:\sqlServer\MSSQL15.MSSQLSERVER\MSSQL\DATA\BarrioDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BarrioDB_log', FILENAME = N'D:\sqlServer\MSSQL15.MSSQLSERVER\MSSQL\DATA\BarrioDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BarrioDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BarrioDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BarrioDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BarrioDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BarrioDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BarrioDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BarrioDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BarrioDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BarrioDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BarrioDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BarrioDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BarrioDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BarrioDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BarrioDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BarrioDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BarrioDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BarrioDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BarrioDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BarrioDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BarrioDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BarrioDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BarrioDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BarrioDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BarrioDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BarrioDB] SET RECOVERY FULL 
GO
ALTER DATABASE [BarrioDB] SET  MULTI_USER 
GO
ALTER DATABASE [BarrioDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BarrioDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BarrioDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BarrioDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BarrioDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BarrioDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BarrioDB', N'ON'
GO
ALTER DATABASE [BarrioDB] SET QUERY_STORE = OFF
GO
USE [BarrioDB]
GO
/****** Object:  Table [dbo].[casas]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[casas](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[manzana] [int] NOT NULL,
	[parcela] [int] NOT NULL,
	[calle] [nchar](20) NOT NULL,
	[altura] [int] NOT NULL,
 CONSTRAINT [PK_casas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exterior]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exterior](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tipo] [nchar](15) NOT NULL,
	[metrosCuadrados] [float] NOT NULL,
	[id_casa] [bigint] NOT NULL,
 CONSTRAINT [PK_Exterior] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[habitacion]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[habitacion](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tipo] [nchar](15) NOT NULL,
	[metrosCuadrados] [float] NOT NULL,
	[id_casa] [bigint] NOT NULL,
 CONSTRAINT [PK_habitacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hijos]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hijos](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](30) NOT NULL,
	[gradoEscuela] [int] NOT NULL,
	[sexo] [bit] NULL,
	[edad] [int] NOT NULL,
	[fechaNacimiento] [datetime] NOT NULL,
	[id_padre] [bigint] NOT NULL,
	[id_casa] [bigint] NOT NULL,
 CONSTRAINT [PK_hijos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mascota]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mascota](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[familia] [nchar](15) NOT NULL,
	[dieta] [nchar](15) NOT NULL,
	[nombre] [nchar](15) NOT NULL,
	[tipo] [nchar](15) NOT NULL,
	[edad] [int] NOT NULL,
	[id_casa] [bigint] NULL,
 CONSTRAINT [PK_mascota] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[muebles]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muebles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](20) NOT NULL,
	[id_lugar] [bigint] NOT NULL,
 CONSTRAINT [PK_muebles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[padres]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[padres](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](30) NOT NULL,
	[sexo] [bit] NOT NULL,
	[edad] [int] NOT NULL,
	[fechaNacimiento] [datetime] NOT NULL,
	[trabajo] [nchar](15) NOT NULL,
	[id_casa] [bigint] NULL,
 CONSTRAINT [PK_padres_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicioAgua]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicioAgua](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tipo] [nchar](10) NOT NULL,
	[empresa] [nchar](10) NOT NULL,
	[precio] [float] NOT NULL,
	[fechaInstalado] [datetime] NOT NULL,
	[id_casa] [bigint] NULL,
 CONSTRAINT [PK_ServicioAgua] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicioCable]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicioCable](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tipo] [nchar](10) NOT NULL,
	[esHd] [bit] NOT NULL,
	[precio] [float] NOT NULL,
	[empresa] [nchar](10) NOT NULL,
	[limiteDeDatos] [float] NOT NULL,
	[fechaInstalado] [datetime] NOT NULL,
	[id_casa] [bigint] NULL,
 CONSTRAINT [PK_servicioInternet] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicioElectricidad]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicioElectricidad](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[esTrifasica] [bit] NOT NULL,
	[precio] [float] NOT NULL,
	[empresa] [nchar](10) NOT NULL,
	[fechaInstalado] [datetime] NOT NULL,
	[id_casa] [bigint] NULL,
 CONSTRAINT [PK_servicioElectricidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicioInternet]    Script Date: 17/06/2021 18:55:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicioInternet](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tipo] [nchar](10) NOT NULL,
	[velocidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[empresa] [nchar](10) NOT NULL,
	[limiteDeDatos] [nchar](10) NOT NULL,
	[fechaInstalado] [datetime] NULL,
	[id_casa] [bigint] NULL,
 CONSTRAINT [PK_servicioInternet_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[exterior]  WITH CHECK ADD  CONSTRAINT [FK_Exterior_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[exterior] CHECK CONSTRAINT [FK_Exterior_casas]
GO
ALTER TABLE [dbo].[habitacion]  WITH CHECK ADD  CONSTRAINT [FK_habitacion_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[habitacion] CHECK CONSTRAINT [FK_habitacion_casas]
GO
ALTER TABLE [dbo].[hijos]  WITH CHECK ADD  CONSTRAINT [FK_hijos_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[hijos] CHECK CONSTRAINT [FK_hijos_casas]
GO
ALTER TABLE [dbo].[hijos]  WITH CHECK ADD  CONSTRAINT [FK_hijos_padres] FOREIGN KEY([id_padre])
REFERENCES [dbo].[padres] ([id])
GO
ALTER TABLE [dbo].[hijos] CHECK CONSTRAINT [FK_hijos_padres]
GO
ALTER TABLE [dbo].[mascota]  WITH CHECK ADD  CONSTRAINT [FK_mascota_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[mascota] CHECK CONSTRAINT [FK_mascota_casas]
GO
ALTER TABLE [dbo].[muebles]  WITH CHECK ADD  CONSTRAINT [FK_muebles_Exterior] FOREIGN KEY([id])
REFERENCES [dbo].[exterior] ([id])
GO
ALTER TABLE [dbo].[muebles] CHECK CONSTRAINT [FK_muebles_Exterior]
GO
ALTER TABLE [dbo].[muebles]  WITH CHECK ADD  CONSTRAINT [FK_muebles_habitacion] FOREIGN KEY([id])
REFERENCES [dbo].[habitacion] ([id])
GO
ALTER TABLE [dbo].[muebles] CHECK CONSTRAINT [FK_muebles_habitacion]
GO
ALTER TABLE [dbo].[padres]  WITH CHECK ADD  CONSTRAINT [FK_padres_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[padres] CHECK CONSTRAINT [FK_padres_casas]
GO
ALTER TABLE [dbo].[servicioAgua]  WITH CHECK ADD  CONSTRAINT [FK_servicioAgua_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[servicioAgua] CHECK CONSTRAINT [FK_servicioAgua_casas]
GO
ALTER TABLE [dbo].[servicioCable]  WITH CHECK ADD  CONSTRAINT [FK_servicioCable_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[servicioCable] CHECK CONSTRAINT [FK_servicioCable_casas]
GO
ALTER TABLE [dbo].[servicioElectricidad]  WITH CHECK ADD  CONSTRAINT [FK_servicioElectricidad_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[servicioElectricidad] CHECK CONSTRAINT [FK_servicioElectricidad_casas]
GO
ALTER TABLE [dbo].[servicioInternet]  WITH CHECK ADD  CONSTRAINT [FK_servicioInternet_casas] FOREIGN KEY([id_casa])
REFERENCES [dbo].[casas] ([id])
GO
ALTER TABLE [dbo].[servicioInternet] CHECK CONSTRAINT [FK_servicioInternet_casas]
GO
USE [master]
GO
ALTER DATABASE [BarrioDB] SET  READ_WRITE 
GO
