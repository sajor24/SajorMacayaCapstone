CREATE PROCEDURE [dbo].[UpdateServiceRequest]
    @RequestId  NVARCHAR(20),
    @Status     NVARCHAR(20),
    @AssignedTo NVARCHAR(100) = NULL,
    @ResolvedAt DATETIME = NULL
AS
BEGIN
    UPDATE [dbo].[ServiceRequests]
    SET Status     = @Status,
        AssignedTo = @AssignedTo,
        ResolvedAt = @ResolvedAt
    WHERE RequestId = @RequestId
END
GO
