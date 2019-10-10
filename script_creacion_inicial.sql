USE [GD2C2019]
GO

-- Creacion del schema
CREATE SCHEMA [LOS_GDDS]
GO

-- Creacion de las tablas 
-- tome como standard que el id de las tablas va a ser id_entidad en lugar de solamente Id
-- hay algunas columnas en la tabla maestra que NO están siendo mapeadas, hay que revisarlas
-- tambien queda pendiente hacer la tabla medios_pago y todo lo relacionado para manejar transacciones en efectivo

--tabla funcionalidades
CREATE TABLE [LOS_GDDS].[funcionalidades] (
	id_funcionalidad INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(100)
)

--tabla roles
CREATE TABLE [LOS_GDDS].[roles] (
	id_rol INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(100),
	habilitado BIT
)

-- tabla funcionalidades_rol
CREATE TABLE [LOS_GDDS].[funcionalidades_rol] (
	id_rol INT,
	id_funcionalidad INT,
	PRIMARY KEY (id_rol, id_funcionalidad),
	FOREIGN KEY (id_rol) REFERENCES [LOS_GDDS].[roles](id_rol),
	FOREIGN KEY (id_funcionalidad) REFERENCES [LOS_GDDS].[funcionalidades](id_funcionalidad)
)

-- tabla usuarios
-- para guardar la password use binary(32) como recomiendan aca https://stackoverflow.com/questions/247304/what-data-type-to-use-for-hashed-password-field-and-what-length
CREATE TABLE [LOS_GDDS].[usuarios] (
	id_usuario INT PRIMARY KEY IDENTITY,
	username VARCHAR(100),
	password BINARY(32),
	habilitado BIT,
	cantidad_logins_fallidos INT
)

-- tabla roles_usuario
CREATE TABLE [LOS_GDDS].[roles_usuario] (
	id_usuario INT,
	id_rol INT,
	PRIMARY KEY (id_usuario, id_rol),
	FOREIGN KEY (id_usuario) REFERENCES [LOS_GDDS].[usuarios](id_usuario),
	FOREIGN KEY (id_rol) REFERENCES [LOS_GDDS].[roles](id_rol)
)

-- tabla clientes
CREATE TABLE [LOS_GDDS].[clientes] (
	id_usuario INT PRIMARY KEY IDENTITY,
	nombre NVARCHAR(255),
	apellido NVARCHAR(255),
	dni NUMERIC(18,0),
	mail NVARCHAR(255),
	telefono NUMERIC(18,0),
	direccion NVARCHAR(255),
	-- todo: revisar codigo postal. No estoy seguro que sea correcto el data type pero no lo veo en la tabla maestra
	codigo_postal NVARCHAR(15),
	fecha_nacimiento DATETIME,
	-- me guie por las columnas que manejan montos de dinero en la tabla maestra, todos estan con este datatype
	saldo NUMERIC(18,2),
	FOREIGN KEY (id_usuario) REFERENCES [LOS_GDDS].[usuarios](id_usuario)
)

-- tabla tipos_tarjeta
CREATE TABLE [LOS_GDDS].[tipos_tarjeta] (
	id_tipo_tarjeta INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR(100)
)

-- tabla tarjetas
CREATE TABLE [LOS_GDDS].[tarjetas] (
	id_tarjeta INT PRIMARY KEY IDENTITY,
	id_usuario INT,
	numero INT,
	fecha_vencimiento DATETIME,
	codigo_seguridad INT,
	id_tipo_tarjeta INT,
	FOREIGN KEY (id_tipo_tarjeta) REFERENCES [LOS_GDDS].[tipos_tarjeta](id_tipo_tarjeta)
)

-- tabla cargas_realizadas
CREATE TABLE [LOS_GDDS].[cargas_realizadas] (
	id_carga INT PRIMARY KEY IDENTITY,
	id_usuario INT,
	id_tarjeta INT,
	fecha DATETIME,
	monto NUMERIC(18,2)
	FOREIGN KEY (id_tarjeta) REFERENCES [LOS_GDDS].[tarjetas](id_tarjeta)
)

-- tabla proveedores
CREATE TABLE [LOS_GDDS].[proveedores] (
	id_usuario INT PRIMARY KEY IDENTITY,
	razon_social NVARCHAR(100),
	-- use el mismo datatype que usamos en clientes, porque en la maestra no esta el campo
	mail NVARCHAR(255),
	telefono NUMERIC(18,0),
	-- use el mismo datatype que en clientes
	codigo_postal NVARCHAR(15),
	ciudad NVARCHAR(255),
	cuit NVARCHAR(20),
	-- todo: revisar, le defini el datatype asi nomas
	nombre_contacto NVARCHAR(100),
	FOREIGN KEY (id_usuario) REFERENCES [LOS_GDDS].[usuarios](id_usuario)
)

-- tabla facturacion_proveedor
CREATE TABLE [LOS_GDDS].[facturacion_proveedor] (
	id_proveedor INT PRIMARY KEY,
	total_facturado NUMERIC(18,2)
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_usuario)
)

-- tabla facturas
CREATE TABLE [LOS_GDDS].[facturas] (
	id_factura NUMERIC(18,0) PRIMARY KEY IDENTITY,
	id_proveedor INT,
	total NUMERIC(18,2),
	fecha_desde DATETIME,
	fecha_hasta DATETIME
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_usuario)
)

-- tabla ofertas
CREATE TABLE [LOS_GDDS].[ofertas] (
	-- este ID es un NVARCHAR segun la tabla maestra
	id_oferta NVARCHAR(50) PRIMARY KEY,
	id_proveedor INT,
	precio_lista NUMERIC(18,2),
	precio_oferta NUMERIC(18,2),
	stock NUMERIC(18,0),
	-- setee el mismo datatype que el stock, que supongo es Oferta_cantidad en la maestra
	unidades_maximas_cliente NUMERIC(18,0),
	descripcion NVARCHAR(255),
	fecha_vencimiento DATETIME,
	fecha_publicacion DATETIME,
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_usuario)
)

--tabla estados_compra
CREATE TABLE [LOS_GDDS].[estados_compra] (
	id_estado_compra INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR(100)
)

-- tabla compras
CREATE TABLE [LOS_GDDS].[compras] (
	id_compra INT PRIMARY KEY IDENTITY,
	id_oferta NVARCHAR(50),
	id_cliente INT,
	id_estado INT,
	fecha DATETIME,
	cantidad NUMERIC(18,0),
	FOREIGN KEY (id_oferta) REFERENCES [LOS_GDDS].[ofertas](id_oferta),
	FOREIGN KEY (id_cliente) REFERENCES [LOS_GDDS].[clientes](id_usuario),
	FOREIGN KEY (id_estado) REFERENCES [LOS_GDDS].[estados_compra](id_estado_compra)
)


/* STORED PROCEDURES */

/* Validar login */
USE [GD2C2019]
GO

/****** Object:  StoredProcedure [LOS_GDDS].[validar_login]    Script Date: 10/10/2019 14:56:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [LOS_GDDS].[validar_login] 
	@Usuario varchar(100),
	@Clave varchar(100),
	@MaxIntentos numeric(3,0),
	@Resultado INT OUT,
	@Id INT OUT
AS
BEGIN
DECLARE
	@ClaveEncriptada varchar(255),
	@Intentos numeric(3,0)
SELECT @Id = id_usuario, @ClaveEncriptada = password, @Intentos = cantidad_logins_fallidos FROM LOS_GDDS.usuarios
WHERE username = @Usuario

SELECT @Resultado =
CASE
	--El usuario no existe
	WHEN @Id IS NULL THEN 0
	--Intentos excedidos
	WHEN @Intentos >= @MaxIntentos THEN 1
	--La password no coincide
	WHEN @ClaveEncriptada <> CAST(@Clave AS binary(32)) THEN 2
	--El usuario no está habilitado
	WHEN (SELECT habilitado FROM LOS_GDDS.usuarios WHERE id_usuario = @Id) = 0 THEN 3
	--Login exitoso
	ELSE 4
END


SELECT @Intentos = 
	CASE @Resultado
		WHEN 1 THEN @Intentos
		WHEN 2 THEN (@Intentos + 1)
		WHEN 3 THEN 0
		WHEN 4 THEN 0
	END

IF (@Resultado <> 0)
	UPDATE LOS_GDDS.usuarios SET cantidad_logins_fallidos = @Intentos WHERE id_usuario = @Id

RETURN
END
GO