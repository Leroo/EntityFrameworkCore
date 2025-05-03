using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;

//We need an instance of the context (which represents the Db) in order to query 
using var context = new FootballLeagueDbContext();//using entails destroying the intance soon as
//it is out of the scope of this class

//Select all Teams
//GetAllTeams();

//Selecting a sinlge record
var teamOne = await context.Teams.FindAsync();

//Selecting a record that meets a certain critierion
var teamTwo = await context.Teams.FindAsync(team => team.TeamId==1);


void GetAllTeams()
{
    var teams = context.Teams.ToList();
    foreach (var t in teams)
    {
        Console.WriteLine(t.Name);
    }
}
