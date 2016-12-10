USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Rep_Gerencial]   Script Date: 01/12/2016 22:16:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[_Rep_Gerencial] 
	 @anio int = null,	
	 @tipoConsulta        tinyint
AS
	SET NOCOUNT ON

	IF @tipoConsulta = 1  --INGRESO POR MES
	BEGIN
		CREATE TABLE ##PERIODO
		(
			ROW INT NOT NULL,
			MES VARCHAR(50) NOT NULL,
			MONTO DECIMAL(18,2) NOT NULL
		)
		INSERT INTO ##PERIODO
		VALUES(1, 'Enero', 0),(2, 'Febrero', 0),(3, 'Marzo', 0),(4, 'Abril', 0),(5, 'Mayo', 0),(6, 'Junio', 0),
			  (7, 'Julio', 0),(8, 'Agosto', 0),(9, 'Septiempre', 0),(10, 'Octubre', 0),(11, 'Noviembre', 0),(12, 'Diciembre', 0)

		SELECT 
			MONTH(FechaPago) as ROW,
			DATENAME(month , FechaPago) as MES,
			SUM(MontoTotal) AS MONTO
		INTO ##TEMPO
		FROM Res_Pagos
		WHERE YEAR(FechaPago) = @anio
		GROUP BY MONTH(FechaPago), DATENAME(month , FechaPago)
		--ORDER BY MONTH(FechaPago) ASC

		SELECT 
			P.ROW, 
			P.MES, 
			ISNULL(T.MONTO, 0) AS MONTO
		FROM ##PERIODO P
		LEFT JOIN ##TEMPO T ON T.ROW = P.row

		DROP TABLE ##TEMPO
		DROP TABLE ##PERIODO
	END

	ELSE IF	@tipoConsulta = 2  --POR TIPO DE PAGO
	BEGIN
		CREATE TABLE ##TIPOPAGO
		(
					ROW CHAR(2) NOT NULL,
					TIPOPAGO VARCHAR(50) NOT NULL,
					MONTO INT NOT NULL
		)
		INSERT INTO ##TIPOPAGO
		VALUES('12', 'ALCABALA', 0), ('11', 'ASOCIADOS', 0), ('10', 'CALCULAR DEUDA', 0), ('2', 'FRACCIONAMIENTO', 0), ('1', 'LIQUIDACIÓN', 0),
			  ('4', 'OTROS PAGOS', 0), ('3', 'RECIBOS', 0), ('13', 'REGISTROS CIVILES', 0)


		SELECT 
			P.TipoPago,
			T.descripcion AS 'TIPO PAGO',
			SUM(P.MontoTotal) AS MONTO
		INTO ##TEMPO2
		FROM Res_Pagos P
		INNER JOIN tablas T ON T.valor = P.TipoPago
		WHERE P.idPeriodo = @anio AND T.dep_id = 45 AND P.TipoPago IN ('1', '10', '11', '12', '13', '2', '3', '4') -- and p.estado = 1
		GROUP BY T.descripcion, P.TipoPago 
		--ORDER BY T.descripcion ASC

		SELECT 
			TP.TIPOPAGO AS 'TIPO PAGO', 
			ISNULL(T.MONTO, 0) AS MONTO
		FROM ##TIPOPAGO TP
		LEFT JOIN ##TEMPO2 T ON T.TIPOPAGO = TP.row

		DROP TABLE ##TEMPO2
		DROP TABLE ##TIPOPAGO
	END

	ELSE IF @tipoConsulta = 3  --CANTIDAD DE FRACCIONAMIENTOS POR MES
	BEGIN
		CREATE TABLE ##PERIODO2
		(
			ROW INT NOT NULL,
			MES VARCHAR(50) NOT NULL,
			MONTO INT NOT NULL
		)
		INSERT INTO ##PERIODO2
		VALUES(1, 'Enero', 0),(2, 'Febrero', 0),(3, 'Marzo', 0),(4, 'Abril', 0),(5, 'Mayo', 0),(6, 'Junio', 0),
			  (7, 'Julio', 0),(8, 'Agosto', 0),(9, 'Septiempre', 0),(10, 'Octubre', 0),(11, 'Noviembre', 0),(12, 'Diciembre', 0)

		SELECT
			MONTH(registro_fecha_add) as ROW,
			DATENAME(month , registro_fecha_add) as MES,				
			COUNT(Deuda_Total) AS MONTO
		INTO ##TEMPO3
		FROM fraccionamiento
		WHERE idPeriodo = @anio 
		GROUP BY DATENAME(month , registro_fecha_add), MONTH(registro_fecha_add)
		--ORDER BY MONTH(registro_fecha_add) ASC	

		SELECT 
			P.ROW, 
			P.MES, 
			ISNULL(T.MONTO, 0) AS MONTO
		FROM ##PERIODO2 P
		LEFT JOIN ##TEMPO3 T ON T.ROW = P.row

		DROP TABLE ##TEMPO3
		DROP TABLE ##PERIODO2
	END

	ELSE IF @tipoConsulta = 4 -- EMISION POR TIPO DE TRIBUTO
	BEGIN
		CREATE TABLE ##TIPOTRIBUTO
		(
			tributo_ID char(16) NOT NULL,
			TRIBUTO VARCHAR(50) NOT NULL,
			MONTO DECIMAL(18, 2) NOT NULL
		)
		INSERT INTO ##TIPOTRIBUTO
		VALUES('0038', 'ALCABALA', 0),('0043', 'LIMP. PUBLICA', 0),('0008', 'PREDIAL', 0)

		DECLARE @cargoF decimal(18,2)
		SET @cargoF = (SELECT SUM(cargo) FROM CuentaCorriente WHERE anio = @anio AND tributo_ID = '0016')

		SELECT 
			CC.tributo_ID,
			T.descripcion,
			(CASE WHEN CC.tributo_ID = '0008' THEN SUM(CC.cargo) + @cargoF ELSE SUM(CC.CARGO) END) AS MONTO
		INTO ##TEMPO4
		FROM CuentaCorriente CC
		INNER JOIN Tributos T ON T.tributos_ID = CC.tributo_ID
		WHERE anio = @anio
		AND estado IN ('P', 'C', 'M', 'F') AND tributo_ID IN ('0008', '0043', '0038')
		GROUP BY T.descripcion, CC.tributo_ID
		--ORDER BY T.descripcion ASC

		SELECT  
			TT.TRIBUTO AS descripcion, 
			ISNULL(T.MONTO, 0) AS MONTO
		FROM ##TIPOTRIBUTO TT
		LEFT JOIN ##TEMPO4 T ON T.tributo_ID = TT.tributo_ID

		DROP TABLE ##TEMPO4
		DROP TABLE ##TIPOTRIBUTO
	END

	