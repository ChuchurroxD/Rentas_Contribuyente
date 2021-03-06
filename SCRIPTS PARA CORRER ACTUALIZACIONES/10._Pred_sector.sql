USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Pred_Sector]    Script Date: 02/12/2016 22:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[_Pred_Sector]
            @sector_id    int=Null output,
            @descripcion    varchar(100)=Null,
			@tipo_Junta varchar(2)=Null,
			@barrido bit=Null,
			@recojo bit=Null,
			@jardin bit=Null,
			@serenazgo bit=Null,
			@estado bit=Null, 
            @sysFecha datetime=Null,
			@sysUser varchar(50)=Null,
			@oficina int=null,
			@registro_fecha_add datetime = null,
			@registro_user_add varchar(40) = null,
			@registro_pc_add varchar(40) = null,
			@registro_fecha_update datetime = null,
			@registro_user_update varchar(40) = null,
			@registro_pc_update varchar(40) = null,
			@TipoConsulta tinyint
AS 
if @TipoConsulta=1 
Begin
             UPDATE dbo.[Sector]SET 
                          [Descripcion]=@descripcion,
						  [Tipo_Junta]=@tipo_Junta,
						  [Barrido]=@barrido,
						  [Recojo]=@recojo,
						  [Jardin]=@jardin,
						  [Serenezgo]=@serenazgo,
						  [estado]=@estado,
						  [sysUser]=@sysUser,
						  [registro_fecha_update] = GETDATE(),
						  [registro_user_update] = @registro_user_update,
					      [registro_pc_update] = HOST_NAME()
             WHERE   [Sector_id]= @sector_id

End

--===========================================================================================
--==========PROCEDIMIENTO Pred_SectorGetByAll ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=2
begin
Select s.Sector_id ,ltrim(rtrim(s.descripcion))as descripcion ,
	   s.Tipo_Junta,s.barrido,s.recojo,s.jardin,s.serenezgo,s.estado,
	   s.sysFecha,s.sysUser,p.descripcion as tipo 
from Sector s 
inner join tablas p on(s.Tipo_Junta=p.valor) 
where p.dep_id=15 
ORDER BY Descripcion

/*case when Barrido =1 then 'SI' else 'NO' end Barrido , case when Recojo =1 then 'SI' else 'NO' end Recojo*/
End

--===========================================================================================
--==========PROCEDIMIENTO Pred_SectorGetByPrimaryKey ===============
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=3
begin
Select valor,descripcion from tablas
WHERE  dep_id = 15
End

--===========================================================================================
--==========PROCEDIMIENTO Pred_SectorInsert ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=4
Begin
             INSERT INTO [dbo].[Sector]
             (
                          [Descripcion],
                          [Tipo_Junta],
						  [Barrido],
						  [Recojo],
						  [Jardin],
						  [Serenezgo],
						  [estado],
						  [sysUser],
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @descripcion,
                          @tipo_Junta,
						  @barrido,
						  @recojo,
						  @jardin,
						  @serenazgo,
						  @estado,
						  @sysUser,
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
             SET @sector_id= @@IDENTITY
End

--===========================================================================================
--==========PROCEDIMIENTO Pred_SectorDelete ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=5
begin
	update Sector set estado = 0
	WHERE  Sector_id = @sector_id
end

--===========================================================================================
else if @TipoConsulta=6
begin
	Select * from Sector
	where Descripcion Like '%'+@descripcion+ '%'
end

--===========================================================================================
--==========PROCEDIMIENTO Pred_SectorDelete ========================
--===========================================================================================
--===========================================================================================
else IF @TipoConsulta=7
begin
	Delete from Sector
end
-- para un combo de sector
ELSE IF @TipoConsulta=8
	SELECT Sector_id as codigo, descripcion 
	FROM Sector where estado=1 --and Oficina_id=@oficina
	order by Descripcion 

--===========================================================================================
--==========PROCEDIMIENTO Pred_SectorCompararDescripcion ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta = 9
begin
	select COUNT(*) as total from Sector where replace(Descripcion,' ','') =replace(@descripcion,' ','')
end
else if @TipoConsulta = 10
begin
	select COUNT(*) as total from Sector where replace(Descripcion,' ','') =replace(@descripcion,' ','') and Sector_id != @sector_id
end
ELSE IF @TipoConsulta=11
begin
	select 0 AS codigo,'TODOS' AS Descripcion,'  ' AS ORDEN
	UNION
	select s.Sector_id as codigo,s.Descripcion,S.Descripcion AS ORDEN
	from Contribuyente c
	inner join Junta_Via jv on c.junta_via_ID=jv.junta_via_ID
	inner join Sector s on s.Sector_id=jv.junta_ID
	group by s.Sector_id,s.Descripcion
	order by ORDEN
end

else if @TipoConsulta = 12
begin
	SELECT Sector_id,Descripcion 
	FROM Sector
	UNION SELECT -1, '---- TODOS ----'
	ORDER BY Descripcion 
end
ELSE IF @TipoConsulta=13
BEGIN
	declare @oficial int
	select top 1 @oficial=oficina_id from Oficina where principal=1
	if @oficina=@oficial
		SELECT Sector_id as codigo, descripcion 
		FROM Sector where estado=1 
		order by Descripcion 
	else
	SELECT Sector_id as codigo, descripcion 
	FROM Sector where estado=1 and Oficina_id=@oficina
	order by Descripcion 
	END
else if @TipoConsulta = 14
begin
	select COUNT(*) as total from Sector where replace(Descripcion,' ','') =replace(@descripcion,' ','') and Sector_id != @sector_id
end

--select * from tablas where dep_id is null