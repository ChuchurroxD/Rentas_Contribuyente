USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Mant_Arancel]    Script Date: 10/12/2016 12:36:06 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[_NumeracionAuto] 
		@TipoConsulta tinyint
AS 
DECLARE @CONTADOR INT
DECLARE @PERIODO INT
DECLARE @NUMERO INT
if @TipoConsulta=1 
Begin
	SET @PERIODO = (SELECT año FROM PERIODO where activo = 1)
	SET @CONTADOR = (SELECT COUNT(*) FROM HR WHERE HR_año = @PERIODO)
	SET @NUMERO = (SELECT TOP 1 HR_id FROM HR ORDER BY HR_id DESC)
	IF (@CONTADOR = 0)
	BEGIN 
		INSERT INTO HR (HR_año, HR_numero) VALUES(@PERIODO, 1)
	END	
	IF (@CONTADOR > 0)
	BEGIN 
		INSERT INTO HR (HR_año, HR_numero) VALUES(@PERIODO, @NUMERO+1)
	END	
End
--===========================================================================================
--============================== Listar Aranceles por Año ===================================
--===========================================================================================
else if @TipoConsulta=2
begin
	SELECT TOP 1 HR_id as numero FROM HR ORDER BY HR_id DESC
end

else if @TipoConsulta=3
begin
	SET @PERIODO = (SELECT año FROM PERIODO where activo = 1)
	SET @CONTADOR = (SELECT COUNT(*) FROM PR WHERE PR_año = @PERIODO)
	SET @NUMERO = (SELECT TOP 1 PR_id FROM PR ORDER BY PR_id DESC)
	IF (@CONTADOR = 0)
	BEGIN 
		INSERT INTO PR (PR_año, PR_numero) VALUES(@PERIODO, 1)
	END	
	IF (@CONTADOR > 0)
	BEGIN 
		INSERT INTO PR (PR_año, PR_numero) VALUES(@PERIODO, @NUMERO+1)
	END	
end

else if @TipoConsulta=4
begin
	SELECT TOP 1 PR_id as numero FROM PR ORDER BY PR_id DESC
end

else if @TipoConsulta=5
begin
	SET @PERIODO = (SELECT año FROM PERIODO where activo = 1)
	SET @CONTADOR = (SELECT COUNT(*) FROM PU WHERE PU_año = @PERIODO)
	SET @NUMERO = (SELECT TOP 1 PU_id FROM PU ORDER BY PU_id DESC)
	IF (@CONTADOR = 0)
	BEGIN 
		INSERT INTO PU (PU_año, PU_numero) VALUES(@PERIODO, 1)
	END	
	IF (@CONTADOR > 0)
	BEGIN 
		INSERT INTO PU (PU_año, PU_numero) VALUES(@PERIODO, @NUMERO+1)
	END	
end

else if @TipoConsulta=6
begin
	SELECT TOP 1 PU_id as numero FROM PU ORDER BY PU_id DESC
end