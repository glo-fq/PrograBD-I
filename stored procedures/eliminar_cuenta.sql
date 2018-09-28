Create procedure CASP_EliminarCuenta
	@idCuenta int,
	@idCliente int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE dbo.Cuenta
			SET activo = 0
			WHERE Id = @idCuenta and ClienteIdDoc = @idCliente
			commit
	return 1
	END TRY
	BEGIN CATCH
		if @@TRANCOUNT > 0 Rollback
		return -1 * @@ERROR
	END CATCH
end