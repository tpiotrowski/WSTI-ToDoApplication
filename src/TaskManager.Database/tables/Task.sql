CREATE TABLE [dbo].[Task]
(
	[TaskId] BIGINT IDENTITY(1,1) NOT NULL, 
    [Subject] NVARCHAR(30) NOT NULL, 
    [StartDate] DATETIME2 NOT NULL, 
    [DueDate] NCHAR(10) NULL, 
    [CompletedDate] NCHAR(10) NULL, 
    [StatusId] BIGINT NOT NULL, 
    [CreatedDate] DATETIME2 NULL, 
    [CreatedUserId] BIGINT NULL,
	[ts] ROWVERSION NOT NULL,
	PRIMARY KEY CLUSTERED ([TaskId] ASC),
	FOREIGN KEY ([CreatedUserId]) REFERENCES [dbo].[User] ([UserId]),
	FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([StatusId])
)
