CREATE PROCEDURE [dbo].[GetAllUser]
AS
BEGIN
    SELECT
        UserId,
        FirstName,
        LastName,
        Username,
        Password,
        Role,
        Email,
        ContactNumber,
        Address,
        CreatedAt
    FROM [dbo].[Users]
    ORDER BY CreatedAt DESC
END
GO