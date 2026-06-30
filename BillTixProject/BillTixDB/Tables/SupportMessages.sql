CREATE TABLE [dbo].[SupportMessages]
(
    [MessageId]  NVARCHAR(20)   PRIMARY KEY,
    [UserId]     NVARCHAR(100)  NOT NULL REFERENCES [dbo].[Users]([UserId]),
    [SenderRole] NVARCHAR(20)   NOT NULL,  -- 'Subscriber' or 'Staff'
    [SentBy]     NVARCHAR(100)  NOT NULL,  -- username
    [Message]    NVARCHAR(1000) NOT NULL,
    [CreatedAt]  DATETIME       NOT NULL DEFAULT GETDATE()
)
