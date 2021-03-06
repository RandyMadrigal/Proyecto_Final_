USE [master]
GO
/****** Object:  Database [Programacion2]    Script Date: 28/4/2021 8:30:32 p. m. ******/
CREATE DATABASE [Programacion2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Programacion2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Programacion2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Programacion2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Programacion2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Programacion2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Programacion2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Programacion2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Programacion2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Programacion2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Programacion2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Programacion2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Programacion2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Programacion2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Programacion2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Programacion2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Programacion2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Programacion2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Programacion2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Programacion2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Programacion2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Programacion2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Programacion2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Programacion2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Programacion2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Programacion2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Programacion2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Programacion2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Programacion2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Programacion2] SET RECOVERY FULL 
GO
ALTER DATABASE [Programacion2] SET  MULTI_USER 
GO
ALTER DATABASE [Programacion2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Programacion2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Programacion2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Programacion2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Programacion2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Programacion2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Programacion2', N'ON'
GO
ALTER DATABASE [Programacion2] SET QUERY_STORE = OFF
GO
USE [Programacion2]
GO
/****** Object:  User [Chan]    Script Date: 28/4/2021 8:30:32 p. m. ******/
CREATE USER [Chan] FOR LOGIN [Chan] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 28/4/2021 8:30:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[IdTurno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[HoraRegistro] [datetime] NOT NULL,
	[Resultado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Registro] ON 

INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (1, N'Maria', CAST(N'2021-04-27T23:56:17.970' AS DateTime), N'Ganador')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (2, N'Juana', CAST(N'2021-04-27T23:56:17.970' AS DateTime), N'Perdedor')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (3, N'sofia', CAST(N'2021-04-27T23:56:17.970' AS DateTime), N'Perdedor')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (4, N'Randy', CAST(N'2021-04-28T00:24:58.957' AS DateTime), N'Perdedor')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (5, N'pedro', CAST(N'2021-04-28T01:03:29.380' AS DateTime), N'Ganador')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (6, N'Fernando', CAST(N'2021-04-28T01:03:36.873' AS DateTime), N'Ganador')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (7, N'No', CAST(N'2021-04-28T01:14:41.403' AS DateTime), N'Perdedor')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (8, N'Maria', CAST(N'2021-04-28T19:36:57.743' AS DateTime), N'Ganador')
INSERT [dbo].[Registro] ([IdTurno], [nombre], [HoraRegistro], [Resultado]) VALUES (9, N'', CAST(N'2021-04-28T19:43:51.687' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Registro] OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar]    Script Date: 28/4/2021 8:30:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizar]
(
@ID int,
@RESULTADO varchar(20)
)
as
begin

	update Registro set Resultado = @RESULTADO where IdTurno = @ID 

end
GO
/****** Object:  StoredProcedure [dbo].[sp_Contador]    Script Date: 28/4/2021 8:30:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Contador]
as
begin

	select MAX(IdTurno) + 1 from registro 

end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar]    Script Date: 28/4/2021 8:30:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertar](
@NOMBRE varchar (20)
)
as
begin

	insert into Registro(nombre,HoraRegistro) values(@NOMBRE,GETDATE() )

end
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar]    Script Date: 28/4/2021 8:30:32 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_mostrar]
as 
begin

	select * from Registro

end
GO
USE [master]
GO
ALTER DATABASE [Programacion2] SET  READ_WRITE 
GO
