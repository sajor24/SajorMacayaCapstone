CREATE PROCEDURE [dbo].[CreateSupportMessage]
    @UserId     NVARCHAR(100),
    @SenderRole NVARCHAR(20),
    @SentBy     NVARCHAR(100),
    @Message    NVARCHAR(1000)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @LastNumber INT;
    DECLARE @NewId NVARCHAR(20);

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(MessageId, 4) AS INT)), 0)
    FROM [dbo].[SupportMessages];

    SET @LastNumber = @LastNumber + 1;
    SET @NewId = 'MSG-' + RIGHT('0000' + CAST(@LastNumber AS NVARCHAR), 4);

    INSERT INTO [dbo].[SupportMessages] (MessageId, UserId, SenderRole, SentBy, Message, CreatedAt)
    VALUES (@NewId, @UserId, @SenderRole, @SentBy, @Message, GETDATE());
END
GO
