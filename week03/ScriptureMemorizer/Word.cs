// represents a single word in a scripture verse
public class Word
{
    // attributes
    private string _text;
    private bool _isHidden;

    // constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }     
}