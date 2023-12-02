USE [master]
GO
DROP DATABASE IF EXISTS [Biblioteca]
GO
USE [Biblioteca]
GO
/****** Object:  Table [dbo].[autores]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  Table [dbo].[CodigosRecuperacion]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  Table [dbo].[devoluciones]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  Table [dbo].[estadoLibro]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  Table [dbo].[estadoPrestamo]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  Table [dbo].[libros]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  Table [dbo].[prestamos]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: jueves 0:15:31 ******/
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
/****** Object:  StoredProcedure [dbo].[ActualizarContraseñaPorCodigo]    Script Date: jueves 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarContraseñaPorCodigo]
    @codigo NVARCHAR(50),
    @nuevaContraseña NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @usuarioId INT;

        -- Obtener el ID del usuario asociado al código
        SELECT @usuarioId = idUsuario
        FROM CodigosRecuperacion
        WHERE Codigo = @codigo;

        IF @usuarioId IS NOT NULL
        BEGIN
            -- Actualizar la contraseña del usuario
            UPDATE usuarios
            SET contraseña = @nuevaContraseña
            WHERE idUsuario = @usuarioId;

            -- Eliminar el código de restablecimiento utilizado
            DELETE FROM CodigosRecuperacion
            WHERE Codigo = @codigo;

            COMMIT TRANSACTION;

            SELECT 'Contraseña actualizada y código eliminado correctamente.' AS Resultado;
        END
        ELSE
        BEGIN
            SELECT 'Código no válido.' AS Resultado;
        END

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT ERROR_MESSAGE() AS Error;
    END CATCH;
END
GO
--Insertando datos a estado libros
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Disponible');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Prestado');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('En reparación');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Perdido');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('En espera');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('En revisión');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Reservado');
GO
--Insertar estados de préstamo
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('En curso');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Pendiente');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Finalizado');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Vencido');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Cancelado');
GO
