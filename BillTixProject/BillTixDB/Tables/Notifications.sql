CREATE TABLE [dbo].[Notifications]
(
    [NotificationId] NVARCHAR(20)  PRIMARY KEY,
    [UserId]         NVARCHAR(100) NOT NULL REFERENCES [dbo].[Users]([UserId]),
    [SentBy]         NVARCHAR(100) NOT NULL,
    [Title]          NVARCHAR(200) NOT NULL,
    [Message]        NVARCHAR(1000) NOT NULL,
    [IsRead]         BIT           NOT NULL DEFAULT 0,
    [CreatedAt]      DATETIME      NOT NULL DEFAULT GETDATE()
)
