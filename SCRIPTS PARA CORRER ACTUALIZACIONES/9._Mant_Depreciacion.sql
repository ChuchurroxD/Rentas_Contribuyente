USE [SG_Rentable]
GO
/****** Object:  StoredProcedure [dbo].[_Mant_Depreciacion]    Script Date: 02/12/2016 22:54:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--===========================================================================================
--==========PROCEDIMIENTO DepreciacionUpdate ========================
--===========================================================================================
--===========================================================================================
ALTER PROCEDURE [dbo].[_Mant_Depreciacion]
            @depreciacion_ID    int=Null output,
            @anio    smallint=Null,
            @clasificacion    smallint=Null,
            @antiguedad    smallint=Null,
            @material    smallint=Null,
            @estado_piso    smallint=Null,
            @porcentaje    decimal(12,2)=Null,
            @estado    bit=Null,
			@antiguedadinicial smallint = null,
			@antiguedadfinal smallint = Null,
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
             UPDATE dbo.[Depreciacion]SET 
                          [anio]=@anio,
                          [clasificacion]=@clasificacion,
                          [antiguedad_]=@antiguedad,
                          [material]=@material,
                          [estado_piso]=@estado_piso,
                          [porcentaje]=@porcentaje,
                          [estado]=@estado,
						  [antiguedadinicial]=@antiguedadinicial,
						  [antiguedadfinal]=@antiguedadfinal,
						  [registro_fecha_update] = GETDATE(),
						  [registro_user_update] = @registro_user_update,
					      [registro_pc_update] = HOST_NAME()
             WHERE  depreciacion_ID = @depreciacion_ID

End

--===========================================================================================
--==========PROCEDIMIENTO DepreciacionGetByAll ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=2
begin
Select d.[depreciacion_ID],d.anio,d.clasificacion,d.antiguedad_,d.material,d.estado_piso,d.porcentaje,t1.descripcion as clasi, t2.descripcion as mate, t3.descripcion as esta,t4.descripcion as anti,d.estado,antiguedadinicial,antiguedadfinal
from Depreciacion d inner join tablas t1 on(d.clasificacion = t1.valor)
inner join tablas t2 on(d.material = t2.valor)
inner join tablas t3 on(d.estado_piso = t3.valor)
inner join tablas t4 on(d.antiguedad_ = t4.valor)
where t1.dep_id = 20 and t2.dep_id=21 and t3.dep_id = 22 and t4.dep_id = 71
End

--===========================================================================================
--==========PROCEDIMIENTO DepreciacionGetByPrimaryKey ===============
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=3
begin
Select * from Depreciacion
WHERE  depreciacion_ID = @depreciacion_ID
End

--===========================================================================================
--==========PROCEDIMIENTO DepreciacionInsert ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=4
Begin
             INSERT INTO [dbo].[Depreciacion]
             (
                          [anio],
                          [clasificacion],
                          [antiguedad_],
                          [material],
                          [estado_piso],
                          [porcentaje],
                          [estado],
						  antiguedadinicial,
						  antiguedadfinal,
						  [registro_fecha_add],
						  [registro_user_add],
						  [registro_pc_add],
						  [registro_fecha_update],
						  [registro_user_update],
						  [registro_pc_update]
             )
             VALUES
             (
                          @anio,
                          @clasificacion,
                          @antiguedad,
                          @material,
                          @estado_piso,
                          @porcentaje,
                          @estado,
						  @antiguedadinicial,
						  @antiguedadfinal,
						  GETDATE(),
						  @registro_user_add,
						  HOST_NAME(),
						  GETDATE(),
						  @registro_user_update,
						  HOST_NAME()
             )
             SET @depreciacion_ID= @@IDENTITY
End

--===========================================================================================
--==========PROCEDIMIENTO DepreciacionDelete ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=5
begin
update Depreciacion set estado= 0
WHERE  depreciacion_ID = @depreciacion_ID
end

--===========================================================================================
else if @TipoConsulta=6
begin
Select * from Depreciacion
where anio Like @anio+ '%'
end

--===========================================================================================
--==========PROCEDIMIENTO DepreciacionDelete ========================
--===========================================================================================
--===========================================================================================
else if @TipoConsulta=7
begin
Delete from Depreciacion
end
else if @TipoConsulta=8
begin
	declare @aclasif as int=0,@bclasif as int,
			@aantigue as int=0,@bantigue as int,
			@amate as int=0,@bmate as int,
			@aesta as int=0,@besta as int
			CREATE TABLE #TablaTemporal (clasif int,antiguedad int,material int,estado int)
	 select @bclasif=count(*)from tablas where dep_id=20
	 select @bmate=count(*)from tablas where dep_id=21
	 select @besta=count(*)from tablas where dep_id=22
	 select @bantigue=count(*)from tablas where dep_id=71

	WHILE (@aclasif < @bclasif)
	BEGIN
		set @aclasif=@aclasif+1;
		set @amate=0;
		  WHILE (@amate < @bmate)
			BEGIN
				set @amate=@amate+1;
				set @aesta=0;
				WHILE (@aesta < @besta)
				BEGIN
					set @aesta=@aesta+1;
					set @aantigue=0;
					WHILE (@aantigue < @bantigue)
					BEGIN
						set @aantigue=@aantigue+1;
						if( (select count(*)from Depreciacion where anio=@anio and clasificacion=@aclasif and antiguedad_=@aantigue
						and material=@amate and estado_piso=@aesta and estado=1)=0)
						begin
						--insert into Depreciacion(anio,clasificacion,antiguedad,material,estado_piso,porcentaje,estado,antiguedad_,antiguedadinicial,antiguedadfinal)values
						--(@anio,@aclasif,0,@amate,@aesta,5,1,@aantigue,0,0)
						--select*from Depreciacion
						INSERT INTO #TablaTemporal VALUES (@aclasif,@aantigue,@amate,@aesta)--solo x mientras
						end
						--print 'clasif'+  cast( @aclasif as varchar(10))  +'  material'+cast( @amate as varchar(10))  +' estado ' +
						--cast( @aesta as varchar(10))  +'  antigueda'+ cast( @aantigue as varchar(10)) 
						--print 'select count(*)from Depreciacion where anio=2016 and clasificacion='+cast( @aclasif as varchar(10)) +'and antiguedad_='+
						--cast( @aantigue as varchar(10)) 
						--+'and material='+cast( @amate as varchar(10))+' and estado_piso='+cast( @aesta as varchar(10))
					END
				END
			END
	END
	--if((select count(*) from #TablaTemporal)>0 )
	--begin 
	select 'Material:'+ ma.descripcion +', Clasificaciòn:'+cl.descripcion+', Antigüedad:' +an.descripcion+', Estado: ' + es.descripcion as descripcion from #TablaTemporal tt
	inner join tablas ma on ma.valor=tt.material and ma.dep_id=21
	inner join tablas cl on cl.valor=tt.clasif and cl.dep_id=20
	inner join tablas an on an.valor=tt.antiguedad and an.dep_id=71
	inner join tablas es on es.valor=tt.estado and es.dep_id=22
	--end
	--else
	--select '0' as Material
	DROP TABLE #TablaTemporal
end

--exec _Mant_Depreciacion @TipoConsulta=8,@anio=2015
else if @TipoConsulta = 9 -- comparardepreciaciones repetidas
select count(*) as total from Depreciacion 
where anio = @anio and clasificacion = @clasificacion and antiguedad_ = @antiguedad and material = @material and estado_piso = @estado_piso
else if @TipoConsulta = 10-- comparar depreciaciones repetidas en modificar
select count(*) as total from Depreciacion
where depreciacion_ID != @depreciacion_ID and anio = @anio and clasificacion = @clasificacion and antiguedad_ = @antiguedad and material = @material and estado_piso = @estado_piso
else if @TipoConsulta=11
begin
	Select d.[depreciacion_ID],d.anio,d.clasificacion,d.antiguedad_,d.material,d.estado_piso,d.porcentaje,t1.descripcion as clasi, t2.descripcion as mate, t3.descripcion as esta,t4.descripcion as anti,d.estado,antiguedadinicial,antiguedadfinal
	from Depreciacion d inner join tablas t1 on(d.clasificacion = t1.valor)
	inner join tablas t2 on(d.material = t2.valor)
	inner join tablas t3 on(d.estado_piso = t3.valor)
	inner join tablas t4 on(d.antiguedad_ = t4.valor)
	where t1.dep_id = 20 and t2.dep_id=21 and t3.dep_id = 22 and t4.dep_id = 71 and d.anio = @anio and t1.valor = @clasificacion
end
ELSE IF @TipoConsulta = 12
BEGIN
	Select 
		d.depreciacion_ID,
		d.anio,
		d.clasificacion,
		d.antiguedad_,
		d.material,
		d.estado_piso,
		d.porcentaje,
		t1.descripcion as clasi, 
		t2.descripcion as mate, 
		t3.descripcion as esta,
		t4.descripcion as anti,
		d.estado,
		antiguedadinicial,
		antiguedadfinal
	INTO ##TEMPORAL
	from Depreciacion d inner join tablas t1 on(convert(char,d.clasificacion) = t1.valor)
	inner join tablas t2 on(d.material = t2.valor)
	inner join tablas t3 on(d.estado_piso = t3.valor)
	inner join tablas t4 on(d.antiguedad_ = t4.valor)
	where t1.dep_id = 20 and t2.dep_id=21 and t3.dep_id = 22 and t4.dep_id = 71 
	and d.anio = @anio and d.clasificacion = @clasificacion
	ORDER BY clasificacion, antiguedad_, material, estado_piso

--select * from ##temporal

	SELECT 
		depreciacion_ID,
		anio,
		clasificacion,
		antiguedad_,
		material,
		estado_piso,
		porcentaje,
		anti, 
		clasi,
		mate, 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'MUY BUENO' THEN porcentaje ELSE null END)) AS 'MUY BUENO', 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'BUENO' THEN porcentaje ELSE null END)) AS 'BUENO', 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'REGULAR' THEN porcentaje ELSE null END)) AS 'REGULAR', 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'MALO' THEN porcentaje ELSE null END)) AS 'MALO', 
		--SUM(CASE esta WHEN 'BUENO' THEN porcentaje ELSE null END) AS 'BUENO' ,
		--SUM(CASE esta WHEN 'REGULAR' THEN porcentaje ELSE null END) AS 'REGULAR',
		--SUM(CASE esta WHEN 'MALO' THEN porcentaje ELSE null END) AS 'MALO',
		estado,
		antiguedadinicial,
		antiguedadfinal
	FROM ##TEMPORAL 
	GROUP BY [depreciacion_ID], anio, clasificacion, antiguedad_, material, 
				estado_piso, anti, mate, estado, antiguedadinicial, antiguedadfinal, clasi, porcentaje
	ORDER BY antiguedad_, clasificacion, material

	DROP TABLE ##TEMPORAL
END
ELSE IF @TipoConsulta = 13
BEGIN
	Select 
		d.depreciacion_ID,
		d.anio,
		d.clasificacion,
		d.antiguedad_,
		d.material,
		d.estado_piso,
		d.porcentaje,
		t1.descripcion as clasi, 
		t2.descripcion as mate, 
		t3.descripcion as esta,
		t4.descripcion as anti,
		d.estado,
		antiguedadinicial,
		antiguedadfinal
	INTO ##TEMPORAL1
	from Depreciacion d inner join tablas t1 on(convert(char,d.clasificacion) = t1.valor)
	inner join tablas t2 on(d.material = t2.valor)
	inner join tablas t3 on(d.estado_piso = t3.valor)
	inner join tablas t4 on(d.antiguedad_ = t4.valor)
	where t1.dep_id = 20 and t2.dep_id=21 and t3.dep_id = 22 and t4.dep_id = 71 
	and d.anio = @anio
	ORDER BY clasificacion, antiguedad_, material, estado_piso

--select * from ##temporal

	SELECT 
		depreciacion_ID,
		anio,
		clasificacion,
		antiguedad_,
		material,
		estado_piso,
		porcentaje,
		anti, 
		clasi,
		mate, 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'MUY BUENO' THEN porcentaje ELSE null END)) AS 'MUY BUENO', 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'BUENO' THEN porcentaje ELSE null END)) AS 'BUENO', 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'REGULAR' THEN porcentaje ELSE null END)) AS 'REGULAR', 
		CONVERT(varchar(50), SUM(CASE esta WHEN 'MALO' THEN porcentaje ELSE null END)) AS 'MALO', 
		--SUM(CASE esta WHEN 'BUENO' THEN porcentaje ELSE null END) AS 'BUENO' ,
		--SUM(CASE esta WHEN 'REGULAR' THEN porcentaje ELSE null END) AS 'REGULAR',
		--SUM(CASE esta WHEN 'MALO' THEN porcentaje ELSE null END) AS 'MALO',
		estado,
		antiguedadinicial,
		antiguedadfinal
	FROM ##TEMPORAL1
	GROUP BY [depreciacion_ID], anio, clasificacion, antiguedad_, material, 
				estado_piso, anti, mate, estado, antiguedadinicial, antiguedadfinal, clasi, porcentaje
	ORDER BY clasificacion, antiguedad_, material

	DROP TABLE ##TEMPORAL1
END