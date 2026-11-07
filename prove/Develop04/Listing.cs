class Listing : BaseActivity
{
    private string prompt;

    public Listing():base()
    {
    }

    public void RandomPrompt()
    {
        string [] prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random rnd2 = new Random();
        prompt = prompts[rnd2.Next(prompts.Length)];

    }
    public void RunActivity()
    {
        StartActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        RandomPrompt();
        RunCountDownMessage("Get Ready", 3);  
        StartTimer();
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--{prompt}--");
        while(! HasTimerExpired()) 
        {
            Console.ReadLine();
            AddTime(3);
        }

        EndActivity();
    }
}