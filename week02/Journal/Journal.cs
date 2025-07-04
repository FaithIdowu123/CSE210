using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Entry> entries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry();
            entry._dateTime = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            entries.Add(entry);
        }
        _entries = entries;
    }
    public void SaveToFile(string fileName)
    {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateTime},{entry._prompt},{entry._response}");
            }
        }
    }
}