namespace Develop04;

public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Mindfulness Program");
        Console.WriteLine("Menu Option: ");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Reflecting activity");
        Console.WriteLine("3. Listing activity");
        Console.WriteLine("4. Exit");
    }

    public int ChooseOption()
    {
        Console.Write("Pick a Menu Option: ");
        int MenuOption = int.Parse(Console.ReadLine());

        return MenuOption;
    }
}


/*

        Console.WriteLine();
        StartingMessage(_actvityname, _description);
        Console.Write("Wait a Bit ");
        SpinnerAnimation(start, end);
        Console.WriteLine("Ready!");








*/