USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[sp_logeo]    Script Date: 22/11/2016 09:36:45 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--===========================================================================================
--==========PROCEDIMIENTO rolesUpdate ========================
--===========================================================================================
--===========================================================================================
alter PROCEDURE [dbo].[sp_logeo]             
             @Usuario    varchar(50)=Null,
			 @Password    varchar(50)=Null,			 
			 @Codigo    varchar(50)=Null,
			 @Persona    varchar(50)=Null,
			 @Grupo    varchar(50)=Null,
			 @Opcion varchar(200)
AS 
if @Opcion='opc_login_respuesta' 
Begin
    DECLARE @RESTRINGIDO int
	DECLARE @CORRECTO int
	set @RESTRINGIDO = (SELECT COUNT(*) FROM usuario usu 
									WHERE usu.per_login = @Usuario AND 
										  CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', usu.per_pass), 0)= @Password AND
										  --usu.per_pass=@Password AND 
										  usu.estado=0)
		
		IF (@RESTRINGIDO) > 0 
			SELECT 'Usuario Restringido' AS 'respuesta'
		ELSE
			SET @CORRECTO = (SELECT COUNT(*) FROM usuario usu 
									WHERE usu.per_login = @Usuario AND 
											CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', usu.per_pass), 0) = @Password AND
											--usu.per_pass=@Password AND
											usu.estado=1)
			
			IF (@CORRECTO) > 0 
				SELECT '1' AS 'respuesta'
			ELSE
				SELECT 'Usuario o clave incorrectos' AS 'respuesta'

End
IF @Opcion='opc_login_listar'
BEGIN	
	SELECT 
		usu.per_login AS usuUsuario,
		usu.per_codigo AS usuId,
		CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', usu.per_pass), 0) AS usuPass,
		--usu.per_pass AS usuPass,
		usu.per_codContributente AS usuContribuyente			
	FROM usuario usu
	WHERE 
		usu.per_login = @Usuario AND
		CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', per_pass), 0) = @Password AND
		--usu.per_pass = @Password AND
		usu.estado=1;
END
IF @Opcion='opc_mostrargrupos'
BEGIN
	select distinct(g.Gru_nombre), g.grupo_id, g.gru_icono from roles_usuario ru 
    inner join rol_tarea pe on pe.rol_id = ru.rol_id
    inner join tarea t on t.tarea_id = pe.tarea_id
    inner join grupo g on g.grupo_id = t.grupo_id
    where ru.per_codigo = @persona 
        and t.tar_activo=1 and g.gru_activo = 1;
END
IF @Opcion='opc_mostrartareas'
BEGIN
	 select t.tar_nombre, t.tar_url from roles_usuario ru 
      inner join rol_tarea pe on pe.rol_id = ru.rol_id
      inner join tarea t on t.tarea_id = pe.tarea_id
      inner join grupo g on g.grupo_id = t.grupo_id
    where ru.per_codigo = @Persona and g.grupo_id = @Grupo
        and t.tar_activo=1 and g.gru_activo = 1;  
END
IF @Opcion='opc_update_contraseña'
BEGIN
	 UPDATE usuario SET per_login = @Usuario, per_pass = ENCRYPTBYPASSPHRASE('SGR_MOCHE', @Password)  WHERE per_codigo = @Codigo;	 
END



--SELECT * FROM usuario 

--exec sp_logeo @opcion='opc_update_contraseña',@Usuario='chuchurro',@Password='12345',@Codigo='287392   '




--SELECT * FROM usuario


--exec sp_logeo @opcion='opc_login_respuesta',@Usuario='admin' @Password='12345'