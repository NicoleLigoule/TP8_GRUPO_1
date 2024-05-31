CREATE PROCEDURE [dbo].[SP_AGREGARSUCURSAL]
    @NombreSucursal NVARCHAR(100),
    @DescripcionSucursal NVARCHAR(255),
    @Id_ProvinciaSucursal INT,
    @DireccionSucursal NVARCHAR(255)
    
AS
BEGIN
    INSERT INTO Sucursal (
        NombreSucursal,
        DescripcionSucursal,
        Id_ProvinciaSucursal,
        DireccionSucursal
    )
    VALUES (
        @NombreSucursal,
        @DescripcionSucursal,
        @Id_ProvinciaSucursal,
        @DireccionSucursal
    )
END