using System;

public class Menu
{
    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine("1) Write New Entry");
        Console.WriteLine("2) Read Journal");
        Console.WriteLine("3) Display Menu");
        Console.WriteLine("4) Get A Prompt");
        Console.WriteLine("5) Save Journal");
        Console.WriteLine("6) Load Journal");
        Console.WriteLine("7) Exit");
        Console.WriteLine("");
    }

    public int GetUserChoice()
    {
        while (true)
        {
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result) && result >= 1 && result <= 7)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }
    }
}
