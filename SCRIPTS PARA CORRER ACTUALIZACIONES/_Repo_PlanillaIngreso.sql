USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Repo_PlanillaIngreso]    Script Date: 17/01/2017 06:18:45 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[_Repo_PlanillaIngreso]
			@FechaPago    datetime=Null,
			@clai_codigo varchar(20)=null,
			@Fuente char(2)=null,
			@Recurso char(2)=null,
			@Pagante varchar(200)=null,
			@nroRecibo int=null,
			@monto_pago decimal(10,2)=null,
			@oficina_id int=Null,
			@FechaDesde datetime=Null,
			@FechaHasta datetime=Null,
			@tributo varchar(20)=Null

,@TipoConsulta tinyint
AS
BEGIN
--============================================================================================
--================================= Listar Por Oficina =======================================
--============================================================================================
	IF @TipoConsulta=1 
	BEGIN

	select * from Pagos
		SELECT P.FechaPago,CAST(CODIGO_VOUCHER AS INT)AS nro_Recibo,P.Pagante,PDT.monto_pago,CI.clai_codigo,CI.Fuente,CI.Recurso 
		FROM Pagos P 
			INNER JOIN pago_detalle_tributo PDT ON P.clasificador = PDT.clai_codigo
			INNER JOIN Clasificador_Ingresos CI ON CI.clai_codigo = PDT.clai_codigo
			INNER JOIN CajeroCaja CC ON CC.CajeroCaja_id = P.CajeroCaja_id
			INNER JOIN Caja as C on C.Caja_id = CC.Caja_id
			INNER JOIN Oficina as O on O.oficina_id = C.idOficina
		WHERE (O.oficina_id = @oficina_id OR @oficina_id = -1)
	END
	
--============================================================================================
--=========================== Listar Por Oficina y Rango de Fechas ===========================
--============================================================================================
	IF @TipoConsulta=2
	BEGIN
		SELECT P.FechaPago,CAST(P.CODIGO_VOUCHER AS INT)as  nro_Recibo,rtrim(P.Pagante)as Pagante,PDT.monto_pago,CI.clai_codigo,CI.Fuente,CI.Recurso
		FROM Pagos P 
			INNER JOIN pago_detalle_tributo PDT ON P.Pagos_id = PDT.pagos_ID
			INNER JOIN Clasificador_Ingresos CI ON CI.clai_codigo = PDT.clai_codigo
			INNER JOIN CajeroCaja CC ON CC.CajeroCaja_id = P.CajeroCaja_id
			INNER JOIN Caja as C on C.Caja_id = CC.Caja_id
			INNER JOIN Oficina as O on O.oficina_id = C.idOficina
		WHERE P.FechaPago BETWEEN @FechaDesde and dateadd(dd,1,@FechaHasta )
		 AND (O.oficina_id = @oficina_id OR @oficina_id = -1) 
		ORDER BY P.FechaPago asc
	END
--============================================================================================
--=============================== RESUMEN PLANILLA DE INGRESOS ===============================
--============================================================================================
--============================================================================================
--====================================== Listar Devolucion ===================================
--============================================================================================
	IF @TipoConsulta=3
	BEGIN
		SELECT cast(P.FechaPago as date)as FechaPago,CI.Fuente,rtrim(CI.clai_codigo)as clai_codigo,
		CI.clai_descripcion,SUM(P.MontoTotal) as MontoTotal
		FROM Clasificador_Ingresos CI 
		INNER JOIN Pagos P ON P.clasificador = CI.clai_codigo
		WHERE  CI.clai_descripcion like  '%DEVOLUCION%' AND
			   P.FechaPago BETWEEN @FechaDesde and dateadd(dd,1,@FechaHasta)
		GROUP BY CI.clai_descripcion,CI.Fuente,CI.clai_codigo,cast(P.FechaPago as date)
		ORDER BY cast(P.FechaPago as date) DESC
	END
--============================================================================================
--================================== Listar Resumen Por Dia ==================================
--============================================================================================
	IF @TipoConsulta=4
	BEGIN
		SELECT CI.Fuente,SUM(dP.monto_pago) as MontoTotal
		FROM Clasificador_Ingresos CI 
		INNER JOIN pago_detalle_tributo dP ON dP.clai_codigo = CI.clai_codigo
		inner join Pagos p on dp.pagos_ID=p.Pagos_id
		WHERE P.FechaPago BETWEEN @FechaDesde and dateadd(dd,1,@FechaHasta) and CI.Fuente is not null and CI.Recurso is not null
		GROUP BY CI.Fuente
		ORDER BY CI.Fuente DESC		
	END
--============================================================================================
--=================================== Listar Resumen Por Partida =============================
--============================================================================================
	IF @TipoConsulta=5
	BEGIN
		SELECT CI.Fuente,CI.clai_codigo,
		rtrim(CI.clai_descripcion)as clai_descripcion,
		SUM(pdt.monto_pago) AS MontoTotal 
		FROM Pagos P  
		INNER JOIN pago_detalle_tributo PDT ON P.Pagos_id = PDT.pagos_ID
		INNER JOIN Clasificador_Ingresos CI ON CI.clai_codigo = PDT.clai_codigo
		WHERE P.FechaPago BETWEEN @FechaDesde AND dateadd(dd,1,@FechaHasta) and CI.Fuente is not null 
		GROUP BY CI.Fuente,CI.clai_codigo,CI.clai_descripcion
		ORDER BY CI.Fuente DESC
	END

--============================================================================================
--============================== Listar PAGOS POR CONTRIBUYENTE DADO =========================
--============================================================================================
	IF @TipoConsulta=6
	BEGIN
		SELECT P.FechaPago,CAST(P.CODIGO_VOUCHER AS INT)as  nro_Recibo,rtrim(P.Pagante)as Pagante,PDT.monto_pago,CI.clai_codigo,CI.Fuente,CI.Recurso
		FROM Pagos P 
			INNER JOIN pago_detalle_tributo PDT ON P.Pagos_id = PDT.pagos_ID
			INNER JOIN Clasificador_Ingresos CI ON CI.clai_codigo = PDT.clai_codigo
			INNER JOIN CajeroCaja CC ON CC.CajeroCaja_id = P.CajeroCaja_id
			INNER JOIN Caja as C on C.Caja_id = CC.Caja_id
			INNER JOIN Oficina as O on O.oficina_id = C.idOficina
		WHERE P.FechaPago BETWEEN @FechaDesde and dateadd(dd,1,@FechaHasta )
		 AND (O.oficina_id = @oficina_id OR @oficina_id = -1) and P.Persona_id = @Pagante
		ORDER BY P.FechaPago asc
	END
		--============================================================================================
--============================== Listar Resumen Por Dia y Clasificador===========================
--============================================================================================
	IF @TipoConsulta=7
	BEGIN
		SELECT CI.Fuente,CI.Recurso,SUM(dP.monto_pago) as MontoTotal
		FROM Clasificador_Ingresos CI 
		INNER JOIN pago_detalle_tributo dP ON dP.clai_codigo = CI.clai_codigo
		inner join Pagos p on dp.pagos_ID=p.Pagos_id		
		WHERE P.FechaPago BETWEEN @FechaDesde and dateadd(dd,1,@FechaHasta) and CI.clai_codigo = @tributo and CI.Fuente is not null and CI.Recurso is not null
		GROUP BY CI.Fuente,CI.Recurso
		ORDER BY CI.Fuente DESC	
	END

	IF @TipoConsulta=8
	BEGIN
		SELECT CI.Fuente,CI.clai_codigo,
		rtrim(CI.clai_descripcion)as clai_descripcion,
		SUM(pdt.monto_pago) AS MontoTotal 
		FROM Pagos P  
		INNER JOIN pago_detalle_tributo PDT ON P.Pagos_id = PDT.pagos_ID
		INNER JOIN Clasificador_Ingresos CI ON CI.clai_codigo = PDT.clai_codigo
		WHERE P.FechaPago BETWEEN @FechaDesde AND dateadd(dd,1,@FechaHasta) AND CI.clai_codigo = @tributo and CI.Fuente is not null
		GROUP BY CI.Fuente,CI.clai_codigo,CI.clai_descripcion
		ORDER BY CI.Fuente DESC
	END

	IF @TipoConsulta=9
	BEGIN
		SELECT CI.Fuente,rtrim(CI.clai_codigo)as clai_codigo,
		CI.clai_descripcion,SUM(P.MontoTotal) as MontoTotal
		FROM Clasificador_Ingresos CI 
		INNER JOIN Pagos P ON P.clasificador = CI.clai_codigo
		WHERE  CI.clai_descripcion like  '%DEVOLUCION%' AND
			   P.FechaPago BETWEEN @FechaDesde and dateadd(dd,1,@FechaHasta) AND CI.clai_codigo = @tributo
		GROUP BY CI.clai_descripcion,CI.Fuente,CI.clai_codigo
		ORDER BY CI.clai_descripcion,CI.Fuente DESC
	END
END