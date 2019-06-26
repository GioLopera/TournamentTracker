CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
Begin
	-- Set Nocount on to prevent extra result from interfering with Select statement
	Set Nocount On;

	select p.*
	from TeamMembers m
	inner join People p on m.PersonId = p.Id
	where m.TeamId = @TeamId;

End
