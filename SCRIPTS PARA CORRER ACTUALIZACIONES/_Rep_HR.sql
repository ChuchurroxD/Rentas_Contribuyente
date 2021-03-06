USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Rep_HR]    Script Date: 05/12/2016 07:03:04 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--===========================================================================================
--================= PROCEDIMIENTO ReporteHojaResumen - Contribuyente ========================
--===========================================================================================
--===========================================================================================
ALTER PROCEDURE [dbo].[_Rep_HR]
             @persona_id    char(9)=Null,
			 @idPeriodo int=null,
			 @Sector int=null,
			 @nombres varchar(300)=null

,@TipoConsulta tinyint
AS
BEGIN
	declare 
		@impuestoanual decimal(18,2),
		@cuotatrimestral decimal(18,2),
		@totalpredios int,
		@baseimponible decimal(18,2),
		@prediosafecto decimal(18,2)

--===========================================================================================
--============= DATOS DEL CONTRIBUYENTE - Codigo,Apellidos y Nombre, RUC/DNI, ===============
--============= Direccion/Referencia Fiscal , Referencias/Observaciones =====================
--===========================================================================================
--===========================================================================================
if @TipoConsulta=1 
Begin
	Select c.persona_id,c.razon_social,c.ruc,t.descripcion as TipoDocDescripcion,c.c_num,c.c_mz,c.c_mz,c.c_lote,c.direccCompleta 
	From Contribuyente c 
	inner join Persona p on p.persona_ID = c.persona_id
	inner join tablas t on t.valor = p.tipo_documento
 	where  t.dep_id = 3 and c.persona_id = @persona_id
End
--===========================================================================================
--======== RELACION DE PREDIOS - Codigo,UbicacionPredio,ValorPredio,%C,ValorAfecto ==========
--===========================================================================================
--===========================================================================================
if @TipoConsulta=2
Begin
		Select DBO._getDireccionFiscal(p.junta_via_ID,p.num_via,p.interior,p.mz,p.lote,p.edificio,p.piso,p.dpto,p.tienda,p.kilometro) as Ubicacion_Predio,
		p.predio_ID,p.total_autovaluo,pc.Porcentaje_Condomino,p.exo_predial_porcentaje--,'100' as Valor_Afecto
		From PREDio_COntribuyente pc
		inner join Predio p on p.predio_ID = pc.Predio_id
		where pc.idPeriodo = @idPeriodo and pc.persona_ID = @persona_id
End

--===========================================================================================
--===== DETERMINACION DEL IMPUESTO - ImpuestoAnual,CuentaTrimestral,TotalPredios=============
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=3
begin
	Select @impuestoanual=isnull (sum(cargo),0) From CuentaCorriente
	where persona_ID = @persona_id and anio = @idPeriodo and tributo_ID='0008'	
	select top 1 @cuotatrimestral=monto from (
	Select mes, isnull(sum(cargo),0)as monto From CuentaCorriente 
	where persona_ID = @persona_id and anio = @idPeriodo and tributo_ID='0008'
	group by mes)as cuotas
	Select @totalpredios=count(*)
	From PREDio_COntribuyente pc
	inner join Predio p on p.predio_ID = pc.Predio_id
	where pc.idPeriodo = @idPeriodo and pc.persona_ID= @persona_id AND p.estado=1
	Select @baseimponible=sum((p.total_autovaluo*pc.Porcentaje_Condomino)/100)
	From PREDio_COntribuyente pc
	inner join Predio p on p.predio_ID = pc.Predio_id
	where pc.idPeriodo = @idPeriodo and pc.persona_ID= @persona_id
	and pc.estado=1
	Select @impuestoanual as impuestoanual,@cuotatrimestral as cuotatrimestral,
			@totalpredios as totalpredios,@baseimponible as baseimponible
End
else if @TipoConsulta=4
begin
	if object_id( 'tempdb..##tAB') is not null drop table ##tAB;
	if object_id( 'tempdb..##TAB2') is not null drop table ##TAB2;
	if object_id( 'tempdb..##TAB3') is not null drop table ##TAB3;

	Select  fecha_vence  ,sum(cargo)as cargo,
	0 as derechoemision,sum(abono)as abono,MES, 4 as TIPO_OPERa
	into ##tAB 
	From CuentaCorriente
	--select * FROM  ##tAB T
	where anio = @idPeriodo and persona_ID=@persona_id and tributo_ID='0008' AND (estado = 'C' or estado = 'P' or estado = 'Q' or estado = 'B')
	group by fecha_vence  ,MES
	SELECT T.*,(SELECT SUM(CARGO-ABONO)  FROM  ##tAB  WHERE  TIPO_OPERa=3 AND MES=T.MES) AS REAJUSTE  
	INTO ##TAB2
	FROM  ##tAB T  WHERE  (tipo_opera=1 or tipo_opera=4)
	Select CAST( ROW_NUMBER() OVER(ORDER BY fecha_vence DESC)  AS INT)as cuota,
	fecha_vence as vencimiento,cargo as montoinsoluto,
	isnull(REAJUSTE,0) as REAJUSTE,(cargo+isnull(REAJUSTE,0))as totalpagar,0 as derechoemision INTO ##TAB3
	FROM ##TAB2
	INSERT INTO ##TAB3 VALUES (0,0,cast(0 as decimal(12,2)), cast(0 as decimal (12,2)),
	cast(0 as decimal (12,2)),0)
	INSERT INTO ##TAB3 VALUES (0,0,cast(0 as decimal(12,2)), cast(0 as decimal (12,2)),
	cast(0 as decimal (12,2)),0)
	INSERT INTO ##TAB3 VALUES (0,0,cast(0 as decimal(12,2)), cast(0 as decimal (12,2)),
	cast(0 as decimal (12,2)),0)
	INSERT INTO ##TAB3 VALUES (0,0,cast(0 as decimal(12,2)), cast(0 as decimal (12,2)),
	cast(0 as decimal (12,2)),0)
	INSERT INTO ##TAB3 VALUES (0,0,cast(0 as decimal(12,2)), cast(0 as decimal (12,2)),
	cast(0 as decimal (12,2)),0)
	INSERT INTO ##TAB3 VALUES (0,0,cast(0 as decimal(12,2)), cast(0 as decimal (12,2)),
	cast(0 as decimal (12,2)),0)
	--INSERT INTO ##TAB3 VALUES (0,GETDATE(),0,0,0,0)
	--INSERT INTO ##TAB3 VALUES (0,GETDATE(),0,0,0,0)
	--INSERT INTO ##TAB3 VALUES (0,GETDATE(),0,0,0,0)
	--INSERT INTO ##TAB3 VALUES (0,GETDATE(),0,0,0,0)
	Select TOP 5 * FROM ##TAB3
	--DROP TABLE ##TAB2
	--DROP TABLE ##TAB3
	--DROP TABLE ##TAB
	--select*from cuentacorriente
	--0 as derechoemision,0 as reajuste,(cargo-abono)as totalpagar 
	--Select CAST( ROW_NUMBER() OVER(ORDER BY fecha_vence DESC)  AS INT)as cuota,fecha_vence as vencimiento,cargo as montoinsoluto,
	--0 as derechoemision,0 as reajuste,(cargo-abono)as totalpagar 
	----into ##tAB 
	--From CuentaCorriente
	--where anio = @idPeriodo and persona_ID=@persona_id and tributo_ID='0008' AND estado='C'
end

else if @TipoConsulta=5
begin 
if object_id( 'tempdb..##PREDIOSS') is not null drop table ##PREDIOSS;
Select DBO._getDireccionFiscal(p.junta_via_ID,p.num_via,p.interior,p.mz,p.lote,p.edificio,p.piso,p.dpto,p.tienda,p.kilometro) as Ubicacion_Predio,
	       p.predio_ID,p.total_autovaluo,pc.Porcentaje_Condomino,((p.total_autovaluo*pc.Porcentaje_Condomino)/100) as valorafecto
	INTO ##PREDIOSS From PREDio_COntribuyente pc
		inner join Predio p on p.predio_ID = pc.Predio_id
		where pc.persona_ID = @persona_id and pc.idPeriodo = @idPeriodo and pc.estado=1
INSERT INTO ##PREDIOSS VALUES('','   ',0,0,0)
INSERT INTO ##PREDIOSS VALUES('','   ',0,0,0)
INSERT INTO ##PREDIOSS VALUES('','   ',0,0,0)
INSERT INTO ##PREDIOSS VALUES('','   ',0,0,0)
INSERT INTO ##PREDIOSS VALUES('','   ',0,0,0)
INSERT INTO ##PREDIOSS VALUES('','   ',0,0,0)
INSERT INTO ##PREDIOSS VALUES('','   ',0,0,0)
 SELECT TOP 5 *FROM  ##PREDIOSS order by predio_ID desc
end 
else if @TipoConsulta=6--igusal q el 5
begin 
if object_id( 'tempdb..##PREDIOSsS') is not null drop table ##PREDIOSsS;
Select DBO._getDireccionFiscal(p.junta_via_ID,p.num_via,p.interior,p.mz,p.lote,p.edificio,p.piso,p.dpto,p.tienda,p.kilometro) as Ubicacion_Predio,
	       p.predio_ID,p.total_autovaluo,pc.Porcentaje_Condomino,((p.total_autovaluo*pc.Porcentaje_Condomino)/100) as valorafecto
	INTO ##PREDIOSsS From PREDio_COntribuyente pc
		inner join Predio p on p.predio_ID = pc.Predio_id
		where pc.persona_ID = @persona_id and pc.idPeriodo = @idPeriodo
		and pc.estado=1
SELECT  *FROM  ##PREDIOSsS order by predio_ID desc
end 
else if @TipoConsulta=7--igusal q el 4
begin
	if object_id( 'tempdb..##tAB') is not null drop table ##tAB;
	if object_id( 'tempdb..##TAB2') is not null drop table ##TAB2;
	if object_id( 'tempdb..##TAB3') is not null drop table ##TAB3;

	Select  fecha_vence  ,sum(cargo)as cargo,
	0 as derechoemision,sum(abono)as abono,MES, 4 as TIPO_OPERa
	into ##tABb 
	From CuentaCorriente

	--select * FROM  ##tAB T

	where anio = @idPeriodo and persona_ID=@persona_id and tributo_ID='0008' AND (estado = 'C' or estado = 'P' or estado = 'Q' or estado = 'B')
	group by fecha_vence  ,MES

	--Select  fecha_vence  ,cargo,
	--0 as derechoemision,abono,MES, tipo_opera
	--into ##tABb 
	--From CuentaCorriente
	----select * FROM  ##tAB T
	--where anio = @idPeriodo and persona_ID=@persona_id and tributo_ID='0008' --AND estado='C'

	SELECT T.*,(SELECT SUM(CARGO-ABONO)  FROM  ##tABb  WHERE  TIPO_OPERa=3 AND MES=T.MES) AS REAJUSTE  
	INTO ##TAB22
	FROM  ##tABb T  WHERE  (tipo_opera=1 or tipo_opera=4)
	Select CAST( ROW_NUMBER() OVER(ORDER BY fecha_vence DESC)  AS INT)as cuota,
	fecha_vence as vencimiento,cargo as montoinsoluto,
	isnull(REAJUSTE,0) as REAJUSTE,(cargo+isnull(REAJUSTE,0))as totalpagar, 0
	as derechoemision 
	FROM ##TAB22
	Select  * FROM ##TAB22
	end
else if @TipoConsulta=9--igusal q el 4
	begin
		Select c.persona_id AS persona_ID,c.razon_social AS nombres, CONCAT(t.descripcion,' - ', c.ruc) as documento,c.direccCompleta as direccion
	From Contribuyente c 
	inner join Persona p on p.persona_ID = c.persona_id
	inner join tablas t on t.valor = p.tipo_documento
	inner join junta_via jv on c.junta_via_id = jv.junta_via_id
	inner join Sector j on jv.junta_id = j.Sector_id 
 	where  t.dep_id = 3 and (jv.junta_id = @Sector or @Sector = '0' )
	order by c.razon_social asc
	end
	else if @TipoConsulta=10--igusal q el 4
	begin
		Select c.persona_id AS persona_ID,c.razon_social AS nombres, CONCAT(t.descripcion,' - ', c.ruc) as documento,c.direccCompleta as direccion
	From Contribuyente c 
	inner join Persona p on p.persona_ID = c.persona_id
	inner join tablas t on t.valor = p.tipo_documento
	inner join junta_via jv on c.junta_via_id = jv.junta_via_id
	inner join Sector j on jv.junta_id = j.Sector_id 
 	where  t.dep_id = 3 and (jv.junta_id = @Sector or @Sector = '0' ) and c.razon_social  >= @nombres
	order by c.razon_social asc
	end
End







