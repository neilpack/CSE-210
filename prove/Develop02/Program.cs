using System;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        PromptGen promptGen = new PromptGen();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to Your Journal!");

        bool done = false;
        while (!done)
        {
            menu.Display();
            int choice = menu.GetUserChoice();

            switch (choice)
            {
                case 1:
                    // Get a random prompt
                    string prompt = promptGen.GeneratePrompt();
                    // Get the user's response
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    // Create a new entry
                    Entry entry = new Entry(prompt, response, DateTime.Now);
                    // Add the entry to the journal
                    journal.AddEntry(entry);
                    break;

                case 2:
                    Console.WriteLine("Reading the journal");
                    journal.DisplayJournal();  // Display all entries in the journal
                    break;

                case 3:
                    Console.WriteLine("Displaying menu again");
                    break;

                case 4:
                    promptGen.ReadPrompt();
                    break;

                case 5:
                    Console.WriteLine("Saving journal as a .txt file");
                    Console.Write("Enter the filename (with extension, example: myjournal.txt): ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case 6:
                    Console.WriteLine("Loading from file");
                    Console.Write("Enter the filename (with extension, example: myjournal.txt): ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case 7:
                    Console.WriteLine("Exiting");
                    done = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}