create database Colegio

GO

use Colegio

GO

Create table Alumno(
Id_Alumno nvarchar(10)primary key,
Nom_Alumno nvarchar(50),
Dir_Alumno nvarchar(50),
Tel_Alumno bigint,
Grp_Alumno nvarchar(1))


Create table Docente(
ID_Docente nvarchar(10)primary key,
Nom_Docente nvarchar(50),
Dire_Docente nvarchar(50),
Tel_Docente bigint)

Create table Oficina(
Id_Oficina nvarchar(10)primary key,
Nom_Oficina nvarchar(50),
Tel_Oficina bigint)


Create table Especialidad(
Id_Especialidad nvarchar(10)primary key,
Nom_Especialidad nvarchar(50))


Create table Curso(
Id_Curso nvarchar(10)primary key,
Nom_Curso nvarchar(50))




create proc Insertar_Alumno
@Id_Alumno nvarchar(10),
@Nom_Alumno nvarchar(50),
@Dir_Alumno nvarchar(50),
@Tel_Alumno bigint,
@Grp_Alumno nvarchar(1)
as
insert into Alumno (Id_Alumno, Nom_Alumno, Dir_Alumno, Tel_Alumno, Grp_Alumno) values (@Id_Alumno, @Nom_Alumno, @Dir_Alumno, @Tel_Alumno, @Grp_Alumno)


create proc Insertar_Curso
@Id_Curso nvarchar(10),
@Nom_Curso nvarchar(50)
as
insert into Curso (Id_Curso, Nom_Curso) values (@Id_Curso, @Nom_Curso)

create proc Insertar_Docente
@ID_Docente nvarchar(10),
@Nom_Docente nvarchar(50),
@Dire_Docente nvarchar(50),
@Tel_Docente bigint
as
insert into Docente (ID_Docente, Nom_Docente, Dire_Docente, Tel_Docente) values (@ID_Docente, @Nom_Docente, @Dire_Docente, @Tel_Docente)


create proc Insertar_Especialidad
@Id_Especialidad nvarchar(10),
@Nom_Especialidad nvarchar(50)
as
insert into Especialidad (Id_Especialidad, Nom_Especialidad) values (@Id_Especialidad, @Nom_Especialidad)



create proc Modif_Curso
@Id_Curso nvarchar(10),
@Nom_Curso nvarchar(50)
as
update Curso set Nom_Curso=@Nom_Curso where Id_Curso=@Id_Curso


create proc Modif_Alumno
@Id_Alumno nvarchar(10),
@Nom_Alumno nvarchar(50),
@Dir_Alumno nvarchar(50),
@Tel_Alumno bigint,
@Grp_Alumno nvarchar(1)
as
update Alumno set Nom_Alumno=@Nom_Alumno, Dir_Alumno=@Dir_Alumno, Tel_Alumno=@Tel_Alumno, Grp_Alumno=@Grp_Alumno where Id_Alumno=@Id_Alumno


create proc Modif_Docente
@ID_Docente nvarchar(10),
@Nom_Docente nvarchar(50),
@Dire_Docente nvarchar(50),
@Tel_Docente bigint
as
update Docente set Nom_Docente=@Nom_Docente, Dire_Docente=@Dire_Docente, Tel_Docente=@Tel_Docente where ID_Docente=@ID_Docente


create proc Modif_Especialidad
@Id_Especialidad nvarchar(10),
@Nom_Especialidad nvarchar(50)
as
update Especialidad set Nom_Especialidad=@Nom_Especialidad where Id_Especialidad=@Id_Especialidad


create proc Modif_Oficina
@Id_Oficina nvarchar(10),
@Nom_Oficina nvarchar(50),
@Tel_Oficina bigint
as
update Oficina set Nom_Oficina=@Nom_Oficina, Tel_Oficina=@Tel_Oficina where Id_Oficina=@Id_Oficina


create proc Consul_Alumno
@Id_Alumno nvarchar(10)
as
select * from Alumno where Id_Alumno = @Id_Alumno


create proc Consul_Curso
@Id_Curso nvarchar(10)
as
select * from Curso where Id_Curso = @Id_Curso


create proc Consul_Docente
@ID_Docente nvarchar(10)
as
select * from Docente where ID_Docente = @ID_Docente


create proc Consul_Especialidad
@Id_Especialidad nvarchar(10)
as
select * from Especialidad where Id_Especialidad = @Id_Especialidad


create proc Consul_Oficina
@Id_Oficina nvarchar(10)
as
select * from Oficina where Id_Oficina = @Id_Oficina


create proc Borrar_Alumno
@Id_Alumno nvarchar(10)
as
delete from Alumno where Id_Alumno = @Id_Alumno

