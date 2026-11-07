class Reflection : BaseActivity
{
    private string prompt;
    private string question;

    public Reflection():base()
    {
    }

    public void RandomPrompt()
    {
        string [] questions =
    // ------------Random Generator--------------
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        string [] prompts =
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random rnd2 = new Random();
        prompt = prompts[rnd2.Next(prompts.Length)];
        Random rnd = new Random();
        question = questions[rnd.Next(questions.Length)];
    }
    public void RunActivity()
    {
        StartActivity("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        RunCountDownMessage("Get Ready", 3);  
        RandomPrompt();
        StartTimer();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        RunCountDownMessage("Now ponder on each of the following questions as they relate to that experience. You will begin in:", 3);
        while(! HasTimerExpired()) 
        {
            RandomPrompt();
            RunCountDownMessage(question, 10);
        }
        EndActivity();
    }
}