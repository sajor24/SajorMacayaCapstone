CREATE TABLE [dbo].[InternetPlans]
(
    [PlanId]    NVARCHAR(20) PRIMARY KEY,
    [PlanName]  NVARCHAR(100) NOT NULL,
    [Speed]     NVARCHAR(50) NOT NULL,
    [Price]     DECIMAL(10,2) NOT NULL,
    [Features]  NVARCHAR(500) NULL,
    [IsActive]  BIT NOT NULL DEFAULT 1,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE()
)
