CREATE PROCEDURE [dbo].[GetAllNotifications]
AS
BEGIN
    SELECT n.NotificationId, n.UserId, n.SentBy, n.Title, n.Message, n.IsRead, n.CreatedAt,
           u.FirstName, u.LastName, u.Username
    FROM [dbo].[Notifications] n
    INNER JOIN [dbo].[Users] u ON n.UserId = u.UserId
    ORDER BY n.CreatedAt DESC
END
GO
