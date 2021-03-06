USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_SeguUsuario]    Script Date: 01/12/2016 22:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[_SeguUsuario] 
	 @per_codigo		char(9) = null,
	 @seguc_iCodigo int = null,
	 @nombre varchar(50) = null,
	 @apellido varchar(50) = null,
	 @areas_codarea varchar(4) = null,
	 @estado bit = null,
	 @fecha_creacion datetime = null,
	 @per_login varchar(20) = null,
	 @per_pass nvarchar(300) = null,
	 @per_last varchar(32) = null,
	 @per_session varchar(32) = null,
	 @fecha_cese datetime = null,
	 @rol_id bigint = null,
	 @rol_nombre varchar(50) = null,
	 @tipoConsulta        tinyint
AS
	SET NOCOUNT ON
--===========================================================================================
--==========PROCEDIMIENTO formato_camposUpdate ========================
--===========================================================================================
--===========================================================================================
	IF @tipoConsulta = 1  --Update usuario
	BEGIN
			UPDATE dbo.[usuario] SET 
                          areas_codarea = @areas_codarea,
						  estado = @estado,
						  fecha_creacion = @fecha_creacion,
						  per_login = @per_login,
						  --per_pass = ENCRYPTBYPASSPHRASE('SGR_MOCHE', @per_pass),
						  per_last = @per_last,
						  per_session = @per_session,
						  fecha_cese = @fecha_cese,
						  nombre = @nombre,
						  apellido = @apellido
             WHERE  per_codigo = @per_codigo	
	END

	ELSE IF	@tipoConsulta = 2  --Insert usuario
	BEGIN
		SET @per_codigo = (SELECT TOP 1 CONVERT(int,per_codigo) + 1 FROM usuario order by per_codigo desc)
		INSERT INTO [dbo].[usuario]
             (
						  [per_codigo],
						  [areas_codarea],
						  [estado],
						  [fecha_creacion],
						  [per_login],
						  [per_pass],
						  [per_last],
						  [per_session],
						  [fecha_cese],
						  [nombre],
						  [apellido]
             )
             VALUES
             (
                          @per_codigo,
                          @areas_codarea,
                          @estado,
						  GETDATE(),
                          @per_login,
						  ENCRYPTBYPASSPHRASE('SGR_MOCHE', @per_pass),
						  @per_last,
						  @per_session,
						  @fecha_cese,
						  @nombre,
						  @apellido
             )
	END

	ELSE IF @tipoConsulta = 3  --listar todos los usuarios
	BEGIN
		SELECT 
			per_codigo,
			areas_codarea,
			estado,
			fecha_creacion,
			per_login,
			fecha_cese,
			nombre, 
			apellido
		FROM usuario
	END

	ELSE IF @tipoConsulta = 4 -- listar usuarios solo activos
	BEGIN
		SELECT 
			per_codigo,
			areas_codarea,
			estado,
			fecha_creacion,
			per_login,
			fecha_cese,
			nombre, 
			apellido
		FROM usuario where estado = '1'
	END

	ELSE IF @tipoConsulta = 5 --
	BEGIN
		select * from roles
	END

	ELSE IF @TipoConsulta = 6
	BEGIN
		SELECT COUNT(*)AS TOTAL FROM usuario WHERE per_login = @per_login
	END

	ELSE IF @TipoConsulta = 7
	BEGIN
		SELECT COUNT(*) AS TOTAL FROM usuario WHERE per_login = @per_login and per_codigo != @per_codigo
	END

	ELSE IF @TipoConsulta = 8  -- Insertar rol_usuario
	BEGIN		
		DECLARE @urol_id bigint
		SET @urol_id = (SELECT TOP 1 urol_id + 1 FROM roles_usuario order by urol_id desc)
		SET @per_codigo = (SELECT per_codigo FROM usuario WHERE per_login = @per_login)
		SET @rol_id = (SELECT rol_id FROM roles WHERE rol_nombre = @rol_nombre)
		insert into roles_usuario values(@urol_id, @per_codigo, @rol_id, 1)
	END			 

	ELSE IF @tipoConsulta = 9 --DELETE A ROL_USUARIO PARA LUEGO AGREGAR
	BEGIN
		DELETE roles_usuario WHERE per_codigo = @per_codigo
	END

	ELSE IF @tipoConsulta = 10
	BEGIN
		SELECT R.rol_id, R.rol_nombre, R.rol_descripcion, R.rol_activo FROM USUARIO U
		INNER JOIN ROLES_USUARIO RU ON RU.per_codigo = U.per_codigo
		INNER JOIN ROLES R ON R.rol_id = RU.rol_id
		WHERE U.PER_CODIGO = @per_codigo		 
	END
	ELSE IF @tipoConsulta = 11
	BEGIN
		SELECT
			per_codigo,
			areas_codarea,
			estado,
			fecha_creacion,
			per_login,
			fecha_cese,
			nombre, 
			apellido 
		FROM usuario
		WHERE per_login LIKE @per_login + '%' OR nombre LIKE @nombre + '%' OR apellido LIKE @apellido + '%'
	END
	ELSE	IF @tipoConsulta = 12  --Update usuario
	BEGIN
			UPDATE dbo.[usuario] SET 
						  per_login = @per_login,
						  per_pass = ENCRYPTBYPASSPHRASE('SGR_MOCHE', @per_pass),
						  nombre = @nombre,
						  apellido = @apellido
             WHERE  per_codigo = @per_codigo	
	END
	ELSE IF @tipoConsulta = 13  --listar usuario para datos personales
	BEGIN
		SELECT TOP 1 
			per_codigo, 
			apellido, 
			nombre, 
			CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', per_pass), 0) as per_pass, 
			per_login
		FROM usuario 
		WHERE PER_LOGIN =@per_login
	END
	ELSE IF @tipoConsulta = 14
	BEGIN
		SELECT @per_codigo=per_codigo 
		FROM usuario 
		WHERE per_login = @per_login and CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', per_pass), 0) = @per_pass

		if(SELECT COUNT(*) FROM roles_usuario WHERE per_codigo=@per_codigo and rol_id=1)=0
			SELECT 0;
		ELSE 
			SELECT 1;
	END	
	ELSE IF @tipoConsulta = 15
	BEGIN
		SELECT per_codigo, (nombre + ' ' + apellido) AS nombre 
		FROM [dbo].[usuario] 
		WHERE per_login = @per_login AND CONVERT(nvarchar(300), DECRYPTBYPASSPHRASE('SGR_MOCHE', per_pass), 0) = @per_pass
	END
