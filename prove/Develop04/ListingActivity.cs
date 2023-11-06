namespace Develop04;

public class ListingActivity : ActivityClass
{

    private string name = "Listening Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _list = new(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};


    
    public void ListeningSession(int duration)
    {
        
        StartingMessage(name, _description);
        SpinnerAnimation(0,4);

        Console.WriteLine("Ready!");
        Console.Clear();
        string question = PickFromList(_list);
        Console.WriteLine($"----- {question} -----");
        Console.WriteLine("You may begin");

        while (duration != 0)
        {
            Console.Write("> ");
            Console.ReadLine();
            duration -= 1;
        }
        SpinnerAnimation(0,3);
        EndingMessage(duration, name);
        SpinnerAnimation(0,3);
        Console.Clear();
    }
}
