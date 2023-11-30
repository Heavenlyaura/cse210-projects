namespace FinalProject;

public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to Kubwa Ward 1");
        Console.WriteLine("Choose Option: ");
        Console.WriteLine("1. Bishop: ");
        Console.WriteLine("2. Relief Society: ");
        Console.WriteLine("3. Elders Quourm: ");
        Console.WriteLine("4. Member: ");
        Console.Write("> ");

    }

    public void BishopMenu()
    {
        Console.WriteLine("Welcome Bishop");
        Console.WriteLine("1. View Personal Information");
        Console.WriteLine("2. Search Member");
        Console.WriteLine("3. View Ward Directory");
        Console.WriteLine("4. Create Member Record");
        Console.Write("Enter Option: ");

    }

    public void BishopSearchOptions()
    {
        Console.WriteLine("1. Search MRN: ");
        Console.WriteLine("2. Search Name: ");
        Console.Write("> ");
    }

    public void ClearConsole(){
        Console.Clear();
    }
}
