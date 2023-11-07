using System.Diagnostics;

namespace Develop04;

public class ListingActivity : ActivityClass
{

    private string name = "Listening Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _list = new(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};


    
   public void ListeningSession(int durationInSeconds)
{
    StartingMessage(name, _description);
    SpinnerAnimation(0, 4);

    Console.WriteLine("Ready!");
    Console.Clear();
    string question = PickFromList(_list);
    Console.WriteLine($"----- {question} -----");
    Console.WriteLine("You may begin");

    // Start a stopwatch to keep track of the elapsed time
    Stopwatch stopwatch = new();
    stopwatch.Start();

    // Continue the session until the elapsed time reaches the specified duration
    while (stopwatch.Elapsed.TotalSeconds < durationInSeconds)
    {
        Console.Write("> ");
        Console.ReadLine();
    }

    stopwatch.Stop();

    SpinnerAnimation(0, 3);
    EndingMessage(durationInSeconds, name);
    SpinnerAnimation(0, 3);
    Console.Clear();
}}