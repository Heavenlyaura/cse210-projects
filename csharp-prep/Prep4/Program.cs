using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List <int > numList = new List<int>();
        while (true)
        {
            Console.Write("Enter a number (enter 0 to stop): ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
            numList.Add(userInput);
            }

            else{
                break;
            }
        }

        // calculate the sum of the list
        int sum = 0;

        foreach (int num in numList)
        {
            sum += num;
        }

        Console.WriteLine($"sum: {sum }");

        // calculate the average 
        int length = numList.Count;

        float average = sum / length;
        Console.WriteLine($"Average: {average}");

        // calcuate the largest number in the list
        int max = 0;
        foreach (int n in numList)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"Max Number: {max}");

        // find the smallest positive number in the list

        int min = sum; // i made the min number to be the sum of the list, this always ensures that the min is alway greater than an item in the list
        foreach (int i in numList)
        {
            if (i < min && i > 0)
            {
                min = i;
            }
        }
        Console.WriteLine($"Min Number Above Zero: {min}");
        numList.Sort((a, b) => a.CompareTo(b)); // this is a sorting function in assending order

        foreach (int n in numList) // prints out the items of the list to the console!
        {
            Console.WriteLine(n);
        }
        
    }
    
}