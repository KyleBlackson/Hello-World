public class Journal
{
    public List <JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    
    public static List<JournalEntry> Entries = new List<JournalEntry>();

        public string CreateJournalEntry()
    {
        string [] prompts =
    // ------------Random Generator--------------
        {
            "How was your day?",
            "Talk about someone you met",
            "What did you have for Breakfast?",
            "What was a miracle that you saw today?",
            "Who did you think about today?",
            "What is something funny that happened to you today?",
            "What did you do to have fun today?"
        };
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];

    //------------Set values for date, prompt and response-------
        string date = DateTime.Now.ToString();
        Console.WriteLine($"---------------{date}--------------");
        Console.WriteLine($"{prompt} ");
        string response = Console.ReadLine();
        JournalEntry entry = new JournalEntry(prompt,response,date);
        Entries.Add(entry);
        return "";
    }


    public void DisplayEntries()
    {
        foreach (JournalEntry item in Journal.Entries)
        {
            Console.WriteLine($"{item._date}, {item._prompt}");
            Console.WriteLine($"{item._response}");
        }
     }
   /* public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayEntries();
        }
    }*/

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