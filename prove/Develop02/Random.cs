/*
namespace Develop02;

public class Random
{
     
    List<string> _spinnerstrings = new() { "|", "/", "-", "\\"};
     int i = 0;

        int startTime = 0;
        int endTime = 5;


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





*/