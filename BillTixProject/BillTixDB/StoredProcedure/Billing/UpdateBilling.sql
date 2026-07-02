CREATE PROCEDURE [dbo].[UpdateBilling]
    @BillingId     NVARCHAR(20),
    @Amount        DECIMAL(10,2),
    @PaymentMethod NVARCHAR(255) = NULL,
    @Status        NVARCHAR(20),
    @DueDate       DATETIME = NULL,
    @PaidAt        DATETIME = NULL,
    @Description   NVARCHAR(255) = NULL
AS
BEGIN
    UPDATE [dbo].[Billing]
    SET
        Amount        = @Amount,
        PaymentMethod = @PaymentMethod,
        Status        = @Status,
        DueDate       = @DueDate,
        PaidAt        = @PaidAt,
        Description   = @Description
    WHERE BillingId = @BillingId
END
GO
