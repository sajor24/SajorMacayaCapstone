CREATE PROCEDURE [dbo].[CreateNotification]
    @UserId  NVARCHAR(100),
    @SentBy  NVARCHAR(100),
    @Title   NVARCHAR(200),
    @Message NVARCHAR(1000)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @LastNumber INT;
    DECLARE @NewId NVARCHAR(20);

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(NotificationId, 4) AS INT)), 0)
    FROM [dbo].[Notifications];

    SET @LastNumber = @LastNumber + 1;
    SET @NewId = 'NOT-' + RIGHT('0000' + CAST(@LastNumber AS NVARCHAR), 4);

    INSERT INTO [dbo].[Notifications] (NotificationId, UserId, SentBy, Title, Message, IsRead, CreatedAt)
    VALUES (@NewId, @UserId, @SentBy, @Title, @Message, 0, GETDATE());
END
GO
