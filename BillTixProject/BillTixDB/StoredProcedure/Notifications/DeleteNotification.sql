CREATE PROCEDURE [dbo].[DeleteNotification]
    @NotificationId NVARCHAR(20)
AS
BEGIN
    DELETE FROM [dbo].[Notifications]
    WHERE NotificationId = @NotificationId
END
GO
