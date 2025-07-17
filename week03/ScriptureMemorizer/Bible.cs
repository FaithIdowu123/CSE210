class Bible
{
    private List<string> _reference = new List<string>();
    private List<string> _scripture = new List<string>();


    public void SetReference(string reference)
    {
        _reference.Add(reference);
    }

    public void SetScripture(string scripture)
    {
        _scripture.Add(scripture);
    }


    public string GetReference(int choice)
    {
        return _reference[choice];
    }

    public string GetScripture(int choice)
    {
        return _scripture[choice];
    }

    public int GetTotal()
    {
        return _reference.Count();
    }
}