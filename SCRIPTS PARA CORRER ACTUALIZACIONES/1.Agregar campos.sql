--ALTER TABLE Arancel ADD registro_fecha_add DATETIME NULL;
--ALTER TABLE Arancel ADD registro_user_add VARCHAR(40) NULL;
--ALTER TABLE Arancel ADD registro_pc_add VARCHAR(40) NULL;
--ALTER TABLE Arancel ADD registro_fecha_update DATETIME NULL;
--ALTER TABLE Arancel ADD registro_user_update VARCHAR(40) NULL;
--ALTER TABLE Arancel ADD registro_pc_update VARCHAR(40) NULL;

--ALTER TABLE ArancelRustico ADD registro_fecha_add DATETIME NULL;
--ALTER TABLE ArancelRustico ADD registro_user_add VARCHAR(40) NULL;
--ALTER TABLE ArancelRustico ADD registro_pc_add VARCHAR(40) NULL;
--ALTER TABLE ArancelRustico ADD registro_fecha_update DATETIME NULL;
--ALTER TABLE ArancelRustico ADD registro_user_update VARCHAR(40) NULL;
--ALTER TABLE ArancelRustico ADD registro_pc_update VARCHAR(40) NULL;

use SG_Rentable
go


ALTER TABLE Area ADD registro_fecha_add DATETIME NULL;
ALTER TABLE Area ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE Area ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE Area ADD registro_fecha_update DATETIME NULL;
ALTER TABLE Area ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE Area ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE Clasificador_Ingresos ADD registro_fecha_add DATETIME NULL;
ALTER TABLE Clasificador_Ingresos ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE Clasificador_Ingresos ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE Clasificador_Ingresos ADD registro_fecha_update DATETIME NULL;
ALTER TABLE Clasificador_Ingresos ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE Clasificador_Ingresos ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE FormatoCampos ADD registro_fecha_add DATETIME NULL;
ALTER TABLE FormatoCampos ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE FormatoCampos ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE FormatoCampos ADD registro_fecha_update DATETIME NULL;
ALTER TABLE FormatoCampos ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE FormatoCampos ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE formato_valores ADD registro_fecha_add DATETIME NULL;
ALTER TABLE formato_valores ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE formato_valores ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE formato_valores ADD registro_fecha_update DATETIME NULL;
ALTER TABLE formato_valores ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE formato_valores ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE grupo ADD registro_fecha_add DATETIME NULL;
ALTER TABLE grupo ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE grupo ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE grupo ADD registro_fecha_update DATETIME NULL;
ALTER TABLE grupo ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE grupo ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE tarea ADD registro_fecha_add DATETIME NULL;
ALTER TABLE tarea ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE tarea ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE tarea ADD registro_fecha_update DATETIME NULL;
ALTER TABLE tarea ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE tarea ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE Sector ADD registro_fecha_add DATETIME NULL;
ALTER TABLE Sector ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE Sector ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE Sector ADD registro_fecha_update DATETIME NULL;
ALTER TABLE Sector ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE Sector ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE Depreciacion ADD registro_fecha_add DATETIME NULL;
ALTER TABLE Depreciacion ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE Depreciacion ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE Depreciacion ADD registro_fecha_update DATETIME NULL;
ALTER TABLE Depreciacion ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE Depreciacion ADD registro_pc_update VARCHAR(40) NULL;

ALTER TABLE valores ADD registro_fecha_add DATETIME NULL;
--ALTER TABLE valores ADD registro_user_add VARCHAR(40) NULL;
ALTER TABLE valores ADD registro_pc_add VARCHAR(40) NULL;
ALTER TABLE valores ADD registro_fecha_update DATETIME NULL;
ALTER TABLE valores ADD registro_user_update VARCHAR(40) NULL;
ALTER TABLE valores ADD registro_pc_update VARCHAR(40) NULL;


