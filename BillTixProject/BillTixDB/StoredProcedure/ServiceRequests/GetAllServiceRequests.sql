CREATE PROCEDURE [dbo].[GetAllServiceRequests]
AS
BEGIN
    SELECT s.RequestId, s.UserId, s.IssueType, s.Priority, s.Description,
           s.ContactNumber, s.Status, s.AssignedTo, s.ResolvedAt, s.CreatedAt,
           u.FirstName, u.LastName, u.Username
    FROM [dbo].[ServiceRequests] s
    INNER JOIN [dbo].[Users] u ON s.UserId = u.UserId
    ORDER BY s.CreatedAt DESC
END
GO
