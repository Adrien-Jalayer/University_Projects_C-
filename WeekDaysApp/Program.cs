using System;

class Program
{
    static void Main()
    {

        string[] daysOfWeek = {
            "sat",    // index 0
            "sun",  // index 1
            "mon",  // index 2
            "tue", // index 3
            "wed",// index 4
            "thu",// index 5
            "fri"     // index 6
        };

        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 7)
        {
            Console.WriteLine("Today is: " + daysOfWeek[number - 1]);
        }
        else
        {
            Console.WriteLine("!END");
        }
    }
}