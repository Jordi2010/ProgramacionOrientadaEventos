USE [master]
GO
DROP DATABASE IF EXISTS [Biblioteca]
GO
/****** Object:  Database [Biblioteca]    Script Date: martes 10:17:32 ******/
CREATE DATABASE [Biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Biblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Biblioteca] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteca] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteca] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Biblioteca] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Biblioteca] SET QUERY_STORE = OFF
GO
USE [Biblioteca]
GO
/****** Object:  Table [dbo].[autores]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autores](
	[idAutor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodigosRecuperacion]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodigosRecuperacion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[Codigo] [nvarchar](6) NOT NULL,
	[Estado] [bit] NOT NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[devoluciones]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[devoluciones](
	[idDevoluciones] [int] IDENTITY(1,1) NOT NULL,
	[idPrestamo] [int] NULL,
	[idUsuario] [int] NULL,
	[fechaDevolucionReal] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDevoluciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estadoLibro]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estadoLibro](
	[idestadoLibro] [int] IDENTITY(1,1) NOT NULL,
	[estadoLibro] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idestadoLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estadoPrestamo]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estadoPrestamo](
	[idestadoPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[estadoPrestamo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idestadoPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libros]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libros](
	[idLibro] [int] IDENTITY(1,1) NOT NULL,
	[idAutor] [int] NULL,
	[idestadoLibro] [int] NULL,
	[editorialLibro] [varchar](50) NULL,
	[nombreLibro] [varchar](100) NULL,
	[isbnLibro] [varchar](100) NULL,
	[generoLibro] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prestamos]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prestamos](
	[idPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[idestadoPrestamo] [int] NULL,
	[idLibro] [int] NULL,
	[idUsuario] [int] NULL,
	[clientePrestamo] [varchar](100) NULL,
	[fechaPrestamo] [date] NULL,
	[fechaDevolucionEstimada] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: martes 10:17:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contraseña] [nvarchar](150) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[correo] [varchar](100) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[fechaCreacion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [correoConstraint] UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [usuarioConstraint] UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CodigosRecuperacion] ADD  DEFAULT ((0)) FOR [Estado]
GO
ALTER TABLE [dbo].[CodigosRecuperacion] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[CodigosRecuperacion]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioCodigo] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[CodigosRecuperacion] CHECK CONSTRAINT [FK_UsuarioCodigo]
GO
ALTER TABLE [dbo].[devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_Prestamos] FOREIGN KEY([idPrestamo])
REFERENCES [dbo].[prestamos] ([idPrestamo])
GO
ALTER TABLE [dbo].[devoluciones] CHECK CONSTRAINT [FK_Devoluciones_Prestamos]
GO
ALTER TABLE [dbo].[devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[devoluciones] CHECK CONSTRAINT [FK_Devoluciones_Usuarios]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_Autores] FOREIGN KEY([idAutor])
REFERENCES [dbo].[autores] ([idAutor])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_Libros_Autores]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_Libros_EstadoLibro] FOREIGN KEY([idestadoLibro])
REFERENCES [dbo].[estadoLibro] ([idestadoLibro])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_Libros_EstadoLibro]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_EstadoPrestamo] FOREIGN KEY([idestadoPrestamo])
REFERENCES [dbo].[estadoPrestamo] ([idestadoPrestamo])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_Prestamos_EstadoPrestamo]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Libros] FOREIGN KEY([idLibro])
REFERENCES [dbo].[libros] ([idLibro])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_Prestamos_Libros]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_Prestamos_Usuarios]
GO
USE [master]
GO
ALTER DATABASE [Biblioteca] SET  READ_WRITE 
GO
