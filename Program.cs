using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Създаване на играчи
        var player1 = new Goalkeeper { Name = "Player 1", Number = 1, Age = 25, Height = 1.85 };
        var player2 = new Defender { Name = "Player 2", Number = 2, Age = 28, Height = 1.82 };
        // ...

        // Създаване на треньори
        var coach1 = new Coach { Name = "Coach 1", Age = 45 };
        var coach2 = new Coach { Name = "Coach 2", Age = 50 };

        // Създаване на отбори
        var team1 = new Team { Coach = coach1, Players = new List<FootballPlayer> { player1, player2 } };
        var team2 = new Team { Coach = coach2, Players = new List<FootballPlayer> { /* ... */ } };

        // Създаване на съдии
        var referee = new Referee { Name = "Referee 1", Age = 35 };
        var assistantReferee1 = new AssistantReferee { Name = "Assistant Referee 1", Age = 30 };
        var assistantReferee2 = new AssistantReferee { Name = "Assistant Referee 2", Age = 32 };

        // Създаване на мач
        var game = new Game
        {
            Team1 = team1,
            Team2 = team2,
            Referee = referee,
            AssistantReferees = new List<AssistantReferee> { assistantReferee1, assistantReferee2 },
            Goals = new List<Goal>(),
            Result = "",
            Winner = null
        };

        // Добавяне на голове към мача
        var goal1 = new Goal { Minute = 15, Player = player1 };
        var goal2 = new Goal { Minute = 30, Player = player2 };

        game.Goals.Add(goal1);
        game.Goals.Add(goal2);

        // Изчисляване на резултата и определяне на победителя
        if (game.Goals.Count > 0)
        {
            if (game.Goals.Count % 2 == 0)
            {
                game.Result = "Draw";
            }
            else
            {
                game.Result = "Team 1 wins";
                game.Winner = game.Team1;
            }
        }
        else
        {
            game.Result = "No goals scored";
        }

        // Отпечатване на резултата от мача
        Console.WriteLine("Result: " + game.Result);

        if (game.Winner != null)
        {
            Console.WriteLine("Winner: " + game.Winner.Coach.Name);
        }
    }
}