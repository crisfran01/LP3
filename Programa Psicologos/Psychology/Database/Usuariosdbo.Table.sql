CREATE TABLE [dbo].[Usuarios]
(
	[cod] INT NOT NULL PRIMARY KEY, 
    [Nome] NCHAR(20) NULL, 
    [senha] NCHAR(10) NULL, 
    [nivel] INT NULL
)
