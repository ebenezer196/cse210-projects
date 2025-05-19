using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd"),
            _prompt = prompt,
            _response = response
        };
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._prompt}|{e._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry
            {
                _date = parts[0],
                _prompt = parts[1],
                _response = parts[2]
            };
            _entries.Add(entry);
        }
    }
}
