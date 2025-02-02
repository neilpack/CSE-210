using System;

public class PromptGen
{
    public void ReadPrompt()
    {
        bool done = false;
        while (!done)
        {
            Console.WriteLine("Now Generating a Prompt");
            Console.WriteLine("");
            GeneratePrompt();
            Console.WriteLine("\nWould you like another prompt?");
            Console.WriteLine("1) Yes   2) No");
            int choice = GetUserInput();
            if (choice == 2)
            {
                done = true;
            }
        }
    }

    public string GeneratePrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If I could summarize my day in one sentence, how would I do that?",
            "What was the worst part of my day?",
            "Did I smile today? Why?",
            "Did I overcome a challenge today?",
            "What is something that I am grateful for?"
        };

        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        Console.WriteLine("Here is your randomized prompt: ");
        Console.WriteLine(prompts[index]);
        return prompts[index];
    }

    private int GetUserInput()
    {
        while (true)
        {
            Console.Write("");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result) && (result == 1 || result == 2))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
            }
        }
    }
}
