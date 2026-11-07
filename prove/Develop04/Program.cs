using System;

class Program
{
    static void Main(string[] args)
    {
       /* BaseActivity activity = new BaseActivity();
        activity.RunCountDownMessage("Get Ready", 5);
        activity.RunSpinnerMessage("Yup", 6);*/

        Menu myMenu = new Menu();

        int response = 0;
        while(response != 5)
        {
            Console.Clear();
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("---How Mindfulness Practice can help you---");
                    Console.WriteLine("1. Practicing Mindfulness helps you be aware of your mind.");
                    Console.WriteLine("2. It will help you to be calm despite challenging thoughts or feelings.");
                    Console.WriteLine("3. Reduces stress and worry.");
                    Console.WriteLine("4. Be more accepting in your approach to life.");
                    Console.WriteLine("5. Improves physical health and quality of life.");
                    Console.WriteLine("");
                    Console.WriteLine("When you are finished reading, press enter to return to menu.");
                    Console.ReadLine();
                    break;
                case 2:
                    Breathing breathing = new Breathing();
                    breathing.RunActivity();
                    break;
                case 3:      
                    Reflection reflection = new Reflection();
                    reflection.RunActivity();
                    break;
                case 4:      
                    Listing listing = new Listing();
                    listing.RunActivity();        
                    break;
            }
        }

    }
}