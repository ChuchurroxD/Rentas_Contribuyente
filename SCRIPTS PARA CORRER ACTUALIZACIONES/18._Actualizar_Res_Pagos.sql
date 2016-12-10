USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Conf_Grupo]    Script Date: 02/12/2016 12:28:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_Actualizar_Res_Pagos]           
AS 
	DELETE FROM Res_Pagos
	WHERE YEAR(FechaPago) = YEAR(GETDATE())
	AND MONTH(FechaPago) =  MONTH(GETDATE())

	INSERT INTO Res_Pagos(Pagos_id, FechaPago, idPeriodo, MontoTotal, TipoPago)
	SELECT Pagos_id, FechaPago, idPeriodo, MontoTotal, TipoPago FROM Pagos
	WHERE YEAR(FechaPago) = YEAR(GETDATE())
	AND MONTH(FechaPago) =  MONTH(GETDATE())			



	