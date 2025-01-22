
class Choice
{
    // methods
    public int GetChoice()
    {
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();
        return Convert.ToInt32(choice);
    }
}
