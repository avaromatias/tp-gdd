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
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Modificar password'))

INSERT INTO [LOS_GDDS].[funcionalidades_rol]
           ([id_rol]
           ,[id_funcionalidad])
     VALUES
           ((SELECT [id_rol] FROM [LOS_GDDS].[roles] WHERE [nombre] = 'Administrador')
           ,(SELECT [id_funcionalidad] FROM [LOS_GDDS].[funcionalidades] WHERE [nombre] = 'Baja de usuario'))