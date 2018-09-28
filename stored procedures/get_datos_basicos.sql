Create procedure CASP_Get_Info_Actual_Cliente
	@idCliente int,
	@idCuenta int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			SELECT saldo,intersesAcumulados,fechaCreacion FROM dbo.Cuenta
			WHERE ClienteId = @idCliente

			SELECT * FROM dbo.movimiento
			WHERE idCuenta = @idCuenta
			commit
	return 1
	END TRY
	BEGIN CATCH
		if @@TRANCOUNT > 0 Rollback
		return -1 * @@ERROR
	END CATCH
end