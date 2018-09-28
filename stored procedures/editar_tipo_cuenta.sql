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
-- Description:	Edita el tipo de cuenta de un nombre dado
-- =============================================
CREATE PROCEDURE EditarTipoCuenta 
	-- Add the parameters for the stored procedure here
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
	UPDATE dbo.TipoCuenta
	SET tasaInteresAnual = @tasaInteresAnual, saldoMinimo = @saldoMin,
	multaSaldoMin = @multaSaldoMin, multaSaldoNeg = @multaSaldoNeg,
	cargoServicioMensual = @cargoServicioMensual, cantMaxOpManual = @cantMaxOpManual,
	cantMaxOpATM = @cantMaxOpATM, multaOpManual = @multaOpManual, multaOpATM = @multaOpATM
	WHERE nombre = @nombre
END
GO
