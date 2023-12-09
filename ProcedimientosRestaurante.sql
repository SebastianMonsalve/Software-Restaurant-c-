use Restaurante
------Insertar personal------

create proc insertarPersonal
	@idPersonal_ int,
	@nombrePersonal_ varchar(50),
	@rolPersonal_ int,
	@fotoPersonal_ image,
	@correoPersonal_ varchar(50),
	@celularPersonal_ int,
	@nacimientoPersonal_ varchar(50),
	@contraseñaPersonal_ int,
	@estado_ bit
as
insert into Personal values(@idPersonal_, @nombrePersonal_, @rolPersonal_, @fotoPersonal_, @correoPersonal_,
	@celularPersonal_, @nacimientoPersonal_, @contraseñaPersonal_, @estado_)

------Modificar personal------

create proc modificarPersonal
	@idPersonal_ int,
	@nuevoNombrePersonal_ varchar(50),
	@nuevoRolPersonal_ int,
	@nuevaFotoPersonal_ image,
	@nuevoCorreoPersonal_ varchar(50),
	@nuevoCelularPersonal_ int,
	@nuevoNacimientoPersonal_ varchar(50),
	@contraseñaPersonal_ int
as begin
	update Personal set
		nombrePersonal = @nuevoNombrePersonal_,
		rolPersonal = @nuevoRolPersonal_,
		fotoPersonal = @nuevaFotoPersonal_,
		correoPersonal = @nuevoCorreoPersonal_,
		celularPersonal = @nuevoCelularPersonal_,
		nacimientoPersonal = @nuevoNacimientoPersonal_,
		contraseñaPersonal = @contraseñaPersonal_
	where idPersonal = @idPersonal_
end

------Desactivar personal------

create proc desactivarPersonal
	@idPersonal_ int
as begin
	update Personal
		set estado = 0
	where idPersonal = @idPersonal_
end

------Insertar rol------

create proc insertarRol
	@idRol_ int,
	@nombreRol_ varchar(50),
	@estado_ bit
as
insert into roles values(@nombreRol_, @estado_)

------Modificar roles------

create proc modificarRoles
	@idRol_ int,
	@nuevoNombreRol_ varchar(50)
as begin
	update roles set
		nombreRol = @nuevoNombreRol_
	where idRol = @idRol_
end

------Desactivar roles------

create proc desactivarRoles
	@idRol_ int
as begin
	update roles
		set estado = 0
	where idRol = @idRol_
end