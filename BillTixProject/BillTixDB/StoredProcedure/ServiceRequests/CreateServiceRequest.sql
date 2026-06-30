CREATE PROCEDURE [dbo].[CreateServiceRequest]
    @UserId        NVARCHAR(100),
    @IssueType     NVARCHAR(100),
    @Priority      NVARCHAR(20),
    @Description   NVARCHAR(1000),
    @ContactNumber NVARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @LastNumber INT;
    DECLARE @NewId NVARCHAR(20);

    SELECT @LastNumber = ISNULL(MAX(CAST(RIGHT(RequestId, 4) AS INT)), 0)
    FROM [dbo].[ServiceRequests];

    SET @LastNumber = @LastNumber + 1;
    SET @NewId = 'SR-' + RIGHT('000' + CAST(@LastNumber AS NVARCHAR), 3);

    INSERT INTO [dbo].[ServiceRequests]
        (RequestId, UserId, IssueType, Priority, Description, ContactNumber, Status, CreatedAt)
    VALUES
        (@NewId, @UserId, @IssueType, @Priority, @Description, @ContactNumber, 'Open', GETDATE());
END
GO
