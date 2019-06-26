CREATE PROCEDURE [dbo].[spTournaments_GetAll]
AS
Begin
	-- Set Nocount on to prevent extra result from interfering with Select statement
	Set Nocount On;

	select *
	from Tournaments
	where Active = 1;

End
