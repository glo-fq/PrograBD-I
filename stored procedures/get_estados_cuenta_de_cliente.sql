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
-- Description:	
-- =============================================
CREATE PROCEDURE GetEstadosCuenta 
	-- Add the parameters for the stored procedure here
	@codigoCuenta varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT E.idCuenta, E.fechaCorte, E.saldoInicial, E.saldoFinal, E.cantOpManual, E.cantOpATM, E.saldoMin 
	FROM EstadoCuenta as E
	WHERE E.codigoCuenta = @codigoCuenta and E.activo = 0 --Que haya sido cerrado, o sea, no activo
END
GO
