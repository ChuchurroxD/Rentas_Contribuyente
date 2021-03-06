USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_trib_Formato_Campos]    Script Date: 02/12/2016 11:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[_trib_Formato_Campos] 
	@formatoCampos_ID    int=Null output,
    @tipoFormato_ID	  char(3)=Null,
    @anio				  int=Null,
    @columna1			  varchar(50)=Null,
    @columna2			  varchar(50)=Null,
	@columna3		      varchar(50)=Null,
	@columna4		      varchar(50)=Null,
	@busqueda			  varchar(50)= null,	
	@registro_fecha_add datetime = null,
	@registro_user_add varchar(40) = null,
	@registro_pc_add varchar(40) = null,
	@registro_fecha_update datetime = null,
	@registro_user_update varchar(40) = null,
	@registro_pc_update varchar(40) = null,
	@tipoConsulta        tinyint
AS
	SET NOCOUNT ON
--===========================================================================================
--==========PROCEDIMIENTO formato_camposUpdate ========================
--===========================================================================================
--===========================================================================================
	IF @tipoConsulta = 1 
	BEGIN
			UPDATE dbo.[FormatoCampos] SET 
                          tipoFormato_id = @tipoFormato_ID,
						  anio = @anio,
						  columna1 = @columna1,
						  columna2 = @columna2,
						  columna3 = @columna3,
						  columna4 = @columna4,
						  [registro_fecha_update] = GETDATE(),
						  [registro_user_update] = @registro_user_update,
						  [registro_pc_update] = HOST_NAME()
             WHERE  FormatoCampos_id = @formatoCampos_ID	
	END
	ELSE IF	@tipoConsulta = 2
	BEGIN
		INSERT INTO [dbo].[FormatoCampos]
             (
                          [tipoFormato_id],
                          [anio],
                          [columna1],
                          [columna2],
                          [columna3],
                          [columna4],
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @tipoFormato_ID,
                          @anio,
                          @columna1,
                          @columna2,
                          @columna3,
                          @columna4,
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
	END
	ELSE IF @TipoConsulta = 3
	BEGIN
		SELECT FC.*, T.descripcion FROM FormatoCampos FC
		INNER JOIN tablas T on T.valor = FC.tipoFormato_id
		WHERE T.dep_id = 51 and FC.tipoFormato_id = @tipoFormato_ID and FC.anio = @anio
	END
	ELSE IF @TipoConsulta = 4
	BEGIN
		SELECT FC.*, T.descripcion FROM FormatoCampos FC
		INNER JOIN tablas T on T.valor = FC.tipoFormato_id
		WHERE T.dep_id = 51 and (columna1 like @busqueda + '%' or columna2 like @busqueda + '%' or columna3 like @busqueda + '%'or columna4 like @busqueda + '%') and anio = @anio
		ORDER BY T.descripcion ASC
	END
	ELSE IF @TipoConsulta = 5
	BEGIN
		SELECT FC.*, T.descripcion FROM FormatoCampos FC
		INNER JOIN tablas T on T.valor = FC.tipoFormato_id
		WHERE T.dep_id = 51 and anio = @anio ORDER BY T.descripcion, anio  DESC
	END
	ELSE IF @TipoConsulta = 6
	BEGIN
		SELECT valor, descripcion FROM tablas WHERE dep_id = '51' ORDER BY descripcion ASC
	END
	ELSE IF @TipoConsulta = 7
	BEGIN
		SELECT COUNT(*)AS TOTAL FROM FormatoCampos WHERE tipoFormato_id = @tipoFormato_ID and anio = @anio
	END
	ELSE IF @TipoConsulta = 8
	BEGIN
		SELECT COUNT(*)AS TOTAL FROM FormatoCampos WHERE tipoFormato_id = @tipoFormato_ID and anio = @anio and FormatoCampos_id != @formatoCampos_ID
	END	
