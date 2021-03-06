USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Conf_tarea]    Script Date: 02/12/2016 12:47:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[_Conf_tarea]
            @Tarec_iCodigo    bigint=Null output,
            @grupo_id    bigint=Null,
            @Tarec_vNombre    varchar(30)=Null,
            @Tarec_vDescripcion    varchar(70)=Null,
            @Tarec_vUrl    varchar(150)=Null,
			@registro_fecha_add datetime = null,
			@registro_user_add varchar(40) = null,
			@registro_pc_add varchar(40) = null,
			@registro_fecha_update datetime = null,
			@registro_user_update varchar(40) = null,
			@registro_pc_update varchar(40) = null,
            @Tarec_bActivo    bit=Null,
			@TipoConsulta tinyint
AS 
--===========================================================================================
--==========PROCEDIMIENTO tareaUpdate ==========================
--===========================================================================================
--===========================================================================================
	if @TipoConsulta = 1 
	Begin
				 UPDATE dbo.[tarea] SET 
							  [grupo_id]=@grupo_id,
							  [tar_nombre]=@Tarec_vNombre,
							  [tar_descripcion]=@Tarec_vDescripcion,
							  [tar_url]=@Tarec_vUrl,
							  [tar_activo]=@Tarec_bActivo,
							  [registro_fecha_update] = GETDATE(),
							  [registro_user_update] = @registro_user_update,
							  [registro_pc_update] = HOST_NAME()
				 WHERE  tarea_id = @Tarec_iCodigo
	End

--===========================================================================================
--==========PROCEDIMIENTO tareaGetByAll ========================
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta = 2
	begin
		if @grupo_id = 0 --Si el grupo es 0, muestra todos las tareas.
		begin
			SELECT * FROM tarea WHERE tar_activo = 1
			ORDER BY tar_nombre ASC
		end
		else --Sino muestra las tareas de un determinado grupo.
		begin
			SELECT * FROM tarea WHERE grupo_id = @grupo_id AND tar_activo=1
			ORDER BY tar_nombre ASC
		end	
	End

--===========================================================================================
--==========PROCEDIMIENTO tareaGetByPrimaryKey ===============
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta=3
	begin
		SELECT * FROM tarea
		WHERE  tarea_id = @Tarec_iCodigo
		ORDER BY tar_nombre ASC
	End

--===========================================================================================
--==========PROCEDIMIENTO tareaInsert ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=4
Begin
             INSERT INTO [dbo].[tarea]
             (
                          [grupo_id],
                          [tar_nombre],
                          [tar_descripcion],
                          [tar_url],
                          [tar_activo],
						  [tar_padre],
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @grupo_id,
                          @Tarec_vNombre,
                          @Tarec_vDescripcion,
                          @Tarec_vUrl,
                          1,
						  0,
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
             SET @Tarec_iCodigo= @@IDENTITY
End

--===========================================================================================
--==========PROCEDIMIENTO tareaDeleteByPrimaryKey ========================
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta=5
	begin
		UPDATE dbo.[tarea]SET     [tar_activo]=0
		WHERE  tarea_id = @Tarec_iCodigo
	end

--===========================================================================================
	else if @TipoConsulta=6
	begin
		SELECT * FROM tarea
		WHERE grupo_id LIKE @grupo_id+ '%'
		ORDER BY tar_nombre ASC
	end

--===========================================================================================
--==========PROCEDIMIENTO tareaGetgrupo_id ===============
--===========================================================================================
--===========================================================================================
	else if @TipoConsulta=7
	Begin
		SELECT * FROM tarea
		WHERE grupo_id = @grupo_id
		ORDER BY tar_nombre ASC
	end

--===========================================================================================
--===========================================================================================
--==========PROCEDIMIENTO tareaDelete ========================
--===========================================================================================
--===========================================================================================
	else
		--begin
		--Delete from tarea
		--end
--===========================================================================================
--==========PROCEDIMIENTO ConfMultitablaeXISTEaGREGAR ========================
--===========================================================================================
--===========================================================================================

	IF  @TipoConsulta=8
			SELECT COUNT(*)AS TOTAL FROM tarea WHERE  tar_nombre = @Tarec_vNombre 
	
--===========================================================================================
--==========PROCEDIMIENTO ConfMultitablaeXISTEeditar ========================
--===========================================================================================
--===========================================================================================    
	ELSE IF  @TipoConsulta=9
		SELECT COUNT(*)AS TOTAL FROM tarea WHERE  tar_nombre = @Tarec_vNombre and tarea_id != @Tarec_iCodigo 
		--select*from grupo

--===========================================================================================
--==========PROCEDIMIENTO buscarTareaByGroup ========================================
--===========================================================================================
--=========================================================================================== 
	ELSE IF  @TipoConsulta=10 -- Para buscar tareas de un determinado grupo
	begin
		if @grupo_id = 0
		begin
			SELECT * FROM tarea
			WHERE (tar_nombre like @Tarec_vNombre + '%'  or tar_descripcion like @Tarec_vDescripcion + '%') and tar_activo = 1
			ORDER BY Tar_nombre ASC
		end
		else
		begin
			SELECT * FROM tarea
			WHERE (tar_nombre like @Tarec_vNombre + '%'  or tar_descripcion like @Tarec_vDescripcion + '%')  and grupo_id = @grupo_id and tar_activo = 1
			ORDER BY Tar_nombre ASC
		end		
	end
--===========================================================================================
--==========PROCEDIMIENTO PARA MOSTRAR TODAS LAS TAREAS ACTIVAS E INNACTIVAS=================
--===========================================================================================
--===========================================================================================
	ELSE IF @TipoConsulta = 11
	BEGIN
		IF @grupo_id = 0 --Si el grupo es 0, muestra todos las tareas.
		BEGIN
			SELECT * FROM tarea --WHERE tar_activo = 1
			ORDER BY tar_nombre ASC
		END
		ELSE --Sino muestra las tareas de un determinado grupo.
		BEGIN
			SELECT * FROM tarea WHERE grupo_id = @grupo_id --AND tar_activo=1
			ORDER BY tar_nombre ASC
		END	
	END