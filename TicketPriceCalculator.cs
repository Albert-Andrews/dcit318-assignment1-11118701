using System;

public class TicketPriceCalculator
{
    public static void Run()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;

        Console.WriteLine($"Ticket Price: GHC{price}");
    }
}
