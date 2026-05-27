CREATE PROCEDURE [dbo].[CreateBilling]
    @UserId        NVARCHAR(100),
    @Amount        DECIMAL(10,2),
    @PaymentMethod NVARCHAR(50) = NULL,
    @Status        NVARCHAR(20) = 'Pending',
    @DueDate       DATETIME = NULL,
    @Description   NVARCHAR(255) = NULL
AS
BEGIN
    DECLARE @LastNumber INT
    DECLARE @NewId NVARCHAR(20)

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(BillingId, 4) AS INT)), 0)
    FROM [dbo].[Billing]

    SET @LastNumber = @LastNumber + 1
    SET @NewId = 'BIL-' + RIGHT('0000' + CAST(@LastNumber AS NVARCHAR), 4)

    INSERT INTO [dbo].[Billing]
        (BillingId, UserId, Amount, PaymentMethod, Status, BillingDate, DueDate, Description, CreatedAt)
    VALUES
        (@NewId, @UserId, @Amount, @PaymentMethod, @Status, GETDATE(), @DueDate, @Description, GETDATE())
END
GO
