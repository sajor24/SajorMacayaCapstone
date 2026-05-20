CREATE PROCEDURE CreateUsers
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Username NVARCHAR(100),
    @Password NVARCHAR(255),
    @Role NVARCHAR(50),
    @Email NVARCHAR(255) = NULL,
    @ContactNumber NVARCHAR(20) = NULL,
    @Address NVARCHAR(255) = NULL
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

    -- get last number per role prefix
    SELECT @LastNumber =
        ISNULL(MAX(CAST(RIGHT(UserId, 3) AS INT)), 0)
    FROM Users
    WHERE UserId LIKE @Prefix + '%'

    -- increment
    SET @LastNumber = @LastNumber + 1

    -- build ID (ADM001, USR001, etc.)
    SET @NewId = @Prefix + RIGHT('000' + CAST(@LastNumber AS NVARCHAR), 3)

    -- insert into updated table
    INSERT INTO Users
    (
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
    )
    VALUES
    (
        @NewId,
        @FirstName,
        @LastName,
        @Username,
        @Password,
        @Role,
        @Email,
        @ContactNumber,
        @Address,
        GETDATE()
    )
END