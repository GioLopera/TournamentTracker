CREATE TABLE [dbo].[Prizes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlaceNumber] INT NOT NULL, 
    [PlaceName] NVARCHAR(100) NOT NULL, 
    [PrizeAmount] MONEY NOT NULL DEFAULT 0, 
    [PrizePercentage] FLOAT NOT NULL DEFAULT 0
)
