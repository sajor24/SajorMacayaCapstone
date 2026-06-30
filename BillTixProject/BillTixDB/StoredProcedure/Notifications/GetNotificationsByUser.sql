CREATE PROCEDURE [dbo].[GetNotificationsByUser]
    @UserId NVARCHAR(100)
AS
BEGIN
    SELECT NotificationId, UserId, SentBy, Title, Message, IsRead, CreatedAt
    FROM [dbo].[Notifications]
    WHERE UserId = @UserId
    ORDER BY CreatedAt DESC
END
GO
