Create procedure CASP_Editar_Cuenta
	@idCuenta int,
	@idTipoCuenta int,
	@ClienteId int,
	@saldo money,
	@codigoCuenta varchar(50),
	@intersesAcumulados money,
	@fechaCreacion date,
	@ClienteIdDoc varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE dbo.Cuenta
			SET idTipoCuenta = @idTipoCuenta,
			ClienteId = @ClienteId,
			saldo = @saldo,
			codigoCuenta = @codigoCuenta,
			intersesAcumulados = @intersesAcumulados,
			fechaCreacion = @fechaCreacion,
			ClienteIdDoc = @ClienteIdDoc
			WHERE Id = @idCuenta
			commit
	return 1
	END TRY
	BEGIN CATCH
		if @@TRANCOUNT > 0 Rollback
		return -1 * @@ERROR
	END CATCH
end