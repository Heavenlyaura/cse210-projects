using System;

class Program
{

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter you Name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter you favourite number: ");
        int userInput = int.Parse(Console.ReadLine());
        return userInput;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }

    static void Main(string[] args)
    {
        WelcomeMessage();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(userName, square);
    }
}