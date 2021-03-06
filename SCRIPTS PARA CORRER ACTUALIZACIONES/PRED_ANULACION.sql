USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Pred_Anulacion]    Script Date: 18/01/2017 9:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[_Pred_Anulacion] 
	@persona_id			char(9) = null,
	@anulacion_id		int			= null,
	@tributos_ID		char(5)		= null,
	@observacion		varchar(1000)=	null,
	@anioInicio			smallint 	= null,
	@mesInicio			smallint 	= null,
	@anioFin			smallint 	= null,
	@mesFin				smallint 	= null,
	@registro_fecha_add datetime	= null,
	@registro_pc_add	varchar(40)	= null,
	@registro_user_add	varchar(40)	= null,
	@tipoAnulacion		char(1)		= null,
	@detaAnulacion_id	int = null,
	@cuentaCorriente_id int  = null,
	@montoDeuda			decimal(10, 2) = null,
	@montoAbono			decimal(10, 2) = null,
	@mes				smallint = null,
	@anio				smallint = null,
	@periodo			int = null,
	@predio_id			   char(16) = null,
	@tipoConsulta tinyint	 
AS
	SET NOCOUNT ON
	IF @tipoConsulta = 1  --INSERT ANULACION
	BEGIN
		INSERT INTO Anulacion
		(
			tributos_ID, 
			observacion, 
			anioInicio, 
			mesInicio, 
			anioFin, 
			mesFin, 
			registro_fecha_add, 
			registro_pc_add,
			registro_user_add, 
			tipoAnulacion,
			persona_id
		)
		VALUES
		(
		     @tributos_ID, 
			 @observacion, 
			 @anioInicio,
			 @mesInicio, 
			 @anioFin, 
			 @mesFin, 
			 GETDATE(), 
			 HOST_NAME(), 
			 @registro_user_add, 
			 @tipoAnulacion,
			 @persona_id
		)
		
		--SET @anulacion_id = (SELECT TOP 1 anulacion_id FROM Anulacion ORDER BY anulacion_id DESC)		
		--SET @montoDeuda = (SELECT cargo FROM CuentaCorriente WHERE Cuenta_Corriente_ID = @cuentaCorriente_id)
		--SET @montoAbono = (SELECT abono FROM CuentaCorriente WHERE Cuenta_Corriente_ID = @cuentaCorriente_id)
		--SET @mes = (SELECT mes FROM CuentaCorriente WHERE Cuenta_Corriente_ID = Cuenta_Corriente_ID)
		--SET @anio = (SELECT anio FROM CuentaCorriente WHERE Cuenta_Corriente_ID = Cuenta_Corriente_ID)
		SET @anulacion_id = @@IDENTITY

		INSERT INTO Detalle_Anulacion 
		(	
			anulacion_id, 
			cuentaCorriente_id, 
			montoDeuda, 
			montoAbono, 
			mes, 
			anio
		)
		SELECT @anulacion_id, Cuenta_Corriente_ID, cargo, abono, mes, anio 
		FROM CuentaCorriente 
		WHERE 
		(CAST('3'+'-'+CAST(mes AS VARCHAR(2))+'-'+CAST(anio AS VARCHAR(4)) as datetime) 
		   between CAST('1'+'-'+CAST(@mesInicio AS VARCHAR(2))+'-'+CAST(@anioInicio AS VARCHAR(4)) as datetime) 
		   and CAST('3'+'-'+CAST(@mesFin AS VARCHAR(2))+'-'+CAST(@anioFin AS VARCHAR(4)) as datetime)
			)
			and persona_ID=@persona_id and tributo_ID=@tributos_ID and estado='P' and predio_ID = @predio_id

		UPDATE CuentaCorriente SET  estado=@tipoAnulacion
		Where (cast('3'+'-'+CAST(mes AS VARCHAR(2))+'-'+CAST(anio AS VARCHAR(4)) as datetime) 
		   between cast('1'+'-'+CAST(@mesInicio AS VARCHAR(2))+'-'+CAST(@anioInicio AS VARCHAR(4)) as datetime) 
		   and cast('3'+'-'+CAST(@mesFin AS VARCHAR(2))+'-'+CAST(@anioFin AS VARCHAR(4)) as datetime)
			)
			and persona_ID=@persona_id   and tributo_ID=@tributos_ID and estado='P' AND predio_ID = @predio_id

		---------
		SELECT @anulacion_id
	END	
	IF @tipoConsulta = 2 --LISTAR ANULACIONES
	BEGIN
		IF @tributos_ID = '0008'
		BEGIN
			SELECT A.persona_id, P.NombreCompleto, A.anulacion_id, A.tributos_ID, 
					T.descripcion, A.observacion, A.anioInicio, 
					A.mesInicio, A.anioFin, A.mesFin, A.tipoAnulacion, TA.descripcion as 'Tipo Anulacion'
			FROM Anulacion A
			INNER JOIN Tributos T ON T.tributos_ID = A.tributos_ID
			INNER JOIN Persona P ON P.persona_ID = A.persona_id
			INNER JOIN tablas TA ON TA.abrev = A.tipoAnulacion
			WHERE A.tributos_ID = '0008' AND A.persona_id = @persona_id 
			AND DATEPART(YY, A.registro_fecha_add) = @periodo AND TA.dep_id = 50
		END
		ELSE IF @tributos_ID = '0043'
		BEGIN
		    SELECT A.persona_id, P.NombreCompleto, A.anulacion_id, A.tributos_ID, 
					T.descripcion, A.observacion, A.anioInicio, 
					A.mesInicio, A.anioFin, A.mesFin, A.tipoAnulacion, TA.descripcion as 'Tipo Anulacion'
			FROM Anulacion A
			INNER JOIN Tributos T ON T.tributos_ID = A.tributos_ID
			INNER JOIN Persona P ON P.persona_ID = A.persona_id
			INNER JOIN tablas TA ON TA.abrev = A.tipoAnulacion
			WHERE A.tributos_ID = '0043' AND A.persona_id = @persona_id 
			AND DATEPART(YY, A.registro_fecha_add) = @periodo AND TA.dep_id = 50
		END
		ELSE IF @tributos_ID = '0016'
		BEGIN
			SELECT A.persona_id, P.NombreCompleto, A.anulacion_id, A.tributos_ID, 
					T.descripcion, A.observacion, A.anioInicio, 
					A.mesInicio, A.anioFin, A.mesFin, A.tipoAnulacion, TA.descripcion as 'Tipo Anulacion'
			FROM Anulacion A
			INNER JOIN Tributos T ON T.tributos_ID = A.tributos_ID
			INNER JOIN Persona P ON P.persona_ID = A.persona_id
			INNER JOIN tablas TA ON TA.abrev = A.tipoAnulacion
			WHERE A.tributos_ID = '0016' AND A.persona_id = @persona_id 
			AND DATEPART(YY, A.registro_fecha_add) = @periodo 
			AND TA.dep_id = 50
		END
		ELSE IF @tributos_ID = '0000'
		BEGIN
			SELECT A.persona_id, P.NombreCompleto, A.anulacion_id, A.tributos_ID, 
					T.descripcion, A.observacion, A.anioInicio, 
					A.mesInicio, A.anioFin, A.mesFin, A.tipoAnulacion, TA.descripcion as 'Tipo Anulacion'
			FROM Anulacion A
			INNER JOIN Tributos T ON T.tributos_ID = A.tributos_ID
			INNER JOIN Persona P ON P.persona_ID = A.persona_id
			INNER JOIN tablas TA ON TA.abrev = A.tipoAnulacion
			WHERE (A.tributos_ID = '0043' OR A.tributos_ID = '0008') AND A.persona_id = @persona_id
			AND DATEPART(YY, A.registro_fecha_add) = @periodo AND TA.dep_id = 50
		END
	END
	IF @tipoConsulta = 3
	BEGIN
		select DA.anio,
			isnull((case when DA.mes = 1 then DA.montoDeuda else 0 end), 0) as enero,
			isnull((case when DA.mes = 2 then DA.montoDeuda else 0 end), 0) as febrero,
			isnull((case when DA.mes = 3 then DA.montoDeuda else 0 end), 0) as marzo,
			isnull((case when DA.mes = 4 then DA.montoDeuda else 0 end), 0) as abril,
			isnull((case when DA.mes = 5 then DA.montoDeuda else 0 end), 0) as mayo,
			isnull((case when DA.mes = 6 then DA.montoDeuda else 0 end), 0) as junio,
			isnull((case when DA.mes = 7 then DA.montoDeuda else 0 end), 0) as julio,
			isnull((case when DA.mes = 8 then DA.montoDeuda else 0 end), 0) as agosto,
			isnull((case when DA.mes = 9 then DA.montoDeuda else 0 end), 0) as setiembre,
			isnull((case when DA.mes = 10 then DA.montoDeuda else 0 end), 0) as octubre,
			isnull((case when DA.mes = 11 then DA.montoDeuda else 0 end), 0) as noviembre,
			isnull((case when DA.mes = 12 then DA.montoDeuda else 0 end), 0) as diciembre,
			isnull((DA.montoDeuda), 0) as total into #deuda from Anulacion A
			INNER JOIN Detalle_Anulacion DA on A.anulacion_id = DA.anulacion_id
			WHERE A.anulacion_id = @anulacion_id

			select anio, sum(enero) as '1', sum(febrero)as '2', sum(marzo) as '3', sum(abril) as '4',
				sum(mayo)as '5', sum(junio)as'6', sum(julio)as'7', sum(agosto)as'8', sum(setiembre)as'9',
				sum(octubre)as'10', sum(noviembre) as'11', sum(diciembre) as'12', sum(total)as total 
			from #deuda
			group by anio
			drop table #deuda
	END

	IF @TipoConsulta = 4
	BEGIN
		SELECT DISTINCT 
			P.predio_ID + ' - ' + ISNULL(P.direccion_completa,'Sin direcciòn') as 'direccion_completa',
			P.predio_ID 
		FROM PREDIO P
		INNER JOIN PREDio_COntribuyente PC ON P.predio_ID=PC.Predio_id
		WHERE PC.persona_ID=@persona_id 
			AND p.estado=1 
			AND pc.estado=1
	END