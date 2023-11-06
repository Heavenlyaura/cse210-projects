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


        while (true)
        {
            menu.DisplayMenu();
            int option = menu.ChooseOption();
            Console.WriteLine();

            switch (option)
            {
                case 1:
                    option = 1;
                    breathingActivity.BreathingSession(3,3);
                    break;

                case 2:
                    option = 2;
                    reflectionActivity.ReflectionSession(40);
                    break;
           }     
        }
       
    }
}


