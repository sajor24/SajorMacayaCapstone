CREATE PROCEDURE [dbo].[UpdateUser]
    @UserId              NVARCHAR(100),
    @FirstName           NVARCHAR(100),
    @LastName            NVARCHAR(100),
    @Username            NVARCHAR(100),
    @Password            NVARCHAR(255),
    @Role                NVARCHAR(50),
    @Email               NVARCHAR(255),
    @ContactNumber       NVARCHAR(20),
    @Address             NVARCHAR(255),
    @Photo               NVARCHAR(MAX) = NULL,     
    @TechSpecialization  NVARCHAR(100) = NULL,
    @TechArea            NVARCHAR(100) = NULL,
    @TechCompletedJobs   INT           = NULL
AS
BEGIN
    UPDATE [dbo].[Users]
    SET
        FirstName          = @FirstName,
        LastName           = @LastName,
        Username           = @Username,
        Password           = @Password,
        Role               = @Role,
        Email              = @Email,
        ContactNumber      = @ContactNumber,
        Address            = @Address,
        Photo              = @Photo,
        TechSpecialization = @TechSpecialization,
        TechArea           = @TechArea,
        TechCompletedJobs  = @TechCompletedJobs
    WHERE UserId = @UserId
END
GO
