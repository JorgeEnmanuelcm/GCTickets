--create database GCTicketsDb

--use GCTicketsDb

--Create Table Usuarios(
--UsuarioId int Primary key identity(1,1),
--Nombres varchar(32),
--Apellidos varchar(32),
--Telefono varchar(15),
--Email varchar(60),
--Direccion varchar(60),
--NombreUsuario varchar(32),
--Contrasenia varchar(30),
--ConfirmarContrasenia varchar(30),
--EsActivo bit,
--Foto varchar(280)
--)

--create table TipoEvento(
--TipoEventoId int primary key identity(1,1),
--Descripcion varchar(30)
--)

--create table Eventos(
--EventoId int primary key identity(1,1),
--TipoEventoId int references TipoEvento(TipoEventoId),
--NombreEvento varchar(26),
--FechaEvento varchar(12),
--LugarEvento varchar(26)
--)

--create table EventosDetalle(
--Id int primary key identity(1,1),
--EventoId int references Eventos(EventoId),
--Descripcion varchar(12),
--CantDisponible int,
--PrecioTicket int
--)

--create table Ventas(
--VentaId int primary key identity(1,1),
--UsuarioId int references Usuarios(UsuarioId),
--Fecha varchar(12),
--Ticket int,
--Cantidad int,
--Descripcion varchar(60),
--Total int
--)

--create table VentasDetalle(
--VentaId int references Ventas(VentaId),
--EventoId int references Eventos(EventoId)
--)

