USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Repo_Estadisico1]    Script Date: 30/11/2016 10:50:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[_Repo_Estadisico1]
				@anio int = null,
				@anio2 int = null,
				@TipoConsulta tinyint = null,
				@m1 tinyint = null,
				@m2 tinyint = null
AS 
if @TipoConsulta=1 
BEGIN
		SELECT mes = (case when MONTH(P.FechaPago) = 1 then 'Enero' when MONTH(P.FechaPago) = 2 then 'Febrero' when MONTH(P.FechaPago) = 3 then 'Marzo'
		when MONTH(P.FechaPago) = 4 then 'Abril' when MONTH(P.FechaPago) = 5 then 'Mayo' when MONTH(P.FechaPago) = 6 then 'Junio'when MONTH(P.FechaPago) = 7 then 'Julio'
		when MONTH(P.FechaPago) = 8 then 'Agosto' when MONTH(P.FechaPago) = 9 then 'Septiembre' when MONTH(P.FechaPago) = 10 then 'Octubre' when MONTH(P.FechaPago) = 11 then 'Noviembre'
		when MONTH(P.FechaPago) = 12 then 'Diciembre' end), 
		Predial = sum(case when PDT.clai_codigo = '1.1. 2. 1. 1. 1' then pdt.monto_pago else 0 end)	,
		PredialAnterior = sum(case when PDT.clai_codigo = '1.1.2.1.1.2' then pdt.monto_pago else 0 end),
		Arbitrios = sum(case when PDT.clai_codigo = '1.3. 3. 9. 2.23.1' then pdt.monto_pago else 0 end)+sum(case when PDT.clai_codigo = '1.3. 3. 9. 2.23.2' then pdt.monto_pago else 0 end),		
		Alcabala = sum(case when PDT.clai_codigo = '1.1. 2. 1. 2. 1' then pdt.monto_pago else 0 end),
		TotalMes = sum(case when PDT.clai_codigo in('1.1. 2. 1. 1. 1','1.1.2.1.1.2') then pdt.monto_pago else 0 end)
		FROM pagos P
		inner join pago_detalle_tributo PDT ON P.Pagos_id=PDT.pagos_ID
		WHERE year(P.FechaPago) = @anio 
		group by MONTH(P.FechaPago)
		order by MONTH(P.FechaPago)
End
if @TipoConsulta=2
BEGIN
	SELECT mes = (case when CC.mes = 1 then 'Enero' when CC.mes = 2 then 'Febrero' when CC.mes = 3 then 'Marzo'
		when CC.mes = 4 then 'Abril' when CC.mes = 5 then 'Mayo' when CC.mes = 6 then 'Junio'when CC.mes = 7 then 'Julio'
		when CC.mes = 8 then 'Agosto' when CC.mes = 9 then 'Septiembre' when CC.mes = 10 then 'Octubre' when CC.mes = 11 then 'Noviembre'
		when CC.mes = 12 then 'Diciembre' end), 
		CargoPredio = sum(case when T.tipo_tributo = 1 then CC.cargo else 0 end), 
		AbonoPredio = sum(case when T.tipo_tributo = 1 then CC.abono else 0 end),
		SaldoPredio = sum(case when T.tipo_tributo = 1 then CC.cargo-abono else 0 end),
		(case when sum(case when T.tipo_tributo = 1 then CC.cargo else 0 end)!=0 then (sum(case when T.tipo_tributo = 1 then CC.abono else 0 end)/sum(case when T.tipo_tributo = 1 then CC.cargo else 0 end))*100
		else 0 end) as CobradoPredio,
		(case when sum(case when T.tipo_tributo = 1 then CC.cargo else 0 end)!=0 then(1-(sum(case when T.tipo_tributo = 1 then CC.abono else 0 end)/sum(case when T.tipo_tributo = 1 then CC.cargo else 0 end)))*100
		else 0 end) as MorosidadPredio, 
		CargoArbitrio = sum(case when T.tipo_tributo = 2 then CC.cargo else 0 end), 
		AbonoArbitrio = sum(case when T.tipo_tributo = 2 then CC.abono else 0 end),
		SaldoArbitrio = sum(case when T.tipo_tributo = 2 then CC.cargo-abono else 0 end),
		(case when sum(case when T.tipo_tributo = 2 then CC.cargo else 0 end)!=0 then (sum(case when T.tipo_tributo = 2 then CC.abono else 0 end)/sum(case when T.tipo_tributo = 2 then CC.cargo else 0 end))*100
		else 0 end) as CobradoArbitrio,
	(case when sum(case when T.tipo_tributo = 2 then CC.cargo else 0 end)!=0 then(1-(sum(case when T.tipo_tributo = 2 then CC.abono else 0 end)/sum(case when T.tipo_tributo = 2 then CC.cargo else 0 end)))*100
		else 0 end) as MorosidadArbitrio
		FROM CUENTACORRIENTE CC
		inner join tributos T ON T.tributos_ID = CC.tributo_ID
		WHERE cc.anio = @anio and (cc.mes between @m1 and @m2) and estado in ('P', 'C') 
		group by cc.mes
		order by cc.mes
End
if @TipoConsulta=3
BEGIN
	SELECT 
	CargoPredio = sum(case when T.tipo_tributo = 1 then CC.cargo else 0 end), 
	AbonoPredio = sum(case when T.tipo_tributo = 1 then CC.abono else 0 end),
	SaldoPredio = sum(case when T.tipo_tributo = 1 then CC.cargo-abono else 0 end),
	CargoArbitrio = sum(case when T.tipo_tributo = 2 then CC.cargo else 0 end), 
	AbonoArbitrio = sum(case when T.tipo_tributo = 2 then CC.abono else 0 end),
	SaldoArbitrio = sum(case when T.tipo_tributo = 2 then CC.cargo-abono else 0 end),
	CargoOtros = sum(case when (T.tipo_tributo <> 1 and T.tipo_tributo <> 2) then CC.cargo else 0 end), 
	AbonoOtros = sum(case when (T.tipo_tributo <> 1 and T.tipo_tributo <> 2) then CC.abono else 0 end),
	SaldoOtros = sum(case when (T.tipo_tributo <> 1 and T.tipo_tributo <> 2) then CC.cargo-abono else 0 end)	
	FROM CUENTACORRIENTE CC
	inner join tributos T ON T.tributos_ID = CC.tributo_ID	
	WHERE CC.anio = @anio 
	group by  CC.interes_cobrado		
End
if @TipoConsulta=4
BEGIN
	if object_id( 'tempdb..##tabla2') is not null drop table ##tabla2; 
	if object_id( 'tempdb..##tabla3') is not null drop table ##tabla3; 
SELECT MONTH(CC.fecha_cancelacion) as nro,
		CargoPredio = sum(case when T.tipo_tributo = 1 then CC.cargo else 0 end), 
		AbonoPredio = sum(case when T.tipo_tributo = 1 then CC.abono else 0 end),
		SaldoPredio = sum(case when T.tipo_tributo = 1 then CC.cargo-abono else 0 end),
		CargoArbitrio = sum(case when T.tipo_tributo = 2 then CC.cargo else 0 end), AbonoArbitrio = sum(case when T.tipo_tributo = 2 then CC.abono else 0 end),
		SaldoArbitrio = sum(case when T.tipo_tributo = 2 then CC.cargo-abono else 0 end)
		--(SUM(CC.abono)/SUM(CC.cargo))*100 as Cobrado,CC.interes_cobrado As Morosidad
		into ##tabla2
		FROM CUENTACORRIENTE CC
		inner join tributos T ON T.tributos_ID = CC.tributo_ID		
		WHERE YEAR(CC.fecha_cancelacion) = @anio
		group by YEAR(CC.fecha_cancelacion), MONTH(CC.fecha_cancelacion),CC.interes_cobrado
		order by MONTH(CC.fecha_cancelacion)
	select nro, CargoPredio, AbonoPredio, SaldoPredio,
	(case when CargoPredio!=0 then (AbonoPredio/CargoPredio)*100
		else 0 end) as CobradoPredio,
	(case when CargoPredio!=0 then(1-(AbonoPredio/CargoPredio))*100
		else 0 end) as MorosidadPredio, 
	CargoArbitrio, SaldoArbitrio, AbonoArbitrio, 
	(case when CargoArbitrio!=0 then (AbonoArbitrio/CargoArbitrio)*100
		else 0 end) as CobradoArbitrio,
	(case when CargoArbitrio!=0 then(1-(AbonoArbitrio/CargoArbitrio))*100
		else 0 end) as MorosidadArbitrio into ##tabla3 from ##tabla2
select  sum(tt.CargoPredio) as CargoPredio, sum(tt.AbonoPredio) as AbonoPredio, 
		sum(tt.SaldoPredio) as SaldoPredio, sum(tt.CargoArbitrio) as CargoArbitrio, sum(tt.SaldoArbitrio) as SaldoArbitrio, 
		sum(tt.AbonoArbitrio) as AbonoArbitrio
		from ##tabla3 tt where tt.nro between @m1 and @m2
End
if @TipoConsulta=5
BEGIN
	SELECT cc.anio as Periodo,
		Predial = sum(case when T.tributos_ID = '0008' then CC.cargo-abono else 0 end), 
		Arbitrios = sum(case when T.tributos_ID = '0043' then CC.cargo-abono else 0 end),
		Alcabala = sum(case when T.tributos_ID = '0038' then CC.cargo-abono else 0 end)
		--'Multas' = sum(case when T.tributos_ID = '0188' then CC.cargo-abono else 0 end)				
		FROM CUENTACORRIENTE CC
		inner join tributos T ON T.tributos_ID = CC.tributo_ID		
	WHERE cc.anio >= @anio
	group by CC.anio
	order by CC.anio
End
if @TipoConsulta=6
BEGIN
	SELECT Periodo = YEAR(P.FechaPago), 
		Predial = sum(case when PDT.clai_codigo = '1.1. 2. 1. 1. 1' then pdt.monto_pago else 0 end)+sum(case when PDT.clai_codigo = '1.1.2.1.1.2' then pdt.monto_pago else 0 end),		
		Arbitrios = sum(case when PDT.clai_codigo = '1.3. 3. 9. 2.23.1' then pdt.monto_pago else 0 end)+sum(case when PDT.clai_codigo = '1.3. 3. 9. 2.23.2' then pdt.monto_pago else 0 end),		
		Alcabala = sum(case when PDT.clai_codigo = '1.1. 2. 1. 2. 1' then pdt.monto_pago else 0 end)		
		FROM pagos P
		inner join pago_detalle_tributo PDT ON P.Pagos_id=PDT.pagos_ID
		WHERE year(P.FechaPago) >= @anio 
		group by YEAR(P.FechaPago)
		order by YEAR(P.FechaPago)

End
if @TipoConsulta=7
BEGIN
	if object_id( 'tempdb..##tabla4') is not null drop table ##tabla4; 
	if object_id( 'tempdb..##tabla5') is not null drop table ##tabla5; 
	declare @alcabala int
	declare @alcabala2 int
	set @alcabala = (SELECT count(*) FROM PAGOS P
		INNER JOIN pago_detalle_tributo PDT ON PDT.pagos_ID = P.Pagos_id
		inner join clasificador_ingresos T ON T.clai_codigo = PDT.clai_codigo	
	 WHERE year(P.FechaPago) = @anio AND MONTH(P.FechaPago) = @m1 AND 
	 (PDT.clai_codigo = '1.1. 2. 1. 2. 1'))	
	  
	select * into ##tabla4 from
	(	SELECT 
		'ALCABALA' AS Tributos, 
		MontoAño1 = case when @alcabala>0 then sum(pdt.monto_pago) else 0 end
	FROM PAGOS P
		INNER JOIN pago_detalle_tributo PDT ON PDT.pagos_ID = P.Pagos_id
		inner join clasificador_ingresos T ON T.clai_codigo = PDT.clai_codigo	
	 WHERE year(P.FechaPago) = @anio AND MONTH(P.FechaPago) = @m1 AND 
	 (PDT.clai_codigo = '1.1. 2. 1. 2. 1')	
	 union	  
	SELECT T.clai_descripcion as Tributos, 
	sum(pdt.monto_pago) as MontoAño1 FROM PAGOS P
		INNER JOIN pago_detalle_tributo PDT ON PDT.pagos_ID = P.Pagos_id
		inner join clasificador_ingresos T ON T.clai_codigo = PDT.clai_codigo	
	 WHERE year(P.FechaPago) = @anio AND MONTH(P.FechaPago) = @m1 AND 
	 (PDT.clai_codigo = '1.1. 2. 1. 1. 1' or PDT.clai_codigo = '1.1.2.1.1.2' or PDT.clai_codigo = '1.3. 3. 9. 2.23.1' or PDT.clai_codigo = '1.3. 3. 9. 2.23.2')
	 GROUP BY T.clai_descripcion ) x	

	 set @alcabala2 = (SELECT count(*) FROM PAGOS P
		INNER JOIN pago_detalle_tributo PDT ON PDT.pagos_ID = P.Pagos_id
		inner join clasificador_ingresos T ON T.clai_codigo = PDT.clai_codigo	
	 WHERE year(P.FechaPago) = @anio2 AND MONTH(P.FechaPago) = @m2 AND 
	 (PDT.clai_codigo = '1.1. 2. 1. 2. 1'))	
	  
	select * into ##tabla5 from
	(	SELECT 
		'ALCABALA' AS Tributos, 
		MontoAño2 = case when @alcabala2>0 then sum(pdt.monto_pago) else 0 end
	FROM PAGOS P
		INNER JOIN pago_detalle_tributo PDT ON PDT.pagos_ID = P.Pagos_id
		inner join clasificador_ingresos T ON T.clai_codigo = PDT.clai_codigo	
	 WHERE year(P.FechaPago) = @anio2 AND MONTH(P.FechaPago) = @m2 AND 
	 (PDT.clai_codigo = '1.1. 2. 1. 2. 1')	
	 union	  
	SELECT T.clai_descripcion as Tributos, 
	sum(pdt.monto_pago) as MontoAño2 FROM PAGOS P
		INNER JOIN pago_detalle_tributo PDT ON PDT.pagos_ID = P.Pagos_id
		inner join clasificador_ingresos T ON T.clai_codigo = PDT.clai_codigo	
	 WHERE year(P.FechaPago) = @anio2 AND MONTH(P.FechaPago) = @m2 AND 
	 (PDT.clai_codigo = '1.1. 2. 1. 1. 1' or PDT.clai_codigo = '1.1.2.1.1.2' or PDT.clai_codigo = '1.3. 3. 9. 2.23.1' or PDT.clai_codigo = '1.3. 3. 9. 2.23.2')
	 GROUP BY T.clai_descripcion ) x	

	 select t1.Tributos,t1.MontoAño1,t2.MontoAño2 from ##tabla4 t1
	 inner join ##tabla5 t2 on t1.Tributos=t2.Tributos
End







