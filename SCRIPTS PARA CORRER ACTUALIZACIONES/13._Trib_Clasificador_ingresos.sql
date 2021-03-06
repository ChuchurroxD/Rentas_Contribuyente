USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Trib_Clasificador_ingresos]    Script Date: 02/12/2016 11:03:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--===========================================================================================
--==========PROCEDIMIENTO Clasificador_ingresosUpdate ========================
--===========================================================================================
--===========================================================================================
ALTER PROCEDURE [dbo].[_Trib_Clasificador_ingresos]
            @clai_codigo    varchar(20)=Null,
            @clai_anio    varchar(10)=Null,
            @clai_presupuesto    varchar(50)=Null,
            @clai_contable    varchar(50)=Null,
            @clai_contableant    varchar(50)=Null,
            @clai_descripcion    varchar(150)=Null,
            @clai_estado    bit=Null,
			@periodoPrevio varchar(10)=null,
			@periodoActual varchar(10)=null,
			@TipoConsulta tinyint,
			@anteCodigo varchar(20)=null,
			@registro_fecha_add datetime = null,
			@registro_user_add varchar(40) = null,
			@registro_pc_add varchar(40) = null,
			@registro_fecha_update datetime = null,
			@registro_user_update varchar(40) = null,
			@registro_pc_update varchar(40) = null

AS 
DECLARE @CANTIDAD INT
if @TipoConsulta=1 
Begin
             UPDATE dbo.[Clasificador_ingresos]SET 
							clai_codigo=@clai_codigo,
                          [clai_anio]=@clai_anio,
                          [clai_presupuesto]=@clai_presupuesto,
                          [clai_contable]=@clai_contable,
                          [clai_contableant]=@clai_contableant,
                          [clai_descripcion]=@clai_descripcion,
                          [clai_estado]=@clai_estado,
						  [registro_fecha_update] = GETDATE(),
						  [registro_user_update] = @registro_user_update,
						  [registro_pc_update] = HOST_NAME()
             WHERE  clai_codigo = @anteCodigo And clai_anio = @clai_anio

End

--===========================================================================================
--==========PROCEDIMIENTO Clasificador_ingresosGetByAll ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=2
begin
Select * from Clasificador_ingresos
End

--===========================================================================================
--==========PROCEDIMIENTO Clasificador_ingresosGetByPrimaryKey ===============
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=3
begin
Select * from Clasificador_ingresos
WHERE  clai_codigo = @clai_codigo And clai_anio = @clai_anio
End

--===========================================================================================
--==========PROCEDIMIENTO Clasificador_ingresosInsert ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=4
Begin
             INSERT INTO [dbo].[Clasificador_ingresos]
             (
                          [clai_codigo],
                          [clai_anio],
                          [clai_presupuesto],
                          [clai_contable],
                          [clai_contableant],
                          [clai_descripcion],
                          [clai_estado],
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @clai_codigo,
                          @clai_anio,
                          @clai_presupuesto,
                          @clai_contable,
                          @clai_contableant,
                          @clai_descripcion,
                          @clai_estado,
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
             SET @clai_codigo= @@IDENTITY
End

--===========================================================================================
--==========PROCEDIMIENTO Clasificador_ingresosDelete ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=5
begin
Delete from Clasificador_ingresos
WHERE  clai_codigo = @clai_codigo And clai_anio = @clai_anio
end

--===========================================================================================
else if @TipoConsulta=6
begin
Select * from Clasificador_ingresos
where clai_anio Like @clai_anio+ '%'
end

--===========================================================================================
--==========PROCEDIMIENTO Clasificador_ingresosDelete ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=7
begin
update  Clasificador_ingresos set clai_estado=0
WHERE  clai_codigo = @clai_codigo And clai_anio = @clai_anio
end
else if @TipoConsulta=8
begin 

		IF LEN(@Clai_codigo)=0
		BEGIN
		SET @CANTIDAD=1
		END
		IF LEN(@Clai_codigo)=1
		BEGIN
		SET @CANTIDAD=3
		END
		IF LEN(@Clai_codigo)=3
		BEGIN
		SET @CANTIDAD=5
		END
		IF LEN(@Clai_codigo)=5
		BEGIN
		SET @CANTIDAD=6
		END
		IF LEN(@Clai_codigo)=6
		BEGIN
		SET @CANTIDAD=8
		END
		IF LEN(@Clai_codigo)=8
		BEGIN
		SET @CANTIDAD=10
		END

		SELECT * FROM Clasificador_ingresos
		WHERE clai_codigo LIKE @Clai_codigo+'%' AND LEN(clai_codigo)=@CANTIDAD AND clai_anio=@Clai_anio
	END
	else if @TipoConsulta=9
	begin
		select count(*)as TOTAL from Clasificador_ingresos
		where clai_descripcion=@clai_descripcion and clai_anio=@clai_anio
	end
	else if @TipoConsulta=10
	begin
		select count(*)as TOTAL from Clasificador_ingresos
		where clai_codigo=@clai_codigo and clai_anio=@clai_anio
	end
else if @TipoConsulta = 11
begin
select clai_codigo,(clai_codigo+' '+clai_descripcion)as clai_descripcion from Clasificador_Ingresos c  inner join periodo p on(c.clai_anio = p.año)
where Titulo = 'N'  and p.año = @clai_anio
end
else if @TipoConsulta = 12
begin
	delete Clasificador_Ingresos where clai_anio=@periodoActual
	insert into Clasificador_Ingresos(clai_codigo,clai_anio,clai_presupuesto,clai_contable,clai_contableant,clai_descripcion,clai_estado)
	select clai_codigo,@periodoActual,clai_presupuesto,clai_contable,clai_contableant,clai_descripcion,clai_estado from Clasificador_Ingresos where clai_anio=@periodoPrevio
end

--select * from Tributos