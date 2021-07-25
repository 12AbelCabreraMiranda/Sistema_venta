--Procedimiento Listar
create proc usuario_listar
as
select u.idusuario as ID,u.idrol, r.nombre as Rol,u.nombre as Nombre,
u.tipo_documento as Tipo_Documento,u.num_documento as Num_Documento,
u.direccion as Direccion,u.telefono as Telefono,u.email as Email,
u.estado as Estado
 from usuario u inner join rol r on u.idrol=r.idrol
 order by u.idusuario desc
 go

--Procedimiento Buscar
create proc usuario_buscar
@valor varchar(50)
as
select u.idusuario as ID,u.idrol, r.nombre as Rol,u.nombre as Nombre,
u.tipo_documento as Tipo_Documento,u.num_documento as Num_Documento,
u.direccion as Direccion,u.telefono as Telefono,u.email as Email,
u.estado as Estado
 from usuario u inner join rol r on u.idrol=r.idrol
 where u.nombre like '%' +@valor + '%' Or u.email like '%' +@valor + '%'
 order by u.nombre asc
 go

--Procedimiento Insertar
create proc usuario_insertar
@idrol integer,
@nombre varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@direccion varchar(70),
@telefono varchar(20),
@email varchar(50),
@clave varchar(50)
as
insert into usuario (idrol,nombre,tipo_documento,num_documento,direccion,telefono,email,clave)
values (@idrol,@nombre,@tipo_documento,@num_documento,@direccion,@telefono,@email,HASHBYTES('SHA2_256',@clave))
go

--Procedimiento Actualizar
create proc usuario_actualizar
@idusuario integer,
@idrol integer,
@nombre varchar(100),
@tipo_documento varchar(20),
@num_documento varchar(20),
@direccion varchar(70),
@telefono varchar(20),
@email varchar(50),
@clave varchar(50)
as
if @clave<>''
update usuario set idrol=@idrol,nombre=@nombre,tipo_documento=@tipo_documento,
num_documento=@num_documento,direccion=@direccion,telefono=@telefono,
email=@email,clave=HASHBYTES('SHA2_256', @clave)
where idusuario=@idusuario;
else
update usuario set idrol=@idrol,nombre=@nombre,tipo_documento=@tipo_documento,
num_documento=@num_documento,direccion=@direccion,telefono=@telefono,
email=@email
where idusuario=@idusuario;
go
--Procedimiento Eliminar
create proc usuario_eliminar
@idusuario integer
as
delete from usuario
where idusuario=@idusuario
go

--Procedimiento Desactivar
create proc usuario_desactivar
@idusuario integer
as
update usuario set estado=0
where idusuario=@idusuario
go

--Procedimiento Activar
create proc usuario_activar
@idusuario integer
as
update usuario set estado=1
where idusuario=@idusuario
go
