using Newtonsoft.Json;

namespace Develop05;

public class Goals
{
    private int _points = 0;
    private bool _iscompletechecklist;
    protected List<string> _name = new();
    protected List<string> _description = new();
    protected List<int> _gamepoints = new();
    

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int point)
    {
        _points = point;
    }

    public void SaveToFile(string fileName)
    {
       
        // List<int> list1 = new() { 10, 100, 5, 18, 5 };
        // List<string> list2 = new() { "Heaven", "weds", "Arinze"};
        // List<double> list3 = new() { 1.5, 2.7, 3.1, 4.8 };

        // Combine the lists into a single object
        var combinedLists = new { List1 = _name, List2 = _description, List3 = _gamepoints };

        Console.WriteLine(combinedLists);

        string filePath = "lists.json"; // File path to save the data

        // Serialize the combined lists to JSON and save to a file
        string serializedData = JsonConvert.SerializeObject(combinedLists, Formatting.Indented);
        File.WriteAllText(filePath, serializedData);

        Console.WriteLine("Lists saved to file.");
        
        for (int i = 0; i < _description.Count; i++)
        {
            Console.WriteLine($"[ ] {_name[i]} ({_description[i]})");
            Console.WriteLine($"this is the end");
        }
    }

    public virtual void RecordEvent(string fileName)
    {
    }

    public virtual void IsComplete()
    { 
    }

    public virtual void DisplayGoals()
    {
        for (int i = 0; i < _description.Count; i++)
        {
            Console.WriteLine($"[ ] {_name[i]} ({_description[i]})");
        }
    }

    public virtual void Play()
    {
    }


}
