CREATE PROCEDURE [dbo].[GetAllSubscription]
AS
BEGIN
    SELECT
        s.SubscriptionId,
        s.UserId,
        s.PlanName,
        s.PlanPrice,
        s.StartDate,
        s.EndDate,
        s.Status,
        s.CreatedAt,
        u.FirstName,
        u.LastName
    FROM [dbo].[Subscription] s
    INNER JOIN [dbo].[Users] u ON s.UserId = u.UserId
    ORDER BY s.CreatedAt DESC
END
GO
