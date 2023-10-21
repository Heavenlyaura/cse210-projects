using System;
using Develop03;
namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.Write("Enter number of words you want to hide: ");
        int hideCount = int.Parse(Console.ReadLine()); // selectes the number of words to be hidden at a time

        Reference reference = new();
        string book = reference.GetReference();
        string textVerse = reference.GetVerse();
        string endTextVerse = reference.GetEndVerse();
        Scripture scriptures = new(book, textVerse, endTextVerse);

        Console.WriteLine(scriptures.GetRenderedText());

        while (true)
        {
            string read = Console.ReadLine();
            Console.Clear();

            if (read.ToLower() != "quit")
            {
                scriptures.HideWords(hideCount);
                string text = scriptures.GetRenderedText();
                Console.WriteLine(text);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}


