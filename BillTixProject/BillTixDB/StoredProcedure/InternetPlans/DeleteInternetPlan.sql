CREATE PROCEDURE [dbo].[DeleteInternetPlan]
    @PlanId NVARCHAR(20)
AS
BEGIN
    DELETE FROM [dbo].[InternetPlans]
    WHERE PlanId = @PlanId
END
GO
