go 
use [C:\USERS\AARON LEYVA CRUZ\SOURCE\REPOS\EMPRESA\PROGRAMA EMPRESA\CAPAPRESENTACION\EMPRESA.MDF]
create table Usuarios
(
ID_Usuarios      int identity (1,1) primary key,
Nombre           nvarchar(100),
Tipo_De_Usuario  nvarchar(100),
Usuario          nvarchar(100),
Contraseña       nvarchar(100)
)


create table Mercancia
(
ID_Mercancia      int identity (1,1) primary key,
Nombre            nvarchar(100),
Cantidad          int,
Tipo_De_Servicio  nvarchar(100),
Precio            float,
Total_Por_Pagar   float,
Total_Pagado      float,
Total             float
)

create proc MostrarUsuarios
as
select *from Usuarios
go

create proc MostrarMercancia
as
select *from Mercancia
go


create proc InsertarUsuarios
@Nombre      nvarchar(100),
@Tipo        nvarchar(100),
@Usuario     nvarchar(100),
@Contraseña  nvarchar(100)
as
insert into Usuarios values (@Nombre,@Tipo,@Usuario,@Contraseña)
go

create proc IsertarMercancia
@Nombre    nvarchar (100),
@Cantidad  int,
@TipoDS    nvarchar (100),
@Precio    float,
@TotalPp   float,
@TotalP    float,
@Total     float
as
insert into Mercancia values(@Nombre,@Cantidad,@TipoDS,@Precio,@TotalPp,@TotalP,@Total)
go

create proc ActualizarUsuarios
@Nombre      nvarchar (100),
@Tipo        nvarchar (100),
@Usuario     nvarchar (100),
@Contraseña  nvarchar (100),
@Id          int 
as 
update Usuarios set Nombre=@Nombre,Tipo_De_Usuario=@Tipo,Usuario=@Usuario,Contraseña=@Contraseña
where ID_Usuarios=@Id
go

create proc ActualizarMercancia
@Nombre     nvarchar(100),
@Cantidad   int,
@TipoDs     nvarchar(100),
@Precio     float,
@TotalPp    float,
@TotalP     float,
@Total      float,
@Id         int
as
update Mercancia set Nombre=@Nombre,Cantidad=@Cantidad,Tipo_De_Servicio=@TipoDs,Precio=@Precio,Total_Por_Pagar=@TotalPp,Total_Pagado=@TotalP,Total=@Total
where ID_Mercancia=@Id
go

create proc EliminarUsuarios
@Id  int
as
delete from Usuarios where ID_Usuarios=@Id
go

create proc EliminarMercancia
@Id int
as
delete from Mercancia where ID_Mercancia=@Id
go

create proc IniciarSesion
@Usuario    varchar(100),
@Contraseña varchar(100)
as
select *from  Usuarios where Usuario=@Usuario and Contraseña=@Contraseña
go

create proc Buscar
@filtro varchar(200)
as
select  ID_Mercancia,Nombre,Cantidad,Tipo_De_Servicio,Precio,Total_Por_Pagar,Total_Pagado,Total
from Mercancia
where Tipo_De_Servicio like @filtro + '%'
go

create proc SUMAS_De_Columnas

@TotalPorPagar float out,
@TotalPagado   float out,
@Total         float out,
@CantidadMercancia int out
as
set @TotalPorPagar=(select sum(Total_Por_Pagar) as SumaTotalPorpagar from Mercancia)
set @TotalPagado=(select sum(Total_Pagado) as SumaTotalPagado from Mercancia)
set @Total=(  select sum(Total)as TotalMercancia from Mercancia)
set @CantidadMercancia=(select count(ID_Mercancia) as CantidadDeMercancia from Mercancia)
go

exec InsertarUsuarios 'Aaron','Usuario','Aaron1234','12345678'
exec InsertarUsuarios 'Arturo','Administrador','Arturo1234','12345678'

EXEC MostrarUsuarios