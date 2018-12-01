CREATE TABLE [dbo].[User]
(
	[UserId] BIGINT IDENTITY(1, 1) NOT NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Login] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [ts] ROWVERSION NOT NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY ([UserId]),
)
