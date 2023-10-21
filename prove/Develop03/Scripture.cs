namespace Develop03;

public class Scripture
{
    private string _book;
    private string _verse;
    private string _endVerse;
    private string _scriptureText;
    private List<int> _hiddenWordIndex = new();
    private Random _random = new();

    public Scripture(string book, string verse)
    {
        _book = book;
        _verse = verse;
        _scriptureText = verse;
    }

    public Scripture(string book, string verse, string endVerse)
    {
        _book = book;
        _verse = verse;
        _endVerse = endVerse;
        _scriptureText = $"{verse} {endVerse}";
    }

    public void HideWords(int hideCount)
    {
        string[] words = _scriptureText.Split(" "); // split the words according to the spaces

        // create a lsit of word index that can be hidden. NOTE: this words are not hidden!
        List<int> avaliableWordIndex = Enumerable.Range(0, words.Length).Except(_hiddenWordIndex).ToList();

        if (avaliableWordIndex.Count == 0)
        {
            Environment.Exit(0);
        }
        else
        {
            int hideCounter = hideCount;

            for (int i = 0; i < hideCounter; i++)
            {
                int wordToHideIndex = avaliableWordIndex[_random.Next(0, avaliableWordIndex.Count)]; // select a random index from the avaliablewordindex list to use in hiding the word

                words[wordToHideIndex] = new string('_', words[wordToHideIndex].Length);

                _hiddenWordIndex.Add(wordToHideIndex); // add the word to hide index to the list to avoide repetition

                _scriptureText = string.Join(" ", words);
            }
        }
    }

    public string GetRenderedText()
    {
        return $"{_book}: {_scriptureText}";
    }
}
