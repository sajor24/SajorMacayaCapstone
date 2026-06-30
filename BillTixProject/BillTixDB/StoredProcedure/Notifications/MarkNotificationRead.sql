CREATE PROCEDURE [dbo].[MarkNotificationRead]
    @NotificationId NVARCHAR(20)
AS
BEGIN
    UPDATE [dbo].[Notifications]
    SET IsRead = 1
    WHERE NotificationId = @NotificationId
END
GO
