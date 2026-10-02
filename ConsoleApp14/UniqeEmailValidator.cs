using System;
using System.Collections.Generic;
using System.Linq;

public class UniqueEmailValidator
{
    public static void Run()
    {
        HashSet<string> emails =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        emails.Add("ahmed@test.com");
        emails.Add("AHMED@test.com");
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.Com");

        Console.WriteLine("Emails: " + string.Join(", ", emails));

        Console.WriteLine("Email Count: " + emails.Count);

        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

        HashSet<int> union = new HashSet<int>(setA);
        union.UnionWith(setB);

        Console.WriteLine("UnionWith: " +
            string.Join(", ", union.OrderBy(x => x)));

        HashSet<int> intersection = new HashSet<int>(setA);
        intersection.IntersectWith(setB);

        Console.WriteLine("IntersectWith: " +
            string.Join(", ", intersection.OrderBy(x => x)));

        HashSet<int> difference = new HashSet<int>(setA);
        difference.ExceptWith(setB);

        Console.WriteLine("ExceptWith: " +
            string.Join(", ", difference.OrderBy(x => x)));

        HashSet<int> subset = new HashSet<int> { 1, 2 };

        Console.WriteLine("{1, 2} is subset of Set A: " +
            subset.IsSubsetOf(setA));
    }
}