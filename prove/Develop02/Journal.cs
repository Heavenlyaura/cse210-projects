namespace Develop02;

public class Journal
{
    public string _fullname;

    public int DisplayMenu()
    {
        Console.WriteLine($"{_fullname}, Welcome to Macaroni Journal system!");
        Console.WriteLine("Please Enter one of the following: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What will you like to do: ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

    public void Write(List<string> PromptList, List<string> saveList)
    {
        PromptGenerator promptgen = new();
        string prompt = promptgen.PrompGen(PromptList);
        Console.WriteLine(prompt);
        Console.Write("> ");
        string entry = Console.ReadLine();
        Write writeList = new();
        writeList.WriteEntryToList(prompt, entry, saveList);
        Console.WriteLine("\nEntry Recorded!!\n");
    }

    public void Display(List<string> saveList)
    {
        Console.WriteLine($"{_fullname} Here are your entries: ");
        foreach (string item in saveList)
        {
            Console.WriteLine(item);
        }
    }

    public void Load(List<string> saveList)
    {
        Console.Write("Enter a file to Load from: ");
        string file = Console.ReadLine();
        Load loadFile = new();
        loadFile.LoadFromFile(saveList, file);
        Console.WriteLine("File loaded sucessfully!!\n");
    }

    public void Save(List<string> saveList)
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();
        Write writeFile = new();
        writeFile.WriteEntryToFile(fileName, saveList);
        Console.WriteLine("File saved!!\n");
    }

}
