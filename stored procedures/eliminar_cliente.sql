Create procedure CASP_EliminarCliente
	@Nombre varchar(50),
	@DocId varchar(50),
	@idCliente int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			Update dbo.Clientes
			SET activo = 0
			WHERE Id = @idCliente
			commit
	return 1
	END TRY
	BEGIN CATCH
		if @@TRANCOUNT > 0 Rollback
		return -1 * @@ERROR
	END CATCH
end