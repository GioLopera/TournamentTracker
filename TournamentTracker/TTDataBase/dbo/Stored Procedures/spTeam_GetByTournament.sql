CREATE PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
Begin
	-- Set Nocount on to prevent extra result from interfering with Select statement
	Set Nocount On;

	select t.*
	from Teams t
	inner join TournamentEntries e on t.Id = e.TeamId
	where e.TournamentId = @TournamentId;

End
