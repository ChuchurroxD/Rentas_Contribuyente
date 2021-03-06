USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_trib_formato_valores]    Script Date: 02/12/2016 12:03:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--===========================================================================================
--==========PROCEDIMIENTO formato_valoresUpdate ========================
--===========================================================================================
--===========================================================================================
ALTER PROCEDURE [dbo].[_trib_formato_valores]
            @formato_valores_ID    int=Null output,
            @descripcion    varchar(150)=Null,
            @mot_determ    varchar(5000)=Null,
            @mensaje    varchar(5000)=Null,
            @base_legal    varchar(5000)=Null,
            @pie_pag    varchar(3000)=Null,
            @anio    int=Null,
            @tipodoc    tinyint=Null,
			@estado bit=null,
			@registro_fecha_add datetime = null,
			@registro_user_add varchar(40) = null,
			@registro_pc_add varchar(40) = null,
			@registro_fecha_update datetime = null,
			@registro_user_update varchar(40) = null,
			@registro_pc_update varchar(40) = null,
			@TipoConsulta tinyint
AS 
if @TipoConsulta=1 
Begin
             UPDATE dbo.[formato_valores]SET 
                          [descripcion]=@descripcion,
                          [mot_determ]=@mot_determ,
                          [mensaje]=@mensaje,
                          [base_legal]=@base_legal,
                          [pie_pag]=@pie_pag,
                          [anio]=@anio,
                          [tipodoc]=@tipodoc,
						  activo=@estado,
						  [registro_fecha_update] = GETDATE(),
						  [registro_user_update] = @registro_user_update,
						  [registro_pc_update] = HOST_NAME()
             WHERE  formato_valores_ID = @formato_valores_ID

End

--===========================================================================================
--==========PROCEDIMIENTO formato_valoresGetByAll ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=2
begin
SELECT fv.*,t.descripcion as tipodocdesc FROM formato_valores fv
inner join tablas t
on fv.tipodoc=t.valor 
where t.dep_id=38

End

--===========================================================================================
--==========PROCEDIMIENTO formato_valoresGetByPrimaryKey ===============
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=3
begin
SELECT fv.*,t.descripcion as tipodocdesc FROM formato_valores fv
inner join tablas t
on fv.tipodoc=t.valor 
where t.dep_id=38 and formato_valores_ID = @formato_valores_ID
End

--===========================================================================================
--==========PROCEDIMIENTO formato_valoresInsert ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=4
Begin
             INSERT INTO [dbo].[formato_valores]
             (
                          [descripcion],
                          [mot_determ],
                          [mensaje],
                          [base_legal],
                          [pie_pag],
                          [anio],
                          [tipodoc],
						  activo,
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @descripcion,
                          @mot_determ,
                          @mensaje,
                          @base_legal,
                          @pie_pag,
                          @anio,
                          @tipodoc,
						  @estado,						  
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
End

--===========================================================================================
--==========PROCEDIMIENTO formato_valoresDelete ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=5
begin
Delete from formato_valores
WHERE  formato_valores_ID = @formato_valores_ID
end

--===========================================================================================
else if @TipoConsulta=6
begin
Select * from formato_valores
where descripcion Like @descripcion+ '%'
end

--===========================================================================================
--==========PROCEDIMIENTO mostarMensajes ========================
--===========================================================================================
--===========================================================================================
ELSE IF @TipoConsulta = 7
BEGIN
	select *, '' AS tipodocDesc from formato_valores where tipodoc = @tipodoc and anio = @anio
END


--===========================================================================================
--==========PROCEDIMIENTO formato_valoresDelete ========================
--===========================================================================================
--===========================================================================================
else
begin
Delete from formato_valores
end