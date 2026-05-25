CREATE PROCEDURE [dbo].[GetBillingByUser]
    @UserId NVARCHAR(100)
AS
BEGIN
    SELECT
        BillingId,
        UserId,
        Amount,
        PaymentMethod,
        Status,
        BillingDate,
        DueDate,
        PaidAt,
        Description,
        CreatedAt
    FROM [dbo].[Billing]
    WHERE UserId = @UserId
    ORDER BY CreatedAt DESC
END
GO
