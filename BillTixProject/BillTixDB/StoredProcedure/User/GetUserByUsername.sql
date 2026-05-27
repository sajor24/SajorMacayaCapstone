CREATE PROCEDURE [dbo].[GetUserByUsername]
    @Username NVARCHAR(100)
AS
BEGIN
    SELECT UserId, FirstName, LastName, Username, Password, Role,
           Email, ContactNumber, Address, CreatedAt
    FROM [dbo].[Users]
    WHERE Username = @Username
END
