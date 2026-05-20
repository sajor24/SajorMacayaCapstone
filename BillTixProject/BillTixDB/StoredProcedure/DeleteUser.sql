CREATE PROCEDURE [dbo].[DeleteUser]
    @UserId NVARCHAR(100)
AS
BEGIN
    DELETE FROM [dbo].[Users]
    WHERE UserId = @UserId
END
GO