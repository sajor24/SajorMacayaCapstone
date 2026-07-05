CREATE PROCEDURE [dbo].[UpdateTechCompletedJobs]
    @UserId           NVARCHAR(100),
    @TechCompletedJobs INT
AS
BEGIN
    UPDATE [dbo].[Users]
    SET TechCompletedJobs = @TechCompletedJobs
    WHERE UserId = @UserId
END
GO
