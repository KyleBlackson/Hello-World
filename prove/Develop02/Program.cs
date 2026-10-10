using System;
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
                    Console.WriteLine("Save");
                    //Call ReadFromFile()
                    break;
                case 4:               
                    Console.WriteLine("Write");
                    //Call WriteToFile()
                    break;
            }
        }
    }
}