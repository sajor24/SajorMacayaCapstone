CREATE TABLE [dbo].[Subscription]
(
    [SubscriptionId] NVARCHAR(20) PRIMARY KEY,
    [UserId]         NVARCHAR(100) NOT NULL REFERENCES [dbo].[Users]([UserId]),
    [PlanName]       NVARCHAR(100) NOT NULL,
    [PlanPrice]      DECIMAL(10,2) NOT NULL DEFAULT 0,
    [StartDate]      DATETIME NOT NULL DEFAULT GETDATE(),
    [EndDate]        DATETIME NULL,
    [Status]         NVARCHAR(20) NOT NULL DEFAULT 'Active',
    [CreatedAt]      DATETIME NOT NULL DEFAULT GETDATE()
)
