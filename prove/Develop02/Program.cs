using System;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;

        while(response != 5)

        //JournalEntry = new JournalEntry();
        //myEntry.CreateJournalEntry();
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    JournalEntry create = new JournalEntry();
                    string log1 = create.CreateJournalEntry();
                    // Call CreateJournalEntry()
                    break;
                case 2:
                    Console.WriteLine("Display");
                    JournalEntry display = new JournalEntry();
                    display.DisplayEntries();
                    //display.SaveToFile();

                    //Call Display Journal()
                    break;
                case 3:                
                    Console.WriteLine("Enter Filename: ");
                    string _fileName = Console.ReadLine();
                    Journal save = new Journal();
                    save.ReadFromFile(_fileName);
                    //Call ReadFromFile()
                    break;
                case 4:               
                    Console.WriteLine("Enter Filename: ");
                    string _fileName2 = Console.ReadLine();
                    Journal write = new Journal();
                    write.WriteToFile(_fileName2);
                    //Call WriteToFile()
                    break;
            }
        }
    }
}