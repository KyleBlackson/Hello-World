using System.Security.Cryptography.X509Certificates;
public class JournalEntry
{
    public string _userInput;
    static List<JournalEntry> userLogs = new List<JournalEntry>();
    public string CreateJournalEntry()
    {
        Console.WriteLine("Insert Random Question???");


        JournalEntry log2 = new JournalEntry();
        log2._userInput = Console.ReadLine();
        userLogs.Add(log2);


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
    


}
