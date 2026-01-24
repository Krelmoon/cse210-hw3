public class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // constructor
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // method to get reference as string
    public string GetReferenceString()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}