USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Repo_PredioUrbano]    Script Date: 17/01/2017 02:42:07 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--===========================================================================================
--==================================== PROCEDIMIENTO PREDIO URBANO ==========================
--===========================================================================================
ALTER PROCEDURE [dbo].[_Repo_PredioUrbano]
             @persona_id    char(9)=Null,
			 @idPeriodo int=null,
			 @predio_ID char(16) = Null

,@TipoConsulta tinyint
AS 
BEGIN
--	declare 
--		@impuestoanual decimal(18,2),
--		@cuotatrimestral decimal(18,2),
--		@totalpredios int,
--		@baseimponible decimal(18,2),
--		@prediosafecto decimal(18,2)
--End
--===========================================================================================
--==========PROCEDIMIENTO REPROTE PREDIO URBANO - DATOS DEL CONTRIBUYENTE ===============
--===========================================================================================
if @TipoConsulta=1 
	Begin
		Select Distinct TOP 1 c.persona_id,c.razon_social,c.ruc as documento,doc.descripcion as DescripcionDocumento
		From Contribuyente c
			inner join Persona per on per.persona_ID = c.persona_id
			inner join tablas doc on doc.valor = per.tipo_documento
		where  doc.dep_id = 3
				and c.persona_id =@persona_id
	End
--===========================================================================================
--==========PROCEDIMIENTO REPROTE PREDIO URBANO - DATOS DEL PREDIO ==========================
--===========================================================================================

if @TipoConsulta=2 
	Begin
		select Distinct TOP 1 c.persona_id,
			   dbo._getDireccionFiscal(pr.junta_via_ID,pr.num_via,pr.interior,pr.mz,pr.lote,pr.edificio,pr.piso,pr.dpto,pr.tienda,pr.kilometro)as direccion_completa,
			   pr.nombre_predio,pr.referencia as frente_a,--Dep_id =14
			   pr.tipo_predio,TipoPredio.descripcion as DescripcionTipoPredio,
			   pr.estado_predio,EstadoPredio.descripcion as DescripcionEstadoPredio,
			   pr.uso_predio,UsoPredio.descripcion as DescripcionUsoPredio,--,pr.tipo_inmueble
			   1 as piso_material
			   
			   ,'' as DescripcionMaterPredom
		From Contribuyente c 
		inner join Persona per on per.persona_ID = c.persona_id
		inner join PREDio_COntribuyente pc on pc.persona_ID = c.persona_id
		inner join Predio_auditoria pr on pr.predio_ID = pc.Predio_id 
		--inner join pisos_auditoria pis on pis.persona_ID = per.persona_ID
		inner join tablas doc on doc.valor = per.tipo_documento
		inner join tablas TipoPredio on TipoPredio.valor = pr.tipo_predio
		inner join tablas EstadoPredio on EstadoPredio.valor = pr.estado_predio
		inner join tablas UsoPredio on UsoPredio.valor = pr.uso_predio
		--inner join tablas MaterPredom on MaterPredom.valor = pis.piso_material
		where pr.vez=(select max(vez)from Predio_auditoria where predio_id=pr.predio_id 
		and periodo_id=pr.periodo_id)
			and doc.dep_id = 3 
			and TipoPredio.dep_id = 11
			and EstadoPredio.dep_id = 7
			and UsoPredio.dep_id = 8
			--and pr.tipo_inmueble = 1
			--and MaterPredom.dep_id = 21
			and pr.periodo_id = @idPeriodo
			and pr.predio_ID = @predio_ID
			and pc.idperiodo=pr.periodo_id
	End

--===========================================================================================
--==========PROCEDIMIENTO REPROTE PREDIO URBANO - DETERMINACION DEL IMPUESTO ===============
--===========================================================================================

if @TipoConsulta=3
	Begin
	if object_id( 'tempdb..##PISOOS') is not null drop table ##PISOOS;
		Select DISTINCT pis.predio_ID,pis.numero,pis.antiguedad,CONCAT(pis.antiguedad,'') as DescripcionAntiguedad,
		pis.fecha_construc,
				pis.piso_clasificacion,
				(PIS.muro + PIS.techo+PIS.PISO+PIS.puerta+PIS.revestimiento+PIS.banio+PIS.instalaciones)
				AS DescripcionPisoClasificacion,
				--pisoclasific.descripcion as DescripcionPisoClasificacion,
				pis.valor_unitario,pis.porcent_depreci,(pis.valor_unit_depreciado) as ValorUnitarioDepreciacion,
				pis.area_construida,pis.valor_comun,pis.valor_construido_total,pis.vez
		INTO ##PISOOS From  pisos_auditoria pis
			  --inner join tablas pisoclasific on pisoclasific.valor = pis.piso_clasificacion
		where 
		--pisoclasific.dep_id = 20 and
		 pis.periodo_id = @idPeriodo
			   and pis.predio_ID = @predio_ID 
			   and pis.estado = 1
			   and pis.vez=(select max(vez)from pisos_auditoria
							where piso_ID=pis.piso_ID and periodo_id=pis.periodo_id)   
		--group by pis.numero,pis.antiguedad,pis.fecha_construc,
		--		pis.piso_clasificacion,--pisoclasific.descripcion,
		--		pis.valor_unitario,pis.porcent_depreci,(pis.valor_unit_depreciado),
		--		pis.area_construida,pis.valor_comun,pis.valor_construido_total,pis.predio_ID,pis.vez
		order by pis.predio_ID
		INSERT INTO ##PISOOS VALUES('  ',0,1,'','01/01/1900',0,'',cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2))) 
		INSERT INTO ##PISOOS VALUES('  ',0,1,'','01/01/1900',0,'',cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2))) 
		INSERT INTO ##PISOOS VALUES('  ',0,1,'','01/01/1900',0,'',cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2))) 
		INSERT INTO ##PISOOS VALUES('  ',0,1,'','01/01/1900',0,'',cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2))) 
		INSERT INTO ##PISOOS VALUES('  ',0,1,'','01/01/1900',0,'',cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2))) 
		INSERT INTO ##PISOOS VALUES('  ',0,1,'','01/01/1900',0,'',cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2)),cast(0 as decimal(12,2))) 

		SELECT TOP 5 *FROM ##PISOOS order by predio_ID desc
	End
End
IF @TipoConsulta=4
BEGIN
	select area_terreno,arancel,valor_otra_instalacion,valor_terreno,
	valor_construccion,total_autovaluo 
	from Predio_auditoria 
	where predio_id=@predio_ID and vez=(select max(vez) from Predio_auditoria 
	where predio_id=@predio_ID  and periodo_id=@idPeriodo)
	AND PERIODO_ID=@idPeriodo

END
if @TipoConsulta=5--igual q el3 conn  formato
	Begin
		Select DISTINCT pis.predio_ID,pis.numero,pis.antiguedad,CONCAT(pis.antiguedad,'') as DescripcionAntiguedad,
		pis.fecha_construc,
				pis.piso_clasificacion,
				(PIS.muro + PIS.techo+PIS.PISO+PIS.puerta+PIS.revestimiento+PIS.banio+PIS.instalaciones)
				AS DescripcionPisoClasificacion,
				--pisoclasific.descripcion as DescripcionPisoClasificacion,
				pis.valor_unitario,pis.porcent_depreci,(pis.valor_unit_depreciado) as ValorUnitarioDepreciacion,
				pis.area_construida,pis.valor_comun,pis.valor_construido_total,pis.vez
		From  pisos_auditoria pis
			  --inner join tablas pisoclasific on pisoclasific.valor = pis.piso_clasificacion
		where 
		--pisoclasific.dep_id = 20 and
		 pis.periodo_id = @idPeriodo
			   and pis.predio_ID = @predio_ID 
			   and pis.estado = 1
			   and pis.vez=(select max(vez)from pisos_auditoria
							where piso_ID=pis.piso_ID and periodo_id=pis.periodo_id)   
		--group by pis.numero,pis.antiguedad,pis.fecha_construc,
		--		pis.piso_clasificacion,--pisoclasific.descripcion,
		--		pis.valor_unitario,pis.porcent_depreci,(pis.valor_unit_depreciado),
		--		pis.area_construida,pis.valor_comun,pis.valor_construido_total,pis.predio_ID,pis.vez
		order by pis.predio_ID
		
	
End
--select area_terreno,arancel,valor_otra_instalacion,valor_terreno,
--	valor_construccion,total_autovaluo 
--	from Predio_auditoria 
--	where predio_id='290835041001' and vez=(select max(vez) from Predio_auditoria 
--	where predio_id='290835041001'  and periodo_id=2016)