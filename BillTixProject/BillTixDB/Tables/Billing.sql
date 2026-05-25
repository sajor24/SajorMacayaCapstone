CREATE TABLE [dbo].[Billing]
(
    [BillingId]      NVARCHAR(20) PRIMARY KEY,
    [UserId]         NVARCHAR(100) NOT NULL REFERENCES [dbo].[Users]([UserId]),
    [Amount]         DECIMAL(10,2) NOT NULL DEFAULT 0,
    [PaymentMethod]  NVARCHAR(50) NULL,
    [Status]         NVARCHAR(20) NOT NULL DEFAULT 'Pending',
    [BillingDate]    DATETIME NOT NULL DEFAULT GETDATE(),
    [DueDate]        DATETIME NULL,
    [PaidAt]         DATETIME NULL,
    [Description]    NVARCHAR(255) NULL,
    [CreatedAt]      DATETIME NOT NULL DEFAULT GETDATE()
)
