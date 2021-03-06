USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Conf_Grupo]    Script Date: 02/12/2016 12:28:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[_Conf_Grupo]
            @Grupc_iCodigo    bigint=Null output,
            @Grupc_vNombre    varchar(20)=Null,
            @Grupc_vDescripcion    varchar(50)=Null,
            @Grupc_bActivo    bit=Null,
			@registro_fecha_add datetime = null,
			@registro_user_add varchar(40) = null,
			@registro_pc_add varchar(40) = null,
			@registro_fecha_update datetime = null,
			@registro_user_update varchar(40) = null,
			@registro_pc_update varchar(40) = null,
			@TipoConsulta tinyint
AS 
--===========================================================================================
--==========PROCEDIMIENTO grupoUpdate ========================
--===========================================================================================
--===========================================================================================
	if @TipoConsulta=1 
	Begin
				 UPDATE dbo.[grupo]SET 
							[gru_nombre]=@Grupc_vNombre,
							[gru_descripcion]=@Grupc_vDescripcion,
							[gru_activo]=@Grupc_bActivo,
							[registro_fecha_update] = GETDATE(),
							[registro_user_update] = @registro_user_update,
							[registro_pc_update] = HOST_NAME()
				 WHERE  grupo_id = @Grupc_iCodigo
	End

--===========================================================================================
--==========PROCEDIMIENTO grupoGetByAll ========================
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta=2
	begin
		SELECT * FROM grupo WHERE gru_activo=1
		ORDER BY gru_nombre
	End

--===========================================================================================
--==========PROCEDIMIENTO grupoGetByPrimaryKey ===============
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta=3
	begin
		SELECT * FROM grupo
		WHERE  grupo_id = @Grupc_iCodigo and gru_activo=1
		ORDER BY gru_nombre
	End

--===========================================================================================
--==========PROCEDIMIENTO grupoInsert ========================
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta=4
	Begin
             INSERT INTO [dbo].[grupo]
             (
                          [gru_nombre],
                          [gru_descripcion],
                          [gru_activo],
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @Grupc_vNombre,
                          @Grupc_vDescripcion,
                          1,
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
             SET @Grupc_iCodigo= @@IDENTITY
	End

--===========================================================================================
--==========PROCEDIMIENTO grupoDelete ========================
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta=5
	begin
	UPDATE dbo.[grupo]SET 
			[gru_activo] = 0
	WHERE  grupo_id = @Grupc_iCodigo
	end

--===========================================================================================
	else if @TipoConsulta=6
	begin
		SELECT * FROM grupo
		WHERE gru_nombre LIKE @Grupc_vNombre+ '%' --AND gru_activo=1
		ORDER BY gru_nombre
	end

--===========================================================================================
--==========PROCEDIMIENTO grupoDelete ========================
--===========================================================================================
--===========================================================================================
	else
		IF @TipoConsulta=7
		BEGIN
		DELETE FROM grupo
	end
--===========================================================================================
--==========PROCEDIMIENTO ConfMultitablaeXISTEaGREGAR ========================
--===========================================================================================
--===========================================================================================
	ELSE IF  @TipoConsulta=8
			SELECT COUNT(*)AS TOTAL FROM grupo WHERE  gru_nombre=@Grupc_vNombre 
	
--===========================================================================================
--==========PROCEDIMIENTO ConfMultitablaeXISTEeditar ========================
--===========================================================================================
--===========================================================================================    
	ELSE IF  @TipoConsulta=9
		SELECT COUNT(*)AS TOTAL FROM grupo WHERE  gru_nombre=@Grupc_vNombre and grupo_id!=@Grupc_iCodigo 
		--select*from grupo

	ELSE IF @TipoConsulta=10--listado para combo
		BEGIN
			SELECT grupo_id as codigo, gru_nombre as descripcion, SUBSTRING(gru_nombre,1,1)as orden FROM grupo 
			WHERE gru_activo = 1
			UNION SELECT 0, 'Todos','!'
			ORDER BY orden
		END

	--===========================================================================================
--==========PROCEDIMIENTO listarGruposActivosInactivos ========================
--===========================================================================================
--===========================================================================================
	ELSE IF @TipoConsulta=11
	BEGIN
		SELECT * FROM grupo --WHERE gru_activo=1
		ORDER BY gru_nombre
	END