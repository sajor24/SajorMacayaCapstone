CREATE PROCEDURE [dbo].[DeleteUpgradeRequest]
    @RequestId NVARCHAR(20)
AS
BEGIN
    DELETE FROM [dbo].[UpgradeRequests]
    WHERE RequestId = @RequestId
END
GO
