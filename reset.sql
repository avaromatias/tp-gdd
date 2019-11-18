IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'compras')
DROP TABLE [LOS_GDDS].[compras]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'estados_compra')
DROP TABLE [LOS_GDDS].[estados_compra]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'ofertas')
DROP TABLE [LOS_GDDS].[ofertas]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'facturas')
DROP TABLE [LOS_GDDS].[facturas]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'facturacion_proveedor')
DROP TABLE [LOS_GDDS].[facturacion_proveedor]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'roles_usuario')
DROP TABLE [LOS_GDDS].[roles_usuario]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'usuarios')
DROP TABLE [LOS_GDDS].[usuarios]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'proveedores')
DROP TABLE [LOS_GDDS].[proveedores]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'rubros')
DROP TABLE [LOS_GDDS].[rubros]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'cargas_realizadas')
DROP TABLE [LOS_GDDS].[cargas_realizadas]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'medios_pago')
DROP TABLE [LOS_GDDS].[medios_pago]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'tarjetas')
DROP TABLE [LOS_GDDS].[tarjetas]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'tipos_tarjeta')
DROP TABLE [LOS_GDDS].[tipos_tarjeta]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'clientes')
DROP TABLE [LOS_GDDS].[clientes]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'funcionalidades_rol')
DROP TABLE [LOS_GDDS].[funcionalidades_rol]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'roles')
DROP TABLE [LOS_GDDS].[roles]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'funcionalidades')
DROP TABLE [LOS_GDDS].[funcionalidades]

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
           WHERE TABLE_NAME = N'obtener_rubro_by_descripcion')
DROP TABLE [LOS_GDDS].[obtener_rubro_by_descripcion]

IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'[LOS_GDDS].[obtener_rubro_by_descripcion]') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION [LOS_GDDS].[obtener_rubro_by_descripcion]

IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'[LOS_GDDS].[get_medio_pago_by_descripcion]') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION [LOS_GDDS].[get_medio_pago_by_descripcion]

IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'[LOS_GDDS].[buscar_fecha_entrega_oferta]') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION [LOS_GDDS].[buscar_fecha_entrega_oferta]

IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'[LOS_GDDS].[obtener_cliente_by_dni]') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION [LOS_GDDS].[obtener_cliente_by_dni]

IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'[LOS_GDDS].[obtener_proveedor_by_cuit]') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION [LOS_GDDS].[obtener_proveedor_by_cuit]

IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'[LOS_GDDS].[get_tarjeta_by_id_cliente]') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION [LOS_GDDS].[get_tarjeta_by_id_cliente]

IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'[LOS_GDDS].[get_tipo_tarjeta_by_descripcion]') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION [LOS_GDDS].[get_tipo_tarjeta_by_descripcion]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'validar_login')
DROP PROCEDURE [LOS_GDDS].[validar_login]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'migrar_clientes')
DROP PROCEDURE [LOS_GDDS].[migrar_clientes]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'actualizar_fecha_entrega_ofertas')
DROP PROCEDURE [LOS_GDDS].[actualizar_fecha_entrega_ofertas]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'migrar_rubros')
DROP PROCEDURE [LOS_GDDS].[migrar_rubros]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'migrar_proveedores')
DROP PROCEDURE [LOS_GDDS].[migrar_proveedores]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'migrar_cargas_realizadas')
DROP PROCEDURE [LOS_GDDS].[migrar_cargas_realizadas]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'migrar_ofertas')
DROP PROCEDURE [LOS_GDDS].[migrar_ofertas]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'migrar_compras')
DROP PROCEDURE [LOS_GDDS].[migrar_compras]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'migrar_facturas')
DROP PROCEDURE [LOS_GDDS].[migrar_facturas]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'actualizar_stock_ofertas')
DROP PROCEDURE [LOS_GDDS].[actualizar_stock_ofertas]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'actualizar_saldos_clientes')
DROP PROCEDURE [LOS_GDDS].[actualizar_saldos_clientes]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'actualizar_saldo_disponible_clientes')
DROP PROCEDURE [LOS_GDDS].[actualizar_saldo_disponible_clientes]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'actualizar_fecha_desde_fecha_hasta_facturas')
DROP PROCEDURE [LOS_GDDS].[actualizar_fecha_desde_fecha_hasta_facturas]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'generar_tipos_tarjeta')
DROP PROCEDURE [LOS_GDDS].[generar_tipos_tarjeta]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'generar_tarjetas_clientes')
DROP PROCEDURE  [LOS_GDDS].[generar_tarjetas_clientes]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'crear_usuarios_para_clientes_con_tarjeta')
DROP PROCEDURE  [LOS_GDDS].[crear_usuarios_para_clientes_con_tarjeta]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'cargar_roles')
DROP PROCEDURE  [LOS_GDDS].[cargar_roles]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'asociar_facturas_compras')
DROP PROCEDURE  [LOS_GDDS].[asociar_facturas_compras]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'cargar_funcionalidades_de_rol')
DROP PROCEDURE  [LOS_GDDS].[cargar_funcionalidades_de_rol]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'cargar_funcionalidades_disponibles_rol')
DROP PROCEDURE  [LOS_GDDS].[cargar_funcionalidades_disponibles_rol]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insertar_funcionalidad_rol')
DROP PROCEDURE  [LOS_GDDS].[insertar_funcionalidad_rol]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insertar_nuevo_rol')
DROP PROCEDURE  [LOS_GDDS].[insertar_nuevo_rol]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sacar_funcionalidades_a_rol')
DROP PROCEDURE  [LOS_GDDS].[sacar_funcionalidades_a_rol]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'existe_usuario')
DROP PROCEDURE  [LOS_GDDS].[existe_usuario]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insertar_nuevo_cliente')
DROP PROCEDURE  [LOS_GDDS].[insertar_nuevo_cliente]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insertar_nuevo_proveedor')
DROP PROCEDURE  [LOS_GDDS].[insertar_nuevo_proveedor]

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insertar_nuevo_usuario')
DROP PROCEDURE  [LOS_GDDS].insertar_nuevo_usuario

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'aplicar_carga_en_saldo_cliente')
DROP PROCEDURE  [LOS_GDDS].aplicar_carga_en_saldo_cliente

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'modificar_password')
DROP PROCEDURE  [LOS_GDDS].modificar_password

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'cargar_proveedores')
DROP PROCEDURE  [LOS_GDDS].cargar_proveedores

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'insertar_nueva_oferta')
DROP PROCEDURE  [LOS_GDDS].insertar_nueva_oferta

IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'LOS_GDDS')
BEGIN
DROP SCHEMA [LOS_GDDS]
END