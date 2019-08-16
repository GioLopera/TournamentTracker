CREATE PROCEDURE [dbo].[spTeam_GetAll]
	
AS
Begin
	Set Nocount on;

	select *
	from Teams;

End
