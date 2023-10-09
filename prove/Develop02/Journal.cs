class Journal{

private readonly List<string> entries = new List<string>();

public void AddEntry(string entry)
{
    entries.Add(entry);
}

public void DisplayEntries()
{
    Console.WriteLine("Journal Entries: ");
    foreach (var entry in entries)
    {
        Console.WriteLine(entry);
    }
}

public void Load(string[] loadedEntries)
{
    entries.Clear();
    entries.AddRange(loadedEntries);
}

public void SaveToFile(string fileName)
{
    File.WriteAllLines(fileName, entries);
}

}