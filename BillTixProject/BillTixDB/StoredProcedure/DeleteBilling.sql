CREATE PROCEDURE [dbo].[DeleteBilling]
    @BillingId NVARCHAR(20)
AS
BEGIN
    DELETE FROM [dbo].[Billing]
    WHERE BillingId = @BillingId
END
GO
