using System;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


//Small Extras!!! I made sure to save all entries in a list, so that the user can input multiple entries at a time.
//I aslo added a fun little "Facts or Feelings" prompter, so that if the user doesn't know exactly where to go with the prompt they have even more guidance.
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int response = 0;
        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Journal create = new Journal();
                    string log1 = create.CreateJournalEntry();
                    break;
                case 2:
                    Console.WriteLine("-------------Display------------");
                    Journal display = new Journal();
                    display.DisplayEntries();
                    break;
                case 3:                
                    Console.WriteLine("----------Enter Filename---------- ");
                    string _fileName = Console.ReadLine();
                    Journal save = new Journal();
                    save.ReadFromFile(_fileName);
                    break;
                case 4:               
                    Console.WriteLine("-----------Enter Filename-----------");
                    string _fileName2 = Console.ReadLine();
                    Journal write = new Journal();
                    write.WriteToFile(_fileName2);
                    break;
            }
        }
    }
}