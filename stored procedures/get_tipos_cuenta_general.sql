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
-- Description:	Conseguir la lista de tipos de cuenta
-- =============================================
CREATE PROCEDURE GetTiposCuenta 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT T.nombre, T.tasaInteresAnual, T.saldoMinimo, T.multaSaldoMin, T.multaSaldoNeg,
	T.cargoServicioMensual, T.cantMaxOpManual, T.cantMaxOpATM, T.multaOpManual, T.multaOpATM
	FROM TipoCuenta as T
END
GO
