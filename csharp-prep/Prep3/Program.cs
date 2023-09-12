using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgen = new Random();
        int magicNumber = randomgen.Next(1,100);
        int guessCount = 0; // this variable will keep count of how many guess was made by the user

        while (true) // the while loop will always run
        {
            Console.Write("Enter you guess: ");
            int guess = int.Parse(Console.ReadLine());
            guessCount ++; // increments the guess count by one in each iteration

            if (guess > magicNumber)
            {
                Console.WriteLine("Guess Lower!");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher!");
            }

            else
            {
                Console.WriteLine("Correct!!!");
                Console.WriteLine($"you had {guessCount} guesses");

                Console.Write("Do you want to play again? ");
                string playAgain = Console.ReadLine().ToLower();
                guessCount = 0; // resets the guess count to zero

                if (playAgain == "yes")
                {
                    magicNumber = randomgen.Next(1,100); // generate a new random number between 1 - 100
                    continue; 
                }

                else if (playAgain == "no")
                {
                    break;
                }
            }
        }

        
    }
}