CREATE PROCEDURE CreateUser
    @FirstName           NVARCHAR(100),
    @LastName            NVARCHAR(100),
    @Username            NVARCHAR(100),
    @Password            NVARCHAR(255),
    @Role                NVARCHAR(50),
    @Email               NVARCHAR(255) = NULL,
    @ContactNumber       NVARCHAR(20)  = NULL,
    @Address             NVARCHAR(255) = NULL,
    @TechSpecialization  NVARCHAR(100) = NULL,
    @TechArea            NVARCHAR(100) = NULL,
    @TechCompletedJobs   INT           = 0
AS
BEGIN
    DECLARE @Prefix NVARCHAR(3)
    DECLARE @NewId NVARCHAR(10)
    DECLARE @LastNumber INT

    SET @Prefix =
        CASE @Role
            WHEN 'Admin'      THEN 'ADM'
            WHEN 'Technician' THEN 'TEC'
            WHEN 'Subscriber' THEN 'SUB'
            WHEN 'Staff'      THEN 'STF'
            ELSE 'USR'
        END

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(UserId, 3) AS INT)), 0)
    FROM Users
    WHERE UserId LIKE @Prefix + '%'

    SET @LastNumber = @LastNumber + 1
    SET @NewId = @Prefix + RIGHT('000' + CAST(@LastNumber AS NVARCHAR), 3)

    INSERT INTO Users
    (
        UserId, FirstName, LastName, Username, Password, Role,
        Email, ContactNumber, Address, CreatedAt,
        TechSpecialization, TechArea, TechCompletedJobs
    )
    VALUES
    (
        @NewId, @FirstName, @LastName, @Username, @Password, @Role,
        @Email, @ContactNumber, @Address, GETDATE(),
        @TechSpecialization, @TechArea, ISNULL(@TechCompletedJobs, 0)
    )
END
