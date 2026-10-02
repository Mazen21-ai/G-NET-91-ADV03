using System;
using System.Collections.Generic;
using System.Linq;

public class Leaderboard
{
    public static void Run()
    {
        SortedDictionary<int, string> players =
            new SortedDictionary<int, string>();

        players.Add(500, "Ahmed");
        players.Add(200, "Sara");
        players.Add(800, "Ali");
        players.Add(350, "Mona");

        Console.WriteLine("Leaderboard:");

        foreach (var player in players)
        {
            Console.WriteLine(player.Key + " = " + player.Value);
        }

        Console.WriteLine("First key: " + players.First().Key);

        Console.WriteLine("First value: " + players.First().Value);

        Console.WriteLine("Score 500 exists: " +
            players.ContainsKey(500));

        if (players.TryGetValue(999, out string player999))
        {
            Console.WriteLine("Player with score 999: " + player999);
        }
        else
        {
            Console.WriteLine("Player with score 999: Not Found");
        }

        players.Remove(200);

        Console.WriteLine("After removing score 200:");

        foreach (var player in players)
        {
            Console.WriteLine(player.Key + " = " + player.Value);
        }
    }
}