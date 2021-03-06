USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Pred_ValidacionPredioArbitrio]    Script Date: 05/12/2016 10:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--===========================================================================================
--=====================PROCEDIMIENTO _Pred_ValidacionPredioArbitrio==========================
--===========================================================================================

ALTER PROCEDURE [dbo].[_Pred_ValidacionPredioArbitrio]
				@idPeriodo    int=Null
,@TipoConsulta tinyint,
@busqueda varchar(250) = null
AS 
--para Tabla Temporal
declare 
		@junta_via_ID    int=Null,
        @c_num    varchar(30)=Null,
        @c_mz    varchar(5)=Null,
        @c_lote    varchar(10)=Null,
        @c_interior    varchar(5)=Null,
        @c_dpto    varchar(5)=Null,
        @estado    bit=Null,
		@c_edificio  varchar(100)=null,
		@c_piso varchar(100)=null,
		@c_tienda varchar(100)=null

--===========================================================================================
--=====================================CALCULO COSTO=========================================
--===========================================================================================

if @TipoConsulta=1 
Begin
	SELECT sum(va.Costo)FROM PredioArbitrio PA
	INNER JOIN TablaArancel TA ON PA.idTablaArancel=TA.idTablaArancel
	INNER JOIN ValoresArbitrio VA ON VA.idTablaArancel=TA.idTablaArancel 
	WHERE PA.Estado=1  AND Predio_id='0001' AND pa.idPeriodo=@idPeriodo
End

--===========================================================================================
--=====================================TABLA TEMPORAL========================================
--===========================================================================================

else if @TipoConsulta=2
Begin
	CREATE TABLE #TablaTemporal (predio_ID char(16))
	INSERT INTO #TablaTemporal (predio_ID)
	SELECT predio_ID From Predio
	WHERE predio_ID not in (SELECT predio_ID FROM CuentaCorriente WHERE anio = 2016 and tributo_ID='0043')
			   SELECT Pe.NombreCompleto,P.predio_ID,
			   (
			   CASE 
				  WHEN P.direccion_completa IS NULL 
				  THEN dbo._getDireccionFiscal(@junta_via_ID,@c_num,@c_interior,@c_mz,@c_lote,@c_edificio,@c_piso,@c_dpto,@c_tienda,'')
				  WHEN P.direccion_completa = '' 
				  THEN dbo._getDireccionFiscal(@junta_via_ID,@c_num,@c_interior,@c_mz,@c_lote,@c_edificio,@c_piso,@c_dpto,@c_tienda,'')
			   ELSE P.direccion_completa 
			   END
			   ) AS direccion_completa,
			   P.nombre_predio,P.tipo_operacion,TipOp.descripcion as DescripcionTipoOperacion,P.tipo_inmueble,
			   TipInm.descripcion as DescripcionTipoInmueble,P.tipo_predio,TipPre.descripcion as DescripcionTipoPredio,
			   P.estado_predio,EstPre.descripcion as DescripcionEstadoPredio From #TablaTemporal TT
		INNER JOIN Predio P on P.predio_ID = TT.predio_ID
		INNER JOIN PREDio_COntribuyente PC ON P.predio_ID=PC.Predio_id
		INNER JOIN tablas TipOp on P.tipo_operacion = TipOp.valor 
		INNER JOIN tablas TipInm on P.tipo_inmueble = TipInm.valor
		INNER JOIN tablas TipPre on P.tipo_predio = TipPre.valor
		INNER JOIN tablas EstPre on P.estado_predio = EstPre.valor
		INNER JOIN Persona Pe on Pe.persona_ID = PC.persona_ID
		WHERE TipOp.dep_id  = 12  AND
			  TipInm.dep_id = 5   AND
			  TipPre.dep_id = 11  AND
			  EstPre.dep_id = 7   AND
			  P.estado  = 1  AND 
			  PC.estado = 1  AND
			  PC.idPeriodo = @idPeriodo
DROP TABLE #TablaTemporal
End
ELSE IF @TipoConsulta = 3
BEGIN
		CREATE TABLE #TablaTemporal1 (predio_ID char(16))

		INSERT INTO #TablaTemporal1 (predio_ID)
		SELECT predio_ID From Predio
		WHERE predio_ID not in (SELECT predio_ID FROM CuentaCorriente WHERE anio = 2016 and tributo_ID='0043')

		SELECT Pe.NombreCompleto,P.predio_ID,
			   (
			   CASE 
				  WHEN P.direccion_completa IS NULL 
				  THEN dbo._getDireccionFiscal(@junta_via_ID,@c_num,@c_interior,@c_mz,@c_lote,@c_edificio,@c_piso,@c_dpto,@c_tienda,'')
				  WHEN P.direccion_completa = '' 
				  THEN dbo._getDireccionFiscal(@junta_via_ID,@c_num,@c_interior,@c_mz,@c_lote,@c_edificio,@c_piso,@c_dpto,@c_tienda,'')
			   ELSE P.direccion_completa 
			   END
			   ) AS direccion_completa,
			   P.nombre_predio,P.tipo_operacion,TipOp.descripcion as DescripcionTipoOperacion,P.tipo_inmueble,
			   TipInm.descripcion as DescripcionTipoInmueble,P.tipo_predio,TipPre.descripcion as DescripcionTipoPredio,
			   P.estado_predio,EstPre.descripcion as DescripcionEstadoPredio 
		FROM #TablaTemporal1 TT
		INNER JOIN Predio P on P.predio_ID = TT.predio_ID
		INNER JOIN PREDio_COntribuyente PC ON P.predio_ID=PC.Predio_id
		INNER JOIN tablas TipOp on P.tipo_operacion = TipOp.valor 
		INNER JOIN tablas TipInm on P.tipo_inmueble = TipInm.valor
		INNER JOIN tablas TipPre on P.tipo_predio = TipPre.valor
		INNER JOIN tablas EstPre on P.estado_predio = EstPre.valor
		INNER JOIN Persona Pe on Pe.persona_ID = PC.persona_ID
		WHERE TipOp.dep_id  = 12  AND
			  TipInm.dep_id = 5   AND
			  TipPre.dep_id = 11  AND
			  EstPre.dep_id = 7   AND
			  P.estado  = 1  AND 
			  PC.estado = 1  AND
			  PC.idPeriodo = @idPeriodo AND
			  PE.NombreCompleto LIKE @busqueda + '%'
		DROP TABLE #TablaTemporal1
END

