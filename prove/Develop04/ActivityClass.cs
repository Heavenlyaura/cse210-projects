namespace Develop04;

public class ActivityClass
{
    private List<string> _spinnerstrings = new() { "|", "/", "-", "\\"};

    // private string _endingmessage;
    public void StartingMessage(string activityName, string activityDescription)
    {
        string StartingMessage = $"Welcome to {activityName} \n{activityDescription}";

        Console.WriteLine(StartingMessage);
    }

    public void EndingMessage(int timeCompleted, string activityName)
    {
        string endingMessage = $"You have completed another {timeCompleted} seconds of {activityName}";

        Console.WriteLine(endingMessage);
    }

    public void SpinnerAnimation(int startTime, int endTime)
    {
        int i = 0;
        while (startTime < endTime)
        {
            string s = _spinnerstrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            startTime ++;
            if (i >= _spinnerstrings.Count) // sets i = 0 so the iteration wont go out of index and keeps the spinner rolling for the given amount of time
            {
                i = 0;
            }
        }
    }

    public void CountDown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Timer(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
    }
}
