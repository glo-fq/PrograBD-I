Create procedure CASP_ModificarCliente
	@Nombre varchar(50),
	@DocId varchar(50),
	@password varchar(50),
	@idCliente int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			Update dbo.Clientes
			SET nombre = @nombre,
			DocId =
				case when @DocId is null
					then docId
					else @DocId
				end,
			password = isnull(password,@password)
			where id = @idCliente
			commit
	return 1
	END TRY
	BEGIN CATCH
		if @@TRANCOUNT > 0 Rollback
		return -1 * @@ERROR
	END CATCH
end
