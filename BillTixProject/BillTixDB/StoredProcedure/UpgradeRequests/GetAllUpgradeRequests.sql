CREATE PROCEDURE [dbo].[GetAllUpgradeRequests]
AS
BEGIN
    SELECT
        r.RequestId, r.UserId, r.PlanId, r.PlanName,
        r.ReferenceNo, r.Status, r.RequestedAt, r.ProcessedAt,
        u.FirstName, u.LastName, u.Username
    FROM [dbo].[UpgradeRequests] r
    INNER JOIN [dbo].[Users] u ON r.UserId = u.UserId
    ORDER BY r.RequestedAt DESC
END
GO
