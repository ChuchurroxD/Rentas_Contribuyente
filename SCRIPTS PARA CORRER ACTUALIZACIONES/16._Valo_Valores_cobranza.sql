USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Valo_ValoresCobranza]    Script Date: 03/12/2016 9:05:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER procedure [dbo].[_Valo_ValoresCobranza]
	@persona varchar(9) = null,
	@anio1 int = null,
	@anio2 int = null,
	@aniot int = null,
	@aniof int = null,
	@tipovalor tinyint = null,
	@anio int = null, -- anio para el que se genera los valores
	--
	@junta int = null,
	@monto1 decimal(18,2) = null,
	@monto2 decimal(18,2) = null,
	@nro int = null,
	@estado char(2)=null,
	@usuario varchar(30)  = null,
	--
	@tptributo int=null,
	
	@valor int = null,
	@tipoconsulta tinyint,
	@observ varchar(150)=null,@tp1 int=null,@tp2 int=null,@tp3 int=null,
	@numero int =null,
	@notificacion int=null,

	@registro_fecha_add datetime = null,
	--@registro_user_add varchar(40) = null,
	@registro_pc_add varchar(40) = null,
	@registro_fecha_update datetime = null,
	@registro_user_update varchar(40) = null,
	@registro_pc_update varchar(40) = null


as
set nocount on
begin
declare @ult1 int,@ult2 int,@ult3 int
declare @aactual int

	-- listar los tipos de valores
	if @tipoconsulta = 1
		begin
			select ltrim(rtrim(valor)) as valor, descripcion from tablas where dep_id = 38 and estado = 1 and valor in ('1','2','10','3')
		end

	-- listar los valores generados pro contribuyente, año y tipo
	if @tipoconsulta = 2
		begin
			select tv.descripcion as nombre, v.numero, v.anio_valor as anio,
			convert(char(10), fecha_recep,103) as recep ,  convert(char(10),fecha_vence, 103 ) as vence
			from valores v 	inner join tablas tv on ( v.tipo_valor = tv.valor and tv.dep_id =  38 )
			where persona_id = @persona and anio_valor = @anio and v.estado in ('g', 'i', 'n')
		end

	--listar deuda por predio/tipovalor/anio
	if @tipoconsulta = 3
		begin
			select t.persona_id, predio_id, direccion_completa, deuda, numero, anio_valor, valor_id, recep, vence from (
				select cc.persona_id, p.predio_id, p.direccion_completa, sum(cargo-abono) as deuda
				from CuentaCorriente cc inner join tributos t on cc.tributo_id = t.tributos_id
				inner join predio p on cc.predio_id = p.predio_id
				where cc.persona_id = @persona and cc.anio = @anio and cc.fecha_vence+1 < getdate()
				and t.tipo_tributo = case when @tipovalor = 3 then 1 when @tipovalor = 4 then 3 else @tipovalor end
				and cc.estado = 'p' and cc.activo = 1 and t.tributos_id<>'0016'
				group by cc.persona_id, p.predio_id, p.direccion_completa
			) as t left join
			(
				select persona_id, valor_id, numero, anio_valor, predio,
				convert(char(10), fecha_recep,103) as recep ,  convert(char(10),fecha_vence, 103 ) as vence
				from valores
				where persona_id = @persona and anio_valor = @anio and tipo_valor = @tipovalor and estado <> 'a' --and anio_curso = dbo.getanio()
			) as v on t.persona_id = v.persona_id and t.predio_id = v.predio
			where deuda > 0

		end

	-- listar cantidad de contrib. por junta segun montos
	if @tipoconsulta = 4
		begin
			
		if object_id( 'tempdb..#ecuenta') is not null drop table #ecuenta;
		if object_id( 'tempdb..#ecuenta_') is not null drop table #ecuenta_;

		select * into #ecuenta from CuentaCorriente where activo='1' and anio between @anio1 and @anio2 
		select * into #ecuenta_ from CuentaCorriente where activo='1' and anio between @aniot and @aniof

			select count(*) as nro, junta, Sector_id, sum(deuda) as deuda from (
				select cc.persona_id, j.descripcion as junta, j.Sector_id, deuda = sum(cargo-abono)
				from #ecuenta cc inner join contribuyente c on cc.persona_id = c.persona_id
				inner join tributos t on cc.tributo_id = t.tributos_id
				inner join junta_via jv on c.junta_via_id = jv.junta_via_id
				inner join Sector j on jv.junta_id = j.Sector_id
				where  (j.Sector_id = @junta or @junta = 0)
				and t.tipo_tributo = 1 and t.tributos_id<>'0016'
				and cc.fecha_vence+1 < getdate() and cc.estado = 'p' and c.estado = 1 
				and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))
				group by cc.persona_id, j.descripcion, j.Sector_id				
				having sum(cargo-abono) between @monto1 and @monto2
				union
				select cc.persona_id, j.descripcion as junta, j.Sector_id, deuda = sum(cargo-abono)
				from #ecuenta_ cc inner join contribuyente c on cc.persona_id = c.persona_id
				inner join tributos t on cc.tributo_id = t.tributos_id
				inner join junta_via jv on c.junta_via_id = jv.junta_via_id
				inner join Sector j on jv.junta_id = j.Sector_id
				where (j.Sector_id = @junta or @junta =0)
				and t.tipo_tributo = 2 and cc.fecha_vence+1 < getdate() and cc.estado = 'p' and c.estado = 1 
				and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))
				group by cc.persona_id, j.descripcion, j.Sector_id
				having sum(cargo-abono) between @monto1 and @monto2
			) f group by junta, Sector_id
			order by junta
		end
	-- listar los mas morosos
	--exec [dbo].[_Valo_ValoresCobranza] @junta = 0, @anio1=2000,@anio2=2010,@nro=10,@tipoconsulta=5
	if @tipoconsulta = 5
		begin
			if object_id( 'tempdb..#tempa') is not null drop table #tempa;
			if object_id( 'tempdb..#tempo') is not null drop table #tempo;
			if object_id( 'tempdb..#tempas') is not null drop table #tempas;
			if object_id( 'tempdb..#tempas_l') is not null drop table #tempas_l;					
			
			select *  into #tempo from CuentaCorriente where  estado='P' and tributo_id not in('0016','0043')
			and anio between @anio1 and @anio2

			select cargo,abono,cc.persona_id,jv.junta_id,t.tipo_tributo,ubicacion_id into #tempa
			from #tempo cc inner join contribuyente c on cc.persona_id = c.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			inner join junta_via jv on c.junta_via_id = jv.junta_via_id
			where  (jv.junta_id = @junta or @junta = 0) and c.estado = '1'
			and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))

			select persona_id, junta_id,ubicacion_id, deuda = sum(cargo-abono) into #tempas
			from #tempa			where tipo_tributo in ('1','2')
			group by persona_id, junta_id,ubicacion_id order by deuda desc

			select top (@nro) persona_id, junta_id, deuda,ubicacion_id  into #tempas_l
			from #tempas
			order by deuda desc

			select c.persona_id, c.deuda, RTRIM((paterno+' '+materno+' '+nombres)) as nombres, c.junta_id, j.descripcion as DESCRIPCION
			from #tempas_l c inner join persona p on c.persona_id = p.persona_id
			inner join Sector j on (c.junta_id = j.Sector_id and c.ubicacion_id=j.ubicacion_id)
			order by deuda desc
		end
		
	-- impresion by contribuyente
--	if @tipoconsulta = 6
--		begin
--			select n.notificacion_id, (cast(n.numero as varchar)+' - '+cast(n.anio_curso as varchar) ) as notificacion, imagen, v.predio,
--			v.valor_id, tv.descripcion as tipo ,(cast(v.numero as varchar)+' - '+cast(v.anio_valor as varchar) ) as valor, tipo_valor, predio, deuda, convert(char(10), fecha_emision, 103 ) as emision,
--			convert(char(10), n.fecha_registro, 103 ) as registro, convert(char(10), fecha_impresion, 103 ) as impresion,suspendido,td.descripcion as estado
--			from notificacion n inner join det_notificacion d on n.notificacion_id = d.notificacion_id
--			inner join valores v on d.valor_id = v.valor_id
--			inner join tablas tv on ( v.tipo_valor = tv.valor and tv.dep_id = 38 )
--			inner join tablas td on ( v.estado = td.valor and td.dep_id = 49 )
--			where n.persona_id = @persona and v.estado <> 'a' and n.activo='1' --and n.anio_curso = dbo.getanio() 
			
--group by n.notificacion_id,n.numero,n.anio_curso,imagen,v.predio,v.valor_id, tv.descripcion,v.numero,v.anio_valor,tipo_valor,predio,deuda,fecha_emision
--,n.fecha_registro,fecha_impresion,suspendido,td.descripcion
--			order by notificacion_id, valor_id
--		end

	-- listar los generados por junta segun monto
	if @tipoconsulta = 7
		begin
			select c.persona_id, sum( cargo-abono) as monto  into #clientes
			from contribuyente c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
				inner join tributos t on cc.tributo_id = t.tributos_id
				inner join junta_via jv on c.junta_via_id  = jv.junta_via_id
			where cc.anio  between @anio1 and @anio2 and ( jv.junta_id = @junta or @junta = '!!' )
				and fecha_vence+1 < getdate() and tipo_tributo in (1,2) and t.tributos_id<>'0016'
				--and c.estado_cuentas = 1 
				and cc.estado = 'p' and cc.activo = 1 and c.estado = 1  --and t.cobro_interes = 1
			group by c.persona_id
			having sum(cargo-abono) between @monto1 and @monto2

			select  t.persona_id, predio_id, anio, t.deuda, valor_id, Sector_id, junta into #temps
			from (
				select c.persona_id, predio_id, anio, sum(cargo-abono) as deuda, j.Sector_id, j.descripcion as junta
				from #clientes c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
				inner join contribuyente co on c.persona_id = co.persona_id
				inner join tributos t on cc.tributo_id = t.tributos_id
				inner join junta_via jv on co.junta_via_id = jv.junta_via_id
				inner join Sector j on jv.junta_id = j.Sector_id
				where cc.anio = @anio and t.tipo_tributo = case @tipovalor when 3 then 1 else @tipovalor end
				and cc.estado = 'p' and cc.activo = 1 and t.cobro_interes = 1
				group by c.persona_id, predio_id, anio,  j.Sector_id, j.descripcion
			) as t
			left join valores v on (t.persona_id = v.persona_id and t.predio_id = v.predio and v.tipo_valor = @tipovalor and anio_valor = @anio and v.estado <> 'a' )

			select t.Sector_id, junta, isnull(nro,0) as personas ,total,   isnull(generados,0) as generados from
			(select count(*) as total, Sector_id, junta from #temps group by Sector_id, junta	) as t  left join
			(select count(*) as nro, Sector_id from #temps group by Sector_id ) as n on t.Sector_id = n.Sector_id left join
			(select count(*) as generados, Sector_id from #temps where valor_id is not null group by Sector_id ) as p on t.Sector_id = p.Sector_id

		end

	-- listar los valores generados pro contribuyente,  tipo entre dos años
	if @tipoconsulta = 8
		begin
			select v.valor_id, tv.descripcion as nombre, v.numero, v.anio_valor as anio,  v.deuda,
			convert(char(10), fecha_recep,103) as recep ,  convert(char(10),fecha_vence, 103 ) as vence
			from valores v 	inner join tablas tv on (convert(varchar(50),v.tipo_valor) = tv.valor and tv.dep_id =  38 )
			where persona_id = @persona and anio_valor between @anio1 and @anio2  and v.estado in ('g', 'i', 'n')	and tipo_valor = @tipovalor
		end

	-- anular un valor
	--if @tipoconsulta = 9
	--	begin
	--		update valores set estado = 'a',observaciones=@observ where valor_id = @valor and estado <> 'n'
	--		if @@rowcount > 0
	--			begin
	--				update notificacion set fecha_impresion = null from notificacion n inner join det_notificacion d on n.notificacion_id = d.notificacion_id
	--				inner join valores v on d.valor_id = v.valor_id where v.valor_id = @valor
	--			end
	--	end

	---- anular varios valores
	--if @tipoconsulta = 10
	--	begin
	--		update valores set estado = 'a'	where persona_id = @persona and tipo_valor = @tipovalor and anio_valor between @anio1 and @anio2 and estado <> 'n'
	--		if @@rowcount > 0
	--			begin
	--				update notificacion set fecha_impresion = null from notificacion n inner join det_notificacion d on n.notificacion_id = d.notificacion_id
	--				inner join valores v on d.valor_id = v.valor_id where v.persona_id = @persona and tipo_valor = @tipovalor and anio_valor between @anio1 and @anio2
	--			end

	--	end

	---- anular varios valores advanced
	--if @tipoconsulta = 11
	--	begin
	--		update valores set estado = 'a'	where persona_id = @persona and tipo_valor = @tipovalor and anio_valor = @anio and estado <> 'n'
	--		if @@rowcount > 0
	--			begin
	--				update notificacion set fecha_impresion = null from notificacion n inner join det_notificacion d on n.notificacion_id = d.notificacion_id
	--				inner join valores v on d.valor_id = v.valor_id where v.persona_id = @persona and tipo_valor = @tipovalor and anio_valor = @anio
	--			end

	--	end

	if @tipoconsulta=12
	begin
		
			if object_id( 'tempdb..#ctaa') is not null drop table #ctaa;



select * into #ctaa from CuentaCorriente where activo='1' 

				select cc.persona_id, j.descripcion as junta,paterno+' '+materno+' '+nombres as texto, j.Sector_id, deuda = sum(cargo-abono),documento,'PREDIAL' AS tipo,
				[dbo].[_getDireccionCorta](c.junta_via_id, c_num, c_interior , c_mz, c_lote, c_edificio, c_piso, c_dpto, c_tienda, '' )  as direccion,v.descripcion as calle
				from #ctaa cc inner join contribuyente c on cc.persona_id = c.persona_id
				inner join persona pe on pe.persona_id=c.persona_id
				inner join tributos t on cc.tributo_id = t.tributos_id
				inner join junta_via jv on c.junta_via_id = jv.junta_via_id
				inner join Sector j on (jv.junta_id = j.Sector_id and j.ubicacion_id=jv.ubicacion_id)
				inner join Via v on v.via_ID=jv.via_ID
				where anio between @anio1 and @anio2 and cc.estado = 'p' and fecha_vence+1 < getdate() and
				(j.Sector_id = @junta)
				and t.tipo_tributo = 1 and t.tributos_id<>'0016' and c.estado = 1 
				and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))
				group by cc.persona_id, j.descripcion, j.Sector_id,paterno,materno,nombres,documento,
				c.junta_via_id, c_num, c_interior , c_mz, c_lote, c_edificio, c_piso, c_dpto, c_tienda,v.descripcion
				having sum(cargo-abono) between @monto1 and @monto2 
				union
				select cc.persona_id, j.descripcion as junta,paterno+' '+materno+' '+nombres as texto, j.Sector_id, deuda = sum(cargo-abono),documento,'ARBITRIOS' AS tipo,
				[dbo].[_getDireccionCorta](c.junta_via_id, c_num, c_interior , c_mz, c_lote, c_edificio, c_piso, c_dpto, c_tienda, '' )  as direccion,v.descripcion as calle
				from #ctaa cc inner join contribuyente c on cc.persona_id = c.persona_id
				inner join persona pe on pe.persona_id=c.persona_id
				inner join tributos t on cc.tributo_id = t.tributos_id
				inner join junta_via jv on c.junta_via_id = jv.junta_via_id
				inner join Sector j on (jv.junta_id = j.Sector_id and j.ubicacion_id=jv.ubicacion_id)
				inner join Via v on v.via_ID=jv.via_ID
				where anio between @aniot and @aniof and cc.estado = 'p' and fecha_vence+1 < getdate() and
				(j.Sector_id = @junta)
				and t.tipo_tributo = 2 and c.estado = 1 
				group by cc.persona_id, j.descripcion, j.Sector_id,paterno,materno,nombres,documento,
				c.junta_via_id, c_num, c_interior , c_mz, c_lote, c_edificio, c_piso, c_dpto, c_tienda,v.descripcion
				having sum(cargo-abono) between @monto1 and @monto2 
				order by deuda desc
	end

	if @tipoconsulta = 13
		begin
			
				select cc.persona_id,paterno+' '+materno+' '+nombres as texto, j.descripcion as junta, j.Sector_id, deuda = sum(cargo-abono)
				from CuentaCorriente cc inner join contribuyente c on cc.persona_id = c.persona_id
				inner join persona p on p.persona_id=c.persona_id
				inner join tributos t on cc.tributo_id = t.tributos_id
				inner join junta_via jv on c.junta_via_id = jv.junta_via_id
				inner join Sector j on jv.junta_id = j.Sector_id
				where cc.anio between @anio1 and @anio2
				and j.Sector_id = @junta and t.tributos_id<>'0016'
				and t.tipo_tributo in (1,2)
				and cc.fecha_vence+1 < getdate()
				and cc.estado = 'p'
				--and c.estado_cuentas = 1	
				and cc.activo = 1 and c.estado = 1  --and t.cobro_interes = 1
				group by cc.persona_id,paterno,materno,nombres, j.descripcion, j.Sector_id
				having sum(cargo-abono) between @monto1 and @monto2
			
			
		end

	if @tipoconsulta = 14
		begin
			update valores set 
							estado = 'F',
							[registro_fecha_update] = GETDATE(),
							[registro_user_update] = @usuario,
							[registro_pc_update] = HOST_NAME()
			 where persona_id = @persona and estado = 'n'			
		end

	if @tipoconsulta = 15
		begin
			
			if object_id( 'tempdb..#tempa_1') is not null drop table #tempa_1;
			if object_id( 'tempdb..#tempo_1') is not null drop table #tempo_1;
			if object_id( 'tempdb..#tempas_1') is not null drop table #tempas_1;
			if object_id( 'tempdb..#tempas_l_1') is not null drop table #tempas_l_1;
					
			select *  into #tempo_1 from CuentaCorriente where activo='1' and estado in ('P','F','E') and anio between @anio1 and @anio2 and cargo>0
			
			select cargo,abono,cc.persona_id,j.descripcion as junta into #tempa_1
			from #tempo_1 cc inner join contribuyente c on cc.persona_id = c.persona_id
			inner join junta_via jv on c.junta_via_id = jv.junta_via_id
			inner join Sector j on (jv.junta_id = j.Sector_id and jv.ubicacion_id=j.ubicacion_id)
			where  (jv.junta_id = @junta or @junta = '!!') 
			

			select persona_id, junta, sum(cargo-abono) as deuda into #tempas_1
			from #tempa_1
			group by persona_id, junta order by deuda desc

			select top (@nro) persona_id, deuda,junta  into #tempas_l_1
			from #tempas_1
			order by deuda desc
				

			select c.persona_id, c.deuda,  (paterno+' '+materno+' '+nombres) as nombres, junta
			from #tempas_l_1 c inner join persona p on c.persona_id = p.persona_id
			order by deuda desc

		end

	if @tipoconsulta = 16
		begin
			
			if object_id( 'tempdb..#topredial') is not null drop table #topredial;
			if object_id( 'tempdb..#toarbitrio') is not null drop table #toarbitrio;
			if object_id( 'tempdb..#tempo_11') is not null drop table #tempo_11;
			if object_id( 'tempdb..#tempa_11') is not null drop table #tempa_11;
			if object_id( 'tempdb..#toalcabala') is not null drop table #toalcabala;
			if object_id( 'tempdb..#tootrostrib') is not null drop table #tootrostrib;
			if object_id( 'tempdb..#general') is not null drop table #general;
			if object_id( 'tempdb..#tempo_11_pr') is not null drop table #tempo_11_pr;
					
			select *  into #tempo_11_pr from CuentaCorriente where activo='1' 
			
			
			select *  into #tempo_11 from #tempo_11_pr where estado in ('P','F','E') and anio between @anio1 and @anio2 and cargo>0 
			--and persona_id ='70881'
			
			select cargo,abono,cc.persona_id,j.descripcion as junta,j.Sector_id,tipo_tributo into #tempa_11
			from #tempo_11 cc inner join contribuyente c on cc.persona_id = c.persona_id
			inner join junta_via jv on c.junta_via_id = jv.junta_via_id
			inner join Sector j on (jv.junta_id = j.Sector_id and jv.ubicacion_id=j.ubicacion_id)
			inner join tributos t on cc.tributo_id = t.tributos_id
			where  (jv.junta_id = @junta or @junta = '!!') 


			select sum(cargo) as cpred,sum(abono) as abpred,cc.persona_id,junta,Sector_id
		    into #topredial
			from #tempa_11 cc
			where tipo_tributo='1'
			group by cc.persona_id,junta,Sector_id
			
			select sum(cargo) as carbri,sum(abono) as abarbri,cc.persona_id,junta,Sector_id
			into #toarbitrio
			from #tempa_11 cc 
			where tipo_tributo='2'
			group by cc.persona_id,junta,Sector_id

			select sum(cargo) as calcab,sum(abono) as abalcab,cc.persona_id,junta,Sector_id
			into #toalcabala
			from #tempa_11 cc 
			where tipo_tributo='3'
			group by cc.persona_id,junta,Sector_id

			select sum(cargo) as cotro,sum(abono) as abotro,cc.persona_id,junta,Sector_id
			into #tootrostrib
			from #tempa_11 cc 
			where tipo_tributo='7'
			group by cc.persona_id,junta,Sector_id		



select cpred,abpred,pred.persona_id,pred.junta,pred.Sector_id,carbri,abarbri,calcab,abalcab,cotro,abotro into #general from #tempa_11 as pred
left join #topredial pr on (pr.persona_id=pred.persona_id	and pr.Sector_id=pred.Sector_id) 
left join #toarbitrio arb on (arb.persona_id=pred.persona_id	and arb.Sector_id=pred.Sector_id)
left join #toalcabala alc on (alc.persona_id=pred.persona_id	and alc.Sector_id=pred.Sector_id)
left join #tootrostrib otr on (otr.persona_id=pred.persona_id	and otr.Sector_id=pred.Sector_id)



select top (@nro) c.persona_id,paterno+' '+materno+' '+nombres as texto,junta,cpred,abpred,
carbri as carbitr,abarbri as abarbitr,calcab, abalcab, cotro,abotro,
(isnull(cpred, 0))-(isnull(abpred, 0))+((isnull(carbri, 0))-(isnull(abarbri, 0)))+((isnull(calcab, 0))-(isnull(abalcab, 0)))+((isnull(cotro, 0))-(isnull(abotro, 0)))  as titt
--(sum(isnull(cpred, 0))-sum(isnull(abpred, 0)))+(sum(isnull(carbri, 0))-sum(isnull(abarbri, 0)))+(sum(isnull(calcab, 0))-sum(isnull(abalcab, 0)))+(sum(isnull(cotro, 0))-sum(isnull(abotro, 0))) as titt
			from #general c inner join persona p on p.persona_id=c.persona_id
			group by c.persona_id,junta,paterno,materno,nombres,cpred,abpred,carbri,abarbri,calcab, abalcab, cotro,abotro
			order by titt desc



		end


	if @tipoconsulta = 17
		begin
			
			if object_id( 'tempdb..#tempa_2') is not null drop table #tempa_2;
			if object_id( 'tempdb..#tempo_2') is not null drop table #tempo_2;
			if object_id( 'tempdb..#tempas_2') is not null drop table #tempas_2;
			if object_id( 'tempdb..#tempas_2_2') is not null drop table #tempas_2_2;
			if object_id( 'tempdb..#mirr') is not null drop table #mirr;		
			if object_id( 'tempdb..#mess') is not null drop table #mess;	
		
			declare @fvence datetime
			
				select mes, fecha_vence = case 
				when mes = 1 then '26-02-'+convert(varchar(50),year(getdate())) 
				when mes = 2 then '26-02-'+convert(varchar(50),year(getdate()))  
				when mes = 3 then '26-02-'+convert(varchar(50),year(getdate()))  
				when mes = 4 then '31-05-'+convert(varchar(50),year(getdate())) 
				when mes = 5 then '31-05-'+convert(varchar(50),year(getdate()))  
				when mes = 6 then '31-05-'+convert(varchar(50),year(getdate()))  
				when mes = 7 then '31-08-'+convert(varchar(50),year(getdate()))  
				when mes = 8 then '31-08-'+convert(varchar(50),year(getdate())) 
				when mes = 9 then '31-08-'+convert(varchar(50),year(getdate()))  
				when mes = 10 then '30-11-'+convert(varchar(50),year(getdate()))  
				when mes = 11 then '30-11-'+convert(varchar(50),year(getdate())) 
				when mes = 12 then '30-11-'+convert(varchar(50),year(getdate())) 
				end into #mess FROM parametro_mes WHERE periodo_id=year(getdate())

			set @fvence = (select fecha_vence FROM #mess WHERE mes=month(getdate()))

			select *  into #mirr from CuentaCorriente 
			where activo='1'  and cargo>0 and fecha_vence < @fvence
			
			select ct.* into #tempo_2  
			from #mirr as ct inner join tributos as tr on tr.tributos_id=ct.tributo_id 
			where tipo_tributo  in (@tp1,@tp2,@tp3) 


			select cargo,abono,cc.persona_id,j.descripcion as junta,'' as direccion
			--,[dbo].[_getDireccionCorta](c.junta_via_id, c_num, c_interior , c_mz, c_lote, c_edificio, c_piso, c_dpto, c_tienda, '' ) as direccion
			into #tempa_2
			from #tempo_2 cc inner join contribuyente c on cc.persona_id = c.persona_id
			inner join junta_via jv on c.junta_via_id = jv.junta_via_id
			inner join Sector j on (jv.junta_id = j.Sector_id and jv.ubicacion_id=j.ubicacion_id)
			where  (jv.junta_id = @junta or @junta = '!!') 
			

			select persona_id, junta,direccion, sum(cargo-abono) as deuda into #tempas_2
			from #tempa_2
			group by persona_id, junta ,direccion
			having sum(cargo-abono)=0 

			select t.persona_id, deuda,junta,direccion into #tempas_2_2
			from #tempas_2 t inner join predio_contribuyente pr on pr.persona_id=t.persona_id where pr.estado='1' and idPeriodo=year(getdate())
			group by t.persona_id,deuda,junta,direccion
			order by deuda desc

			select cc.persona_id, cc.deuda,  (paterno+' '+materno+' '+nombres) as nombres, junta,
			[dbo].[_getDireccionCorta](c.junta_via_id, c_num, c_interior , c_mz, c_lote, c_edificio, c_piso, c_dpto, c_tienda, '' ) as direccion 
			from #tempas_2_2 cc 
			inner join persona p on cc.persona_id = p.persona_id
			inner join contribuyente c on c.persona_id=p.persona_id
			order by nombres asc

		end


	if @tipoconsulta = 18
	begin
		if object_id( 'tempdb..#tempa_2c') is not null drop table #tempa_2c;
		if object_id( 'tempdb..#tempo_2c') is not null drop table #tempo_2c;
		if object_id( 'tempdb..#tempas_2c') is not null drop table #tempas_2c;
		if object_id( 'tempdb..#tempas_2_2c') is not null drop table #tempas_2_2c;
		if object_id( 'tempdb..#mirr_ctt') is not null drop table #mirr_ctt;		
		
		select *  into #mirr_ctt from CuentaCorriente 
		where activo='1' and anio between @anio1 and @anio2 and cargo>0 
	
		select ct.* into #tempo_2c  
		from #mirr_ctt as ct inner join tributos as tr on tr.tributos_id=ct.tributo_id 
		where tipo_tributo  in (@tp1,@tp2,@tp3) 

		select cc.estado,cargo,abono,cc.persona_id,j.descripcion as junta,'' as direccion
		into #tempa_2c
		from #tempo_2c cc inner join contribuyente c on cc.persona_id = c.persona_id
		inner join junta_via jv on c.junta_via_id = jv.junta_via_id
		inner join Sector j on (jv.junta_id = j.Sector_id and jv.ubicacion_id=j.ubicacion_id)
		where  (jv.junta_id = @junta or @junta = '!!') 

		select persona_id, junta,direccion, sum(abono) as deuda into #tempas_2c
		from #tempa_2c where estado not in ('E','X')
		group by persona_id, junta ,direccion
		having sum(cargo-abono)=0 

		select t.persona_id, deuda,junta,direccion into #tempas_2_2c
		from #tempas_2c t inner join predio_contribuyente pr on pr.persona_id=t.persona_id where pr.estado='1' and idPeriodo=year(getdate())
		group by t.persona_id,deuda,junta,direccion
		order by deuda desc

		select cc.persona_id, cc.deuda,  (paterno+' '+materno+' '+nombres) as nombres, junta,
		[dbo].[_getDireccionCorta](c.junta_via_id, c_num, c_interior , c_mz, c_lote, c_edificio, c_piso, c_dpto, c_tienda, '' ) as direccion 
		from #tempas_2_2c cc 
		inner join persona p on cc.persona_id = p.persona_id
		inner join contribuyente c on c.persona_id=p.persona_id
		where deuda>@monto1
		order by deuda desc
	end	
	
	--if @tipoconsulta = 19
	--	begin
	--		update notificacion set activo = '1' where notificacion_id=@nro		
	--	end
		
	--if @tipoconsulta = 20
	--	begin
		
	--	update notificacion set activo = '1' where notificacion_id=@nro
		
	--	update contribuyente set estado_cuentas='2' 
	--		from valores v 
	--		inner join det_notificacion d on d.valor_id=v.valor_id 
	--		inner join contribuyente p on p.persona_ID=v.persona_ID
	--		where notificacion_id=@nro
			
			
	--	update CuentaCorriente set estado='n'
	--		from valores v inner join det_notificacion d on d.valor_id=v.valor_id
	--		inner join det_valor dd on dd.valor_id=v.valor_id 
	--		inner join CuentaCorriente c on c.CuentaCorriente_ID=dd.CuentaCorriente_ID 
	--		where notificacion_id=@nro and v.estado='n'	
		
	--	end	
	
	if @tipoconsulta = 21
		begin
			
			update valores set estado=@estado where valor_id=@valor
			
		end	
		
	--if @tipoconsulta = 22
	--	begin
	--		update notificacion set suspendido = '1' where notificacion_id=@nro	
			
	--		update valores set estado=@estado
	--		from valores v 
	--		inner join det_notificacion d on d.valor_id=v.valor_id 
	--		inner join contribuyente p on p.persona_ID=v.persona_ID
	--		where notificacion_id=@nro
			
	--		update contribuyente set estado_cuentas='1'
	--		from valores v 
	--		inner join det_notificacion d on d.valor_id=v.valor_id 
	--		inner join contribuyente p on p.persona_ID=v.persona_ID
	--		where notificacion_id=@nro
				
	--	end	
		
	if @tipoconsulta = 23
		begin
			select ltrim(rtrim(pc.predio_id)) as valor,[dbo].[_getDireccionCorta](p.junta_via_id, num_via, interior , mz, lote, edificio, piso, dpto, tienda, kilometro ) as descripcion 
			from predio_contribuyente pc inner join predio p on p.predio_ID=pc.predio_ID
			where persona_ID=@persona and idPeriodo between @anio1 and @anio2 and pc.estado='1'
		end	

		if @tipoconsulta = 24
		begin
			select ltrim(rtrim(valor)) as valor, descripcion from tablas where dep_id = 38 and estado = 1
		end
		
	if @tipoconsulta = 25
		begin
			select v.valor_id, tv.descripcion as nombre, v.numero, v.anio_valor as anio,  v.deuda,
			convert(char(10), fecha_recep,103) as recep ,  convert(char(10),fecha_vence, 103 ) as vence
			from valores v 	inner join tablas tv on (convert(varchar(50),v.tipo_valor) = tv.valor and tv.dep_id =  38 )
			where persona_id = @persona and anio_valor between @anio1 and @anio2  and v.estado in ('g', 'i', 'n')	and tipo_valor = '1'
			union
			select v.valor_id, tv.descripcion as nombre, v.numero, v.anio_valor as anio,  v.deuda,
			convert(char(10), fecha_recep,103) as recep ,  convert(char(10),fecha_vence, 103 ) as vence
			from valores v 	inner join tablas tv on (convert(varchar(50),v.tipo_valor) = tv.valor and tv.dep_id =  38 )
			where persona_id = @persona and anio_valor between @aniot and @aniof  and v.estado in ('g', 'i', 'n')	and tipo_valor = '2'
			
			
		end
		
	if @tipoconsulta = 26
		begin
			select ltrim(rtrim(valor)) as valor, descripcion from tablas where dep_id = 38 and estado = 1 and valor in ('3')
		end	
		
	if @tipoconsulta = 27
		begin
			select ltrim(rtrim(valor)) as valor, descripcion from tablas where dep_id = 38 and estado = 1 and valor in ('4')
		end	
	if @tipoconsulta = 28
	begin
		
		set @aactual = dbo.getAnio()
	
		-- LISTANDO CONTRIBUYENTES
		if object_id( 'tempdb..#tempo') is not null drop table #tempo;
		if object_id( 'tempdb..#cliente') is not null drop table #cliente;
		if object_id( 'tempdb..#temp') is not null drop table #temp;
		
		select c.persona_id,t.tipo_tributo, sum( cargo-abono) as monto  into #cliente
		from contribuyente c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			inner join junta_via jv on c.junta_via_id  = jv.junta_via_id
		where c.persona_ID in (select persona_ID from predio_contribuyente where estado='1' and idPeriodo=YEAR(GETDATE())) and
			  ( jv.junta_id = @junta or @junta = 0 )
			and fecha_vence+1 < getdate() and
			((tipo_tributo = 1 and  cc.anio  between @anio1 and @anio2 )
			or(tipo_tributo = 2 and  cc.anio  between @aniot and @aniof ))
			and t.tributos_id not in ('0016','0344')
			and cc.estado = 'P' and c.estado = 1 and cc.activo='1'
			and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))
		group by c.persona_id ,t.tipo_tributo
		having sum(cargo-abono) between @monto1 and @monto2				
		select  t.tipo_valor,t.persona_id, predio_id, anio, t.deuda, insoluta, valor_id into #temp from (
			select '1' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, sum(cargo - abono)  as insoluta
			from #cliente c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @anio1 and @anio2 and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1 and
			 t.tributos_id not in ('0016','0344') and @tipovalor in (1,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
			union
			select '2' AS tipo_valor,c.persona_id, predio_id, anio, sum(cargo - abono) as deuda,  sum(cargo - abono) as  insoluta
			from #cliente c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @aniot and @aniof and t.tipo_tributo = '2' and cc.estado = 'P' and cc.activo = 1  and @tipovalor in (2,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
			union			
			select '3' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, (dbo.calculo_predial_monto_anual(c.persona_id, anio))  as insoluta
			from #cliente c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @anio1 and @anio2 and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1  and @tipovalor=3  and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
		) as t 
		left join valores v on (t.persona_id = v.persona_id and t.predio_id = v.predio and v.tipo_valor = t.tipo_valor and anio_valor = t.anio 
		and v.estado not in ('A','F','C' ))
		where valor_id is null	
		--c.tipodoc = case t.tipo_valor when 1 then 'P' when 2 then 'A' when 3 then 'D' when 4 then 'Q' end  and 	
		-- INSERTANDO LOS VALORES		
		select @ult1=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=1
		select @ult2=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=2
		select @ult3=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=3
		--
		select (row_number() over  ( order by persona_id))+@ult1 as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( t.persona_id, t.anio, t.predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor into #valorr
		from #temp t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='1'
		 union
		 select (row_number() over  ( order by persona_id))+@ult2  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor
		from #temp t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='2'
		union
		select (row_number() over  ( order by persona_id))+@ult3  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor
		from #temp t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		where t.tipo_valor='3'		
		insert into valores (numero, anio_curso, tipo_valor, persona_id, predio, fecha_emision, autovaluo, deuda, deuda_insoluta, 
			estado,  formato_valores_id, create_user, anio_valor, registro_fecha_add, registro_pc_add)			
		select  numero,anio_curso,tipo_valor,persona_id,predio_id,femision,autovaluo,deuda,insoluta,
			estado,formato,usuario,anio_valor, GETDATE(), HOST_NAME()
		from #valorr
		---- INSERTANDO LOS DETALLES DE VALOR
		insert into det_valor ( valor_id, cuenta_corriente_id, deuda, interes, estado)
		select v.valor_id, cuenta_corriente_id, (cargo-abono) as deuda, 0, '1' as estado 
		from valores v inner join #temp t on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id and v.anio_valor = t.anio and v.anio_curso = @aactual )
			inner join CuentaCorriente cc on ( v.persona_id = cc.persona_id and v.anio_valor = cc.anio and v.predio = cc.predio_id )
			inner join tributos tr on cc.tributo_id = tr.tributos_id 
		where cc.fecha_vence < getdate() and tr.tributos_id not in ('0016','0033','0035','0344') and cc.activo = 1 and cc.estado = 'P'  and v.estado='G'
				select @nro=isnull(max(numero),0) from notificacion where anio_curso=@aactual
				insert into notificacion (numero, anio_curso, persona_id, materia, observacion, create_user, fecha_genera, tipo_notificacion, unico ,suspendido)
				select  (row_number() over  ( order by persona_id ))+@nro as numero, @aactual as anio,  t.persona_id, '1' as materia, 
				'UNO' as obs, @usuario as usuario,  getdate() as fgenera, 1 as tipo, 
				0 as unico,0 as suspendido
				from #temp t group by t.persona_id	
				--INSERTANDO DETALLES DE CARGOS						
				insert into det_notificacion ( notificacion_id, valor_id )
				select n.notificacion_id, v.valor_id
				from #temp t 
				inner join valores v on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id and v.anio_valor = t.anio and v.anio_curso = @aactual  )
				inner join notificacion n on (t.persona_id = n.persona_id and tipo_notificacion = 1 and v.anio_curso = n.anio_curso and unico = 0 and 'UNO' = rtrim(observacion)  ) where v.estado not in ('a','n')
				select @nro = count(*)  from ( select persona_id from #temp group by persona_id ) as t				
				update notificacion set observacion = null from notificacion n inner join #temp t on (t.persona_id = n.persona_id and tipo_notificacion = 1 and n.anio_curso = n.anio_curso and unico = 0 and 'UNO' = rtrim(observacion)) 
				where fecha_impresion is null and observacion='UNO' and unico = 0					
end
else 
if @tipoconsulta = 29
	begin
		

		if object_id( 'tempdb..#tempa_') is not null drop table #tempa;
			if object_id( 'tempdb..#tempo_') is not null drop table #tempo;
			if object_id( 'tempdb..#tempas_') is not null drop table #tempas;
			if object_id( 'tempdb..#tempas_l_') is not null drop table #tempas_l_;
			if object_id( 'tempdb..#temp___') is not null drop table #temp___;
			if object_id( 'tempdb..#valorr__') is not null drop table #valorr__;
			
			
			select *  into #tempo_ from CuentaCorriente where  estado='P' and tributo_id not in('0016','0043')
			and anio between @anio1 and @anio2

			select cargo,abono,cc.persona_id,jv.junta_id,t.tipo_tributo,ubicacion_id into #tempa_
			from #tempo_ cc inner join contribuyente c on cc.persona_id = c.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			inner join junta_via jv on c.junta_via_id = jv.junta_via_id
			where  (jv.junta_id = @junta or @junta = 0) and c.estado = '1'
			and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))

			select persona_id, junta_id,ubicacion_id, deuda = sum(cargo-abono) into #tempas_
			from #tempa_ where tipo_tributo in ('1')
			group by persona_id, junta_id,ubicacion_id order by deuda desc

			select top (@numero) persona_id, junta_id, deuda,ubicacion_id  into #tempas_l_
			from #tempas_
			order by deuda desc
			

			set @aactual = dbo.getAnio()
	
		-- LISTANDO CONTRIBUYENTES
				

		select  t.tipo_valor,t.persona_id, predio_id, anio, t.deuda, insoluta, valor_id into #temp___ from (


		select '1' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, sum(cargo - abono)  as insoluta
			from #tempas_l_ c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @anio1 and @anio2 and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1 and
			 t.tributos_id not in ('0016','0344') and @tipovalor in (1,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio

			union
			select '2' AS tipo_valor,c.persona_id, predio_id, anio, sum(cargo - abono) as deuda,  sum(cargo - abono) as  insoluta
			from #tempas_l_ c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @aniot and @aniof and t.tipo_tributo = '2' and cc.estado = 'P' and cc.activo = 1  and @tipovalor in (2,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
			union			









			select '3' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, 
			(dbo.calculo_predial_monto_anual(c.persona_id, anio))  as insoluta from #tempas_l_ c 
			inner join CuentaCorriente cc on c.persona_id = cc.persona_id inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @anio1 and @anio2 and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1  and @tipovalor=3
			and cc.activo=1	group by c.persona_id, predio_id, cc.anio) as t 
		left join valores v on (t.persona_id = v.persona_id and t.predio_id = v.predio and v.tipo_valor = t.tipo_valor 
		and anio_valor = t.anio and v.estado not in ('A','F','C' ))
		where valor_id is null	
		--c.tipodoc = case t.tipo_valor when 1 then 'P' when 2 then 'A' when 3 then 'D' when 4 then 'Q' end  and 	
		-- INSERTANDO LOS VALORES		
		select @ult1=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=1
		select @ult2=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=2
		select @ult3=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=3
		--
		select (row_number() over  ( order by persona_id))+@ult1 as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( t.persona_id, t.anio, t.predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, 
		formato_valores_ID as formato, @usuario as usuario,  t.anio as anio_valor into #valorr__
		from #temp___ t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='1'
		 union
		 select (row_number() over  ( order by persona_id))+@ult2  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado,
		 formato_valores_ID as formato, @usuario as usuario,  t.anio as anio_valor
		from #temp___ t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='2'
		union
		select (row_number() over  ( order by persona_id))+@ult3  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado,
		 formato_valores_ID as formato, @usuario as usuario,  t.anio as anio_valor
		from #temp___ t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		where t.tipo_valor='3'		
		insert into valores (numero, anio_curso, tipo_valor, persona_id, predio, fecha_emision, autovaluo, deuda, 
		deuda_insoluta, estado,  formato_valores_id, create_user, anio_valor, registro_fecha_add, registro_pc_add )			
		select  numero, anio_curso, tipo_valor, persona_id, predio_id, femision, autovaluo, deuda, 
		insoluta, estado, formato, usuario, anio_valor, GETDATE(), HOST_NAME()
		from #valorr__
		---- INSERTANDO LOS DETALLES DE VALOR
		insert into det_valor ( valor_id, cuenta_corriente_id, deuda, interes, estado)
		select v.valor_id, cuenta_corriente_id, (cargo-abono) as deuda, 0, '1' as estado 
		from valores v inner join #temp___ t on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id 
			and v.anio_valor = t.anio and v.anio_curso = @aactual )
			inner join CuentaCorriente cc on ( v.persona_id = cc.persona_id and v.anio_valor = cc.anio and v.predio = cc.predio_id )
			inner join tributos tr on cc.tributo_id = tr.tributos_id 
		where cc.fecha_vence < getdate() and tr.tributos_id not in ('0016','0033','0035','0344') and cc.activo = 1 and cc.estado = 'P'  and 
		v.estado='G'
				select @nro=isnull(max(numero),0) from notificacion where anio_curso=@aactual
				insert into notificacion (numero, anio_curso, persona_id, materia, observacion, create_user, fecha_genera, tipo_notificacion, 
				unico ,suspendido)
				select  (row_number() over  ( order by persona_id ))+@nro as numero, @aactual as anio,  t.persona_id, '1' as materia, 
				'UNO' as obs, @usuario as usuario,  getdate() as fgenera, 1 as tipo, 
				0 as unico,0 as suspendido
				from #temp___ t group by t.persona_id	
				--INSERTANDO DETALLES DE CARGOS						
				insert into det_notificacion ( notificacion_id, valor_id )
				select n.notificacion_id, v.valor_id
				from #temp___ t 
				inner join valores v on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id and 
				v.anio_valor = t.anio and v.anio_curso = @aactual  )
				inner join notificacion n on (t.persona_id = n.persona_id and tipo_notificacion = 1 and v.anio_curso = n.anio_curso 
				and unico = 0 and 'UNO' = rtrim(observacion)  ) where v.estado not in ('a','n')
				select @nro = count(*)  from ( select persona_id from #temp___ group by persona_id ) as t				
				update notificacion set observacion = null from notificacion n inner join #temp___ t on (t.persona_id = n.persona_id 
				and tipo_notificacion = 1 and n.anio_curso = n.anio_curso and unico = 0 and 'UNO' = rtrim(observacion)) 
				where fecha_impresion is null and observacion='UNO' and unico = 0					
end
else 
if @tipoconsulta = 30
begin
			set @aactual = dbo.getAnio()
	
		-- LISTANDO CONTRIBUYENTES
		if object_id( 'tempdb..#tempo') is not null drop table #tempo;
		if object_id( 'tempdb..#cliente') is not null drop table #cliente2;
		if object_id( 'tempdb..#temp2') is not null drop table #temp2;
		
		select top (@numero) c.persona_id, sum( cargo-abono) as monto  into #cliente2
		from contribuyente c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			inner join junta_via jv on c.junta_via_id  = jv.junta_via_id
		where --c.persona_ID in (select persona_ID from predio_contribuyente where estado='1' and anio=YEAR(GETDATE())) and
			cc.activo=1 and
			cc.anio  between @anio1 and @anio2 and ( jv.junta_id = @junta or @junta = 0 )
			and fecha_vence+1 < getdate() and tipo_tributo in (1,2)
			and cc.estado = 'P' and c.estado = 1 and t.tributos_id not in ('0016','0344')-- and t.cobro_interes = 1
			and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))
		group by c.persona_id 
		order by  monto desc


		
				
		select  t.tipo_valor,t.persona_id, predio_id, anio, t.deuda, insoluta, valor_id into #temp2 from (
			select '1' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, sum(cargo - abono)  as insoluta
			from #cliente2 c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @anio1 and @anio2 and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1 and
			 t.tributos_id not in ('0016','0344') and @tipovalor in (1,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
			union
			select '2' AS tipo_valor,c.persona_id, predio_id, anio, sum(cargo - abono) as deuda,  sum(cargo - abono) as  insoluta
			from #cliente2 c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @aniot and @aniof and t.tipo_tributo = '2' and cc.estado = 'P' and cc.activo = 1  and @tipovalor in (2,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
			union			
			select '3' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, (dbo.calculo_predial_monto_anual(c.persona_id, anio))  as insoluta
			from #cliente2 c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @aniot and @aniof and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1  and @tipovalor=3  and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
		) as t 
		left join valores v on (t.persona_id = v.persona_id and t.predio_id = v.predio and v.tipo_valor = t.tipo_valor and anio_valor = t.anio 
		and v.estado not in ('A','F','C' ))
		where valor_id is null	

		--c.tipodoc = case t.tipo_valor when 1 then 'P' when 2 then 'A' when 3 then 'D' when 4 then 'Q' end  and 	
		-- INSERTANDO LOS VALORES		

		
		select @ult1=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=1
		select @ult2=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=2
		select @ult3=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=3

		--
		select (row_number() over  ( order by persona_id))+@ult1 as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( t.persona_id, t.anio, t.predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor into #valorr2
		from #temp2 t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='1'
		 union
		 select (row_number() over  ( order by persona_id))+@ult2  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor
		from #temp2 t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='2'
		union
		select (row_number() over  ( order by persona_id))+@ult3  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor
		from #temp2 t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		where t.tipo_valor='3'		
		
		insert into valores (numero, anio_curso, tipo_valor, persona_id, predio, fecha_emision, autovaluo, deuda, 
		deuda_insoluta, estado,  formato_valores_id, create_user, anio_valor, registro_fecha_add, registro_pc_add )			
		select  numero,anio_curso,tipo_valor,persona_id,predio_id,femision,autovaluo,deuda,
		insoluta, estado, formato, usuario, anio_valor, GETDATE(), HOST_NAME() from #valorr2
		
		---- INSERTANDO LOS DETALLES DE VALOR

		insert into det_valor ( valor_id, cuenta_corriente_id, deuda, interes, estado)
		select v.valor_id, cuenta_corriente_id, (cargo-abono) as deuda, 0, '1' as estado 
		from valores v inner join #temp2 t on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id and v.anio_valor = t.anio and v.anio_curso = @aactual )
			inner join CuentaCorriente cc on ( v.persona_id = cc.persona_id and v.anio_valor = cc.anio and v.predio = cc.predio_id )
			inner join tributos tr on cc.tributo_id = tr.tributos_id 
		where cc.fecha_vence < getdate() and tr.tributos_id not in ('0016','0033','0035','0344') and cc.activo = 1 and cc.estado = 'P'  and v.estado='G'
				select @nro=isnull(max(numero),0) from notificacion where anio_curso=@aactual
				insert into notificacion (numero, anio_curso, persona_id, materia, observacion, create_user, fecha_genera, tipo_notificacion, unico ,suspendido)
				select  (row_number() over  ( order by persona_id ))+@nro as numero, @aactual as anio,  t.persona_id, '1' as materia, 
				'UNO' as obs, @usuario as usuario,  getdate() as fgenera, 1 as tipo, 
				0 as unico,0 as suspendido
				from #temp2 t group by t.persona_id	
				--INSERTANDO DETALLES DE CARGOS						
				insert into det_notificacion ( notificacion_id, valor_id )
				select n.notificacion_id, v.valor_id
				from #temp2 t 
				inner join valores v on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id and v.anio_valor = t.anio and v.anio_curso = @aactual  )
				inner join notificacion n on (t.persona_id = n.persona_id and tipo_notificacion = 1 and v.anio_curso = n.anio_curso and unico = 0 and 'UNO' = rtrim(observacion)  ) where v.estado not in ('a','n')
				select @nro = count(*)  from ( select persona_id from #temp2 group by persona_id ) as t				
				update notificacion set observacion = null from notificacion n inner join #temp2 t on (t.persona_id = n.persona_id and tipo_notificacion = 1 and n.anio_curso = n.anio_curso and unico = 0 and 'UNO' = rtrim(observacion)) 
				where fecha_impresion is null and observacion='UNO' and unico = 0					
end

else if @tipoconsulta=31
begin
select anio_curso as anio_valor  from notificacion where persona_ID=@persona  and activo=1 --and estado='G'
	group by anio_curso
end

else if @tipoconsulta=32
begin
	select notificacion_id as valor_id,('Cargo de notificación de valores Nro: '+cast(numero as varchar)+' - '+cast (anio_curso as varchar(4)))as descripcion
	from notificacion v 
	where persona_ID=@persona and anio_curso=@anio 	
end
else if @tipoconsulta=34
begin
--select * from det_notificacion
	select * from det_notificacion dn inner join valores v 
	on dn.valor_id=v.valor_id inner join tablas ta
	on v.tipo_valor=ta.valor 
	where dep_id='38' and dn.notificacion_id=@notificacion
end

	ELSE IF @tipoconsulta = 99
	BEGIN
			IF object_id( 'tempdb..#tempa1') IS NOT NULL drop table #tempa1;
			IF object_id( 'tempdb..#tempo1') IS NOT NULL drop table #tempo1;
			IF object_id( 'tempdb..#tempas1') IS NOT NULL drop table #tempas1;
			IF object_id( 'tempdb..#tempas_l1') IS NOT NULL drop table #tempas_l1;			
						
			SELECT * INTO #tempo1 
			FROM CuentaCorriente 
			WHERE  estado = 'P' AND tributo_id <> '0016' AND anio BETWEEN @anio1 AND @anio2					

			SELECT 
				(CASE WHEN tipo_tributo=1 THEN cargo-abono ELSE 0 END) AS predial,
				(CASE WHEN tipo_tributo=2 THEN cargo-abono ELSE 0 END) AS arbitrios,
				cargo,
				abono,
				cc.persona_id,
				c.razon_social as nombres,
				c.ruc as documento,				
				s.Descripcion as sector,
				c.direccCompleta as calle,
				c.c_num,
				c.c_mz,
				c.c_lote,		
				jv.junta_id,				
				t.tipo_tributo,
				jv.ubicacion_ID into #tempa1
			FROM #tempo1 cc 
			INNER JOIN contribuyente c ON cc.persona_id = c.persona_id
			INNER JOIN tributos t ON cc.tributo_id = t.tributos_id
			INNER JOIN junta_via jv ON c.junta_via_id = jv.junta_via_id
			INNER JOIN Sector s ON s.Sector_id = jv.junta_ID
			WHERE (jv.junta_id = @junta or @junta = 0) AND c.estado = '1'			

			SELECT 
				persona_id,
				nombres,
				documento,
				sector, 
				calle,
				c_num,
				c_mz,
				c_lote,
				sum(predial)as predial,
				sum(arbitrios) as arbitrios,
				junta_id, 
				ubicacion_id, 
				deuda = sum(cargo-abono) into #tempas1
			FROM #tempa1			
			WHERE tipo_tributo in ('1','2')
			GROUP BY persona_id, junta_id,ubicacion_id,nombres, documento, sector, calle, c_num, c_mz, c_lote
			ORDER BY deuda desc

			SELECT TOP (@nro) 
				cast(persona_id as int)as persona_id, 
				nombres,
				documento,
				sector, 
				calle,
				c_num,
				c_mz,
				c_lote,
				predial,
				arbitrios,
				junta_id, 
				deuda,
				ubicacion_id  INTO #tempas_l1
			FROM #tempas1
			ORDER BY deuda DESC				

			SELECT 
			--cast((row_number() over  ( order by c.deuda desc))as int)as rowss,
				c.persona_id as rowss,
				c.persona_id as persona_id,
				c.nombres,
				c.documento,
				doc.descripcion,
				c.sector, 
				c.calle,
				isnull(cast( c.c_num as int),0)as c_num,
				c.c_mz,
				c.c_lote, 
				c.predial,
				c.arbitrios,
				p.Fono_Domicilio,
				c.deuda
			FROM #tempas_l1 c 
			INNER JOIN persona p ON c.persona_id = p.persona_id
			INNER JOIN tablas doc ON doc.valor = p.tipo_documento
			WHERE doc.dep_id = 3
			ORDER BY deuda DESC
	END
	ELSE IF @tipoconsulta = 100
	BEGIN
		select t.descripcion as documento, cast(v.numero as varchar) as numero, v.predio as predio, 
		(case when c.direccCompleta is null then dbo._getDireccionFiscal(c.junta_via_ID,c.c_num,c.c_interior,c.c_mz,c.c_lote,c.c_edificio,c.c_piso,c.c_dpto,c.c_tienda,'')
		 else c.direccCompleta end) as ubicacion, (case when v.fecha_recep is null then '' else cast(v.fecha_recep as varchar) end) as fecha_recep, 
		 (case when v.fecha_vence is null then '' else cast(v.fecha_vence as varchar) end) as fecha_vence, sum(dv.deuda) as deuda, estado = case v.estado when 'G' then 'Generado'
		 when 'I' then 'Impreso' when 'N' then 'Notificado' end from valores v
			inner join det_valor dv on dv.valor_id = v.valor_id
			inner join Persona p on p.persona_ID = v.persona_ID
			inner join Contribuyente c on c.persona_ID = v.persona_ID
			inner join tablas t on t.valor = v.tipo_valor
		where v.persona_ID = @persona and t.dep_id = 38 and t.estado = 1 and t.valor in ('1','2','10','3')
		group by t.descripcion, v.numero, v.predio, dv.deuda, v.fecha_recep, v.fecha_vence, c.direccCompleta, c.junta_via_ID,c.c_num,c.c_interior,c.c_mz,c.c_lote,c.c_edificio,c.c_piso,c.c_dpto,c.c_tienda, v.estado	
	END
	ELSE IF @tipoconsulta = 101
	BEGIN
		select t.descripcion as documento, cast(v.numero as varchar) as numero, v.predio as predio, 
		(case when c.direccCompleta is null then dbo._getDireccionFiscal(c.junta_via_ID,c.c_num,c.c_interior,c.c_mz,c.c_lote,c.c_edificio,c.c_piso,c.c_dpto,c.c_tienda,'')
		 else c.direccCompleta end) as ubicacion, (case when v.fecha_recep is null then '' else cast(v.fecha_recep as varchar) end) as fecha_recep, 
		 (case when v.fecha_vence is null then '' else cast(v.fecha_vence as varchar) end) as fecha_vence, sum(dv.deuda) as deuda, estado = case v.estado when 'G' then 'Generado'
		 when 'I' then 'Impreso' when 'N' then 'Notificado' end from valores v
			inner join det_valor dv on dv.valor_id = v.valor_id
			inner join Persona p on p.persona_ID = v.persona_ID
			inner join Contribuyente c on c.persona_ID = v.persona_ID
			inner join tablas t on t.valor = v.tipo_valor
		where v.persona_ID = @persona and v.anio_curso = @anio and t.dep_id = 38 and t.estado = 1 and t.valor in ('1','2','10','3')
		group by t.descripcion, v.numero, v.predio, dv.deuda, v.fecha_recep, v.fecha_vence, c.direccCompleta, c.junta_via_ID,c.c_num,c.c_interior,c.c_mz,c.c_lote,c.c_edificio,c.c_piso,c.c_dpto,c.c_tienda, v.estado	
	END
	ELSE IF @tipoconsulta=102
	BEGIN
		set @aactual = dbo.getAnio()
		-- LISTANDO CONTRIBUYENTES
		if object_id( 'tempdb..#tempooo') is not null drop table #tempooo;
		if object_id( 'tempdb..#clienteoo') is not null drop table #clienteoo;
		if object_id( 'tempdb..#tempoo') is not null drop table #tempoo;
		if object_id( 'tempdb..#valorroo') is not null drop table #valorroo;
		
		select c.persona_id,t.tipo_tributo, sum( cargo-abono) as monto  into #clienteoo
		from contribuyente c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			inner join junta_via jv on c.junta_via_id  = jv.junta_via_id
		where c.persona_ID=@persona and fecha_vence+1 < getdate() and
			((tipo_tributo = 1 and  cc.anio  between @anio1 and @anio2 )
			or(tipo_tributo = 2 and  cc.anio  between @aniot and @aniof ))
			and t.tributos_id not in ('0016','0344')
			and cc.estado = 'P' and c.estado = 1 and cc.activo='1'
			and c.persona_id NOT IN(select persona_id from valores where anio_valor between @anio1 and 
				@anio2 and estado not in('O','A','F','C'))
		group by c.persona_id ,t.tipo_tributo
							
		select  t.tipo_valor,t.persona_id, predio_id, anio, t.deuda, insoluta, valor_id into #tempoo from (
			select '1' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, sum(cargo - abono)  as insoluta
			from #clienteoo c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @anio1 and @anio2 and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1 and
			 t.tributos_id not in ('0016','0344') and @tipovalor in (1,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
			union
			select '2' AS tipo_valor,c.persona_id, predio_id, anio, sum(cargo - abono) as deuda,  sum(cargo - abono) as  insoluta
			from #clienteoo c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @aniot and @aniof and t.tipo_tributo = '2' and cc.estado = 'P' and cc.activo = 1  and @tipovalor in (2,10) and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
			union			
			select '3' AS tipo_valor,  c.persona_id, predio_id, anio, sum(cargo - abono) as deuda, (dbo.calculo_predial_monto_anual(c.persona_id, anio))  as insoluta
			from #clienteoo c inner join CuentaCorriente cc on c.persona_id = cc.persona_id
			inner join tributos t on cc.tributo_id = t.tributos_id
			where cc.anio between @anio1 and @anio2 and t.tipo_tributo = '1' and cc.estado = 'P' and cc.activo = 1  and @tipovalor=3  and cc.activo=1
			group by c.persona_id, predio_id, cc.anio
		) as t 
		left join valores v on (t.persona_id = v.persona_id and t.predio_id = v.predio and v.tipo_valor = t.tipo_valor and anio_valor = t.anio 
		and v.estado not in ('A','F','C' ))
		where valor_id is null	
		--c.tipodoc = case t.tipo_valor when 1 then 'P' when 2 then 'A' when 3 then 'D' when 4 then 'Q' end  and 	
		-- INSERTANDO LOS VALORES		
		select @ult1=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=1
		select @ult2=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=2
		select @ult3=isnull(max(numero),0)from valores where anio_curso=@aactual and tipo_valor=3
		--
		select (row_number() over  ( order by persona_id))+@ult1 as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( t.persona_id, t.anio, t.predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor into #valorroo
		from #tempoo t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='1'
		 union
		 select (row_number() over  ( order by persona_id))+@ult2  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor
		from #tempoo t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		 where t.tipo_valor='2'
		union
		select (row_number() over  ( order by persona_id))+@ult3  as numero, @aactual as anio_curso, tipo_valor, persona_id, predio_id, 
		getdate() as femision, dbo.getautovaluo( persona_id, t.anio, predio_id ) as autovaluo, deuda, insoluta, 'G' as estado, formato_valores_ID as formato, 
		@usuario as usuario,  t.anio as anio_valor
		from #tempoo t 
		inner join formato_valores f on ( @aactual = f.anio and f.tipodoc = t.tipo_valor)
		where t.tipo_valor='3'		
		insert into valores (numero, anio_curso, tipo_valor, persona_id, predio, fecha_emision, autovaluo, deuda, 
		deuda_insoluta, estado,  formato_valores_id, create_user, anio_valor, registro_fecha_add, registro_pc_add )			
		select  numero,anio_curso,tipo_valor,persona_id,predio_id,femision,autovaluo,deuda,
		insoluta,estado,formato,usuario,anio_valor, GETDATE(), HOST_NAME()
		from #valorroo
		---- INSERTANDO LOS DETALLES DE VALOR
		insert into det_valor ( valor_id, cuenta_corriente_id, deuda, interes, estado)
		select v.valor_id, cuenta_corriente_id, (cargo-abono) as deuda, 0, '1' as estado 
		from valores v inner join #tempoo t on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id and v.anio_valor = t.anio and v.anio_curso = @aactual )
			inner join CuentaCorriente cc on ( v.persona_id = cc.persona_id and v.anio_valor = cc.anio and v.predio = cc.predio_id )
			inner join tributos tr on cc.tributo_id = tr.tributos_id 
		where cc.fecha_vence < getdate() and tr.tributos_id not in ('0016','0033','0035','0344') and cc.activo = 1 and cc.estado = 'P'  and v.estado='G'
				select @nro=isnull(max(numero),0) from notificacion where anio_curso=@aactual
				insert into notificacion (numero, anio_curso, persona_id, materia, observacion, create_user, fecha_genera, tipo_notificacion, unico ,suspendido)
				select  (row_number() over  ( order by persona_id ))+@nro as numero, @aactual as anio,  t.persona_id, '1' as materia, 
				'UNO' as obs, @usuario as usuario,  getdate() as fgenera, 1 as tipo, 
				0 as unico,0 as suspendido
				from #tempoo t group by t.persona_id	
				--INSERTANDO DETALLES DE CARGOS						
				insert into det_notificacion ( notificacion_id, valor_id )
				select n.notificacion_id, v.valor_id
				from #tempoo t 
				inner join valores v on (v.persona_id = t.persona_id and v.tipo_valor = t.tipo_valor and v.predio = t.predio_id and v.anio_valor = t.anio and v.anio_curso = @aactual  )
				inner join notificacion n on (t.persona_id = n.persona_id and tipo_notificacion = 1 and v.anio_curso = n.anio_curso and unico = 0 and 'UNO' = rtrim(observacion)  ) where v.estado not in ('a','n')
				select @nro = count(*)  from ( select persona_id from #tempoo group by persona_id ) as t				
				update notificacion set observacion = null from notificacion n inner join #tempoo t on (t.persona_id = n.persona_id and tipo_notificacion = 1 and n.anio_curso = n.anio_curso and unico = 0 and 'UNO' = rtrim(observacion)) 
				where fecha_impresion is null and observacion='UNO' and unico = 0	
	END


	else if @tipoconsulta=103
begin
--select * from det_notificacion
	select 	valor_ID,tipo_valor,t.descripcion as  tipo_valor_desc,c.razon_social as persona,
	numero as nroValor,anio_valor as anioValor,anio_curso as anioCurso,deuda_insoluta as monto 
	from valores v inner join tablas t on v.tipo_valor=t.valor
	inner join Contribuyente c on v.persona_ID=c.persona_id
	where fecha_recep <dateadd(dd,-21, GETDATE()) and t.dep_id=38 and v.estado  in('N')
end
else if @tipoconsulta=104
begin
	declare @cargo decimal(12,2)
	set @persona=(select persona_id from valores where valor_id=@valor)
	declare @abono decimal(12,2)
	declare @contri_coactivo_ID int
	declare @coactivo_cta_ID int
	SELECT @cargo=SUM(CARGO),@abono=SUM(ABONO)FROM det_valor DMA	
	INNER JOIN CuentaCorriente CC ON DMA.cuenta_corriente_id=CC.Cuenta_Corriente_ID
	WHERE valor_id =@valor 		

	INSERT INTO [dbo].[contri_coactivo]
           ([estado],[fecha_inicio],[fecha_fin],[persona_ID],[usuario_insert],
		   [fecha_insert],[usuario_delete],[fecha_delete] )
     VALUES
           (1,GETDATE(),null,@persona,@usuario,GETDATE(),null,null)
		   set @contri_coactivo_ID=@@IDENTITY	  
		
	INSERT INTO [dbo].[coactivo_cta]
           (interes,
		   [fecha_emision],[monto],[persona_ID],[contri_coactivo_ID],[estado]
           ,[grupo] ,[anio_ini],[anio_fin],[monto_tota])
     VALUES
           (
		   0,getdaTE(),@cargo,@persona,@contri_coactivo_ID,1,1,dbo.getAnio(),dbo.getAnio(),
		   @cargo)
		SET @coactivo_cta_ID=@@IDENTITY
	INSERT INTO [dbo].[coactivo_cta_corriente]
           ([coactivo_cta_ID]
           ,[monto_deuda]
           ,[monto_abono]
           ,[cuenta_corriente_ID])
    SELECT @coactivo_cta_ID,CC.cargo,CC.abono,CC.Cuenta_Corriente_ID 
	FROM det_valor DMA
	INNER JOIN CuentaCorriente CC ON DMA.cuenta_corriente_id=CC.Cuenta_Corriente_ID 
	WHERE valor_id =@valor 
	UPDATE Contribuyente SET  estado_cuentas=1 WHERE  persona_id=@persona
	UPDATE valores SET 
			estado='E',
			[registro_fecha_update] = GETDATE(),
			[registro_user_update] = @registro_user_update,
			[registro_pc_update] = HOST_NAME()
	WHERE valor_id=@valor
	END


else if @tipoconsulta=105
begin
--select * from det_notificacion
	select 	valor_ID,tipo_valor,t.descripcion as  tipo_valor_desc,c.razon_social as persona,
	numero as nroValor,anio_valor as anioValor,anio_curso as anioCurso,deuda_insoluta as monto 
	from valores v inner join tablas t on v.tipo_valor=t.valor
	inner join Contribuyente c on v.persona_ID=c.persona_id
	where t.dep_id=38 and v.estado in('G','I')	
end
else if @tipoconsulta=106
begin	
	UPDATE valores SET estado='N',
					fecha_recep=GETDATE(),
					[registro_fecha_update] = GETDATE(),
					[registro_user_update] = @registro_user_update,
					[registro_pc_update] = HOST_NAME()
	WHERE valor_id=@valor
	END

	else if @tipoconsulta=107
begin
--select * from det_notificacion
	select 	valor_ID,tipo_valor,t.descripcion as  tipo_valor_desc,c.razon_social as persona,
	numero as nroValor,anio_valor as anioValor,anio_curso as anioCurso,deuda_insoluta as monto 
	from valores v inner join tablas t on v.tipo_valor=t.valor
	inner join Contribuyente c on v.persona_ID=c.persona_id
	where t.dep_id=38 and v.estado in('N')
end
else if @tipoconsulta=108
begin	
	UPDATE valores SET 
					estado='A',
					[registro_fecha_update] = GETDATE(),
					[registro_user_update] = @registro_user_update,
					[registro_pc_update] = HOST_NAME()
	WHERE valor_id=@valor
	END
	else if @tipoconsulta=109
begin
--select * from det_notificacion
	select 	valor_ID,tipo_valor,t.descripcion as  tipo_valor_desc,c.razon_social as persona,
	numero as nroValor,anio_valor as anioValor,anio_curso as anioCurso,deuda_insoluta as monto 
	from valores v inner join tablas t on v.tipo_valor=t.valor
	inner join Contribuyente c on v.persona_ID=c.persona_id
	where t.dep_id=38 --and v.estado in('N')
end

ELSE IF @tipoconsulta = 110
	BEGIN
		select t.descripcion as documento, cast(v.numero as varchar) as numero, v.predio as predio, 
		(case when c.direccCompleta is null then dbo._getDireccionFiscal(c.junta_via_ID,c.c_num,c.c_interior,c.c_mz,c.c_lote,c.c_edificio,c.c_piso,c.c_dpto,c.c_tienda,'')
		 else c.direccCompleta end) as ubicacion, (case when v.fecha_recep is null then '' else cast(v.fecha_recep as varchar) end) as fecha_recep, 
		 (case when v.fecha_vence is null then '' else cast(v.fecha_vence as varchar) end) as fecha_vence, sum(dv.deuda) as deuda, estado = case v.estado when 'G' then 'Generado'
		 when 'I' then 'Impreso' when 'N' then 'Notificado' end from valores v
			inner join det_valor dv on dv.valor_id = v.valor_id
			inner join Persona p on p.persona_ID = v.persona_ID
			inner join Contribuyente c on c.persona_ID = v.persona_ID
			inner join tablas t on t.valor = v.tipo_valor
		where v.persona_ID = @persona and v.anio_curso = YEAR(GETDATE()) and t.dep_id = 38 and t.estado = 1 and t.valor in ('1','2','10','3')
		group by t.descripcion, v.numero, v.predio, dv.deuda, v.fecha_recep, v.fecha_vence, c.direccCompleta, c.junta_via_ID,c.c_num,c.c_interior,c.c_mz,c.c_lote,c.c_edificio,c.c_piso,c.c_dpto,c.c_tienda, v.estado	
	END
	end
--exec _Valo_ValoresCobranza @anio1=2016,@anio2=2016,@junta=0,@nro=10,@tipoconsulta=99

--delete det_notificacion
--delete notificacion 
--delete det_valor
--delete valores
--select * from valores

--select * from notificacion

--select persona_ID,sum(dv.deuda)as total from valores v inner join det_valor dv on v.valor_id=dv.valor_id
--group by persona_ID
--order by total desc

--exec [dbo].[_Valo_ValoresCobranza] @junta = 0, @anio1=2000,@anio2=2010,@nro=20,@tipoconsulta=5

--select sum(cargo-abono) from CuentaCorriente c  where persona_ID='3854' and anio between 2000 and 2010 and activo='1'
--and tributo_ID not in ('0016','0344')
--
--exec [dbo].[_Valo_ValoresCobranza] @junta = 0, @anio1=2000,@anio2=2010,@aniot=2000,@aniof=2010,@tipovalor=10,@usuario='admin',@tipoconsulta=28,@monto1=1000,@monto2=2000
--exec [dbo].[_Valo_ValoresCobranza] @junta = 0, @anio1=2000,@anio2=2010,@tipovalor=1,@usuario='admin',@tipoconsulta=30,@numero=20
--select * from valores
--select * from notificacion
--select dbo.getautovaluo( 1068     , 1995, '0'     )
--select * from Predio_auditoria
--delete det_notificacion
--delete notificacion
--delete det_notificacion
--delete notificacion
--delete det_valor
			


			--select cc.persona_id,jv.junta_id,ubicacion_id ,sum(cargo-abono)
			--from CuentaCorriente cc inner join contribuyente c on cc.persona_id = c.persona_id
			--inner join tributos t on cc.tributo_id = t.tributos_id
			--inner join junta_via jv on c.junta_via_id = jv.junta_via_id
			--where   c.estado = '1' and anio between 2000 and 2010 and cc.estado='P'
			--and cc.persona_ID='3854'
			--group by cc.persona_id,jv.junta_id,ubicacion_id 

			--select persona_id, junta_id,ubicacion_id, deuda = sum(cargo-abono) into #tempas
			--from #tempa
			--where tipo_tributo in ('1','2')
			--group by persona_id, junta_id,ubicacion_id order by deuda desc

			--select top (@nro) persona_id, junta_id, deuda,ubicacion_id  into #tempas_l
			--from #tempas
			--order by deuda desc
				

			--select c.persona_id, c.deuda, RTRIM((paterno+' '+materno+' '+nombres)) as nombres, c.junta_id, j.descripcion as DESCRIPCION
			--from #tempas_l c inner join persona p on c.persona_id = p.persona_id
			--inner join Sector j on (c.junta_id = j.Sector_id and c.ubicacion_id=j.ubicacion_id)
			--order by deuda desc



			--exec [dbo].[_Valo_ValoresCobranza] @junta = 2, @anio1=2010,@anio2=2016,@aniot=0,@aniof=0,@tipovalor=1,@usuario='admin',@tipoconsulta=28,@monto1=18000,@monto2=19000