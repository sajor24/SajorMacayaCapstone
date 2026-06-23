CREATE TABLE [dbo].[UpgradeRequests]
(
    [RequestId]     NVARCHAR(20) PRIMARY KEY,
    [UserId]        NVARCHAR(100) NOT NULL REFERENCES [dbo].[Users]([UserId]),
    [PlanId]        NVARCHAR(20) NOT NULL,
    [PlanName]      NVARCHAR(100) NOT NULL,
    [ReferenceNo]   NVARCHAR(100) NOT NULL,
    [Status]        NVARCHAR(20) NOT NULL DEFAULT 'Pending',
    [RequestedAt]   DATETIME NOT NULL DEFAULT GETDATE(),
    [ProcessedAt]   DATETIME NULL,
    [FirstName]     NVARCHAR(100) NULL,
    [LastName]      NVARCHAR(100) NULL
)
