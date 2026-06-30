CREATE PROCEDURE [dbo].[GetAllSupportMessages]
AS
BEGIN
    SELECT s.MessageId, s.UserId, s.SenderRole, s.SentBy, s.Message, s.CreatedAt,
           u.FirstName, u.LastName, u.Username
    FROM [dbo].[SupportMessages] s
    INNER JOIN [dbo].[Users] u ON s.UserId = u.UserId
    ORDER BY s.UserId, s.CreatedAt ASC
END
GO
