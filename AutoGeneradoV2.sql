USE [master]
GO
/****** Object:  Database [Colegio]    Script Date: 22/05/2022 05:40:35 p. m. ******/
CREATE DATABASE [Colegio]
GO
ALTER DATABASE [Colegio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Colegio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Colegio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Colegio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Colegio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Colegio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Colegio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Colegio] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Colegio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Colegio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Colegio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Colegio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Colegio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Colegio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Colegio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Colegio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Colegio] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Colegio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Colegio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Colegio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Colegio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Colegio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Colegio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Colegio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Colegio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Colegio] SET  MULTI_USER 
GO
ALTER DATABASE [Colegio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Colegio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Colegio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Colegio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Colegio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Colegio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Colegio] SET QUERY_STORE = OFF
GO
USE [Colegio]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 22/05/2022 05:40:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[Id_Alumno] [nvarchar](10) NOT NULL,
	[Nom_Alumno] [nvarchar](50) NULL,
	[Dir_Alumno] [nvarchar](50) NULL,
	[Tel_Alumno] [bigint] NULL,
	[Grp_Alumno] [nvarchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Id_Curso] [nvarchar](10) NOT NULL,
	[Nom_Curso] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docente]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docente](
	[ID_Docente] [nvarchar](10) NOT NULL,
	[Nom_Docente] [nvarchar](50) NULL,
	[Dire_Docente] [nvarchar](50) NULL,
	[Tel_Docente] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Docente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[Id_Especialidad] [nvarchar](10) NOT NULL,
	[Nom_Especialidad] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oficina]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oficina](
	[Id_Oficina] [nvarchar](10) NOT NULL,
	[Nom_Oficina] [nvarchar](50) NULL,
	[Tel_Oficina] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Oficina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Alumno] ([Id_Alumno], [Nom_Alumno], [Dir_Alumno], [Tel_Alumno], [Grp_Alumno]) VALUES (N'10', N'Fulano', N'Circuar 5', 1010, N'1')
GO
INSERT [dbo].[Alumno] ([Id_Alumno], [Nom_Alumno], [Dir_Alumno], [Tel_Alumno], [Grp_Alumno]) VALUES (N'2323', N'2323', N'2323', 2323, N'2')
GO
INSERT [dbo].[Alumno] ([Id_Alumno], [Nom_Alumno], [Dir_Alumno], [Tel_Alumno], [Grp_Alumno]) VALUES (N'4444', N'44444', N'44444', 4444, N'4')
GO
INSERT [dbo].[Alumno] ([Id_Alumno], [Nom_Alumno], [Dir_Alumno], [Tel_Alumno], [Grp_Alumno]) VALUES (N'5555', N'5555', N'55555', 55555, N'5')
GO
INSERT [dbo].[Alumno] ([Id_Alumno], [Nom_Alumno], [Dir_Alumno], [Tel_Alumno], [Grp_Alumno]) VALUES (N'8', N'Juan', N'Calle 99 #43-33', 234, N'8')
GO
INSERT [dbo].[Alumno] ([Id_Alumno], [Nom_Alumno], [Dir_Alumno], [Tel_Alumno], [Grp_Alumno]) VALUES (N'9', N'Pedro', N'Klr 34# 232.2', 311144, N'9')
GO
INSERT [dbo].[Curso] ([Id_Curso], [Nom_Curso]) VALUES (N'1', N'Lenguajes')
GO
INSERT [dbo].[Curso] ([Id_Curso], [Nom_Curso]) VALUES (N'2', N'Base de Datos')
GO
INSERT [dbo].[Curso] ([Id_Curso], [Nom_Curso]) VALUES (N'3', N'Moviles')
GO
/****** Object:  StoredProcedure [dbo].[Borrar_Alumno]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Borrar_Alumno]
@Id_Alumno nvarchar(10)
as
delete from Alumno where Id_Alumno = @Id_Alumno

GO
/****** Object:  StoredProcedure [dbo].[Borrar_Curso]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Borrar_Curso]
@Id_Curso nvarchar(10)
as
delete from Curso where Id_Curso = @Id_Curso

GO
/****** Object:  StoredProcedure [dbo].[Consul_Alumno]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Consul_Alumno]
@Id_Alumno nvarchar(10)
as
select * from Alumno where Id_Alumno = @Id_Alumno

GO
/****** Object:  StoredProcedure [dbo].[Consul_Alumnos]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Consul_Alumnos]
as
select * from Alumno
GO
/****** Object:  StoredProcedure [dbo].[Consul_Curso]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Consul_Curso]
@Id_Curso nvarchar(10)
as
select * from Curso where Id_Curso = @Id_Curso

GO
/****** Object:  StoredProcedure [dbo].[Consul_Cursos]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Consul_Cursos]
as
select * from Curso

GO
/****** Object:  StoredProcedure [dbo].[Consul_Docente]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Consul_Docente]
@ID_Docente nvarchar(10)
as
select * from Docente where ID_Docente = @ID_Docente
GO
/****** Object:  StoredProcedure [dbo].[Consul_Especialidad]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Consul_Especialidad]
@Id_Especialidad nvarchar(10)
as
select * from Especialidad where Id_Especialidad = @Id_Especialidad
GO
/****** Object:  StoredProcedure [dbo].[Consul_Oficina]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Consul_Oficina]
@Id_Oficina nvarchar(10)
as
select * from Oficina where Id_Oficina = @Id_Oficina
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Alumno]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Alumno]
@Id_Alumno nvarchar(10),
@Nom_Alumno nvarchar(50),
@Dir_Alumno nvarchar(50),
@Tel_Alumno bigint,
@Grp_Alumno nvarchar(1)
as
insert into Alumno (Id_Alumno, Nom_Alumno, Dir_Alumno, Tel_Alumno, Grp_Alumno) values (@Id_Alumno, @Nom_Alumno, @Dir_Alumno, @Tel_Alumno, @Grp_Alumno)
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Curso]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Curso]
@Id_Curso nvarchar(10),
@Nom_Curso nvarchar(50)
as
insert into Curso (Id_Curso, Nom_Curso) values (@Id_Curso, @Nom_Curso)
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Docente]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Docente]
@ID_Docente nvarchar(10),
@Nom_Docente nvarchar(50),
@Dire_Docente nvarchar(50),
@Tel_Docente bigint
as
insert into Docente (ID_Docente, Nom_Docente, Dire_Docente, Tel_Docente) values (@ID_Docente, @Nom_Docente, @Dire_Docente, @Tel_Docente)
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Especialidad]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Especialidad]
@Id_Especialidad nvarchar(10),
@Nom_Especialidad nvarchar(50)
as
insert into Especialidad (Id_Especialidad, Nom_Especialidad) values (@Id_Especialidad, @Nom_Especialidad)
GO
/****** Object:  StoredProcedure [dbo].[Modif_Alumno]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Modif_Alumno]
@Id_Alumno nvarchar(10),
@Nom_Alumno nvarchar(50),
@Dir_Alumno nvarchar(50),
@Tel_Alumno bigint,
@Grp_Alumno nvarchar(1)
as
update Alumno set Nom_Alumno=@Nom_Alumno, Dir_Alumno=@Dir_Alumno, Tel_Alumno=@Tel_Alumno, Grp_Alumno=@Grp_Alumno where Id_Alumno=@Id_Alumno
GO
/****** Object:  StoredProcedure [dbo].[Modif_Curso]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Modif_Curso]
@Id_Curso nvarchar(10),
@Nom_Curso nvarchar(50)
as
update Curso set Nom_Curso=@Nom_Curso where Id_Curso=@Id_Curso
GO
/****** Object:  StoredProcedure [dbo].[Modif_Docente]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Modif_Docente]
@ID_Docente nvarchar(10),
@Nom_Docente nvarchar(50),
@Dire_Docente nvarchar(50),
@Tel_Docente bigint
as
update Docente set Nom_Docente=@Nom_Docente, Dire_Docente=@Dire_Docente, Tel_Docente=@Tel_Docente where ID_Docente=@ID_Docente
GO
/****** Object:  StoredProcedure [dbo].[Modif_Especialidad]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Modif_Especialidad]
@Id_Especialidad nvarchar(10),
@Nom_Especialidad nvarchar(50)
as
update Especialidad set Nom_Especialidad=@Nom_Especialidad where Id_Especialidad=@Id_Especialidad

GO
/****** Object:  StoredProcedure [dbo].[Modif_Oficina]    Script Date: 22/05/2022 05:40:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Modif_Oficina]
@Id_Oficina nvarchar(10),
@Nom_Oficina nvarchar(50),
@Tel_Oficina bigint
as
update Oficina set Nom_Oficina=@Nom_Oficina, Tel_Oficina=@Tel_Oficina where Id_Oficina=@Id_Oficina
GO
USE [master]
GO
ALTER DATABASE [Colegio] SET  READ_WRITE 
GO
