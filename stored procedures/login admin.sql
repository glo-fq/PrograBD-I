CREATE PROCEDURE CASP_LoginAdmin(@nombre varchar(50), @pass varchar(50))
AS
BEGIN
	BEGIN TRY
		SELECT C.nombre, C.password
		FROM dbo.Clientes C
		WHERE  @nombre = nombre and @pass = password
		RETURN 1
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK
		RETURN @@ERROR * -1
	END CATCH
END