CREATE TABLE [dbo].[TournamentPrizes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [PrizeId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentPrizes_TournamentsId] FOREIGN KEY (TournamentId) REFERENCES Tournaments(Id), 
    CONSTRAINT [FK_TournamentPrizes_Prizes] FOREIGN KEY (PrizeId) REFERENCES Prizes(Id)
)
