CREATE PROCEDURE [dbo].[DeleteSubscription]
    @SubscriptionId NVARCHAR(20)
AS
BEGIN
    DELETE FROM [dbo].[Subscription]
    WHERE SubscriptionId = @SubscriptionId
END
GO
