using System;
using System.Collections.Generic;

public class StudentGradeManager
{
    public static void Run()
    {
        List<int> grades = new List<int>
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

        Console.WriteLine("Grades: " + string.Join(", ", grades));

        Console.WriteLine("Count: " + grades.Count);

        Console.WriteLine("First grade: " + grades[0]);

        Console.WriteLine("Last grade: " + grades[grades.Count - 1]);

        grades.Sort();

        Console.WriteLine("Sorted grades: " + string.Join(", ", grades));

        Console.WriteLine("First grade above 90: " +
            grades.Find(g => g > 90));

        Console.WriteLine("Grades below 75: " +
            string.Join(", ", grades.FindAll(g => g < 75)));

        grades.RemoveAll(g => g < 75);

        Console.WriteLine("After removing failing grades: " +
            string.Join(", ", grades));

        Console.WriteLine("Any grade equals 100: " +
            grades.Contains(100));

        List<string> gradeLabels = new List<string>();

        foreach (int grade in grades)
        {
            gradeLabels.Add("Grade: " + grade);
        }

        Console.WriteLine("Grade labels: " +
            string.Join(", ", gradeLabels));
    }
}