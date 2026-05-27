CREATE PROCEDURE [dbo].[CreateSubscription]
    @UserId    NVARCHAR(100),
    @PlanName  NVARCHAR(100),
    @PlanPrice DECIMAL(10,2),
    @StartDate DATETIME,
    @EndDate   DATETIME = NULL,
    @Status    NVARCHAR(20) = 'Active'
AS
BEGIN
    DECLARE @LastNumber INT
    DECLARE @NewId NVARCHAR(20)

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(SubscriptionId, 4) AS INT)), 0)
    FROM [dbo].[Subscription]

    SET @LastNumber = @LastNumber + 1
    SET @NewId = 'SUB-' + RIGHT('0000' + CAST(@LastNumber AS NVARCHAR), 4)

    INSERT INTO [dbo].[Subscription]
        (SubscriptionId, UserId, PlanName, PlanPrice, StartDate, EndDate, Status, CreatedAt)
    VALUES
        (@NewId, @UserId, @PlanName, @PlanPrice, @StartDate, @EndDate, @Status, GETDATE())
END
GO
