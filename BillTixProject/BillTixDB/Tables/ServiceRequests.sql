CREATE TABLE [dbo].[ServiceRequests]
(
    [RequestId]      NVARCHAR(20)   PRIMARY KEY,
    [UserId]         NVARCHAR(100)  NOT NULL REFERENCES [dbo].[Users]([UserId]),
    [IssueType]      NVARCHAR(100)  NOT NULL,
    [Priority]       NVARCHAR(20)   NOT NULL DEFAULT 'Medium',
    [Description]    NVARCHAR(1000) NOT NULL,
    [ContactNumber]  NVARCHAR(20)   NULL,
    [Status]         NVARCHAR(20)   NOT NULL DEFAULT 'Open',
    [AssignedTo]     NVARCHAR(100)  NULL,
    [ResolvedAt]     DATETIME       NULL,
    [CreatedAt]      DATETIME       NOT NULL DEFAULT GETDATE()
)
