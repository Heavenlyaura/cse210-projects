namespace Develop02;

public class Lists
{
    public List<string> PromptListing()
    {
        List<String> promptList = new(){"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};

        return promptList;
    }

    public List<string> SaveList()
    {
        List<string> saveList = new(){}; // creates and returns a list where entries will be stored before being saved

        return saveList;
    }
}
