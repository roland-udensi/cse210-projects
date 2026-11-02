using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        Console.WriteLine("The magic number has been chosen!");

        int guessNum;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if (magicNum > guessNum)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guessNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guessNum != magicNum);

    }

}