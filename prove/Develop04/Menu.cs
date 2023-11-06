namespace Develop04;

public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to Mindfulness Program");
        Console.WriteLine("Menu Option: ");
        Console.WriteLine("Start breathing activity");
        Console.WriteLine("Start reflecting activity");
        Console.WriteLine("Start listing activity");
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