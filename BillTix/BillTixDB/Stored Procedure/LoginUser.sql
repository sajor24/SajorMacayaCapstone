CREATE PROCEDURE LoginUser
    @Username NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Users
    WHERE Username = @Username
END