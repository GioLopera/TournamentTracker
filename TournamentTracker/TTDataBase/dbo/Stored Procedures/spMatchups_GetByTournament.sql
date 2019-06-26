CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
	@TournamentId int
AS
Begin
	-- Set Nocount on to prevent extra result from interfering with Select statement
	Set Nocount On;

	select m.*
	from Matchups m
	where m.TournamentId = @TournamentId
	order by MatchupRound;

End
