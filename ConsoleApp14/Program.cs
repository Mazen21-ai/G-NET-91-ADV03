using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose an Exercise:");
        Console.WriteLine("1. Student Grade Manager");
        Console.WriteLine("2. Leaderboard");
        Console.WriteLine("3. Phone Book");
        Console.WriteLine("4. Unique Email Validator");
        Console.WriteLine("5. Print Queue Simulator");
        Console.WriteLine("6. Browser History");

        Console.Write("Enter Exercise Number: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                StudentGradeManager.Run();
                break;

            case "2":
                Leaderboard.Run();
                break;

            case "3":
                PhoneBook.Run();
                break;

            case "4":
                UniqueEmailValidator.Run();
                break;

            case "5":
                PrintQueueSimulator.Run();
                break;

            case "6":
                BrowserHistory.Run();
                break;

            default:
                Console.WriteLine("Invalid Exercise Number");
                break;
        }
    }
}




