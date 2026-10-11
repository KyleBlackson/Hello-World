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
            "What did you do to have fun today?",
            "What is something you learned today that surprised you?",
            "Describe a moment today when you felt calm or peaceful?",
            "Who helped you today, even in a small way?",
            "What is one thing you wish you had done differently today?",
            "What motivated you the most today?",
            "What is something you noticed today that you usually overlook?",
            "What is one thing you’re grateful for right now",
            "What challenged you today and how did you respond?"
        };

        string [] factsorfeelings =
        {
            "Give me the Facts",
            "Tell me about your Feelings"
        };

        Random rnd2 = new Random();
        string fax = factsorfeelings[rnd2.Next(factsorfeelings.Length)];
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];

    //------------Set values for date, prompt and response-------
        string date = DateTime.Now.ToString();
        Console.WriteLine($"---------------{date}--------------");
        Console.WriteLine($"{prompt} ({fax})");
        string response = Console.ReadLine();
        JournalEntry entry = new JournalEntry(prompt,response,date);
        Entries.Add(entry);
        Console.WriteLine();
        return "";
    }


    public void DisplayEntries()
    {
        foreach (JournalEntry item in Journal.Entries)
        {
            Console.WriteLine($"{item._date}, {item._prompt}");
            Console.WriteLine($"{item._response}");
            Console.WriteLine();
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
            foreach(JournalEntry entry in Entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        Journal.Entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)

        {
            string[] parts = line.Split('|');
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            JournalEntry entry = new JournalEntry(prompt, response, date); 
            Entries.Add(entry);
        }

    }
}