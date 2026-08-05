using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");

            int remainingSeconds =
                (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);

            if (remainingSeconds > 0)
            {
                ShowCountDown(Math.Min(4, remainingSeconds));
            }

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("\nBreathe out... ");

            remainingSeconds =
                (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);

            if (remainingSeconds > 0)
            {
                ShowCountDown(Math.Min(4, remainingSeconds));
            }

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}