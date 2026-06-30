CREATE PROCEDURE [dbo].[GetServiceRequestsByUser]
    @UserId NVARCHAR(100)
AS
BEGIN
    SELECT RequestId, UserId, IssueType, Priority, Description, ContactNumber,
           Status, AssignedTo, ResolvedAt, CreatedAt
    FROM [dbo].[ServiceRequests]
    WHERE UserId = @UserId
    ORDER BY CreatedAt DESC
END
GO
