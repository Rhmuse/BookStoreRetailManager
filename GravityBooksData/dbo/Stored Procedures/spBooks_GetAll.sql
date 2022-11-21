CREATE PROCEDURE [dbo].[spBooks_GetAll]
	
AS
BEGIN
	SET NOCOUNT ON;

	SELECT book_id, title
	FROM book
END