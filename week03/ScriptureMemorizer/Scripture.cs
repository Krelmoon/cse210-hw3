public class Scripture
{
    // attributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    // methods
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        int totalWords = _words.Count;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(totalWords);
            Word word = _words[index];
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }    
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetReferenceString() + "\n";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                displayText += "____ ";
            }
            else
            {
                displayText += word.GetDisplayText() + " ";
            }
        }
        return displayText.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
}