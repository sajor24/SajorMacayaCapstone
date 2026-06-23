CREATE PROCEDURE [dbo].[UpdateUpgradeRequest]
    @RequestId   NVARCHAR(20),
    @Status      NVARCHAR(20),
    @ProcessedAt DATETIME
AS
BEGIN
    UPDATE [dbo].[UpgradeRequests]
    SET Status = @Status, ProcessedAt = @ProcessedAt
    WHERE RequestId = @RequestId
END
GO
