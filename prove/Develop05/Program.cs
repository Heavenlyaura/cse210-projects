using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        Goals goals = new();
        SimpleGoals simpleGoals = new();
        CheckListGoals checkListGoals = new();
        EternalGoals eternalGoals = new();
        
        while (true)
        {
            menu.MenuOptions();
            Console.Write("> ");

            int pick = int.Parse(Console.ReadLine());

            if (pick == 1)
            {
                menu.GoalType();
                Console.Write("Choose a Goal type: ");
                int type = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (type)
                {
                    case 1:
                        type = 1;
                        simpleGoals.Play();
                        break;
                }
            }

            else if (pick == 2)
            {
                simpleGoals.DisplayGoals();
            }

            else if (pick == 3)
            {
                goals.SaveToFile("goal.json");
                // save.DisplayList();
            }
        }
    }
}