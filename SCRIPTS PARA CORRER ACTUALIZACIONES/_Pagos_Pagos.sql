USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Pago_Pagos]    Script Date: 01/12/2016 12:29:44 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[_Pago_Pagos] 
@tipo int,
@tributo varchar(05)=null,
@pago_ID int = null,
@liquidacion_ID int=null,
@fraccionamiento_ID int=null,
@recibo_ID int=null,
@Pagante varchar(200)=null,
@MontoTotal decimal(18,2)=null,
@TipoPago char(3)=null,
@TasaCambio decimal(12,2)=null,
@CajeroCaja_ID int=null,
@persona_ID char(9)=null,
@estado bit=null,
@formaPago int=null,
@pagoSoles decimal(12,2)=null,
@pagoDolares decimal(12,2)=null,
@NroDocumento varchar(120)=null,
@periodo_ID int=null,
@nroConvenio int=null,
@nroCuota int=null,
@anio int=null,
@caja_ID int = null,
@cajero_ID char(9)=null,
@fecha_inicio datetime=null,
@fecha_fin datetime=null,
@predio_ID varchar(12)=null,
@detalleLiquidacion int=null
,@concepto varchar(100)=null
,@cantidad int=null
,@cod_voucher char(10)=null
--

,@documento varchar(25)=null
,@paterno varchar(250)=null
,@materno varchar(250)=null
,@nombres varchar(250)=null
,@usuario varchar(50)=null
as
begin
declare @maximo int=0
	if @tipo=1--Obtención de parámetros
		select fecha,precioVenta from Tasa_Cambio 
		where DATEPART(yy,GETDATE())=DATEPART(yy,fecha)
		and DATEPART(mm,GETDATE())=DATEPART(mm,fecha)
		and DATEPART(dd,GETDATE())=DATEPART(dd,fecha)
		and estado=1
	ELSE IF @TIPO=2--Pago Cabecera Liquidación
	begin
		set @maximo=(select max (cast(codigo_voucher as int))as cod from Pagos)
		insert into Pagos(FechaPago,idPeriodo,Pagante,MontoTotal,TipoPago,TasaCambio,CajeroCaja_Id,Persona_id,liquidacion_ID,Estado,NroCopias,codigo_voucher)
		values(getdate(),datepart(yy,getdate()),@Pagante,@MontoTotal,@TipoPago,@TasaCambio,@CajeroCaja_ID,@persona_ID,@liquidacion_ID,@estado,1,
		RIGHT('0000000000'+cast(@maximo+1 as varchar),10));
		select cast(@@IDENTITY as int)as ultimo
	end
	ELSE IF @TIPO=3--Pago Detalle Liquidación
	begin
		insert into Pagos_Detalle(Pagos_id,FormaPago,pago_soles,pago_dolares,NroDocumento)
		values(@pago_ID,@formaPago,@pagoSoles,@pagoDolares,@NroDocumento)
		select cast(@@IDENTITY as int)as ultimo
	end	
	ELSE IF @TIPO=4--Pago Detalle Liquidación Tributo
	begin
		insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes,clai_codigo)
		select @pago_ID,(dl.monto_abono+dl.monto_interes),cc.tributo_ID,cc.cuenta_corriente_ID,cc.anio,cc.mes,
		t.clai_codigo from Liquidacion l
		inner join DetalleLiquidacion dl on l.liquidacion_id=dl.liquidacion_ID
		inner join CuentaCorriente cc on dl.Cuenta_Corriente_ID=cc.cuenta_corriente_ID
		inner join tributos t on cc.tributo_ID =t.tributos_ID		
		where l.liquidacion_id=@liquidacion_ID
	end		
	ELSE IF @TIPO=5--Actualización de Cuenta Corriente
	begin
	declare @restante decimal(12,2)=0,
	@cta_cte int=0
		update CuentaCorriente set estado='C',abono=cargo,fecha_cancelacion=getdate() where cuenta_corriente_ID 
		in(
			select Cuenta_Corriente_ID from Liquidacion l inner join DetalleLiquidacion dl on l.liquidacion_id=dl.liquidacion_ID 
			where l.liquidacion_id=@liquidacion_ID and monto_deuda=monto_abono
		);
		select @cta_cte=Cuenta_Corriente_ID,@restante=monto_abono 
		from Liquidacion l inner join DetalleLiquidacion dl on l.liquidacion_id=dl.liquidacion_ID 
		where l.liquidacion_id=@liquidacion_ID and monto_deuda>monto_abono;
		update CuentaCorriente set abono=abono+@restante where cuenta_corriente_ID =@cta_cte;
		update Liquidacion set estado='C' where liquidacion_id=@liquidacion_ID;
	end		
	ELSE IF @TIPO=6--Listado de Años de fraccionamiento
	begin		
		select idPeriodo from fraccionamiento
		group by idPeriodo
		order by idPeriodo desc
	end	
	ELSE IF @TIPO=7--validar cuota a pagar
	begin		
		if (select count(*) from fraccionamiento f inner join crono_fraccionamiento cf 
		on f.fraccionamiento_id=cf.Fraccionamiento_id	where idPeriodo=@periodo_ID and Numero=@nroConvenio 
		and cf.NroCuota=@nroCuota and FechaPago is not null)>0--Letra ya pagada
				select -1 as resultado;
		else 
			if (select count(*) from fraccionamiento f inner join crono_fraccionamiento cf 
			on f.fraccionamiento_id=cf.Fraccionamiento_id	where idPeriodo=@periodo_ID and Numero=@nroConvenio
			and FechaPago is not null)<@nroCuota--Letra no disponible aun
				select 0 as resultado;
			else
				select 1 as resultado;--Conformidad
	end		
	ELSE IF @TIPO=8--Activar convenio fraccionamiento
	begin		
		update CuentaCorriente set estado='F' where cuenta_corriente_ID in
		(select cuenta_corriente_ID from fraccionamiento f 
		inner join det_fraccionamiento df on f.fraccionamiento_id=df.Fraccionamiento_id
		where f.fraccionamiento_id=@fraccionamiento_ID);
		update fraccionamiento set Estado='A' where fraccionamiento_id=@fraccionamiento_ID
	end		
	ELSE IF @TIPO=9--REGISTRAR PAGO DE CUOTA Y MODIFICAR CUENTA CORRIENTE
	begin		
		declare @fecha_aco datetime;
		declare @fecha_ven datetime;
		declare @cta_ int;
		declare @cob_int decimal(10,2);
		declare @tasa_int decimal(10,5);
		declare @deuda decimal(12,5);
		declare @interes decimal(12,5);
		declare @valorCuota decimal(12,5);
		declare @tribbb char(5);
		declare @an int;
		declare @me int;

		if @nroCuota=0 
		begin
			declare @derecho decimal(12,2)
			update CuentaCorriente set estado='F' where cuenta_corriente_ID in
			(select cuenta_corriente_ID from fraccionamiento f 
			inner join det_fraccionamiento df on f.fraccionamiento_id=df.Fraccionamiento_id

			where f.fraccionamiento_id=@fraccionamiento_ID);
			update fraccionamiento set Estado='A' where fraccionamiento_id=@fraccionamiento_ID
			select @derecho=tf.monto_derecho from fraccionamiento f
			inner join TipoFraccionamiento tf on f.tipo_fraccionamiento_ID=tf.tipo_fraccionamiento_ID
			where fraccionamiento_id=@fraccionamiento_ID
			if @derecho>0			
				insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,anio,mes,clai_codigo)
				values(@pago_ID,@derecho,'0148 ',datepart(yy,getdate()),datepart(mm,getdate()),
				'1.3. 2.10. 1.99')				
			end		
		select @valorCuota=amortizacion from crono_fraccionamiento 
		where Fraccionamiento_id=@fraccionamiento_ID and NroCuota=@nroCuota
		
		declare cuentas cursor for
		SELECT f.Fecha_Acogida,cc.fecha_vence, cc.cuenta_corriente_ID,df.cobro_interes,df.tasa_interes,(cc.cargo-cc.abono)as deuda,
		((CASE WHEN cc.fecha_vence<f.Fecha_Acogida THEN DATEDIFF(DAY,cc.fecha_vence,f.Fecha_Acogida)else 0 end)
		*df.cobro_interes*df.tasa_interes*(cargo-abono))as interes,cc.tributo_ID ,cc.anio,cc.mes
		FROM det_fraccionamiento DF
		INNER JOIN CuentaCorriente CC ON DF.Cuenta_Corriente_id=CC.cuenta_corriente_ID
		inner join fraccionamiento f on df.Fraccionamiento_id=f.fraccionamiento_id
		WHERE CC.estado='F' and f.fraccionamiento_id=@fraccionamiento_ID
		order by cc.anio,cc.mes,cc.tributo_ID


		OPEN cuentas
		FETCH cuentas INTO @fecha_aco, @fecha_ven,@cta_,@cob_int ,@tasa_int, @deuda ,@interes,@tribbb,@an,@me
		WHILE (@@FETCH_STATUS = 0)
		BEGIN	
		if @valorCuota>0
			begin
			if @valorCuota>@deuda+@interes
				begin			
					update CuentaCorriente set abono=cargo , estado='C',fecha_cancelacion=getdate() where cuenta_corriente_ID=@cta_
					set @valorCuota=@valorCuota - (@deuda+@interes)				
					insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes,
					clai_codigo,EsActual)
					select @pago_ID,@deuda+@interes,tributo_ID,cuenta_corriente_ID,anio,mes,
					(case 
			when t.clai_codigo='1.1. 2. 1. 1. 1' then 
				(case when datepart(yy,getdate())>anio then '1.1.2.1.1.2' else '1.1. 2. 1. 1. 1' end)
			when t.clai_codigo='1.3. 3. 9. 2.23.1' then 
				(case when datepart(yy,getdate())>anio then '1.3. 3. 9. 2.23.2' else '1.3. 3. 9. 2.23.1' end)
				else t.clai_codigo end),
				(case when DATEPART(yy,GETDATE())>anio then 0 else 1 end)
					 from CuentaCorriente cc
					inner join tributos t on  cc.tributo_ID=t.tributos_ID
					where cuenta_corriente_ID=@cta_

					--insert into pago_detalle_tributo (pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes,cantidad)
					--values(@pago_ID,@deuda,@tribbb,@cta_,@an,@me,1)

				end
				else
				begin
					if(@nroCuota=(select max(NroCuota) from crono_fraccionamiento where Fraccionamiento_id=@fraccionamiento_ID))
						begin
						update CuentaCorriente set abono=cargo , estado='C',fecha_cancelacion=getdate() 
						where cuenta_corriente_ID=@cta_					
						insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes)
						select @pago_ID,@deuda+@interes,tributo_ID,cuenta_corriente_ID,anio,mes from CuentaCorriente
						where cuenta_corriente_ID=@cta_

					--	insert into pago_detalle_tributo (pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes,cantidad)
					--	values(@pago_ID,@deuda,@tribbb,@cta_,@an,@me,1)


						end
					else
					begin
						update CuentaCorriente set abono=abono+dbo._getMontoEfectivoPago(@tasa_int,
						@valorCuota,@fecha_ven,@fecha_aco,@cob_int)where cuenta_corriente_ID=@cta_
						insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,
						cuenta_corriente_ID,anio,mes,cantidad,clai_codigo)
						select @pago_ID,@valorCuota,tributo_ID,cuenta_corriente_ID,anio,mes,1,t.clai_codigo from CuentaCorriente cc
						inner join Tributos t on cc.tributo_ID=t.tributos_ID
						where cuenta_corriente_ID=@cta_

						--insert into pago_detalle_tributo (pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes,cantidad)
						--values(@pago_ID,dbo._getMontoEfectivoPago(@tasa_int,
					--	@valorCuota,@fecha_ven,@fecha_aco,@cob_int),@tribbb,@cta_,@an,@me,1)

					end
					set @valorCuota=0				 
				end 
			end	
		FETCH cuentas INTO @fecha_aco, @fecha_ven,@cta_,@cob_int ,@tasa_int, @deuda ,@interes,@tribbb,@an,@me
		END 
		CLOSE cuentas
		DEALLOCATE cuentas 
		update crono_fraccionamiento set FechaPago=getdate()
		where Fraccionamiento_id=@fraccionamiento_ID and NroCuota=@nroCuota		
	end	
	ELSE IF @TIPO=10--Pago Cabecera fraccionamiento
	begin
	set @maximo=(select max (cast(codigo_voucher as int))as cod from Pagos)
		insert into Pagos(FechaPago,idPeriodo,Pagante,MontoTotal,TipoPago,TasaCambio,CajeroCaja_Id,Persona_id,
		fraccionamiento_ID,Estado,NroCopias,codigo_voucher)
		values(getdate(),datepart(yy,getdate()),@Pagante,@MontoTotal,@TipoPago,@TasaCambio,@CajeroCaja_ID,
		(select Persona_id from fraccionamiento where fraccionamiento_id=@fraccionamiento_ID),@fraccionamiento_ID,@estado,1,
		RIGHT('0000000000'+cast(@maximo+1 as varchar),10));
		select cast(@@IDENTITY as int)as ultimo

		
	end
	ELSE IF @TIPO=11--Pago cabecera fraccionamiento
	begin
		insert into Pagos_Detalle(Pagos_id,FormaPago,pago_soles,pago_dolares,NroDocumento)
		values(@pago_ID,@formaPago,@pagoSoles,@pagoDolares,@NroDocumento)
		select cast(@@IDENTITY as int)as ultimo
	end
	else if @tipo = 12 -- ConsultarPagos
	select p.Pagos_id,p.FechaPago,p.idPeriodo,p.Pagante,p.MontoTotal,p.TipoPago,p.TasaCambio,p.NroCopias,p.CajeroCaja_Id,p.Persona_id,
	isnull(p.liquidacion_ID,0) as liquidacion_ID ,isnull(p.fraccionamiento_ID,0) as fraccionamiento_ID ,isnull(p.OtroReferencia,' ') as OtroReferencia,p.Estado, 
	t.descripcion as tipoPago_descripcion, pe.NombreCompleto as CajeroNombre
	 from Pagos p inner join tablas t on p.TipoPago = t.valor
	 inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
	 inner join persona pe on cc.Persona_id = pe.persona_ID
	 where t.dep_id = 45
	 order by p.Pagante

	 else if @tipo = 13 --PagoDetalle
		select p.Pagos_Det_ID,p.Pagos_id,p.FormaPago,p.pago_soles,p.pago_dolares,p.NroDocumento, t.descripcion as formaPago_descripcion, PA.MontoTotal
		 from Pagos_Detalle p inner join tablas t on p.FormaPago = t.valor
		 inner join Pagos PA on PA.pagos_id = p.pagos_id
		 where t.dep_id = 46 and p.Pagos_id = @pago_ID
		
	else if @tipo = 14 -- Pago detalle tributo
		select p.pagos_det_ID,p.pagos_ID,p.monto_pago,p.tributos_ID,
		(case when p.cuenta_corriente_ID is null then 0 else p.cuenta_corriente_ID end )as cuenta_corriente_ID,p.anio,p.mes,p.cantidad,t.descripcion as tributo_descripcion
		 from pago_detalle_tributo p inner join Tributos t on p.tributos_ID = t.tributos_ID
		 where p.pagos_ID = @pago_ID
	ELSE IF @TIPO=15--Pago Cabecera Recibo
	begin
	declare @per int
	set @maximo=(select max (cast(codigo_voucher as int))as cod from Pagos)
	set @per=(select persona_id from recibo where recibo_id=@recibo_ID);
		insert into Pagos(FechaPago,idPeriodo,Pagante,MontoTotal,TipoPago,TasaCambio,CajeroCaja_Id,Persona_id,nro_Recibo,Estado,NroCopias,
		codigo_voucher)
		values(getdate(),datepart(yy,getdate()),@Pagante,@MontoTotal,@TipoPago,@TasaCambio,@CajeroCaja_ID,@per,
		@recibo_ID,@estado,1,RIGHT('0000000000'+cast(@maximo+1 as varchar),10));
		select cast(@@IDENTITY as int)as ultimo
	end
	ELSE IF @TIPO=16--Pago Detalle ReciboTributo
	begin
			insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes,clai_codigo,
			EsActual)
			select @pago_ID,(cc.cargo-cc.abono),cc.tributo_ID,cc.cuenta_corriente_ID,cc.anio,cc.mes,
			(case 
			when t.clai_codigo='1.1. 2. 1. 1. 1' then 
				(case when datepart(yy,getdate())>anio then '1.1.2.1.1.2' else '1.1. 2. 1. 1. 1' end)
			when t.clai_codigo='1.3. 3. 9. 2.23.1' then 
				(case when datepart(yy,getdate())>anio then '1.3. 3. 9. 2.23.2' else '1.3. 3. 9. 2.23.1' end)
				else t.clai_codigo end),
				(case when DATEPART(yy,GETDATE())>anio then 0 else 1 end)
			 from det_recibo dr 
			inner join CuentaCorriente cc on dr.cuenta_corriente_id=cc.cuenta_corriente_ID
			inner join Tributos t on cc.tributo_ID=t.tributos_ID 
			where dr.recibo_id=@recibo_ID

			update CuentaCorriente set abono=cargo , estado='C',fecha_cancelacion=getdate()
			where cuenta_corriente_ID in (select cuenta_corriente_ID from det_recibo where recibo_id=@recibo_ID)

			update recibo set estado='C' where recibo_id=@recibo_ID			
	end
	else if @tipo = 17 -- prueba estadistica de monto pagado por tributo y año
	select sum(pt.monto_pago) as total,t.descripcion as tributo from pago_detalle_tributo pt
	inner join Tributos t on pt.tributos_ID = t.tributos_ID
	where pt.anio = @anio
	group by t.descripcion
	ELSE IF @TIPO=18--Cargar tasas
	begin
		select tributos_ID as codigo,rtrim(descripcion)as descripcion from Tributos where  activo=1
		order by descripcion
	end
	ELSE IF @TIPO=19--Cargar tasas
	begin
		select importe from Tributos where tributos_ID=@tributo
	end
	ELSE IF @TIPO=20--Pago Cabecera Recibo
	begin
	set @maximo=(select max (cast(codigo_voucher as int))as cod from Pagos)
		insert into Pagos(FechaPago,idPeriodo,Pagante,MontoTotal,TipoPago,TasaCambio,CajeroCaja_Id,Persona_id,Estado,NroCopias,
		codigo_voucher)
		values(getdate(),datepart(yy,getdate()),@Pagante,@MontoTotal,@TipoPago,@TasaCambio,@CajeroCaja_ID,@Persona_id,
		@estado,1,RIGHT('0000000000'+cast(@maximo+1 as varchar),10));
		select cast(@@IDENTITY as int)as ultimo
	end
	ELSE IF @TIPO=21--Pago Detalle otros pagos
	begin
			insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,anio,mes,clai_codigo,descripcion,cantidad)
			select @pago_ID,@MontoTotal,tributos_ID,DATEPART(yy,GETDATE()),(DATEPART(mm,GETDATE())),clai_codigo,@concepto ,@cantidad
			from tributos where tributos_ID=@tributo
	end
	ELSE IF @TIPO=22--Pago Detalle otros pagos
	begin		

		select @maximo=max(cast(persona_ID as int))+1 from Persona
			insert into Persona (persona_ID,tipo_persona,tipo_documento,documento,paterno,materno,nombres,NombreCompleto,
			registro_fecha_add,registro_user_add,registro_pc_add,ESTADO,junta_via_ID,ubi_codigo,sexo)
			values(cast(@maximo as char(9)),1,1,@documento,@paterno,@materno,@nombres,
			@paterno+' '+@materno+' '+@nombres,GETDATE(),@usuario,HOST_NAME(),1,5445,'130107','M')
			select @maximo as ultimo
	end
	ELSE IF @TIPO=23--Pago Detalle otros pagos
	begin
		select f.fraccionamiento_id,Fecha_Acogida,Cuotas,ValorCuota,(select count(*) from crono_fraccionamiento cf
		where cf.Fraccionamiento_id=f.fraccionamiento_id and NroCuota!=0 and FechaPago is null and FechaVence<getdate())as 
		cuotasVencidas from fraccionamiento f where Persona_id=@persona_ID
	end
	ELSE IF @TIPO=24--Pago Detalle otros pagos
	begin
		select NroCuota,Importe,FechaVence from crono_fraccionamiento where FechaPago is null and Fraccionamiento_id=@fraccionamiento_ID
		order by NroCuota
	end
	ELSE IF @TIPO=25
	begin
		declare @res int=0
		if(select count(*) from Persona where nombres=@nombres and paterno=@paterno and materno=@materno)>0
			set @res=1
		if(select count(*) from Persona where documento=@documento)>0
			set @res=2
		select @res as resultado
	end
	else if @tipo = 26
	begin
	if @Caja_ID = 0 and @TipoPago = '0' and @cajero_ID = '0'
		select p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		 t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.Persona_id = @persona_ID
		 order by p.FechaPago

	 else if @Caja_ID > 0 and @TipoPago = '0' and @cajero_ID = 0
		select p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and cc.Caja_Id = @Caja_ID and p.Persona_id = @persona_ID
		 order by p.FechaPago

	 else if @Caja_ID > 0 and @TipoPago = '0' and @cajero_ID <> '0'
		select p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on t.valor = p.TipoPago
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and cc.Caja_id = @caja_ID and cc.Persona_id = @cajero_ID
		 and p.Persona_id = @persona_ID
		 order by p.FechaPago 

	 else if @caja_ID = 0 and @TipoPago <> '0' and @cajero_ID = '0'
		select p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.TipoPago = @TipoPago and p.Persona_id = @persona_ID
		order by p.FechaPago

	else if @caja_ID = 0 and @TipoPago <> '0' and @cajero_ID <>'0'
		select p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id and p.Persona_id = @persona_ID
		inner join tablas t on p.TipoPago = t.valor
		where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.TipoPago = @TipoPago and cc.Persona_id = @cajero_ID
		and p.Persona_id = @persona_ID
		order by p.FechaPago

	else if @caja_ID = 0 and @TipoPago = '0' and @cajero_ID <>'0'
		select p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and cc.Persona_id = @cajero_ID and p.Persona_id = @persona_ID
		 order by p.FechaPago

	else if @caja_ID > 0 and @TipoPago <>'0' and @cajero_ID <>'0'
		select p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.TipoPago = @TipoPago and cc.Caja_id = @caja_ID 
		 and cc.Persona_id = @cajero_ID and p.Persona_id = @persona_ID
		 order by p.FechaPago
	 end
	else if @tipo = 27
			select pd.anio,pd.tributos_ID,t.descripcion as tributo_descripcion,
			(select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=1
			 and pdt.pagos_ID = pd.pagos_ID
			 )as enero,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=2  and pdt.pagos_ID = pd.pagos_ID)as febrero,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=3  and pdt.pagos_ID = pd.pagos_ID)as marzo,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=4  and pdt.pagos_ID = pd.pagos_ID)as abril,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=5  and pdt.pagos_ID = pd.pagos_ID)as mayo,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=6  and pdt.pagos_ID = pd.pagos_ID)as junio,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=7  and pdt.pagos_ID = pd.pagos_ID)as julio,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=8  and pdt.pagos_ID = pd.pagos_ID)as agosto,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=9  and pdt.pagos_ID = pd.pagos_ID)as setiembre,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=10  and pdt.pagos_ID = pd.pagos_ID)as octubre,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=11  and pdt.pagos_ID = pd.pagos_ID)as noviembre,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=12  and pdt.pagos_ID = pd.pagos_ID)as diciembre,SUM(pd.monto_pago) as total
			 from pago_detalle_tributo pd inner join tributos t on pd.tributos_ID = t.tributos_ID
			where pagos_ID = @pago_ID
			
			group by pd.anio,pd.tributos_ID ,t.descripcion,pd.pagos_ID
	else if @tipo = 28
			select sum(monto_pago)  as total from pago_detalle_tributo where pagos_ID = @pago_ID

	ELSE IF @tipo = 29 --Consultar Pagos por fechas
	BEGIN		
		SELECT p.Pagos_id,
			   p.FechaPago,
			   p.idPeriodo,
			   p.Pagante,
			   p.MontoTotal,
			   p.TipoPago,
			   p.TasaCambio,
			   p.NroCopias,
			   p.CajeroCaja_Id,
			   p.Persona_id,
			   isnull(p.liquidacion_ID,0) as liquidacion_ID, 
			   isnull(p.fraccionamiento_ID,0) as fraccionamiento_ID,
			   isnull(p.OtroReferencia,' ') as OtroReferencia, 
			   p.Estado, 
			   t.descripcion as tipoPago_descripcion,
			   pe.NombreCompleto as CajeroNombre,
			   p.codigo_voucher as voucher
		FROM Pagos p 
		INNER JOIN tablas t ON p.TipoPago = t.valor
		INNER JOIN CajeroCaja cc ON p.CajeroCaja_Id = cc.CajeroCaja_id
		INNER JOIN persona pe ON cc.Persona_id = pe.persona_ID		
		WHERE t.dep_id = 45 and (p.FechaPago >= @fecha_inicio  and p.FechaPago <= dateadd(dd,1,@fecha_fin))
		ORDER BY CAST(P.codigo_voucher AS INT)DESC
	END
	ELSE IF @tipo = 30
	BEGIN
		SELECT 
			   p.Pagos_id,
			   CONCAT(DATENAME(month , DateAdd( month , pd.mes, 0 ) - 1), ' - ', pd.anio) AS 'fecha',
			   p.idPeriodo,
			   p.Persona_id,
			   p.Pagante,
			   pd.monto_pago,
			   p.TipoPago,			   
			   t.descripcion as tipoPago_descripcion,	
			   p.TasaCambio,
			   p.NroCopias,
			   p.CajeroCaja_Id,
			   pe.NombreCompleto as CajeroNombre,			   
			   isnull(p.liquidacion_ID,0) as liquidacion_ID, 
			   isnull(p.fraccionamiento_ID,0) as fraccionamiento_ID,
			   isnull(p.OtroReferencia,' ') as OtroReferencia, 
			   p.Estado			   
		FROM Pagos p 
		INNER JOIN pago_detalle_tributo PD ON PD.pagos_ID = p.Pagos_id
		INNER JOIN tablas t ON p.TipoPago = t.valor
		INNER JOIN CajeroCaja cc ON p.CajeroCaja_Id = cc.CajeroCaja_id
		INNER JOIN persona pe ON cc.Persona_id = pe.persona_ID
		WHERE t.dep_id = 45 and 
		(pd.anio*100 + pd.mes) between datepart(yy, @fecha_inicio)*100 + datepart(mm, @fecha_inicio) and
		datepart(yy, @fecha_fin)*100 + datepart(mm, @fecha_fin)
		ORDER BY pd.anio, pd.mes
	END
	ELSE IF @TIPO=31--Cargar tasas
	begin
	--select * from conceptosAgrupados
		select isnull(sum(montoTotal),0)as importe from conceptosAgrupados where tipo=@tributo and estado=1
	end
	ELSE IF @TIPO=32 --Pago Detalle otros pagos
	begin
			insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,anio,mes,clai_codigo)
			select @pago_ID,montoTotal,tributo_ID,DATEPART(yy,GETDATE()),(DATEPART(mm,GETDATE())),clai_codigo 
			from conceptosAgrupados where tipo=@tributo and estado=1			
	end
	ELSE IF @TIPO=33-- Obtener persona
	begin
			select isnull(razon_social,'_1234567890')as razon_social from Contribuyente where persona_id=@persona_ID
	end
	ELSE IF @TIPO=34-- Cargar Años
	begin
				select anioGeneracion from certificado_alcabala ca 
			inner join CuentaCorriente cc on ca.Cuenta_Corriente_ID=cc.Cuenta_Corriente_ID where 
			cc.estado='P' and cc.persona_ID=@persona_ID group by anioGeneracion
	end
	ELSE IF @TIPO=35-- Cargar alcabalas
	begin
			select cc.predio_id as predio from certificado_alcabala ca 
			inner join CuentaCorriente cc on ca.Cuenta_Corriente_ID=cc.Cuenta_Corriente_ID 
			where 
			cc.estado='P' and cc.persona_ID=@persona_ID and cc.anio=@anio group by cc.predio_id
	end
	ELSE IF @TIPO=36-- Cargar alcabalas
	begin
			select cc.cargo from certificado_alcabala ca 
			inner join CuentaCorriente cc on ca.Cuenta_Corriente_ID=cc.Cuenta_Corriente_ID 
			where 
			cc.estado='P' and cc.persona_ID=@persona_ID and cc.anio=@anio and cc.predio_ID=@predio_ID 
	end
	ELSE IF @TIPO=37-- Cargar alcabalas
	begin
			select isnull(V_NombrePersona,'_1234567890')as razon_social from SysNeo.dbo.RC_RECIBO_PARTIDA  where I_Recibo_Numero=@recibo_ID
			and C_Recibo_Anio=@anio and I_Recibo_Estado=0
	end
	ELSE IF @TIPO=38-- Cargar alcabalas
	begin
			select D_Partida_Costo*I_Formatos as cargo from SysNeo.dbo.RC_RECIBO_PARTIDA  where I_Recibo_Numero=@recibo_ID
			and C_Recibo_Anio=@anio and I_Recibo_Estado=0
	end
	ELSE IF @TIPO=39--Pago Cabecera Recibo
	begin
		set @maximo=(select max (cast(codigo_voucher as int))as cod from Pagos)

		insert into Pagos(FechaPago,idPeriodo,Pagante,MontoTotal,TipoPago,TasaCambio,CajeroCaja_Id,Persona_id,Estado,NroCopias,
		codigo_voucher)
		values(getdate(),datepart(yy,getdate()),@Pagante,@MontoTotal,@TipoPago,@TasaCambio,@CajeroCaja_ID,
		@Persona_id,@estado,1,RIGHT('0000000000'+cast(@maximo+1 as varchar),10));
		select cast(@@IDENTITY as int)as ultimo
	end
	ELSE IF @TIPO=40
	begin
		insert into Pagos(FechaPago,idPeriodo,Pagante,MontoTotal,TipoPago,TasaCambio,CajeroCaja_Id,Persona_id,Estado,NroCopias)
		values(getdate(),datepart(yy,getdate()),@Pagante,@MontoTotal,@TipoPago,@TasaCambio,@CajeroCaja_ID,@Persona_id,@estado,1);
		select cast(@@IDENTITY as int)as ultimo
	end
	ELSE IF @TIPO=41 --
	begin
			insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,anio,mes,clai_codigo,cuenta_corriente_ID)
			select @pago_ID,cargo,tributo_ID,DATEPART(yy,GETDATE()),(DATEPART(mm,GETDATE())),clai_codigo,Cuenta_Corriente_ID  from CuentaCorriente cc 
			inner join Tributos t on cc.tributo_ID=t.tributos_ID where predio_ID=@predio_ID and persona_ID=@persona_ID 
			and anio=@anio and tributo_ID='0038'
			update CuentaCorriente set estado='C',abono=cargo where predio_ID=@predio_ID and persona_ID=@persona_ID 
			and anio=@anio and tributo_ID='0038'
	end
	ELSE IF @TIPO=42
	begin
		set @maximo=(select max (cast(codigo_voucher as int))as cod from Pagos)
		insert into Pagos(FechaPago,idPeriodo,Pagante,MontoTotal,TipoPago,TasaCambio,CajeroCaja_Id,Persona_id,Estado,NroCopias,
		codigo_voucher)
		values(getdate(),datepart(yy,getdate()),@Pagante,@MontoTotal,@TipoPago,@TasaCambio,@CajeroCaja_ID,
		'0',@estado,1,RIGHT('0000000000'+cast(@maximo+1 as varchar),10));
		select cast(@@IDENTITY as int)as ultimo
	end
	ELSE IF @TIPO=43
	begin
		insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,anio,mes,clai_codigo,descripcion)		
		values (@pago_ID,@MontoTotal,'0344 ',DATEPART(yy,GETDATE()),(DATEPART(mm,GETDATE())),'1.3. 2. 1. 1. 5',
		'PARTIDAS')
		update SysNeo.dbo.RC_RECIBO_PARTIDA set I_Recibo_Estado=1 where I_Recibo_Numero=@recibo_ID
		and C_Recibo_Anio=@anio
	end
	ELSE IF @TIPO=44--listado de registros
	begin		
		select dl.Cuenta_Corriente_ID,dl.DetalleLiquidacion,(dl.monto_abono+dl.monto_interes)as  MontoPago from Liquidacion l
		inner join DetalleLiquidacion dl on l.liquidacion_id=dl.liquidacion_ID
		where l.liquidacion_id=@liquidacion_ID
	end	
	ELSE IF @TIPO=45--Pago Detalle Liquidación Tributo
	begin
		insert into pago_detalle_tributo(pagos_ID,monto_pago,tributos_ID,cuenta_corriente_ID,anio,mes,clai_codigo,EsActual)
		select @pago_ID,(dl.monto_abono+dl.monto_interes),cc.tributo_ID,cc.cuenta_corriente_ID,cc.anio,cc.mes,
		(case 
			when t.clai_codigo='1.1. 2. 1. 1. 1' then 
				(case when datepart(yy,getdate())>anio then '1.1.2.1.1.2' else '1.1. 2. 1. 1. 1' end)
			when t.clai_codigo='1.3. 3. 9. 2.23.1' then 
				(case when datepart(yy,getdate())>anio then '1.3. 3. 9. 2.23.2' else '1.3. 3. 9. 2.23.1' end)
				else t.clai_codigo end),
				(case when DATEPART(yy,GETDATE())>anio then 0 else 1 end)
		 from Liquidacion l
		inner join DetalleLiquidacion dl on l.liquidacion_id=dl.liquidacion_ID		
		inner join CuentaCorriente cc on dl.Cuenta_Corriente_ID=cc.cuenta_corriente_ID
		inner join Tributos t on cc.tributo_ID=t.tributos_ID
		where dl.DetalleLiquidacion=@detalleLiquidacion
		update Pagos set MontoTotal=MontoTotal+(select monto_abono+monto_interes from DetalleLiquidacion 
		where DetalleLiquidacion=@detalleLiquidacion)where Pagos_id=@pago_ID
	end
	ELSE IF @TIPO=46--Anular Pago
	begin
		update p set p.pago_soles=0,pago_dolares=0
		from Pagos_Detalle p  inner join Pagos pa on p.Pagos_id=pa.Pagos_id
		where pa.codigo_voucher=@cod_voucher
		UPDATE a 
		SET a.abono= a.abono- b.monto_pago,a.estado='P',a.fecha_cancelacion=null
		FROM CuentaCorriente a INNER JOIN pago_detalle_tributo b 
		ON a.Cuenta_Corriente_ID = b.cuenta_corriente_ID 
		inner join Pagos pa on b.pagos_ID=pa.Pagos_id
		WHERE pa.codigo_voucher = @cod_voucher
		update pdt set pdt.monto_pago=0
		from  pago_detalle_tributo pdt inner join Pagos p
		on pdt.pagos_ID=p.Pagos_id
		where p.codigo_voucher=@cod_voucher
		update Pagos set MontoTotal=0 where codigo_voucher=@cod_voucher

--		update pago_detalle_tributo set monto_pago=0 where pagos_ID =733070)
	end
	else if @tipo = 47
	begin
	if @Caja_ID = 0 and @TipoPago = '0' and @cajero_ID = '0'
		select TOP 10 p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		 t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.Persona_id = @persona_ID
		 order by p.FechaPago desc 

	 else if @Caja_ID > 0 and @TipoPago = '0' and @cajero_ID = 0
		select TOP 10 p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and cc.Caja_Id = @Caja_ID and p.Persona_id = @persona_ID
		 order by p.FechaPago desc

	 else if @Caja_ID > 0 and @TipoPago = '0' and @cajero_ID <> '0'
		select TOP 10 p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on t.valor = p.TipoPago
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and cc.Caja_id = @caja_ID and cc.Persona_id = @cajero_ID
		 and p.Persona_id = @persona_ID
		 order by p.FechaPago desc

	 else if @caja_ID = 0 and @TipoPago <> '0' and @cajero_ID = '0'
		select TOP 10 p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.TipoPago = @TipoPago and p.Persona_id = @persona_ID
		order by p.FechaPago desc

	else if @caja_ID = 0 and @TipoPago <> '0' and @cajero_ID <>'0'
		select TOP 10 p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id and p.Persona_id = @persona_ID
		inner join tablas t on p.TipoPago = t.valor
		where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.TipoPago = @TipoPago and cc.Persona_id = @cajero_ID
		and p.Persona_id = @persona_ID
		order by p.FechaPago desc

	else if @caja_ID = 0 and @TipoPago = '0' and @cajero_ID <>'0'
		select TOP 10 p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and cc.Persona_id = @cajero_ID and p.Persona_id = @persona_ID
		 order by p.FechaPago desc

	else if @caja_ID > 0 and @TipoPago <>'0' and @cajero_ID <>'0'
		select TOP 10 p.Pagos_id,p.codigo_voucher as nro_Recibo,cast(p.FechaPago as date) as fechaPago ,convert(varchar,p.fechaPago,108) as hora ,
		t.descripcion as tipo, p.MontoTotal,case when p.vez > 1 then 'SI' else 'NO' end as recibo_usado,p.NroCopias
		 from Pagos p inner join CajeroCaja cc on p.CajeroCaja_Id = cc.CajeroCaja_id
		 inner join tablas t on p.TipoPago = t.valor
		 where t.dep_id = 45 and p.FechaPago between @fecha_inicio and @fecha_fin and p.TipoPago = @TipoPago and cc.Caja_id = @caja_ID 
		 and cc.Persona_id = @cajero_ID and p.Persona_id = @persona_ID
		 order by p.FechaPago desc 
	 end
	--select * from certificado_alcabala
	--select * from tributos where tributos_id='0128'
	--update CuentaCorriente set estado='P' where Cuenta_Corriente_ID=1882760
	--select * from Tributos where descripcion like '%civil%'
	ELSE IF @TIPO=48--Pago Detalle Liquidación Tributo
	begin
		select pd.anio,pd.tributos_ID,t.descripcion as tributo_descripcion,
			(select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=1
			 and pdt.pagos_ID = pd.pagos_ID
			 )as enero,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=2  and pdt.pagos_ID = pd.pagos_ID)as febrero,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=3  and pdt.pagos_ID = pd.pagos_ID)as marzo,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=4  and pdt.pagos_ID = pd.pagos_ID)as abril,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=5  and pdt.pagos_ID = pd.pagos_ID)as mayo,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=6  and pdt.pagos_ID = pd.pagos_ID)as junio,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=7  and pdt.pagos_ID = pd.pagos_ID)as julio,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=8  and pdt.pagos_ID = pd.pagos_ID)as agosto,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=9  and pdt.pagos_ID = pd.pagos_ID)as setiembre,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=10  and pdt.pagos_ID = pd.pagos_ID)as octubre,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=11  and pdt.pagos_ID = pd.pagos_ID)as noviembre,
			 (select (case when(cast(isnull(sum(pdt.monto_pago),0)as varchar))='0.00'then '0.00'
			else cast(isnull(sum(pdt.monto_pago),0)as varchar)end)			 
			 from pago_detalle_tributo pdt where pdt.anio=pd.anio and pdt.mes=12  and pdt.pagos_ID = pd.pagos_ID)as diciembre,SUM(pd.monto_pago) as total, 
			 (select CC.predio_ID from cuentaCorriente CC INNER JOIN pago_detalle_tributo PDT on PDT.Cuenta_corriente_id = CC.Cuenta_corriente_id where PDT.pagos_ID = @pago_ID group by cc.predio_ID) AS predio,
			 (select PA.direccion_completa from cuentaCorriente CC INNER JOIN pago_detalle_tributo PDT on PDT.Cuenta_corriente_id = CC.Cuenta_corriente_id	INNER JOIN Predio PA ON PA.predio_ID = CC.predio_ID where PDT.pagos_ID = @pago_ID group by PA.direccion_completa) AS Direccion_Predio
			 from pago_detalle_tributo pd inner join tributos t on pd.tributos_ID = t.tributos_ID
			 --INNER JOIN cuentaCorriente CC ON CC.Cuenta_corriente_id = PD.Cuenta_corriente_id
			where PD.pagos_ID = @pago_ID
			
			group by pd.anio,pd.tributos_ID ,t.descripcion,pd.pagos_ID--,CC.predio_ID
	end
	ELSE IF @TIPO=49--Pago Detalle Liquidación Tributo
	begin
		select clai_codigo as codigo,rtrim(descripcion)as descripcion from Tributos where  activo=1
		order by descripcion 
	end
	ELSE IF @TIPO=50--Pago Detalle Liquidación Tributo
	begin
		
		select Pagos_id, fechaPago as FechaPago,  Pagante, MontoTotal, codigo_voucher as voucher from pagos where codigo_voucher = @cod_voucher and MontoTotal != '0.00'

	end
end
