CREATE PROCEDURE [dbo].[GetSupportMessagesByUser]
    @UserId NVARCHAR(100)
AS
BEGIN
    SELECT MessageId, UserId, SenderRole, SentBy, Message, CreatedAt
    FROM [dbo].[SupportMessages]
    WHERE UserId = @UserId
    ORDER BY CreatedAt ASC
END
GO
