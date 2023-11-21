using System.Drawing;

namespace Develop05;

public class Menu : Goals
{
    public void MenuOptions()
    {
        int points = GetPoints();
        Console.WriteLine($"You have {points} Points");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create new Menu");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }

    public void GoalType()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("1. Eternal Goal");
        Console.WriteLine("1. Checklist Goal");
    }

}
