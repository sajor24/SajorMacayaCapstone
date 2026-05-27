CREATE PROCEDURE [dbo].[UpdateSubscription]
    @SubscriptionId NVARCHAR(20),
    @PlanName       NVARCHAR(100),
    @PlanPrice      DECIMAL(10,2),
    @StartDate      DATETIME,
    @EndDate        DATETIME = NULL,
    @Status         NVARCHAR(20)
AS
BEGIN
    UPDATE [dbo].[Subscription]
    SET
        PlanName  = @PlanName,
        PlanPrice = @PlanPrice,
        StartDate = @StartDate,
        EndDate   = @EndDate,
        Status    = @Status
    WHERE SubscriptionId = @SubscriptionId
END
GO
