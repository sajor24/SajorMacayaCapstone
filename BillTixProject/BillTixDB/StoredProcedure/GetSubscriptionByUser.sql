CREATE PROCEDURE [dbo].[GetSubscriptionByUser]
    @UserId NVARCHAR(100)
AS
BEGIN
    SELECT
        SubscriptionId,
        UserId,
        PlanName,
        PlanPrice,
        StartDate,
        EndDate,
        Status,
        CreatedAt
    FROM [dbo].[Subscription]
    WHERE UserId = @UserId
    ORDER BY CreatedAt DESC
END
GO
