USE [GD2C2019]
GO

-- Creacion del schema
CREATE SCHEMA [LOS_GDDS]
GO

/* CREACIÓN TABLAS */
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

-- tabla medios_pago
CREATE TABLE [LOS_GDDS].[medios_pago] (
	id_medio_pago INT IDENTITY PRIMARY KEY,
	descripcion NVARCHAR(100),
)

-- tabla cargas_realizadas
CREATE TABLE [LOS_GDDS].[cargas_realizadas] (
	id_carga INT PRIMARY KEY IDENTITY,
	id_cliente INT,
	id_tarjeta INT,
	id_medio_pago INT,
	fecha DATETIME,
	monto NUMERIC(18,2)
	FOREIGN KEY (id_tarjeta) REFERENCES [LOS_GDDS].[tarjetas](id_tarjeta),
	FOREIGN KEY (id_medio_pago) REFERENCES [LOS_GDDS].[medios_pago](id_medio_pago),
	FOREIGN KEY (id_cliente) REFERENCES [LOS_GDDS].[clientes](id_cliente)
)

-- tabla rubros
CREATE TABLE [LOS_GDDS].[rubros] (
	id_rubro INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(100)
)

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

-- tabla roles_usuario
CREATE TABLE [LOS_GDDS].[roles_usuario] (
	id_usuario INT,
	id_rol INT,
	PRIMARY KEY (id_usuario, id_rol),
	FOREIGN KEY (id_usuario) REFERENCES [LOS_GDDS].[usuarios](id_usuario),
	FOREIGN KEY (id_rol) REFERENCES [LOS_GDDS].[roles](id_rol)
)

-- tabla facturacion_proveedor
CREATE TABLE [LOS_GDDS].[facturacion_proveedor] (
	id_proveedor INT PRIMARY KEY,
	total_facturado NUMERIC(18,2)
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_proveedor)
)

-- tabla facturas
CREATE TABLE [LOS_GDDS].[facturas] (
	id_factura NUMERIC(18,0) PRIMARY KEY IDENTITY,
	id_proveedor INT,
	total NUMERIC(18,2),
	fecha_desde DATETIME,
	fecha_hasta DATETIME
	FOREIGN KEY (id_proveedor) REFERENCES [LOS_GDDS].[proveedores](id_proveedor)
)

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

--tabla estados_compra
CREATE TABLE [LOS_GDDS].[estados_compra] (
	id_estado_compra INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR(100)
)

-- tabla compras
CREATE TABLE [LOS_GDDS].[compras] (
	id_compra INT PRIMARY KEY IDENTITY,
	id_oferta NVARCHAR(50) NOT NULL,
	id_cliente INT NOT NULL,
	id_estado INT NOT NULL,
	fecha DATETIME NOT NULL,
	fecha_consumo DATETIME,
	cantidad NUMERIC(18,0),
	FOREIGN KEY (id_oferta) REFERENCES [LOS_GDDS].[ofertas](id_oferta),
	FOREIGN KEY (id_cliente) REFERENCES [LOS_GDDS].[clientes](id_cliente),
	FOREIGN KEY (id_estado) REFERENCES [LOS_GDDS].[estados_compra](id_estado_compra),
	CHECK([fecha_consumo] > [fecha])
)
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
			((
				SELECT
					[precio_oferta]
				FROM
					[LOS_GDDS].[ofertas]
				WHERE
					[id_oferta] = @id_oferta
			) * @cantidad)
	WHERE
		[clientes].[id_cliente] = @id_cliente
	COMMIT TRANSACTION
END
GO

DISABLE TRIGGER [LOS_GDDS].[aplicar_compra_en_saldo_cliente]
ON [LOS_GDDS].[compras]
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
			AND [Cli_Dni] = @dni_cliente
			AND [Oferta_Entregado_Fecha] IS NOT NULL
	RETURN @fecha_entrega_oferta
END
GO

CREATE FUNCTION [LOS_GDDS].[get_medio_pago_by_descripcion] (@descripcion_medio_pago NVARCHAR(100))
RETURNS INT
AS
BEGIN
	DECLARE @id_medio_pago INT = NULL
	SELECT
		@id_medio_pago =
		[id_medio_pago]
		FROM
			[LOS_GDDS].[medios_pago]
		WHERE 
			[descripcion] = @descripcion_medio_pago
	RETURN @id_medio_pago
END
GO

/* CREACIÓN STORED PROCEDURES */

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
	SELECT 
		@Id = [id_usuario], 
		@ClaveEncriptada = [password],
		@Intentos = [cantidad_logins_fallidos] 
	FROM [LOS_GDDS].[usuarios]
WHERE [username] = @Usuario

SELECT @Resultado =
CASE
	--El usuario no existe
	WHEN @Id IS NULL THEN 0
	--Intentos excedidos
	WHEN @Intentos >= @MaxIntentos THEN 1
	--La password no coincide
	WHEN @ClaveEncriptada <> CAST(@Clave AS binary(32)) THEN 2
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
		(SELECT
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
		(SELECT
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
		(SELECT
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
		-- estoy actualizando el stock disponible en base a lo vendido y NO a lo entregado
		[saldo] +=
				(
					SELECT
						SUM(ISNULL([cr].[monto], 0))
					 FROM
						[cargas_realizadas] [cr]
					 WHERE
						[cr].[id_cliente] = [clientes].[id_cliente]
				)
END
GO



CREATE PROCEDURE [LOS_GDDS].[migrar_cargas_realizadas]
AS
BEGIN
	INSERT INTO 
		[LOS_GDDS].[cargas_realizadas]([id_cliente], [monto], [fecha], [id_medio_pago])
		(SELECT
			DISTINCT
				[LOS_GDDS].[obtener_cliente_by_dni]([Cli_Dni]),
				[Carga_credito],
				[Carga_fecha],
				[LOS_GDDS].[get_medio_pago_by_descripcion]([Tipo_Pago_Desc])
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
		(SELECT
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
					AND [Cli_Dni] IS NOT NULL
					AND [Oferta_Entregado_Fecha] IS NOT NULL
	
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


PRINT('insertando estados compra')
SET IDENTITY_INSERT [LOS_GDDS].[estados_compra] ON
INSERT INTO [LOS_GDDS].[estados_compra](id_estado_compra, descripcion)
VALUES (1, 'Pago')
INSERT INTO [LOS_GDDS].[estados_compra](id_estado_compra, descripcion)
VALUES (2, 'Entregado')
SET IDENTITY_INSERT [LOS_GDDS].[estados_compra] OFF
GO

PRINT('insertando medios de pago')
SET IDENTITY_INSERT [LOS_GDDS].[medios_pago] ON
INSERT INTO [LOS_GDDS].[medios_pago](id_medio_pago, descripcion)
VALUES (1, 'Efectivo')
INSERT INTO [LOS_GDDS].[medios_pago](id_medio_pago, descripcion)
VALUES (2, 'Crédito')
SET IDENTITY_INSERT [LOS_GDDS].[medios_pago] OFF
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
	DECLARE @estado_compra_pago INT = 1
	DECLARE @estado_compra_entregado INT = 2

	INSERT INTO 
		[LOS_GDDS].[compras]([id_oferta], [id_cliente], [id_estado], [fecha], [fecha_consumo], [cantidad])
		(SELECT
			DISTINCT
					[Oferta_Codigo],
					[LOS_GDDS].[obtener_cliente_by_dni]([Cli_Dni]),
					@estado_compra_pago,
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

	UPDATE
		[LOS_GDDS].[compras]
		SET
			[id_estado] = @estado_compra_entregado
		WHERE
			[fecha_consumo] IS NOT NULL

	EXEC [LOS_GDDS].[actualizar_stock_ofertas]
--	EXEC [LOS_GDDS].[actualizar_saldo_disponible_clientes]
END
GO

CREATE PROCEDURE [LOS_GDDS].[migrar_facturas]
AS
BEGIN
	INSERT INTO 
		[LOS_GDDS].[facturas]([id_proveedor], [total], [fecha_desde], [fecha_hasta])
		(SELECT
			[LOS_GDDS].[obtener_proveedor_by_cuit]([Provee_CUIT]),
			SUM([Oferta_Precio]),
			-- revisar de donde sacar la fecha DESDE
			NULL,
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
END
GO


-- este workaround es para que se migren los datos únicamente una vez por tabla
IF((SELECT COUNT(1) FROM [LOS_GDDS].[clientes]) = 0)
BEGIN
	PRINT('migrando clientes')
	EXEC [LOS_GDDS].[migrar_clientes]
	PRINT('clientes migrados!')
END

IF((SELECT COUNT(1) FROM [LOS_GDDS].[rubros]) = 0)
BEGIN
	PRINT('migrando rubros')
	EXEC [LOS_GDDS].[migrar_rubros]
	PRINT('rubros migrados!')
END

IF((SELECT COUNT(1) FROM [LOS_GDDS].[proveedores]) = 0)
BEGIN
	PRINT('migrando proveedores')
	EXEC [LOS_GDDS].[migrar_proveedores]
	PRINT('proveedores migrados!')
END

IF((SELECT COUNT(1) FROM [LOS_GDDS].[cargas_realizadas]) = 0)
BEGIN
	PRINT('migrando cargas realizadas')
	EXEC [LOS_GDDS].[migrar_cargas_realizadas]
	PRINT('cargas realizadas migradas!')
END

IF((SELECT COUNT(1) FROM [LOS_GDDS].[ofertas]) = 0)
BEGIN
	PRINT('migrando ofertas')
	EXEC [LOS_GDDS].[migrar_ofertas]
	PRINT('ofertas migradas!')
END

IF((SELECT COUNT(1) FROM [LOS_GDDS].[compras]) = 0)
BEGIN
	PRINT('migrando compras')
	EXEC [LOS_GDDS].[migrar_compras]
	PRINT('compras migradas!')
	--PRINT('actualizando fecha de entrega de compras')
	--EXEC [LOS_GDDS].[actualizar_fecha_entrega_ofertas]
	--PRINT('fecha de entrega de compras actualizadas')
END

IF((SELECT COUNT(1) FROM [LOS_GDDS].[facturas]) = 0)
BEGIN
	PRINT('migrando facturas')
	EXEC [LOS_GDDS].[migrar_facturas]
	PRINT('facturas migradas!')
END
GO

ENABLE TRIGGER [LOS_GDDS].[aplicar_compra_en_saldo_cliente]
ON [LOS_GDDS].[compras]
GO
	

-- con el viejo approach (cursor) tarda 01:02:53
-- con el nuevo approach (sub-query) tarda 00:00:17
-- hay que verificar los resultados pero parece que esta todo andando