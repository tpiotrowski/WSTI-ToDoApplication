DECLARE
	@statusId INT,
	@taskId INT,
	@userId INT


-- User table --
IF NOT EXISTS (SELECT * FROM [User] WHERE Login = 'TestLogin1')
	INSERT INTO [dbo].[User] (Login, Password, FirstName, LastName, Email) 
	VALUES (N'TestLogin1',N'Password',N'Test1',N'User1',N'test1@user1.com')

IF NOT EXISTS (SELECT * FROM [User] WHERE Login = 'TestLogin2')
	INSERT INTO [dbo].[User] (Login, Password, FirstName, LastName, Email)
	VALUES (N'TestLogin2',N'Password',N'Test2',N'User2',N'test2@user2.com')

-- Task table --
IF NOT EXISTS (SELECT * FROM [dbo].[Task] WHERE Subject = 'First Task')
BEGIN

	SELECT TOP 1 @statusId = StatusId FROM Status ORDER BY StatusId;
	SELECT TOP 1 @userId = UserId FROM [User] ORDER BY UserId;

	INSERT INTO dbo.Task(Subject, StartDate, StatusId, CreatedDate, CreatedUserId)
	VALUES ('First Task', GETDATE(), @statusId, GETDATE(), @userId);

	SET @taskId = SCOPE_IDENTITY();

	INSERT [dbo].[TaskUser] ([TaskId], [UserId])
		VALUES (@taskId, @userId);

END

IF NOT EXISTS (SELECT * FROM [dbo].[Task] WHERE Subject = 'Second Task')
BEGIN

	SELECT TOP 1 @statusId = StatusId FROM Status ORDER BY StatusId;
	SELECT TOP 1 @userId = UserId FROM [User] ORDER BY UserId;

	INSERT INTO dbo.Task(Subject, StartDate, StatusId, CreatedDate, CreatedUserId)
	VALUES ('Second Task', GETDATE(), @statusId, GETDATE(), @userId);

	SET @taskId = SCOPE_IDENTITY();

	INSERT [dbo].[TaskUser] ([TaskId], [UserId])
		VALUES (@taskId, @userId);

END