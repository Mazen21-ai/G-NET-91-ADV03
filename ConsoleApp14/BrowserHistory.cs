using System;
using System.Collections.Generic;

public class BrowserHistory
{
    public static void Run()
    {
        Stack<string> history = new Stack<string>();

        history.Push("google.com");
        history.Push("github.com");
        history.Push("stackoverflow.com");
        history.Push("youtube.com");
        history.Push("claude.ai");

        Console.WriteLine("Current page: " + history.Peek());

        for (int i = 0; i < 3; i++)
        {
            string page = history.Pop();

            Console.WriteLine("Back from: " + page);
        }

        Console.WriteLine("Current page after going back: " +
            history.Peek());

        while (history.Count > 0)
        {
            history.Pop();
        }

        bool success = history.TryPop(out string pageAfter);

        Console.WriteLine("TryPop succeeded: " + success);

        Console.WriteLine("Returned page: " +
            (pageAfter ?? "null"));
    }
}