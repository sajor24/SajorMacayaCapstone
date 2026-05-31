CREATE PROCEDURE [dbo].[GetAllSubscribers]
AS
BEGIN
    SELECT
        u.UserId,
        u.FirstName,
        u.LastName,
        u.Username,
        u.Email,
        u.ContactNumber,
        u.Address,
        u.CreatedAt,
        s.PlanName,
        s.PlanPrice,
        s.Status,
        s.EndDate AS NextBilling
    FROM [dbo].[Users] u
    LEFT JOIN [dbo].[Subscription] s ON u.UserId = s.UserId
    WHERE u.Role = 'Subscriber'
    ORDER BY u.CreatedAt DESC
END
GO
