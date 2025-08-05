using System;

public class GradeCalculator
{
    public static void Run()
    {
        Console.Write("Enter a numerical grade (0 - 100): ");
        int grade = int.Parse(Console.ReadLine());

        string letter = grade switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        Console.WriteLine($"Letter Grade: {letter}");
    }
}
