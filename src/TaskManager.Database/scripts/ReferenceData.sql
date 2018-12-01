
-- Status table --

IF NOT EXISTS (SELECT * FROM dbo.Status  WHERE  Name = 'Not started') 
	INSERT INTO dbo.Status(Name, Ordinal) VALUES (N'Not Started', 0);

IF NOT EXISTS (SELECT * FROM dbo.Status  WHERE  Name = 'In progress') 
	INSERT INTO dbo.Status(Name, Ordinal) VALUES (N'In progress', 1);

IF NOT EXISTS (SELECT * FROM dbo.Status  WHERE  Name = 'Completed') 
	INSERT INTO dbo.Status(Name, Ordinal) VALUES (N'Completed', 2);


