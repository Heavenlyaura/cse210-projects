using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new() { 10, 100, 5, 18, 5 };
        List<string> list2 = new() { "Heaven", "weds", "Arinze"};
        List<double> list3 = new() { 1.5, 2.7, 3.1, 4.8 };

        // Combine the lists into a single object
        var combinedLists = new { List1 = list1, List2 = list2, List3 = list3 };

        string filePath = "lists.json"; // File path to save the data

        // Serialize the combined lists to JSON and save to a file
        string serializedData = JsonConvert.SerializeObject(combinedLists, Formatting.Indented);
        File.WriteAllText(filePath, serializedData);

        Console.WriteLine("Lists saved to file.");
    }
}
