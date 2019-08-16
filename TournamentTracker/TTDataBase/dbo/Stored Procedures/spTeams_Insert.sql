CREATE PROCEDURE [dbo].[spTeams_Insert]
	@TeamName nvarchar(100),
	@id int = 0 output
AS
Begin
	-- Set Nocount on to prevent extra result from interfering with Select statement
	Set Nocount On;

	insert into dbo.Teams (TeamName)
	values (@TeamName)

	select @id = SCOPE_IDENTITY();

End
