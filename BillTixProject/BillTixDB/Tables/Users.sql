CREATE TABLE [dbo].[Users]
(
    [UserId]       NVARCHAR(100) PRIMARY KEY,
    [FirstName]    NVARCHAR(100) NOT NULL,
    [LastName]     NVARCHAR(100) NOT NULL,
    [Username]     NVARCHAR(100) NOT NULL UNIQUE,
    [Password]     NVARCHAR(255) NOT NULL,
    [Role]         NVARCHAR(50)  NOT NULL,
    [Email]        NVARCHAR(255) NULL,
    [ContactNumber] NVARCHAR(20) NULL,
    [Address]      NVARCHAR(255) NULL,
    [Photo]        NVARCHAR(MAX) NULL,          
    [CreatedAt]    DATETIME DEFAULT GETDATE(),

    -- Technician-specific fields
    [TechSpecialization] NVARCHAR(100) NULL,
    [TechArea]           NVARCHAR(100) NULL,
    [TechCompletedJobs]  INT           NULL DEFAULT 0
)