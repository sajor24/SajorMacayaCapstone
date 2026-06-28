CREATE PROCEDURE [dbo].[CreateBilling]
    @UserId        NVARCHAR(100),
    @Amount        DECIMAL(10,2),
    @PaymentMethod NVARCHAR(50) = NULL,
    @Status        NVARCHAR(20) = 'Pending',
    @DueDate       DATETIME = NULL,
    @PaidAt        DATETIME = NULL,
    @Description   NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @LastNumber INT;
    DECLARE @NewId NVARCHAR(20);

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(BillingId, 4) AS INT)), 0)
    FROM [dbo].[Billing];

    SET @LastNumber = @LastNumber + 1;
    SET @NewId = 'BIL-' + RIGHT('0000' + CAST(@LastNumber AS NVARCHAR), 4);

    -- auto-set PaidAt if status is Paid and PaidAt not provided
    IF (@Status = 'Paid' AND @PaidAt IS NULL)
        SET @PaidAt = GETDATE();

    -- clear PaidAt if not Paid
    IF (@Status <> 'Paid')
        SET @PaidAt = NULL;

    INSERT INTO [dbo].[Billing]
        (BillingId, UserId, Amount, PaymentMethod, Status, BillingDate, DueDate, PaidAt, Description, CreatedAt)
    VALUES
        (@NewId, @UserId, @Amount, @PaymentMethod, @Status, GETDATE(), @DueDate, @PaidAt, @Description, GETDATE());
END
GO