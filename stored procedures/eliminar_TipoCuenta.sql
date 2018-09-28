Create procedure CASP_Eliminar_TipoCuenta
	@idTipoCuenta int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			Update dbo.TipoCuenta
			SET activo = 0
			WHERE Id = @idTipoCuenta
			commit
	return 1
	END TRY
	BEGIN CATCH
		if @@TRANCOUNT > 0 Rollback
		return -1 * @@ERROR
	END CATCH
end