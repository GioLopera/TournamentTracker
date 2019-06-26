CREATE PROCEDURE [dbo].[spPeople_GetAll]
	
AS
Begin
	-- Set Nocount on to prevent extra result from interfering with Select statement
	Set Nocount On;

	select *
	from People;

End
