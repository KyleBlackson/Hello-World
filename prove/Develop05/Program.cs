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
                            //Goals.DisplayScore();
                        break;

                        case 2:
                            EternalGoal myEternalGoal = new EternalGoal();
                            Goals.AddGoal(myEternalGoal);
                            Console.WriteLine(myEternalGoal.GetConsoleString());
                        break;

                        case 3:
                            CheckListGoal myCheckListGoal = new CheckListGoal();
                            Goals.AddGoal(myCheckListGoal);
                            Console.WriteLine(myCheckListGoal.CheckListString());

                        break;
                    }

                    break;
                case 2:
                    Console.WriteLine("----------Current Goals---------- ");
                    //Goals load = new Goals();
                    Goals.DisplayGoals();
                    Goals.DisplayScore();
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