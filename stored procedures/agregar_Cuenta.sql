Create procedure CASP_AgregarCuenta
	@idTipoCuenta int,
	@idCliente int,
	@codigoCuenta varchar(50),
	@fechaCreacion date,
	@DocIdCliente varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT dbo.Cuenta(idTipoCuenta,ClienteId,saldo,codigoCuenta,intersesAcumulados,fechaCreacion,ClienteIdDoc,activo)
			VALUES(@idTipoCuenta,@idCliente,0,@codigoCuenta,0,@fechaCreacion,@DocIdCliente,1)
			commit
	return 1
	END TRY
	BEGIN CATCH
		if @@TRANCOUNT > 0 Rollback
		return -1 * @@ERROR
	END CATCH
end