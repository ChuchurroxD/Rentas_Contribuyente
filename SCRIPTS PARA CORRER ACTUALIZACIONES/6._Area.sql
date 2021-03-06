USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Orga_Area]    Script Date: 02/12/2016 9:31:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[_Orga_Area]
            @Are_Codigo    varchar(4)=Null,
            @Are_Descripcion    varchar(100)=Null,
            @Are_proy    varchar(4)=Null,
            @Are_dep    int=Null,
            @tipo_area    char(3)=Null,
            @cod_anterior    varchar(4)=Null,
            @activo    bit=Null,
			@registro_fecha_add datetime = null,
			@registro_user_add varchar(40) = null,
			@registro_pc_add varchar(40) = null,
			@registro_fecha_update datetime = null,
			@registro_user_update varchar(40) = null,
			@registro_pc_update varchar(40) = null

,@TipoConsulta tinyint
,@cod varchar(4)=null
AS 
DECLARE @CANTIDAD INT
if @TipoConsulta=1 
Begin
			UPDATE dbo.[Area]SET 
                          [Are_Descripcion] = @Are_Descripcion,
                          [Are_proy] = @Are_proy,
                          [Are_dep] = @Are_dep,
                          [tipo_area] = @tipo_area,
                          [cod_anterior] = @cod_anterior,
                          [activo] = @activo,
						  [registro_fecha_update] = GETDATE(),
						  [registro_user_update] = @registro_user_update,
						  [registro_pc_update] = HOST_NAME()
			WHERE Are_Codigo=@cod

End

--===========================================================================================
--==========PROCEDIMIENTO AreaGetByAll ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=2
begin
Select * from Area
End

--===========================================================================================
--==========PROCEDIMIENTO AreaGetByPrimaryKey ===============
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=3
begin
Select * from Area where Are_Codigo=@Are_Codigo
End

--===========================================================================================
--==========PROCEDIMIENTO AreaInsert ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=4
Begin
             INSERT INTO [dbo].[Area]
             (
                          [Are_Codigo],
                          [Are_Descripcion],
                          [Are_proy],
                          [Are_dep],
                          [tipo_area],
                          [cod_anterior],
                          [activo],
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @Are_Codigo,
                          @Are_Descripcion,
                          @Are_proy,
                          @Are_dep,
                          @tipo_area,
                          @cod_anterior,
                          @activo,
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
             
End

--===========================================================================================
--==========PROCEDIMIENTO AreaDelete ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=5
begin
Delete from Area
end

--===========================================================================================
else if @TipoConsulta=6
begin
Select * from Area
where Are_Descripcion Like @Are_Descripcion+ '%'
end

--===========================================================================================
--==========PROCEDIMIENTO AreaDelete ========================
--===========================================================================================
--===========================================================================================
else
if @TipoConsulta=7
begin
update Area set activo=0 where Are_Codigo=@Are_Codigo
end
else if @TipoConsulta=8
begin
	IF LEN(@Are_Codigo)=0
		BEGIN
		SET @CANTIDAD=2
		END
		IF LEN(@Are_Codigo)=2
		BEGIN
		SET @CANTIDAD=4
		END
		
		SELECT * FROM Area
		WHERE Are_Codigo LIKE @Are_Codigo+'%' AND LEN(Are_Codigo)=@CANTIDAD 
		order by Are_Descripcion
	
end
else if @TipoConsulta=9
	begin
		select count(*)as TOTAL from Area
		where Are_Descripcion=@Are_Descripcion and activo=1
	end
	else if @TipoConsulta=10
	begin
		select count(*)as TOTAL from Area
		where Are_Codigo=@Are_Codigo and activo=1
	end
	else if @TipoConsulta=11
	begin
		select a.Are_Codigo,a.Are_Descripcion,SUBSTRING(Are_Codigo,1,2)as dep_cod,
		(select ar.Are_Descripcion from Area ar where ar.Are_Codigo=SUBSTRING(a.Are_Codigo,1,2))as desc_cod 
		from Area a where len(a.Are_Codigo)=4
	end
	ELSE IF @TipoConsulta = 12
	BEGIN
		SELECT * FROM Area WHERE activo = 1 ORDER BY Are_Descripcion ASC
	END

