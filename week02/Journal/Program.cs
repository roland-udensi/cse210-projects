
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: I added mood tracking to each journal entry.
        // This allows users to record how they felt when writing,
        // helping them reflect on their emotional experiences over time.
          
        Journal journal = new Journal();
        Random random = new Random();

        string[] prompts =
        {
            "What was the best part of your day?",
            "Who made you smile today?",
            "What did you learn today?",
            "How did you see the hand of the Lord in your life today?",
            "What is one thing you are grateful for today?",
            "What challenge did you overcome today?",
            "What would you like to improve tomorrow?"
        };

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts[random.Next(prompts.Length)];

                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("How are you feeling today? ");
                    string mood = Console.ReadLine();

                    string date = DateTime.Now.ToString("g");

                    Entry entry = new Entry(date, prompt, response, mood);

                    journal.AddEntry(entry);

                    Console.WriteLine("Your entry has been added!");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();

                    try
                    {
                        journal.SaveToFile(saveFile);
                    }
                    catch (IOException error)
                    {
                        Console.WriteLine($"Error saving journal: {error.Message}");
                    }
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();

                    try
                    {
                        journal.LoadFromFile(loadFile);
                    }
                    catch (IOException error)
                    {
                        Console.WriteLine($"Error loading journal: {error.Message}");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    break;
            }
        }
    }
}
