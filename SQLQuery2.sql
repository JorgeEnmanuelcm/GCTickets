Create Table Usuarios(
UsuarioId int Primary key identity(1,1),
Nombres varchar(32),
Apellidos varchar(32),
Telefono int,
Email varchar(60),
Direccion varchar(60),
NombreUsuario varchar(32),
Contrasenia varchar(30),
ConfirmarContrasenia varchar(30),
EsActivo bit,
Foto varchar(280)
)