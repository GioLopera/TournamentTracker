CREATE TABLE [dbo].[TeamMembers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TeamId] INT NOT NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [FK_TeamMembers_TeamsId] FOREIGN KEY (TeamId) REFERENCES Teams(Id), 
    CONSTRAINT [FK_TeamMembers_People] FOREIGN KEY (PersonId) REFERENCES People(Id)
)
