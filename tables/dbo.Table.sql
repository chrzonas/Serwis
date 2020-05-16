CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(20) NULL, 
    [Surname] NCHAR(20) NULL, 
    [Tel] NCHAR(15) NULL, 
    [Street] NCHAR(30) NULL, 
    [House number] NCHAR(10) NULL, 
    [Apartment number] NCHAR(10) NULL, 
    [City] NCHAR(30) NULL, 
    [Zip code] NCHAR(10) NULL, 
    [Post office] NCHAR(30) NULL
)
