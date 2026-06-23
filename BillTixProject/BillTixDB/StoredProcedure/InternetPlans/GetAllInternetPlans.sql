CREATE PROCEDURE [dbo].[GetAllInternetPlans]
AS
BEGIN
    SELECT PlanId, PlanName, Speed, Price, Features, IsActive, CreatedAt
    FROM [dbo].[InternetPlans]
    ORDER BY Price ASC
END
GO
