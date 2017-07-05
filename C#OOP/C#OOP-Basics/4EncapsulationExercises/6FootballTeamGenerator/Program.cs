namespace _6FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Team> teams = new List<Team>();

            while (input != "END")
            {
                var data = input.Split(new char[] {';'});
                if (data[0] == "Team")
                {
                    string teamName = data[1];
                    try
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (data[0] == "Add")
                {
                    string teamName = data[1];
                    string playerName = data[2];
                    double endurance = double.Parse(data[3]);
                    double sprint = double.Parse(data[4]);
                    double dribble = double.Parse(data[5]);
                    double passing = double.Parse(data[6]);
                    double shooting = double.Parse(data[7]);

                    Team team = teams.FirstOrDefault(t => t.Name == teamName);

                    if (team == null)
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        input = Console.ReadLine();
                        continue;
                    }

                    try
                    {
                        PlayerStats playerStats = new PlayerStats(endurance, sprint, dribble, passing, shooting);
                        Player player = new Player(playerName, playerStats);
                        team.AddPlayer(player);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else if (data[0] == "Remove")
                {
                    string teamName = data[1];
                    string playerName = data[2];

                    Team team = teams.FirstOrDefault(t => t.Name == teamName);

                    if (team == null)
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        input = Console.ReadLine();
                        continue;
                    }

                    try
                    {
                        team.RemovePlayer(playerName);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                else if (data[0] == "Rating")
                {
                    string teamName = data[1];

                    Team team = teams.FirstOrDefault(t => t.Name == teamName);

                    if (team == null)
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        input = Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine($"{team.Name} - {team.Rating}");
                }

                input = Console.ReadLine();
            }
        }
    }
}