namespace Develop05;

public class SimpleGoals : Goals
{
    // private int _goalpoint;
    // private int _goalname;
    // private string _goaldescription;

    public override void Play()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        _name.Add(goalName);

        Console.Write("Write a short description? ");
        string goalDescription = Console.ReadLine();
        _description.Add(goalDescription);

        Console.Write("How many points will be associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        _gamepoints.Add(points);
    }

    // public override void DisplayGoals()
    // {
    //     for (int i = 0; i < _description.Count; i++)
    //     {
    //         Console.WriteLine($"[ ] {_name[i]} ({_description[i]})");
    //     }
    // }




}
