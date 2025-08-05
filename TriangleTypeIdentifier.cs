using System;

public class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.Write("Enter side A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter side B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter side C: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Equilateral Triangle");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Isosceles Triangle");
        else
            Console.WriteLine("Scalene Triangle");
    }
}
