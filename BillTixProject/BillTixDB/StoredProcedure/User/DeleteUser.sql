CREATE PROCEDURE [dbo].[DeleteUser]
    @UserId NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete related records first (cascade)
    DELETE FROM [dbo].[Notifications]    WHERE UserId = @UserId;
    DELETE FROM [dbo].[Billing]          WHERE UserId = @UserId;
    DELETE FROM [dbo].[ServiceRequests]  WHERE UserId = @UserId;
    DELETE FROM [dbo].[SupportMessages]  WHERE UserId = @UserId;
    DELETE FROM [dbo].[UpgradeRequests]  WHERE UserId = @UserId;
    DELETE FROM [dbo].[Subscription]     WHERE UserId = @UserId;

    -- Delete the user
    DELETE FROM [dbo].[Users]
    WHERE UserId = @UserId;
END
GO