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


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateJournalEntry2()
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met"
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts[0];
        Console.WriteLine($"{_prompt} ");
        _response = Console.ReadLine();
    }

/// <summary>
/// 
/// </summary>
    public string _userInput;
    static List<JournalEntry> userLogs = new List<JournalEntry>();
    public string CreateJournalEntry()
    {
        Console.WriteLine("Insert Random Question???");


        //JournalEntry log2 = new JournalEntry();
        //log2._userInput = Console.ReadLine();
        //userLogs.Add(log2);


        foreach (JournalEntry item in userLogs)
        {
            Console.WriteLine(item._userInput);
        }
        return "";
    }

    //static void SaveToFile(List<JournalEntry> userLogs)
    public void DisplayEntries()
    {


        foreach (JournalEntry item in userLogs)
        {
            Console.WriteLine(item._userInput);
        }

     }

    public string CreateFileSystemString()
    {
        return _userInput;
    }
    


}
