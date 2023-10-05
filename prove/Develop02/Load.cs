namespace Develop02;

public class Load
{
    public void LoadFromFile(List<string> list, string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName); // Reads all lines in the txt file and saves them into an array

        foreach (string item in lines)
        {
            list.Add(item); // Loops through array and appends each item into a new list
        }
    }
}
