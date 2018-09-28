-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Gloriana
-- Create date: 
-- Description:	Agregar un nuevo tipo de cuenta
-- =============================================
CREATE PROCEDURE AgregarTipoCuenta 
	-- Add the parameters for the stored procedure here
	@id int,
	@nombre varchar(50), 
	@tasaInteresAnual float,
	@saldoMin money,
	@multaSaldoMin money,
	@multaSaldoNeg money,
	@cargoServicioMensual money,
	@cantMaxOpManual int,
	@cantMaxOpATM int,
	@multaOpManual money,
	@multaOpATM money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.TipoCuenta
	VALUES (@id, @nombre, @tasaInteresAnual, @saldoMin, @cantMaxOpManual, @cantMaxOpATM, @multaSaldoMin,
	@multaOpManual, @multaOpATM, @multaSaldoNeg, @cargoServicioMensual)
END
GO
