ALTER TABLE grupo ADD gru_icono VARCHAR(50) NULL;
ALTER TABLE grupo ADD gru_orden int NULL;

ALTER TABLE tarea ADD tar_icono VARCHAR(50) NULL;
ALTER TABLE tarea ADD tar_orden int NULL;

ALTER TABLE usuario ADD per_codContributente CHAR(09) NULL;


-------- INSERTAR DOS GRUPOS PARA PLATAFORMA -----------
insert into grupo (gru_nombre, gru_descripcion, gru_activo, gru_icono, gru_orden) values ('Acceso y Seguridad','Acceso y Seguridad a la plataforma web','1','lock_go','1')
insert into grupo (gru_nombre, gru_descripcion, gru_activo, gru_icono, gru_orden) values ('Información General','Información General del contribuyente','1','','2')


---- INSERTAR TAREAS ----
insert into tarea (grupo_id, tar_nombre, tar_descripcion, tar_url, tar_activo, tar_padre, tar_icono, tar_orden) values (12,'Cambiar Password','Cambiar contraseña','',1,0,'user_edit','1')
insert into tarea (grupo_id, tar_nombre, tar_descripcion, tar_url, tar_activo, tar_padre, tar_icono, tar_orden) values (13,'Contribuyentes','Datos del contributente en la plataforma','_user',1,0,'','1')
insert into tarea (grupo_id, tar_nombre, tar_descripcion, tar_url, tar_activo, tar_padre, tar_icono, tar_orden) values (13,'Simula Fraccionamiento','Simulacion del fraccionamiento','',1,0,'application_split','2')


---- INSERTAR ROLES_TAREAS ----
INSERT INTO Rol_Tarea (rol_id, tarea_id, estado) values (14,'40713',1)
INSERT INTO Rol_Tarea (rol_id, tarea_id, estado) values (14,'40714',1)
INSERT INTO Rol_Tarea (rol_id, tarea_id, estado) values (14,'40715',1)



--insert into usuario (per_codigo, areas_codarea, estado, fecha_creacion, per_login, per_pass, nombre, apellido, per_codContributente)
--values (287392,'06', 1, GETDATE(), 'fabio', ENCRYPTBYPASSPHRASE('SGR_MOCHE', CONVERT(NVARCHAR(300), '12345')), 'Fabio', 'Peralta', '1010'  )

--insert into roles_usuario (urol_id, per_codigo, rol_id, activo)
--values (47, 287392, 14, 1)

----update usuario set per_codContributente = '253' where per_codigo = '287392   '

--update roles_usuario set rol_id = 14 where per_codigo = 287392
--update tarea set tar_url = 'module=seguridad&option=cambiar_password' where tarea_id = 40713
--	update tarea set tar_url = 'module=informacion_general&option=contribuyente' where tarea_id = 40714
--	update tarea set tar_url = 'module=informacion_general&option=fraccionamiento' where tarea_id = 40715

--select * from roles_usuario
--select * from usuario
--select * from roles

--exec sp_logeo @opcion='opc_login_respuesta',@Usuario='fabio', @Password='12345'
--exec sp_logeo @opcion='opc_login_respuesta',@Usuario='fabio',@Password='12345'
--exec sp_logeo @opcion='opc_login_listar'
--,@Usuario='fabio',@Password='12345'


--SELECT CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', per_pass), 0) FROM usuario


--SELECT ENCRYPTBYPASSPHRASE('SGR_MOCHE', '12345')
--SELECT CONVERT(nvarchar(300),DECRYPTBYPASSPHRASE('SGR_MOCHE', 0x0100000093CEF5DD19ECC0DF3E0FDA8B420C5E8FF006DB7BEF7AADE9), 0)