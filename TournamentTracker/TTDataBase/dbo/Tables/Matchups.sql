CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WinnerId] INT NOT NULL, 
    [MatchupRound] INT NOT NULL, 
    [TournamentId] INT NOT NULL, 
    CONSTRAINT [FK_Matchups_Teams] FOREIGN KEY (WinnerId) REFERENCES Teams(Id), 
    CONSTRAINT [FK_Matchups_TournamentsId] FOREIGN KEY (TournamentId) REFERENCES Tournaments(Id)
)
