using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percent? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);

        string letter = "";


        if (gradePercent >= 90)
        {
            letter = "A";
        }

        else if (gradePercent >= 80)
        {
            letter = "B";
        }

        else if (gradePercent >= 70)
        {
            letter = "C";
        }

        else if (gradePercent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class. Great Job!");
        }

        else
        {
            Console.WriteLine("Don't give up! Keep learning and try again next time");
        }

    }
}