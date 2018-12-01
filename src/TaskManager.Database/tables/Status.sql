CREATE TABLE [dbo].[Status]
(
	[StatusId] BIGINT IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(100) NULL, 
    [Ordinal] INT NULL, 
    [ts] ROWVERSION NULL,
	PRIMARY KEY CLUSTERED ([StatusId] ASC),
)
