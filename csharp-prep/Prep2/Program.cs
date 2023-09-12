using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your grades: ");
        string userInput = Console.ReadLine();
        int points = int.Parse(userInput);
        int remainder = points % 10;
        string plus = "+";
        string minus = "-";
        string grade = "";

        // this portion of code checks for the grade of the student
        if (points >= 90)
        {
            grade = "A";
        }

        else if (points >= 80)
        {
            grade = "B";
        }

        else if (points >= 70)
        {
            grade = "C";
        }

        else if (points >= 60)
        {
            grade = "D";
        }

        else
        {
            grade ="F";
        }

        // this portion of code determines if the student had a "-" or "+" to their grades
        if (remainder >= 7 && (grade == "B" || grade == "C" || grade == "D") ) // this conditions ensures that the "+" is not attached to the grade F and A
        {
            grade += plus;
        }

        else if (remainder <= 3 && (grade == "A" || grade == "B" || grade == "C" || grade == "D")) // this conditions ensures that the "-" is not attached to the grade F
        {
            grade += minus;
        }


        // this displays the students grades to the console/ terminal
        Console.WriteLine($"Your Grade is: {grade}");

        if (points >= 70)
        {
            Console.WriteLine("Congratulations you passed the course!!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass the course, but con can definetly do better next time!!");
        }  
    }
}