using System;
using System.Diagnostics;
using Develop04;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        BreathingActivity breathingActivity = new();
        ReflectionActivity reflectionActivity = new();
        ListingActivity listingActivity = new();

        while (true)
        {
            menu.DisplayMenu();
            int option = menu.ChooseOption();

            switch (option)
            {
                case 1:
                    option = 1;

                    Console.Write("How long do you want it to last (in seconds)?");
                    int duration = int.Parse(Console.ReadLine());
                    breathingActivity.RunTheActivity(duration);
                    break;

                case 2:
                    option = 2;

                    Console.Write("How long do you want it to last (in seconds)?");
                    int time = int.Parse(Console.ReadLine());
                    reflectionActivity.RunTheActivity(time);
                    break;

                case 3:
                    option = 3;

                    Console.Write("How long do you want it to last (in seconds)?");
                    int timer = int.Parse(Console.ReadLine());
                    listingActivity.RunTheActivity(timer);
                    break;

                case 4:
                    option = 4;
                    Console.Clear();
                    Environment.Exit(0);
                    break;
           }     
        }
       
    }
}

