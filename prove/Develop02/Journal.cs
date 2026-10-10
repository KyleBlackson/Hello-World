class Journal
{
    public List <JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }
    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    public void WriteToFile(string filename)

    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {        
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    
    public void ReadFromFile(string filename)

    {

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)

        {
            string[] parts = line.Split("#");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            JournalEntry entry = new JournalEntry(prompt, response, date); 

            this.CreateEntry(entry);

        }

    }
}