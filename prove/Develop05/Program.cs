using System;

class Program
{
    static void Main(string[] args)
    {
         Menu myMenu = new Menu();
        int response = 0;
        while(response != 6)
        {
            //Console.Clear();
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    response = myMenu.ProcessSubMenu();
                    switch(response)
                    {
                        case 1:
                            SimpleGoal mySimpleGoal = new SimpleGoal();
                            Goals.AddGoal(mySimpleGoal);
                            Console.WriteLine(mySimpleGoal.GetConsoleString());
                        break;

                        case 2:

                        break;

                        case 3:


                        break;
                    }

                    break;
                case 2:
                    Console.WriteLine("----------Current Goals---------- ");
                    //Goals load = new Goals();
                    Goals.DisplayGoals();
                    break;
                case 3:      
                    Console.WriteLine("----------Enter Filename---------- ");
                    string _fileName = Console.ReadLine();
                    //Goals save = new Goals();
                    Goals.ReadGoals(_fileName);
                    break;
                case 4:      
                    Console.WriteLine("----------Enter Filename---------- ");
                    string _fileName2 = Console.ReadLine();
                    //Goals save2 = new Goals();
                    Goals.LoadGoals(_fileName2);
                    break;
                case 5:
                    Goals.GiveX();
                    break;
            }
        }

    }
}