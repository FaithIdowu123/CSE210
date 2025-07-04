public class Entry
{
    public string _prompt = "";
    public string? _response = "";
    public string _dateTime = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}.");
    }
}