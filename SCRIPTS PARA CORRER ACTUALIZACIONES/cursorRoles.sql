declare @persona_id char(9) 
declare @urol_id char(9) 

declare cursorRoles cursor for
select per_codigo from usuario where per_codigo > '287392'

open cursorRoles
fetch cursorRoles
into @persona_id
while(@@FETCH_STATUS = 0)
begin
	select  top 1 @urol_id =urol_id from roles_usuario order by urol_id desc
	set @urol_id = @urol_id + 1
	
	insert into roles_usuario (urol_id, per_codigo, rol_id, activo) 
	values(@urol_id, @persona_id, 14, 1)
	fetch cursorUsuario
	into @persona_id
end
close cursorRoles
deallocate cursorRoles