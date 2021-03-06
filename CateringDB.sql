USE [master]
GO
/****** Object:  Database [CateringDB]    Script Date: 23/08/2020 14:13:59 ******/
CREATE DATABASE [CateringDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CateringDB', FILENAME = N'C:\Users\mikel\CateringDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CateringDB_log', FILENAME = N'C:\Users\mikel\CateringDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CateringDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CateringDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CateringDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CateringDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CateringDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CateringDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CateringDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CateringDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CateringDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CateringDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CateringDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CateringDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CateringDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CateringDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CateringDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CateringDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CateringDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CateringDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CateringDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CateringDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CateringDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CateringDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CateringDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CateringDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CateringDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CateringDB] SET  MULTI_USER 
GO
ALTER DATABASE [CateringDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CateringDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CateringDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CateringDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CateringDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CateringDB] SET QUERY_STORE = OFF
GO
USE [CateringDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23/08/2020 14:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredientes]    Script Date: 23/08/2020 14:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_ingrediente] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ingredientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredientes_menus]    Script Date: 23/08/2020 14:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredientes_menus](
	[Id_menu] [int] NOT NULL,
	[Id_ingrediente] [int] NOT NULL,
 CONSTRAINT [PK_Ingredientes_menus] PRIMARY KEY CLUSTERED 
(
	[Id_menu] ASC,
	[Id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 23/08/2020 14:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Foto] [int] NOT NULL,
	[Id_tipo_menu] [int] NOT NULL,
	[Ingredientes_menu] [nvarchar](max) NULL,
	[Id_reserva] [int] NOT NULL,
 CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 23/08/2020 14:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_menu] [nvarchar](100) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Reservas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_menus]    Script Date: 23/08/2020 14:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_menus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tipos_menus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200424103759_InitialDatabaseCreation', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[Ingredientes] ON 

INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (1, N'lomo')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (2, N'rabas')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (3, N'merluza')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (4, N'jamon')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (5, N'ostras')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (6, N'rape')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (7, N'perejil')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (8, N'pollo')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (9, N'carne de cerdo')
INSERT [dbo].[Ingredientes] ([Id], [nombre_ingrediente]) VALUES (10, N'anchoas')
SET IDENTITY_INSERT [dbo].[Ingredientes] OFF
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (3, 1)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (5, 1)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (4, 2)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (8, 2)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (4, 5)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (8, 5)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (6, 6)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (3, 7)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (7, 7)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (7, 8)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (5, 9)
INSERT [dbo].[Ingredientes_menus] ([Id_menu], [Id_ingrediente]) VALUES (6, 10)
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Nombre], [Foto], [Id_tipo_menu], [Ingredientes_menu], [Id_reserva]) VALUES (3, N'Sorpresa de fin de semana', 18274, 1, N'lomo, perejil', 1)
INSERT [dbo].[Menus] ([Id], [Nombre], [Foto], [Id_tipo_menu], [Ingredientes_menu], [Id_reserva]) VALUES (4, N'Fantasia del mar', 84933, 2, N'rabas, ostras', 1)
INSERT [dbo].[Menus] ([Id], [Nombre], [Foto], [Id_tipo_menu], [Ingredientes_menu], [Id_reserva]) VALUES (5, N'Atardecer en la terraza', 35682, 1, N'carne de cerdo, lomo', 1)
INSERT [dbo].[Menus] ([Id], [Nombre], [Foto], [Id_tipo_menu], [Ingredientes_menu], [Id_reserva]) VALUES (6, N'Fiesta en la playa', 91209, 2, N'anchoas, rape', 1)
INSERT [dbo].[Menus] ([Id], [Nombre], [Foto], [Id_tipo_menu], [Ingredientes_menu], [Id_reserva]) VALUES (7, N'Barbacoa nocturna', 34884, 1, N'pollo, perejil', 1)
INSERT [dbo].[Menus] ([Id], [Nombre], [Foto], [Id_tipo_menu], [Ingredientes_menu], [Id_reserva]) VALUES (8, N'Demasiada sal', 99999, 2, N'rabas, ostras', 1)
SET IDENTITY_INSERT [dbo].[Menus] OFF
SET IDENTITY_INSERT [dbo].[Reservas] ON 

INSERT [dbo].[Reservas] ([Id], [Id_menu], [Estado], [Email], [Direccion]) VALUES (1, N'1', N'enviado', N'mimail@gmail.com', N'jakjhekdls')
INSERT [dbo].[Reservas] ([Id], [Id_menu], [Estado], [Email], [Direccion]) VALUES (2, N'4', N'enviado', N'pedro@gmail.com', N'kskxnh')
INSERT [dbo].[Reservas] ([Id], [Id_menu], [Estado], [Email], [Direccion]) VALUES (3, N'5', N'espera', N'lalala@gmail.com', N'lmsgto')
INSERT [dbo].[Reservas] ([Id], [Id_menu], [Estado], [Email], [Direccion]) VALUES (1002, N'4', N'enviado', N'kjfod@gmail.com', N'ldjs')
SET IDENTITY_INSERT [dbo].[Reservas] OFF
SET IDENTITY_INSERT [dbo].[Tipos_menus] ON 

INSERT [dbo].[Tipos_menus] ([Id], [Tipo]) VALUES (1, N'carne')
INSERT [dbo].[Tipos_menus] ([Id], [Tipo]) VALUES (2, N'pescado')
SET IDENTITY_INSERT [dbo].[Tipos_menus] OFF
/****** Object:  Index [IX_Ingredientes_menus_Id_ingrediente]    Script Date: 23/08/2020 14:14:00 ******/
CREATE NONCLUSTERED INDEX [IX_Ingredientes_menus_Id_ingrediente] ON [dbo].[Ingredientes_menus]
(
	[Id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Menus_Id_reserva]    Script Date: 23/08/2020 14:14:00 ******/
CREATE NONCLUSTERED INDEX [IX_Menus_Id_reserva] ON [dbo].[Menus]
(
	[Id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Menus_Id_tipo_menu]    Script Date: 23/08/2020 14:14:00 ******/
CREATE NONCLUSTERED INDEX [IX_Menus_Id_tipo_menu] ON [dbo].[Menus]
(
	[Id_tipo_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ingredientes_menus]  WITH CHECK ADD  CONSTRAINT [FK_Ingredientes_menus_Ingredientes_Id_ingrediente] FOREIGN KEY([Id_ingrediente])
REFERENCES [dbo].[Ingredientes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ingredientes_menus] CHECK CONSTRAINT [FK_Ingredientes_menus_Ingredientes_Id_ingrediente]
GO
ALTER TABLE [dbo].[Ingredientes_menus]  WITH CHECK ADD  CONSTRAINT [FK_Ingredientes_menus_Menus_Id_menu] FOREIGN KEY([Id_menu])
REFERENCES [dbo].[Menus] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ingredientes_menus] CHECK CONSTRAINT [FK_Ingredientes_menus_Menus_Id_menu]
GO
ALTER TABLE [dbo].[Menus]  WITH CHECK ADD  CONSTRAINT [FK_Menus_Reservas_Id_reserva] FOREIGN KEY([Id_reserva])
REFERENCES [dbo].[Reservas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_Menus_Reservas_Id_reserva]
GO
ALTER TABLE [dbo].[Menus]  WITH CHECK ADD  CONSTRAINT [FK_Menus_Tipos_menus_Id_tipo_menu] FOREIGN KEY([Id_tipo_menu])
REFERENCES [dbo].[Tipos_menus] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_Menus_Tipos_menus_Id_tipo_menu]
GO
USE [master]
GO
ALTER DATABASE [CateringDB] SET  READ_WRITE 
GO
