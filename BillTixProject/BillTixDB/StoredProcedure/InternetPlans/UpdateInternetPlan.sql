CREATE PROCEDURE [dbo].[UpdateInternetPlan]
    @PlanId   NVARCHAR(20),
    @PlanName NVARCHAR(100),
    @Speed    NVARCHAR(50),
    @Price    DECIMAL(10,2),
    @Features NVARCHAR(500) = NULL,
    @IsActive BIT = 1
AS
BEGIN
    UPDATE [dbo].[InternetPlans]
    SET PlanName=@PlanName, Speed=@Speed, Price=@Price,
        Features=@Features, IsActive=@IsActive
    WHERE PlanId = @PlanId
END
GO
