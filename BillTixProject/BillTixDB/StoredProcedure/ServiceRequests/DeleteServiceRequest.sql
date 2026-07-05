CREATE PROCEDURE [dbo].[DeleteServiceRequest]
    @RequestId NVARCHAR(50)
AS
BEGIN
    DELETE FROM ServiceRequests
    WHERE RequestId = @RequestId
END