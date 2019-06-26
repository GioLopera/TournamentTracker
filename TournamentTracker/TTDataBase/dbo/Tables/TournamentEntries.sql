CREATE TABLE [dbo].[TournamentEntries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentEntries_TournamentsId] FOREIGN KEY (TournamentId) REFERENCES Tournaments(Id), 
    CONSTRAINT [FK_TournamentEntries_Teams] FOREIGN KEY (TeamId) REFERENCES Teams(Id)
)
