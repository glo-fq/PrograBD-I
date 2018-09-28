CREATE PROCEDURE CASP_AgregarCliente(@nombre varchar(50),@valorDocId varchar(50), @pass varchar(50))
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT dbo.Clientes(nombre,DocId,password)
			VALUES(@nombre,@valorDocId,@pass)
			COMMIT
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK
		RETURN @@ERROR * -1
	END CATCH
END