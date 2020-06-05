CREATE TABLE [dbo].[credentials]
(
	[cre_id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [cre_email] VARCHAR(50) NOT NULL UNIQUE, 
    [cre_password] CHAR(256) NOT NULL, 
    [cre_inserted_at] DATETIME NOT NULL DEFAULT SYSDATETIME(), 
    [cre_updated_at] DATETIME NOT NULL DEFAULT SYSDATETIME()
)
