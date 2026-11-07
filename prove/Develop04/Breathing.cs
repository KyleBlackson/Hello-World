class Breathing : BaseActivity
{
    public Breathing():base()
    {
    }

    public void RunActivity()
    {
        StartActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        RunCountDownMessage("Get Ready", 3);  
        StartTimer();      
        //DateTime endTime = DateTime.Now.AddSeconds(20); // delete later
        //while (DateTime.Now < endTime)
        Console.Clear();
        while(! HasTimerExpired()) 
        {
            RunCountDownMessage("Breathe In", 4);
            RunCountDownMessage("Breathe Out", 6);
        }

        EndActivity();
    }
}