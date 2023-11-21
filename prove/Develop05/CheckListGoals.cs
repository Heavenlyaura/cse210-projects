namespace Develop05;

public class CheckListGoals : Goals
{
    private int _times;
    private bool _iscomplete = false;
    
    public override void Play()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        _name.Add(goalName);

        Console.Write("Write a short description? ");
        string goalDescription = Console.ReadLine();
        _description.Add(goalDescription);

        Console.Write("How many points will be associated with this goal? ");
        int times = int.Parse(Console.ReadLine());

        Console.Write("How many points will be associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        _gamepoints.Add(points);
    }

    public void RecordEvent()
    {
        int i = 0;
        foreach (string item in _name)
        {
            i += 1;
            Console.WriteLine($"{i}. {item}");
        }

        Console.Write("Which");


    }

}
