class BaseActivity
{
    private int _duration;
    private string _activity;
    private DateTime _endTime;

    public BaseActivity()
    {
    }

    public void StartActivity(string activity, string intro)
    {
        Console.Clear();
        _activity = activity;
        Console.WriteLine($"Welcom to the {activity} activity!");
        Console.WriteLine("");
        Console.WriteLine(intro);
        Console.WriteLine();
        Console.WriteLine("How long do you want the activity to last (in seconds):");
        string _tempduration = Console.ReadLine();
        _duration = int.Parse(_tempduration);
    }
    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >_endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i>0; i--)
        {
        Console.Clear();
        Console.WriteLine($"{message} - {i}");
        Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(int seconds)
    {
        Console.CursorVisible = false;
        DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }

    public void AddTime(int seconds)
    {
        DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
    }
    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You completed another {_duration} seconds of the {_activity} activity.");
        Console.WriteLine();
        RunSpinnerMessage(5);
    }

}