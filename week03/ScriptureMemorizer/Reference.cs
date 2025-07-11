public class Reference
{
    private string _book = "";
    private string _chapter = "";
    private string _startVerse = "";
    private string _endVerse = "";

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, string chapter, string startverse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
        _endVerse = endVerse;
    }

    public string DisplayText()
    {
        string text = "";
        if (_endVerse == "")
        {
            text = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            text = $"{_book} {_chapter}:{_startVerse} - {_endVerse}";
        }
        return text;
    }
}