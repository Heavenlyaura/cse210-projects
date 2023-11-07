using System.Diagnostics;

namespace Develop04;

public class BreathingActivity : ActivityClass
{
    private string _actvityname = "Breathing Activity!";
    private string _description = "Help the you pace your breathing to have a session of deep breathing for a certain amount of time. you might find more peace and less stress through the exercise.\n";

    public void BreathingSession(int duration)
    {
        int start = 0;
        int end = 5;

        Console.WriteLine();
        StartingMessage(_actvityname, _description);
        Console.Write("Wait a Bit ");
        SpinnerAnimation(start, end);
        Console.Clear();
        Console.WriteLine("Ready!");
        
        Stopwatch stopwatch = new();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("Breathe in....");
            // Thread.Sleep(1000);
            CountDown(5);
            // Console.Write("Hold ");

            Console.Write("\nBreathe Out.... ");
            CountDown(5);
            // Thread.Sleep(1500);
            Console.WriteLine();
        }

        stopwatch.Stop();
        // EndingMessage(reps * duration * 2, _actvityname);
        SpinnerAnimation(start, end);
        Console.Clear();
    }
}
