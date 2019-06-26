CREATE TABLE [dbo].[MatchupEntries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MatchupId] INT NOT NULL, 
    [ParentMatchupId] INT NOT NULL, 
    [TeamCompetingId] INT NOT NULL, 
    [Score] FLOAT NOT NULL, 
    CONSTRAINT [FK_MatchupEntries_Matchups] FOREIGN KEY (MatchupId) REFERENCES Matchups(Id), 
    CONSTRAINT [FK_MatchupEntries_Matchups2] FOREIGN KEY (ParentMatchupId) REFERENCES Matchups(Id), 
    CONSTRAINT [FK_MatchupEntries_Teams] FOREIGN KEY (TeamCompetingId) REFERENCES Teams(Id)
)
