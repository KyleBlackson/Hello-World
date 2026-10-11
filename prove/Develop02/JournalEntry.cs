using System.Security.Cryptography.X509Certificates;
public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry() { }
    public JournalEntry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }        

/// <summary>
/// 
/// </summary>
    public string _userInput;
    static List<JournalEntry> userLogs = new List<JournalEntry>();
    public string CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met"
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts[0];
        Console.WriteLine($"---------------{_date}--------------");
        Console.WriteLine($"{_prompt} ");
        _response = Console.ReadLine();
        JournalEntry log2 = new JournalEntry(_prompt,_response,_date);
        log2._userInput = _response;
        userLogs.Add(log2);
        return "";
    }

    //static void SaveToFile(List<JournalEntry> userLogs)
    public void DisplayEntries()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
        foreach (JournalEntry item in userLogs)
        {
            Console.WriteLine(item._userInput);
            Console.WriteLine($"{item._date}, {item._prompt}");
            Console.WriteLine($"{item._response}");
        }
     }

    public string CreateFileSystemString()
    {
        return _userInput;
    }
    


}
