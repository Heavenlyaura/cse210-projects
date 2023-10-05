using System.IO.Enumeration;

namespace Develop02;
public class Write
{
    public String _theCurrentTime = DateTime.Now.ToShortDateString();

    public void WriteEntryToList(string prompt, string entry, List<string> list)
    {
        list.Add($"\n{_theCurrentTime} Prompt: {prompt}\nEntry: {entry}\n"); // this appends the prompts and entries into a list immediatly they are entered by the user.
    }   

    public void WriteEntryToFile(string fileName, List<string> list)
    {
        using(StreamWriter outputFile = new(fileName))
        {   
            foreach (string lines in list)
            {
                outputFile.WriteLine(lines);
            }
        }
    }

}
