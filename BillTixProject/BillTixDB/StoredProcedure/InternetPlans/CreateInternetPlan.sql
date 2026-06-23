CREATE PROCEDURE [dbo].[CreateInternetPlan]
    @PlanName NVARCHAR(100),
    @Speed    NVARCHAR(50),
    @Price    DECIMAL(10,2),
    @Features NVARCHAR(500) = NULL,
    @IsActive BIT = 1
AS
BEGIN
    DECLARE @LastNumber INT
    DECLARE @NewId NVARCHAR(20)

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(PlanId, 3) AS INT)), 0)
    FROM [dbo].[InternetPlans]

    SET @LastNumber = @LastNumber + 1
    SET @NewId = 'PLN' + RIGHT('000' + CAST(@LastNumber AS NVARCHAR), 3)

    INSERT INTO [dbo].[InternetPlans] (PlanId, PlanName, Speed, Price, Features, IsActive, CreatedAt)
    VALUES (@NewId, @PlanName, @Speed, @Price, @Features, @IsActive, GETDATE())
END
GO
