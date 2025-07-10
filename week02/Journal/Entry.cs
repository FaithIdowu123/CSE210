/*From my exceeding the requirements I added a new variable to the entry class named _time and made it so
when the uses wants to display, load or save their journal the time is also included.*/
public class Entry
{
    public string _prompt = "";
    public string? _response = "";
    public string _dateTime = "";

    public string _time = "";

    public void Display()
    {
        Console.WriteLine($"Date/Time: {_dateTime} {_time} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}.");
    }
}