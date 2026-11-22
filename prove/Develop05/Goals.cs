using System.Reflection.Metadata;

public class Goals
{
    private static string _filename;
    private static int _totalScore;
    public static List <BaseGoal> _goals = new List<BaseGoal>();

    public Goals(string name, string description, int points, bool complete, string goalType)
    {
    }

    public Goals()
    {
    }
    public static void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public static void LoadGoals(string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {        
            foreach(BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.CreateFileSystemString());
            }
        }
    }

    public static void ReadGoals(string filename)
    {
        //Goals._goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string name = parts[2];
            string description = parts[3];
            int points = int.Parse(parts[4]);
            bool complete = bool.Parse(parts[0]);
            string goalType = parts[1];
            //string name, string description, int points, bool complete, string goalType
            SimpleGoal goals = new SimpleGoal(name, description, points, complete, goalType); 
            _goals.Add(goals);
        }

    }

    public static void DisplayGoals()
    {
        foreach(BaseGoal item in _goals)
        {
            Console.WriteLine($"{item.GetConsoleString()}");
        }
    }

    public static void DisplayScore()
    {
        
    }

    public static void GiveX()
    {

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }

        int choice = int.Parse(Console.ReadLine());

        BaseGoal selectedGoal = _goals[choice - 1];
        selectedGoal.RecordEvent();
    }

}