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
   

    public string CreateFileSystemString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}

  