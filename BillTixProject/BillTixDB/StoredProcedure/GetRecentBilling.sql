CREATE PROCEDURE [dbo].[GetRecentBilling]
    @Top INT = 5
AS
BEGIN
    SELECT TOP (@Top)
        b.BillingId,
        b.UserId,
        b.Amount,
        b.PaymentMethod,
        b.Status,
        b.BillingDate,
        b.DueDate,
        b.PaidAt,
        b.Description,
        b.CreatedAt,
        u.FirstName,
        u.LastName
    FROM [dbo].[Billing] b
    INNER JOIN [dbo].[Users] u ON b.UserId = u.UserId
    ORDER BY b.CreatedAt DESC
END
GO
