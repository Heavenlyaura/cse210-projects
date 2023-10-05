namespace Develop02;

public class PromptGenerator
{
    public Random _random = new(); // class Variable: this is an instance of the random class, to help in the random selection of prompts.
    public string PrompGen(List<string> promptList)
    {
        int index = _random.Next(0, promptList.Count); // generates a random integer between 0 and the lenght of all items in the prompt list.
        string pick = promptList[index]; // randomly selects a prompt from the prompy list by index
        promptList.Remove(pick); // deletes the chosen prompt to avoid repeating the same prompt twice or more
        return pick; // returns the choosen prompt
    }

}


