CREATE PROCEDURE [dbo].[SP_ELIMINARSUCURSAL]
	@id_sucursal int
	AS
	DELETE FROM Sucursal WHERE Id_Sucursal = @id_sucursal
