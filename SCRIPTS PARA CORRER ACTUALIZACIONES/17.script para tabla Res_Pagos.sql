USE SG_Rentable
GO

--Creación de la Tabla Res_Pagos
CREATE TABLE Res_Pagos
(     
	Pagos_id			int				not null,
	FechaPago			datetime		not null,
	idPeriodo			int				not null,
	MontoTotal			decimal(18, 2)	not null,
	TipoPago			char(3)			not null
)
GO

--Creacion de la clave primaria y otros
ALTER TABLE Res_Pagos
  ADD
    CONSTRAINT PK_Res_Pagos
	  PRIMARY KEY (Pagos_id)
go

INSERT INTO Res_Pagos(Pagos_id, FechaPago, idPeriodo, MontoTotal, TipoPago)
SELECT Pagos_id, FechaPago, idPeriodo, MontoTotal, TipoPago FROM Pagos





