USE SG_Rentable
GO

--Creación de la Tabla FormatoCampos
CREATE TABLE HR
(     
	HR_id		int			identity(1,1),
	HR_año		int		not null,
	HR_numero	int 	not null	
)
GO

--Creacion de la clave primaria y otros
ALTER TABLE HR
  ADD
    CONSTRAINT PK_HR
	  PRIMARY KEY (HR_id ASC)
go


CREATE TABLE PR
(     
	PR_id		int			identity(1,1),
	PR_año		int		not null,
	PR_numero	int 	not null	
)
GO

--Creacion de la clave primaria y otros
ALTER TABLE PR
  ADD
    CONSTRAINT PK_pr
	  PRIMARY KEY (PR_id ASC)
go


CREATE TABLE PU
(     
	PU_id		int			identity(1,1),
	PU_año		int		not null,
	PU_numero	int 	not null	
)
GO

--Creacion de la clave primaria y otros
ALTER TABLE PU
  ADD
    CONSTRAINT PK_pu
	  PRIMARY KEY (PU_id ASC)
go