using System;
using System.Collections.Generic;

public class PhoneBook
{
    public static void Run()
    {
        Dictionary<string, string> contacts =
            new Dictionary<string, string>();

        contacts.Add("Ahmed", "01011111111");
        contacts.Add("Sara", "01022222222");
        contacts.Add("Mona", "01033333333");
        contacts.Add("Ali", "01044444444");

        contacts["Omar"] = "01055555555";

        Console.WriteLine("Omar's Phone: " + contacts["Omar"]);

        try
        {
            contacts.Add("Ahmed", "01099999999");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        bool added = contacts.TryAdd("Ahmed", "01088888888");

        Console.WriteLine("TryAdd succeeded: " + added);

        Console.WriteLine("Karim exists: " +
            contacts.ContainsKey("Karim"));

        if (contacts.TryGetValue("Karim", out string phone))
        {
            Console.WriteLine("Karim's Phone: " + phone);
        }
        else
        {
            Console.WriteLine("Karim's Phone: Not Found");
        }

        Console.WriteLine("Keys:");
        Console.WriteLine(string.Join(", ", contacts.Keys));

        Console.WriteLine("Values:");
        Console.WriteLine(string.Join(", ", contacts.Values));
    }
}