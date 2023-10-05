// See https://aka.ms/new-console-template for more information

using System.IO.Compression;
using System.Security.Cryptography;
using Develop02;

Lists listSave = new();
List<string> saveList = listSave.SaveList();

Lists listPrompt = new();
List<string> promptList = listPrompt.PromptListing();


Console.Write("Enter your name: ");
string name = Console.ReadLine();
Journal journal = new()
{
    _fullname = name
};

int saveCount = 0; // used to check if a file has been saved
int writeCount = 0; // used to check if an entry has been made

while (true)
{
    try
    {
        int choice = journal.DisplayMenu();

        if (choice > 5 || choice < 0) // checks if the user enters an number greater or lesser than the avaliable options.
        {
            Console.WriteLine($"Option {choice} isnt avaiable! pick from 1-5\n");
        }

        else // else if user enter a valid option the program provides them with the option based on their choice. 
        {
            if (choice == 1)
            {
                if (promptList.Count > 0) // checks if there are prompts left to be displayed in the prompt list.
                {
                    journal.Write(promptList, saveList);
                    writeCount += 1;
                }

                else
                {
                    Console.WriteLine("There are no more prompts avaliable!\n");
                }
            }

            else if (choice == 2)
            {
                if (saveList.Count < 1) // prompts the user to make and entry to be displayed if the saveList is empty
                {
                    Console.WriteLine("\nThere are no Entries to display. Record your entries or load a file!\n");
                }
                else
                {
                    journal.Display(saveList);
                }
            }

            else if (choice == 3)
            {
                journal.Load(saveList);  
            }

            else if (choice == 4)
            {
                if (saveList.Count == 0) // checks if the saveList is empty, if true tells the user that there is nothing to be saved, if false saves the changes made by the user.
                {
                    Console.WriteLine("There are currently no changes made to be saved. recored an entry first!");
                }
                else
                {
                    journal.Save(saveList);
                    saveCount += 1;
                }
                
            }

            else if (choice == 5)
            {
                if (saveCount < 1 && writeCount > 0) // if the user made and entry and exits without saving the file, this condition checks and prompts the user to save the changes they made before exiting the program.
                {
                    Console.Write("Do you want to save your file? ");
                    string save = Console.ReadLine().ToLower();

                    if (save == "yes")
                    {
                        journal.Save(saveList);
                        Console.WriteLine("Hope you recorded the best memories! Till next time. Goodbye!\n");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hope you recorded the best memories! Till next time. Goodbye!\n");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Hope you recorded the best memories! Till next time. Goodbye!\n");
                    Environment.Exit(0);
                }
            }
        }
    }

    catch (FileNotFoundException fnf)
    {
        Console.WriteLine($"\nFileNotFound: {fnf.Message}\n");
    }

    catch (FormatException fe)
    {
        Console.WriteLine($"\nFormatException: {fe.Message}\n");
    }

}