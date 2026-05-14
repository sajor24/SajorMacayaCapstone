CREATE PROCEDURE CreateUsers
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Username NVARCHAR(100),
    @Password NVARCHAR(255),
    @Role NVARCHAR(50)
AS
BEGIN
    DECLARE @Prefix NVARCHAR(3)
    DECLARE @NewId NVARCHAR(10)
    DECLARE @LastNumber INT

    -- prefix based on role
    SET @Prefix =
        CASE @Role
            WHEN 'Admin' THEN 'ADM'
            WHEN 'Technician' THEN 'TEC'
            WHEN 'Subscriber' THEN 'SUB'
            WHEN 'Staff' THEN 'STF'
            ELSE 'USR'
        END

    -- get last number
    SELECT @LastNumber =
        ISNULL(MAX(CAST(RIGHT(UserId, 3) AS INT)), 0)
    FROM Users
    WHERE UserId LIKE @Prefix + '%'

    -- +1
    SET @LastNumber = @LastNumber + 1

    -- build ID
    SET @NewId = @Prefix + RIGHT('000' + CAST(@LastNumber AS NVARCHAR), 3)

    -- insert
    INSERT INTO Users (UserId, FirstName, LastName, Username, Password, Role)
    VALUES (@NewId, @FirstName, @LastName, @Username, @Password, @Role)
END