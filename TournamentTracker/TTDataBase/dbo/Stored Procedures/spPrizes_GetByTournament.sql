CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
AS
Begin
	-- Set Nocount on to prevent extra result from interfering with Select statement
	Set Nocount On;

	select p.*
	from Prizes p
	inner join TournamentPrizes t on p.Id = t.PrizeId
	where t.TournamentId = @TournamentId;

End
