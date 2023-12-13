use Restaurante
------Insertar personal------
create proc insertarPersonal
	@idPersonal_ int,
	@nombrePersonal_ varchar(50),
	@rolPersonal_ int,
	@fotoPersonal_ image,
	@correoPersonal_ varchar(50),
	@celularPersonal_ varchar(50),
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
	@nuevoCelularPersonal_ varchar(50),
	@nuevoNacimientoPersonal_ varchar(50),
	@nuevaContraseñaPersonal_ int
as begin
	update Personal set
		nombrePersonal = @nuevoNombrePersonal_,
		rolPersonal = @nuevoRolPersonal_,
		fotoPersonal = @nuevaFotoPersonal_,
		correoPersonal = @nuevoCorreoPersonal_,
		celularPersonal = @nuevoCelularPersonal_,
		nacimientoPersonal = @nuevoNacimientoPersonal_,
		contraseñaPersonal = @nuevaContraseñaPersonal_
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

-------Listar Roles-----------
drop proc ListarRoles
CREATE PROC ListarRoles AS
Select idRol AS 'N°', nombreRol AS Nombre from roles
 WHERE estado = 1;
GO

--------Listar Empleados-------
drop proc ListarEmpleados
CREATE PROC ListarEmpleados AS
Select idPersonal AS ID, nombrePersonal AS Nombre, roles.nombreRol AS Rol,
fotoPersonal AS Foto, correoPersonal AS Correo, celularPersonal AS 'Móvil',
nacimientoPersonal AS 'Fecha', contraseñaPersonal AS Clave from Personal
inner join roles on personal.rolPersonal = roles.idRol
 WHERE personal.estado = 1;
GO

--------------GRAFICAS DEL HOME----------------
drop proc dashboardDatos
CREATE PROC DashboardDatos
	@CantidadEmpleados_ INT OUT
AS
BEGIN
	SELECT @CantidadEmpleados_ = COUNT(idPersonal) FROM Personal WHERE estado = 1;
END