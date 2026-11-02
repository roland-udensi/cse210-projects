using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int numb = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numb != 0)
        {
            Console.Write("Enter Number: ");
            string num = Console.ReadLine();
            numb = int.Parse(num);

            if (numb != 0)
            {
                numbers.Add(numb);
            }

        }

        // Compute the sum -- Requirement 1
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");

        // Compute the average -- Requirement 2
        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // Find the maximum number -- Requirement 3
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The maximum number in the list is: {max}");

    }
}