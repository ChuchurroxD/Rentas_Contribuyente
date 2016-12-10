use SG_Rentable
go

delete from roles_usuario
delete from usuario 

--ALTER TABLE dbo.usuario ALTER COLUMN per_pass varbinary(300);  
--GO  


declare cursorUsuario cursor for
select per_codigo, areas_codarea, estado, per_login, per_pass, nombre, apellido 
from SG_Rentable2.dbo.usuario

open cursorUsuario

declare	
	 @per_codigo1		char(9),
	 @nombre1 varchar(50),
	 @apellido1 varchar(50),
	 @areas_codarea1 varchar(4),
	 @estado1 bit,
	 @per_login1 varchar(20),
	 @per_pass1 nvarchar(300)
fetch cursorUsuario
into  @per_codigo1, @areas_codarea1, @estado1, @per_login1, @per_pass1, @nombre1, @apellido1
	
WHILE (@@FETCH_STATUS = 0 )
BEGIN	
	INSERT INTO usuario
	VALUES(@per_codigo1, @areas_codarea1, @estado1, GETDATE(), @per_login1, ENCRYPTBYPASSPHRASE('SGR_MOCHE', @per_pass1),
			NULL, NULL, NULL, @nombre1, @apellido1, NULL)

	fetch cursorUsuario
	into  @per_codigo1, @areas_codarea1, @estado1, @per_login1, @per_pass1, @nombre1, @apellido1
END
CLOSE cursorUsuario
DEALLOCATE cursorUsuario

--insert into usuario
--select * from SG_Rentable2.dbo.usuario
insert into roles_usuario
select * from SG_Rentable2.dbo.roles_usuario


select * from usuario
select * from roles_usuario




