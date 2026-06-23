CREATE PROCEDURE [dbo].[CreateUpgradeRequest]
    @UserId      NVARCHAR(100),
    @PlanId      NVARCHAR(20),
    @PlanName    NVARCHAR(100),
    @ReferenceNo NVARCHAR(100)
AS
BEGIN
    DECLARE @LastNumber INT
    DECLARE @NewId NVARCHAR(20)

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(RequestId, 4) AS INT)), 0)
    FROM [dbo].[UpgradeRequests]

    SET @LastNumber = @LastNumber + 1
    SET @NewId = 'REQ-' + RIGHT('0000' + CAST(@LastNumber AS NVARCHAR), 4)

    INSERT INTO [dbo].[UpgradeRequests]
        (RequestId, UserId, PlanId, PlanName, ReferenceNo, Status, RequestedAt)
    VALUES
        (@NewId, @UserId, @PlanId, @PlanName, @ReferenceNo, 'Pending', GETDATE())
END
GO
