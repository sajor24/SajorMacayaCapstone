CREATE PROCEDURE LoginUser
    @Username NVARCHAR(100),
    @Password NVARCHAR(255)
AS
BEGIN

    SELECT 
        Username,
        Role
    FROM Users
    WHERE Username = @Username
      AND Password = @Password
END