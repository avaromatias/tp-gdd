USE [GD2C2019]
GO

-- Creacion del schema
CREATE SCHEMA [LOS_GDDS]
GO

/* CREACIÓN TABLAS */

--tabla funcionalidades
CREATE TABLE [LOS_GDDS].[funcionalidades] (
	id_funcionalidad INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(100)
)
GO

--tabla roles
CREATE TABLE [LOS_GDDS].[roles] (
	id_rol INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(100),
	habilitado BIT
)
GO

-- tabla funcionalidades_rol
CREATE TABLE [LOS_GDDS].[funcionalidades_rol] (
	id_rol INT,
	id_funcionalidad INT,
	PRIMARY KEY (id_rol, id_funcionalidad),
	FOREIGN KEY (id_rol) REFERENCES [LOS_GDDS].[roles](id_rol),
	FOREIGN KEY (id_funcionalidad) REFERENCES [LOS_GDDS].[funcionalidades](id_funcionalidad)
)
GO

-- tabla clientes
CREATE TABLE [LOS_GDDS].[clientes] (
	id_cliente INT PRIMARY KEY IDENTITY,
	nombre NVARCHAR(255),
	apellido NVARCHAR(255),
	dni NUMERIC(18,0) UNIQUE NOT NULL,
	mail NVARCHAR(255),
	telefono NUMERIC(18,0),
	direccion NVARCHAR(255),
	-- todo: revisar codigo postal. No estoy seguro que sea correcto el data type pero no lo veo en la tabla maestra
	codigo_postal NVARCHAR(15),
	fecha_nacimiento DATETIME,
	-- me guie por las columnas que manejan montos de dinero en la tabla maestra, todos estan con este datatype
	saldo NUMERIC(18,2),
	ciudad NVARCHAR(255),
	CHECK ([saldo] >= 0)
)
GO

-- tabla tipos_tarjeta
CREATE TABLE [LOS_GDDS].[tipos_tarjeta] (
	id_tipo_tarjeta INT PRIMARY KEY IDENTITY,
	descripcion NVARCHAR(100)
)
GO

-- tabla tarjetas
CREATE TABLE [LOS_GDDS].[tarjetas] (
	id_tarjeta INT PRIMARY KEY IDENTITY,
	id_cliente INT,
	numero INT,
	fecha_vencimiento DATETIME,
	codigo_seguridad INT,
	id_tipo_tarjeta INT,
	FOREIGN KEY (id_tipo_tarjeta) REFERENCES [LOS_GDDS].[tipos_tarjeta](id_tipo_tarjeta),
	FOREIGN KEY (id_cliente) REFERENCES [LOS_GDDS].[clientes](id_cliente)
)
GO

-- tabla cargas_realizadas
CREATE TABLE [LOS_GDDS].[cargas_realizadas] (
	id_carga INT PRIMARY KEY IDENTITY,
	id_cliente INT,
	id_tarjeta INT,
	fecha DATETIME,
	monto NUMERIC(18,2)
	FOREIGN KEY (id_tarjeta) REFERENCES [LOS_GDDS].[tarjetas](id_tarjeta),
	FOREIGN KEY (id_cliente) REFERENCES [LOS_GDDS].[clientes](id_cliente)
)
GO

-- tabla rubros
CREATE TABLE [LOS_GDDS].[rubros] (
	id_rubro INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(100)
)
GO

-- tabla proveedores
CREATE TABLE [LOS_GDDS].[proveedores] (
	id_proveedor INT PRIMARY KEY IDENTITY,
	razon_social NVARCHAR(100),
	-- use el mismo datatype que usamos en clientes, porque en la maestra no esta el campo
	mail NVARCHAR(255),
	telefono NUMERIC(18,0),
	-- use el mismo datatype que en clientes
	codigo_postal NVARCHAR(15),
	ciudad NVARCHAR(255),
	direccion NVARCHAR(100),
	cuit NVARCHAR(20) UNIQUE NOT NULL,
	-- todo: revisar, le defini el datatype asi nomas
	nombre_contacto NVARCHAR(100),
	id_rubro INT
	FOREIGN KEY (id_rubro) REFERENCES [LOS_GDDS].[rubros](id_rubro)
)
GO

-- tabla usuarios
-- para guardar la password use binary(32) como recomiendan aca https://stackoverflow.com/questions/247304/what-data-type-to-use-for-hashed-password-field-and-what-length
CREATE TABLE [LOS_GDDS].[usuarios] (
	id_usuario INT PRIMARY KEY IDENTITY,
	username VARCHAR(100) NOT NULL,
	password BINARY(32) NOT NULL,
	habilitado BIT,
	cantidad_logins_fallidos INT,
	id_proveedor INT,
	id_cliente INT,
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_proveedor),
	FOREIGN KEY (id_cliente) REFERENCES [LOS_GDDS].[clientes](id_cliente),
)
GO

-- tabla roles_usuario
CREATE TABLE [LOS_GDDS].[roles_usuario] (
	id_usuario INT,
	id_rol INT,
	PRIMARY KEY (id_usuario, id_rol),
	FOREIGN KEY (id_usuario) REFERENCES [LOS_GDDS].[usuarios](id_usuario),
	FOREIGN KEY (id_rol) REFERENCES [LOS_GDDS].[roles](id_rol)
)
GO

-- tabla facturas
CREATE TABLE [LOS_GDDS].[facturas] (
	id_factura INT PRIMARY KEY IDENTITY,
	nro_factura NUMERIC(18,0) UNIQUE,
	id_proveedor INT,
	total NUMERIC(18,2),
	fecha_emision DATETIME,
	fecha_desde DATETIME,
	fecha_hasta DATETIME
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_proveedor)
)
GO

-- tabla ofertas
CREATE TABLE [LOS_GDDS].[ofertas] (
	-- este ID es un NVARCHAR segun la tabla maestra
	id_oferta NVARCHAR(50) PRIMARY KEY,
	id_proveedor INT NOT NULL,
	precio_lista NUMERIC(18,2),
	precio_oferta NUMERIC(18,2),
	stock NUMERIC(18,0),
	-- setee el mismo datatype que el stock, que supongo es Oferta_cantidad en la maestra
	unidades_maximas_cliente NUMERIC(18,0),
	descripcion NVARCHAR(255),
	fecha_vencimiento DATETIME,
	fecha_publicacion DATETIME,
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_proveedor),
	CHECK ([stock] >= 0),
	CHECK ([fecha_vencimiento] > [fecha_publicacion])
)
GO

-- tabla compras
CREATE TABLE [LOS_GDDS].[compras] (
	id_compra INT PRIMARY KEY IDENTITY,
	id_oferta NVARCHAR(50) NOT NULL,
	id_cliente INT NOT NULL,
	id_factura INT DEFAULT NULL,
	fecha DATETIME NOT NULL,
	fecha_consumo DATETIME,
	cantidad NUMERIC(18,0),
	FOREIGN KEY (id_oferta) REFERENCES [LOS_GDDS].[ofertas](id_oferta),
	FOREIGN KEY (id_cliente) REFERENCES [LOS_GDDS].[clientes](id_cliente),
	FOREIGN KEY (id_factura) REFERENCES [LOS_GDDS].[facturas](id_factura),
	CHECK([fecha_consumo] > [fecha])
)
GO

/* CREACIÓN FUNCTIONS */

CREATE FUNCTION [LOS_GDDS].[obtener_rubro_by_descripcion] (@descripcion_rubro NVARCHAR(100))
RETURNS INT
AS
BEGIN
	DECLARE @id_rubro INT
	SELECT
		@id_rubro = [id_rubro]
		FROM 
			[LOS_GDDS].[rubros]
		WHERE 
			[descripcion] = @descripcion_rubro
	RETURN @id_rubro
END
GO

CREATE FUNCTION [LOS_GDDS].[obtener_cliente_by_dni] (@dni NUMERIC(18,0))
RETURNS INT
AS
BEGIN
	DECLARE @id_cliente INT
	SELECT
		@id_cliente = [id_cliente]
		FROM 
			[LOS_GDDS].[clientes]
		WHERE 
			[dni] = @dni
	RETURN @id_cliente
END
GO

CREATE FUNCTION [LOS_GDDS].[obtener_proveedor_by_cuit] (@cuit NVARCHAR(20))
RETURNS INT
AS
BEGIN
	DECLARE @id_proveedor INT
	SELECT
		@id_proveedor = [id_proveedor]
		FROM 
			[LOS_GDDS].[proveedores]
		WHERE 
			[cuit] = @cuit
	RETURN @id_proveedor
END
GO

-- esta function está al pedo por ahora, pero hasta que revisemos bien los datos popor las dudas la dejo
CREATE FUNCTION [LOS_GDDS].[buscar_fecha_entrega_oferta] (@codigo_oferta NVARCHAR(50), @dni_cliente NUMERIC(18,0))
RETURNS DATETIME
AS
BEGIN
	DECLARE @fecha_entrega_oferta DATETIME = NULL
	SELECT
		@fecha_entrega_oferta =
		[Oferta_Entregado_Fecha]
		FROM
			[gd_esquema].[Maestra]
		WHERE 
			[Oferta_Codigo] = @codigo_oferta
		AND 
			[Cli_Dni] = @dni_cliente
		AND 
			[Oferta_Entregado_Fecha] IS NOT NULL
	RETURN @fecha_entrega_oferta
END
GO

CREATE FUNCTION [LOS_GDDS].[get_tarjeta_by_id_cliente] (@id_cliente INT)
RETURNS INT
AS
BEGIN
	DECLARE @id_tarjeta INT = NULL
	SELECT TOP 1
		@id_tarjeta =
		[t].[id_tarjeta]
		FROM
			[LOS_GDDS].[tarjetas] [t]
		WHERE
			[t].[id_cliente] = @id_cliente
	RETURN @id_tarjeta
END
GO


CREATE FUNCTION [LOS_GDDS].[get_tipo_tarjeta_by_descripcion] (@descripcion_tarjeta NVARCHAR(100))
RETURNS INT
AS
BEGIN
	DECLARE @id_tipo_tarjeta INT = NULL
	SELECT
		@id_tipo_tarjeta = [tt].[id_tipo_tarjeta]
		FROM
			[LOS_GDDS].[tipos_tarjeta] [tt]
		WHERE
			[tt].[descripcion] = @descripcion_tarjeta
	RETURN @id_tipo_tarjeta
END
GO

/* CREACIÓN STORED PROCEDURES */

CREATE PROCEDURE [LOS_GDDS].[validar_login] 
	@Usuario varchar(100),
	@Clave varchar(100),
	@MaxIntentos numeric(3,0),
	@Resultado INT OUT,
	@Id INT OUT,
	@Rol INT OUT
AS
BEGIN
DECLARE
	@ClaveEncriptada varchar(255),
	@Intentos numeric(3,0)
	SELECT 
		@Id = [u].[id_usuario], 
		@ClaveEncriptada = [u].[password],
		@Intentos = [u].[cantidad_logins_fallidos],
		@Rol = [ru].[id_rol]
		FROM 
			[LOS_GDDS].[usuarios] [u]
		INNER JOIN 
			[LOS_GDDS].[roles_usuario] [ru]
		ON 
			[ru].[id_usuario] = [u].[id_usuario]
	WHERE [username] = @Usuario

SELECT @Resultado =
CASE
	--El usuario no existe
	WHEN @Id IS NULL THEN 0
	--Intentos excedidos
	WHEN @Intentos >= @MaxIntentos THEN 1
	--La password no coincide
	WHEN @ClaveEncriptada <> CAST(HASHBYTES('SHA2_256', @Clave) AS binary(32)) THEN 2
	--El usuario no está habilitado
	WHEN (SELECT [habilitado] FROM [LOS_GDDS].[usuarios] WHERE [id_usuario] = @Id) = 0 THEN 3
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
	UPDATE [LOS_GDDS].[usuarios] SET [cantidad_logins_fallidos] = @Intentos WHERE [id_usuario] = @Id

RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[migrar_clientes]
AS
BEGIN
	INSERT INTO 
		[LOS_GDDS].[clientes]([apellido], [nombre], [dni], [direccion], [telefono], [mail], [fecha_nacimiento], [ciudad], [saldo])
		(
			SELECT
				DISTINCT
				[Cli_Apellido] ,
				[Cli_Nombre],
				[Cli_Dni],
				[Cli_Direccion],
				[Cli_Telefono],
				[Cli_Mail],
				[Cli_Fecha_Nac],
				[Cli_Ciudad],
				0
			FROM 
				[gd_esquema].[Maestra]
			WHERE 
				[Cli_Apellido] IS NOT NULL
		)
END
GO

CREATE PROCEDURE [LOS_GDDS].[migrar_rubros]
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[rubros](descripcion)
		(
			SELECT
				DISTINCT
				[provee_rubro]
			 FROM 
				[gd_esquema].[Maestra]
			 WHERE
				[provee_rubro] IS NOT NULL
		)
END
GO

CREATE PROCEDURE [LOS_GDDS].[migrar_proveedores]
AS
BEGIN
	INSERT INTO 
		[LOS_GDDS].[proveedores]([razon_social], [direccion], [ciudad], [telefono], [cuit], [id_rubro])
		(
			SELECT
				DISTINCT
				[Provee_RS],
				[Provee_Dom],
				[Provee_Ciudad],
				[Provee_Telefono],
				[Provee_CUIT],
				[LOS_GDDS].[obtener_rubro_by_descripcion]([Provee_Rubro])
			FROM 
				[gd_esquema].[Maestra]
			WHERE 
				[Provee_RS] IS NOT NULL
		)
END
GO

CREATE PROCEDURE [LOS_GDDS].[actualizar_saldos_clientes]
AS
BEGIN
	UPDATE
		[clientes]
	SET
		-- estoy actualizando el saldo disponible en base a lo vendido y NO a lo entregado
		[saldo] +=
				(
					SELECT
						ISNULL(SUM([cr].[monto]), 0)
					 FROM
						[cargas_realizadas] [cr]
					 WHERE
						[cr].[id_cliente] = [clientes].[id_cliente]
				)
END
GO

CREATE PROCEDURE [LOS_GDDS].[generar_tipos_tarjeta]
AS
BEGIN
	SET IDENTITY_INSERT [LOS_GDDS].[tipos_tarjeta] ON
	INSERT INTO [LOS_GDDS].[tipos_tarjeta](id_tipo_tarjeta, descripcion)
		VALUES
			(	
				1,
				'Crédito'
			)

	INSERT INTO [LOS_GDDS].[tipos_tarjeta](id_tipo_tarjeta, descripcion)
		VALUES
			(
				2,
				'Débito'
			)
	SET IDENTITY_INSERT [LOS_GDDS].[tipos_tarjeta] OFF
END
GO

CREATE PROCEDURE [LOS_GDDS].[generar_tarjetas_clientes]
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[tarjetas](id_cliente, fecha_vencimiento, id_tipo_tarjeta)
	(
		SELECT
			DISTINCT
			[LOS_GDDS].[obtener_cliente_by_dni]([Cli_Dni]),
			GETDATE(),
			[LOS_GDDS].[get_tipo_tarjeta_by_descripcion]([Tipo_Pago_Desc])
		FROM 
			[gd_esquema].[Maestra]
		WHERE 
			[Carga_credito] IS NOT NULL
		AND
			[LOS_GDDS].[get_tipo_tarjeta_by_descripcion]([Tipo_Pago_Desc]) IS NOT NULL
	)
END
GO

--CREATE PROCEDURE [LOS_GDDS].[crear_usuarios_para_clientes_con_tarjeta]
--AS
--BEGIN
--	INSERT INTO
--		[LOS_GDDS].[usuarios](username, password, habilitado, cantidad_logins_fallidos, id_cliente)
--	(
--		SELECT
--			DISTINCT
--			UPPER(CONCAT([c].[nombre], [c].[apellido])),
--			HASHBYTES('SHA2_256', CAST([c].[dni] AS VARCHAR(8))),
--			1,
--			0,
--			[c].[id_cliente]
--		FROM 
--			[LOS_GDDS].[cargas_realizadas] [cr]
--		INNER JOIN
--			[LOS_GDDS].[tarjetas] [t]
--		ON
--			[t].[id_tarjeta] = [cr].[id_tarjeta]
--		INNER JOIN
--			[LOS_GDDS].[clientes] [c]
--		ON
--			[c].[id_cliente] = [cr].[id_cliente]
--	)
--END
--GO

CREATE PROCEDURE [LOS_GDDS].[migrar_cargas_realizadas]
AS
BEGIN
	EXEC [LOS_GDDS].[generar_tipos_tarjeta]
	EXEC [LOS_GDDS].[generar_tarjetas_clientes]
	INSERT INTO
		[LOS_GDDS].[cargas_realizadas]([id_cliente], [id_tarjeta], [fecha], [monto])
		(
			SELECT
				DISTINCT
				[LOS_GDDS].[obtener_cliente_by_dni]([Cli_Dni]),
				CASE
					WHEN 
						[Tipo_Pago_Desc] = 'Efectivo'
						THEN
							NULL
					ELSE
						[LOS_GDDS].[get_tarjeta_by_id_cliente]([LOS_GDDS].[obtener_cliente_by_dni]([Cli_Dni]))
				END,
				[Carga_fecha],
				[Carga_credito]
			FROM 
				[gd_esquema].[Maestra]
			WHERE 
				[Carga_credito] IS NOT NULL
		)
	EXEC [LOS_GDDS].[actualizar_saldos_clientes]
END
GO

CREATE PROCEDURE [LOS_GDDS].[migrar_ofertas]
AS
BEGIN
	INSERT INTO 
		[LOS_GDDS].[ofertas]([id_oferta], [id_proveedor], [precio_lista], [precio_oferta], [stock], [descripcion], [fecha_publicacion], [fecha_vencimiento])
		(
			SELECT
				DISTINCT
				[Oferta_Codigo],
				[LOS_GDDS].[obtener_proveedor_by_cuit]([Provee_CUIT]),
				[Oferta_Precio_Ficticio],
				[Oferta_Precio],
				[Oferta_Cantidad],
				[Oferta_Descripcion],
				[Oferta_Fecha],
				[Oferta_Fecha_Venc]
			FROM 
				[gd_esquema].[Maestra]
			WHERE 
				[Oferta_Codigo] IS NOT NULL
		)
END
GO

CREATE PROCEDURE [LOS_GDDS].[actualizar_fecha_entrega_ofertas]
AS
BEGIN
	DECLARE @id_oferta NVARCHAR(50),
			@id_cliente	INT,
			@oferta_entregado_fecha DATETIME

	DECLARE ofertas_cursor CURSOR
	FOR
		SELECT
			DISTINCT
			[Oferta_Codigo],
			[LOS_GDDS].[obtener_cliente_by_dni]([Cli_Dni]),
			[Oferta_entregado_fecha]
		FROM
			[gd_esquema].[Maestra]
		WHERE 
			[Oferta_Codigo]	IS NOT NULL
		AND
			[Cli_Dni] IS NOT NULL
		AND 
			[Oferta_Entregado_Fecha] IS NOT NULL
	
	OPEN ofertas_cursor
		FETCH NEXT FROM ofertas_cursor INTO
			@id_oferta,
			@id_cliente,
			@oferta_entregado_fecha

	WHILE @@FETCH_STATUS = 0
				BEGIN
					UPDATE
						[LOS_GDDS].[compras]
						SET 
							[fecha_consumo] = @oferta_entregado_fecha
						WHERE
							[id_oferta] = @id_oferta
							AND [id_cliente] = @id_cliente

					FETCH NEXT FROM ofertas_cursor INTO
						@id_oferta,
						@id_cliente,
						@oferta_entregado_fecha
				END
	CLOSE ofertas_cursor
	DEALLOCATE ofertas_cursor
END
GO

CREATE PROCEDURE [LOS_GDDS].[actualizar_stock_ofertas]
AS
BEGIN
	UPDATE
		[LOS_GDDS].[ofertas]
	SET
		-- estoy actualizando el stock disponible en base a lo vendido y NO a lo entregado
		[stock] -=
				(
					SELECT
						ISNULL(COUNT(1), 0)
					 FROM
						[compras] [c]
					 WHERE
						[c].[id_oferta] = [ofertas].[id_oferta]
				)
END
GO

--CREATE PROCEDURE [LOS_GDDS].[actualizar_saldo_disponible_clientes]
--AS
--BEGIN
--	UPDATE
--		[LOS_GDDS].[clientes]
--	SET
--		[saldo] -=
--					(
--						SELECT
--							SUM([o].[precio_oferta])
--						FROM
--							[LOS_GDDS].[compras] [c]
--						INNER JOIN
--							[LOS_GDDS].[ofertas] [o]
--						ON
--							[c].[id_oferta] = [o].[id_oferta]
--						WHERE
--							[clientes].[id_cliente] = [c].[id_cliente]
--						GROUP BY
--							[o].[id_oferta], [c].[id_cliente]
--					)
--END
--GO

CREATE PROCEDURE [LOS_GDDS].[migrar_compras]
AS
BEGIN
	INSERT INTO 
		[LOS_GDDS].[compras]([id_oferta], [id_cliente], [id_factura], [fecha], [fecha_consumo], [cantidad])
		(
			SELECT
				DISTINCT
				[Oferta_Codigo],
				[LOS_GDDS].[obtener_cliente_by_dni]([Cli_Dni]),
				NULL,
				[Oferta_fecha_compra],
				(
					SELECT	
						[Oferta_Entregado_fecha]
					FROM
						[gd_esquema].[Maestra] [m2]
					WHERE
						[m1].[Oferta_Codigo] = [m2].[Oferta_Codigo]
					AND
						[m1].[Cli_Dni] = [m2].[Cli_Dni]
					AND
						[m1].[Oferta_Fecha_Compra] = [m2].[Oferta_Fecha_Compra]
					AND
						[m2].[Oferta_Cantidad] IS NOT NULL
					AND
						[m2].[Oferta_Entregado_Fecha] IS NOT NULL
				),
				1
			FROM
				[gd_esquema].[Maestra] [m1]
			WHERE 
				[Oferta_Codigo] IS NOT NULL
		)

	EXEC [LOS_GDDS].[actualizar_stock_ofertas]
--	EXEC [LOS_GDDS].[actualizar_saldo_disponible_clientes]
END
GO

CREATE PROCEDURE [LOS_GDDS].[actualizar_fecha_desde_fecha_hasta_facturas]
AS
BEGIN
	UPDATE
		[LOS_GDDS].[facturas]
	SET
		[fecha_desde] = [a].[fecha_desde],
		[fecha_hasta] = [a].[fecha_hasta]
	FROM
		(
			SELECT
				[f].[nro_factura] AS [nro_factura],
				MIN([Oferta_fecha_compra]) AS [fecha_desde],
				MAX([Oferta_fecha_compra]) AS [fecha_hasta]
			FROM
				[LOS_GDDS].[facturas] [f]
			LEFT JOIN
				[gd_esquema].[Maestra] [m]
			ON
				[m].[Factura_Nro] = [f].[nro_factura]
			INNER JOIN
				[LOS_GDDS].[ofertas] [o]
			ON
				[o].[id_oferta] = [m].[Oferta_Codigo]
			GROUP BY
				[f].[nro_factura]
		) [a]
	WHERE
		[a].[nro_factura] = [facturas].[nro_factura]
END
GO

CREATE PROCEDURE [LOS_GDDS].[asociar_facturas_compras]
AS
BEGIN
	DECLARE
		@id_factura INT,
		@id_proveedor INT,
		@fecha_desde DATETIME,
		@fecha_hasta DATETIME
	DECLARE facturas_cursor CURSOR FOR
	SELECT
		DISTINCT
		[f].[id_factura],
		[f].[id_proveedor],
		[f].[fecha_desde],
		[f].[fecha_hasta]
	FROM
		[LOS_GDDS].[facturas] f

	-- esta condicion es para SIEMPRE procesar ÚNICAMENTE lo pendiente (que nunca fue procesado)
	WHERE
		NOT EXISTS (SELECT
						1
					FROM
						[LOS_GDDS].[compras] c
					WHERE
						[c].[id_factura] = [f].[id_factura]
					)
	
	OPEN facturas_cursor
	FETCH NEXT FROM facturas_cursor	INTO
	@id_factura,
	@id_proveedor,
	@fecha_desde,
	@fecha_hasta
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE
			[LOS_GDDS].[compras]
		SET
			[id_factura] = @id_factura
		WHERE
			[id_factura] IS NULL AND
			[fecha] >= @fecha_desde AND
			[fecha] < @fecha_hasta AND
			[id_oferta] IN (
							SELECT
								[id_oferta]
							FROM
								[LOS_GDDS].[ofertas]
							WHERE
								[id_proveedor] = @id_proveedor
							)
		FETCH NEXT FROM facturas_cursor	INTO
		@id_factura,
		@id_proveedor,
		@fecha_desde,
		@fecha_hasta
	END
	CLOSE facturas_cursor
	DEALLOCATE facturas_cursor
END
GO

CREATE PROCEDURE [LOS_GDDS].[migrar_facturas]
AS
BEGIN
	INSERT INTO 
		[LOS_GDDS].[facturas]([nro_factura], [id_proveedor], [total], [fecha_emision])
		(
			SELECT
				[Factura_Nro],
				[LOS_GDDS].[obtener_proveedor_by_cuit]([Provee_CUIT]),
				SUM([Oferta_Precio]),
				[Factura_Fecha]
			 FROM
				[gd_esquema].[Maestra]
			 WHERE 
				[Factura_Fecha] IS NOT NULL
			 GROUP BY
				[Factura_nro],
				[Provee_CUIT],
				[Factura_Fecha]
		)
	EXEC [LOS_GDDS].[actualizar_fecha_desde_fecha_hasta_facturas]
	EXEC [LOS_GDDS].[asociar_facturas_compras]
END
GO

CREATE PROCEDURE [LOS_GDDS].[cargar_roles]
	@Rol varchar(255)
AS
BEGIN
	SELECT
		[id_rol],
		[nombre]
	FROM
		[LOS_GDDS].[roles]
	WHERE
		[nombre] LIKE '%' + ISNULL(@Rol, '') + '%' AND
		[habilitado] = 1
	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[cargar_proveedores]
	@RazonSocial VARCHAR(255),
	@Cuit VARCHAR(255)
AS
BEGIN
	SELECT
		[p].[id_proveedor],
		[p].[razon_social] AS 'Razón social',
		[p].[telefono] AS 'Teléfono',
		[p].[ciudad] AS 'Ciudad',
		[p].[direccion] AS 'Dirección',
		[p].[cuit] AS 'CUIT'
	FROM
		[LOS_GDDS].[proveedores] [p]
	JOIN
		[LOS_GDDS].[usuarios] [u]
	ON
		[u].[id_proveedor] = [p].[id_proveedor]
	WHERE
		[p].[razon_social] LIKE '%' + ISNULL(@RazonSocial, '') + '%' AND
		[p].[cuit] LIKE '%' + ISNULL(@Cuit, '') + '%' AND
		[u].[habilitado] = 1
	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[cargar_funcionalidades_disponibles_rol]
	@IdRol INT
AS
BEGIN
	SELECT DISTINCT
		[f].[id_funcionalidad],
		[f].[nombre]
	FROM
		[LOS_GDDS].[funcionalidades] f
	LEFT JOIN
		[LOS_GDDS].[funcionalidades_rol] fr
	ON
		[fr].[id_funcionalidad] = [f].[id_funcionalidad]
	WHERE
		[f].[id_funcionalidad] NOT IN	(
											SELECT
												[id_funcionalidad]
											FROM
												[LOS_GDDS].[funcionalidades_rol]
											WHERE
												[id_rol] = @IdRol
										)

	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[cargar_funcionalidades_de_rol]
	@IdRol INT
AS
BEGIN
	SELECT DISTINCT
		[f].[id_funcionalidad],
		[f].[nombre]
	FROM
		[LOS_GDDS].[funcionalidades] f
	LEFT JOIN
		[LOS_GDDS].[funcionalidades_rol] fr
	ON
		[fr].[id_funcionalidad] = [f].[id_funcionalidad]
	WHERE
		[f].[id_funcionalidad] IN	(
											SELECT
												[id_funcionalidad]
											FROM
												[LOS_GDDS].[funcionalidades_rol]
											WHERE
												[id_rol] = @IdRol
									)

	RETURN
END
GO

/*CREATE PROCEDURE [LOS_GDDS].[sacar_funcionalidades_a_rol]
	@IdRol INT
AS
BEGIN
	DELETE
		[LOS_GDDS].[funcionalidades_rol]
	WHERE
		[id_rol] = @IdRol

	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[insertar_funcionalidad_rol]
	@IdRol INT,
	@IdFuncionalidad INT
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[funcionalidades_rol]
	VALUES
		(
			@IdRol,
			@IdFuncionalidad
		)

	RETURN
END
GO*/

CREATE PROCEDURE [LOS_GDDS].[insertar_nuevo_rol]
	@Nombre VARCHAR(255),
	@Habilitado BIT,
	@IdRol INT OUT
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[roles] ([nombre], [habilitado])
	VALUES
		(
			@Nombre,
			@Habilitado
		)

	SET @IdRol = SCOPE_IDENTITY();

	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[existe_usuario]
	@Username VARCHAR(255),
	@Respuesta INT OUT
AS
BEGIN
		IF EXISTS(SELECT 1 FROM [LOS_GDDS].[usuarios] WHERE [username] = @Username)
		BEGIN
			SET @Respuesta = 1
		END
		ELSE
		BEGIN
			SET @Respuesta = 0
		END

	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[insertar_nuevo_usuario]
	@Username VARCHAR(255),
	@Password VARCHAR(255),
	@IdProveedor INT,
	@IdCliente INT,
	@IdUsuario INT OUT
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[usuarios] ([username], [password], [habilitado], [cantidad_logins_fallidos],
		[id_proveedor], [id_cliente])
	VALUES
		(
			@Username,
			CAST(HASHBYTES('SHA2_256', @Password) AS binary(32)),
			1,
			0,
			@IdProveedor,
			@IdCliente
		)

	SET @IdUsuario = SCOPE_IDENTITY();

	IF(@IdCliente IS NOT NULL)
		BEGIN
			DECLARE @id_rol_cliente INT

			SELECT TOP 1
				@id_rol_cliente = [id_rol]
			FROM
				[LOS_GDDS].[roles]
			WHERE
				[nombre] = 'Cliente'
		
			INSERT INTO 
				[LOS_GDDS].[roles_usuario]
			VALUES
				(@IdUsuario,@id_rol_cliente)
		END
	ELSE IF(@IdProveedor IS NOT NULL)
		BEGIN
			DECLARE @id_rol_proveedor INT

				SELECT TOP 1
					@id_rol_proveedor = [id_rol]
				FROM
					[LOS_GDDS].[roles]
				WHERE
					[nombre] = 'Proveedor'
		
				INSERT INTO 
					[LOS_GDDS].[roles_usuario]
				VALUES
					(@IdUsuario,@id_rol_proveedor)
		END
	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[insertar_nuevo_cliente]
	@Nombre VARCHAR(255),
	@Apellido VARCHAR(255),
	@Dni NUMERIC(18, 0),
	@Mail NVARCHAR(255),
	@Telefono NUMERIC(18, 0),
	@Direccion NVARCHAR(255),
	@CodigoPostal NVARCHAR(15),
	@FechaNacimiento DATETIME,
	@IdCliente INT OUT
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[clientes] ([nombre], [apellido], [dni], [mail], [telefono], [direccion],
		[codigo_postal], [fecha_nacimiento], [saldo])
	VALUES
		(
			@Nombre,
			@Apellido,
			@Dni,
			@Mail,
			@Telefono,
			@Direccion,
			@CodigoPostal,
			@FechaNacimiento,
			200
		)

	SET @IdCliente = SCOPE_IDENTITY();

	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[insertar_nuevo_proveedor]
	@RazonSocial NVARCHAR(100),
	@Mail NVARCHAR(255),
	@Telefono NUMERIC(18, 0),
	@CodigoPostal NVARCHAR(255),
	@Ciudad NVARCHAR(255),
	@Direccion NVARCHAR(100),
	@Cuit NVARCHAR(20),
	@NombreContacto NVARCHAR(100),
	@Rubro INT,
	@IdProveedor INT OUT
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[proveedores] ([razon_social], [mail], [telefono], [codigo_postal], [ciudad],
		[direccion], [cuit], [nombre_contacto], [id_rubro])
	VALUES
		(
			@RazonSocial,
			@Mail,
			@Telefono,
			@CodigoPostal,
			@Ciudad,
			@Direccion,
			@Cuit,
			@NombreContacto,
			@Rubro
		)

	SET @IdProveedor = SCOPE_IDENTITY();

	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[insertar_nueva_oferta]
	@IdProveedor INT,
	@PrecioLista NUMERIC(18, 2),
	@PrecioOferta NUMERIC(18, 2),
	@Stock NUMERIC(18, 0),
	@UnidadesMaximas NUMERIC(18, 0),
	@Descripcion NVARCHAR(255),
	@FechaVencimiento DATETIME,
	@FechaPublicacion DATETIME
AS
BEGIN
	INSERT INTO
		[LOS_GDDS].[ofertas] ([id_proveedor], [precio_lista], [precio_oferta], [stock], [unidades_maximas_cliente],
			[descripcion], [fecha_vencimiento], [fecha_publicacion])
	VALUES
		(
			@IdProveedor,
			@PrecioLista,
			@PrecioOferta,
			@Stock,
			@UnidadesMaximas,
			@Descripcion,
			@FechaVencimiento,
			@FechaPublicacion
		)

	RETURN
END
GO

CREATE PROCEDURE [LOS_GDDS].[modificar_password]
	@IdUsuario INT,
	@NuevaPassword VARCHAR(255),
	@Resultado INT OUT
AS
BEGIN
BEGIN TRY
	UPDATE
		[LOS_GDDS].[usuarios]
	SET
		[password] = CAST(HASHBYTES('SHA2_256', @NuevaPassword) AS binary(32))
	WHERE
		[id_usuario] = @IdUsuario

	SET @Resultado = 1 /*TODO OK*/
END TRY
BEGIN CATCH
	SET @Resultado = 0 /*ERROR*/
END CATCH
END
GO

/* CREACIÓN TRIGGERS */

CREATE TRIGGER [LOS_GDDS].[aplicar_compra_en_saldo_cliente]
ON
	[LOS_GDDS].[compras]
AFTER
	INSERT
AS
BEGIN
	BEGIN TRANSACTION 
	DECLARE 
		@id_cliente INT,
		@id_oferta NVARCHAR(50),
		@cantidad NUMERIC(18,0)
	SELECT
		@id_cliente = [i].[id_cliente],
		@id_oferta = [i].[id_oferta],
		-- chequear que onda la cantidad, siempre esta en NULL actualmente
		@cantidad = [i].[cantidad]
	FROM
		[inserted] [i]

	UPDATE
		[LOS_GDDS].[clientes]
	SET
		[saldo] -=
			(
				(
					SELECT
						[precio_oferta]
					FROM
						[LOS_GDDS].[ofertas]
					WHERE
						[id_oferta] = @id_oferta
				) * @cantidad
			)
	WHERE
		[clientes].[id_cliente] = @id_cliente
	COMMIT TRANSACTION
END
GO

CREATE TRIGGER [LOS_GDDS].[update_compra]
ON
	[LOS_GDDS].[facturas]
AFTER
	INSERT
AS
BEGIN
	EXEC [LOS_GDDS].[asociar_facturas_compras]
END
GO

CREATE TRIGGER [LOS_GDDS].[generar_usuario_cliente]
ON [LOS_GDDS].[clientes]
AFTER
	INSERT
AS
BEGIN
	DECLARE @mail_cliente NVARCHAR(255),
			@dni_cliente VARCHAR(18),
			@id_cliente INT,
			@id_usuario INT

	DECLARE clientes_cursor CURSOR FOR
		SELECT
			CAST([mail] AS VARCHAR(100)),
			CAST([dni] AS VARCHAR(18)),
			[id_cliente]
		FROM
			[inserted]
		ORDER BY
			[inserted].[id_cliente]

	OPEN clientes_cursor
	FETCH NEXT FROM clientes_cursor INTO
		@mail_cliente,
		@dni_cliente,
		@id_cliente
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC [LOS_GDDS].[insertar_nuevo_usuario] @dni_cliente, @mail_cliente, NULL, @id_cliente, @id_usuario OUT

		FETCH NEXT FROM clientes_cursor INTO
		@mail_cliente,
		@dni_cliente,
		@id_cliente
	END
	CLOSE clientes_cursor
	DEALLOCATE clientes_cursor
END
GO

CREATE TRIGGER [LOS_GDDS].[generar_usuario_proveedor]
ON [LOS_GDDS].[proveedores]
AFTER
	INSERT
AS
BEGIN
	DECLARE @razon_social NVARCHAR(100),
			@cuit VARCHAR(20),
			@id_proveedor INT,
			@id_usuario INT

	DECLARE proveedores_cursor CURSOR FOR
		SELECT
			[razon_social],
			[cuit],
			[id_proveedor]
		FROM
			[inserted]
		ORDER BY
			[inserted].[id_proveedor]

	OPEN proveedores_cursor
	FETCH NEXT FROM proveedores_cursor INTO
		@razon_social,
		@cuit,
		@id_proveedor
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC [LOS_GDDS].[insertar_nuevo_usuario] @razon_social, @cuit, @id_proveedor, NULL, @id_usuario OUT

		FETCH NEXT FROM proveedores_cursor INTO
		@razon_social,
		@cuit,
		@id_proveedor
	END
	CLOSE proveedores_cursor
	DEALLOCATE proveedores_cursor
END
GO

CREATE TRIGGER [LOS_GDDS].[aplicar_carga_en_saldo_cliente]
ON
	[LOS_GDDS].[cargas_realizadas]
AFTER
	INSERT
AS
BEGIN
	DECLARE 
		@id_cliente INT,
		@monto NUMERIC(18,0)

	DECLARE cargas_cursor CURSOR FOR
	SELECT
		[id_cliente],
		[monto]
	FROM
		[inserted]

	OPEN cargas_cursor
	FETCH NEXT FROM cargas_cursor INTO
		@id_cliente,
		@monto

	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE
			[LOS_GDDS].[clientes]
		SET
			[saldo] += @monto
		WHERE
			[id_cliente] = @id_cliente

	FETCH NEXT FROM cargas_cursor INTO
		@id_cliente,
		@monto
	END
	CLOSE cargas_cursor
	DEALLOCATE cargas_cursor
END
GO

-- deshabilito los triggers para que no ejecuten durante la migracion
DISABLE TRIGGER [LOS_GDDS].[aplicar_compra_en_saldo_cliente]
ON [LOS_GDDS].[compras]
GO

DISABLE TRIGGER [LOS_GDDS].[update_compra]
ON [LOS_GDDS].[facturas]
GO

-- inserto algunos datos de prueba
INSERT INTO [LOS_GDDS].[usuarios]
           ([username]
           ,[password]
           ,[habilitado]
           ,[cantidad_logins_fallidos]
           ,[id_proveedor]
           ,[id_cliente])
     VALUES
           ('tute'
           ,CAST(HASHBYTES('SHA2_256', 'tute') AS binary(32))
           ,1
           ,0
           ,NULL
           ,NULL)

INSERT INTO [LOS_GDDS].[roles]
           ([nombre]
           ,[habilitado])
     VALUES
           ('Administrador'
           ,1)

INSERT INTO [LOS_GDDS].[roles]
           ([nombre]
           ,[habilitado])
     VALUES
           ('Proveedor'
           ,1)

INSERT INTO [LOS_GDDS].[roles]
           ([nombre]
           ,[habilitado])
     VALUES
           ('Cliente'
           ,1)

INSERT INTO [LOS_GDDS].[roles_usuario]
           ([id_usuario]
           ,[id_rol])
     VALUES
           ((SELECT [id_usuario] FROM [LOS_GDDS].[usuarios] WHERE username = 'tute')
           ,(SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE nombre = 'Administrador'))

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('ABM de Roles')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('ABM de Clientes')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('ABM de Proveedores')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Modificar password')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Baja de usuario')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Cargar crédito')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Comprar oferta')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Crear oferta')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Facturar')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Listado estadístico')

INSERT INTO [LOS_GDDS].[funcionalidades]
           ([nombre])
     VALUES
           ('Consumir oferta')

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Administrador')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'ABM de Roles'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Administrador')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'ABM de Clientes'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Administrador')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'ABM de Proveedores'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Administrador')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Cargar crédito'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Administrador')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Modificar password'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Administrador')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Baja de usuario'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Cliente')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Cargar crédito'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Cliente')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Modificar password'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Proveedor')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Modificar password'))

INSERT INTO [LOS_GDDS].[tarjetas]
	VALUES
		((SELECT [id_usuario] FROM [LOS_GDDS].[usuarios] WHERE [username] = 'tute'),
		12345678,
		GETDATE(),
		1234,
		1);

INSERT INTO [LOS_GDDS].[tarjetas]
	VALUES
		((SELECT [id_usuario] FROM [LOS_GDDS].[usuarios] WHERE [username] = 'tute'),
		11111111,
		GETDATE(),
		5678,
		1);

INSERT INTO [LOS_GDDS].[tarjetas]
	VALUES
		((SELECT [id_usuario] FROM [LOS_GDDS].[usuarios] WHERE [username] = 'tute'),
		22222222,
		GETDATE(),
		1122,
		1);

INSERT INTO [LOS_GDDS].[tarjetas]
	VALUES
		((SELECT [id_usuario] FROM [LOS_GDDS].[usuarios] WHERE [username] = 'tute'),
		87654321,
		GETDATE(),
		0990,
		2);

-- este workaround es para que se migren los datos únicamente una vez por tabla
IF((SELECT COUNT(1) FROM [LOS_GDDS].[clientes]) = 0)
BEGIN
	PRINT('migrando clientes')
	EXEC [LOS_GDDS].[migrar_clientes]
	PRINT('clientes migrados!')
END
GO

IF((SELECT COUNT(1) FROM [LOS_GDDS].[rubros]) = 0)
BEGIN
	PRINT('migrando rubros')
	EXEC [LOS_GDDS].[migrar_rubros]
	PRINT('rubros migrados!')
END
GO

IF((SELECT COUNT(1) FROM [LOS_GDDS].[proveedores]) = 0)
BEGIN
	PRINT('migrando proveedores')
	EXEC [LOS_GDDS].[migrar_proveedores]
	PRINT('proveedores migrados!')
END
GO

IF((SELECT COUNT(1) FROM [LOS_GDDS].[cargas_realizadas]) = 0)
BEGIN
	PRINT('migrando cargas realizadas')
	EXEC [LOS_GDDS].[migrar_cargas_realizadas]
	PRINT('cargas realizadas migradas!')
END
GO

IF((SELECT COUNT(1) FROM [LOS_GDDS].[ofertas]) = 0)
BEGIN
	PRINT('migrando ofertas')
	EXEC [LOS_GDDS].[migrar_ofertas]
	PRINT('ofertas migradas!')
END
GO

IF((SELECT COUNT(1) FROM [LOS_GDDS].[compras]) = 0)
BEGIN
	PRINT('migrando compras')
	EXEC [LOS_GDDS].[migrar_compras]
	PRINT('compras migradas!')
	--PRINT('actualizando fecha de entrega de compras')
	--EXEC [LOS_GDDS].[actualizar_fecha_entrega_ofertas]
	--PRINT('fecha de entrega de compras actualizadas')
END
GO

IF((SELECT COUNT(1) FROM [LOS_GDDS].[facturas]) = 0)
BEGIN
	PRINT('migrando facturas')
	EXEC [LOS_GDDS].[migrar_facturas]
	PRINT('facturas migradas!')
END
GO

-- habilito los triggers para que ejecuten durante la ejecución de la app
ENABLE TRIGGER [LOS_GDDS].[aplicar_compra_en_saldo_cliente]
ON [LOS_GDDS].[compras]
GO

ENABLE TRIGGER [LOS_GDDS].[update_compra]
ON [LOS_GDDS].[facturas]
GO

-- Hay que verificar el tema de la asociar el usuario con el cliente
-- existen distintos clientes con igual mail lo que nos puede llegar a dar problemas
-- probar con estas queries
	--SELECT u.id_proveedor, p.id_proveedor FROM
	--	LOS_GDDS.usuarios U
	--INNER JOIN
	--	[LOS_GDDS].[proveedores] p
	--ON
	--	p.razon_social = U.username
	--WHERE
	--	u.id_proveedor <> p.id_proveedor
	--	order by 1


	--SELECT u.id_cliente, c.id_cliente FROM
	--	LOS_GDDS.usuarios U
	--INNER JOIN
	--	[LOS_GDDS].clientes c
	--ON
	--	c.mail = U.username
	--WHERE
	--	u.id_cliente <> c.id_cliente
	--	order by 1,2