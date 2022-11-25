CREATE PROCEDURE [dbo].[spInventory_Insert]
	@ProductId INT,
	@Quantity INT,
	@PurchasePrice MONEY,
	@PurchaseDate DATETIME2
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Inventory(ProductId, Quantity, PurchaseDate, PurchasePrice)
	VALUES (@ProductId, @Quantity, @PurchaseDate, @PurchasePrice); 
END
