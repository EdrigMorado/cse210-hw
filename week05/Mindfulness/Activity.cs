using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);

        Console.Write("\nHow long, in seconds, would you like for your session? ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a positive number of seconds: ");
        }

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");

        ShowSpinner(3);

        Console.WriteLine(
            $"\nYou have completed another {_duration} seconds of the {_name}."
        );

        ShowSpinner(3);

        Console.WriteLine();
    }

    // Getter
    protected int GetDuration()
    {
        return _duration;
    }

    protected void ShowSpinner(int seconds)
    {
        string[] animation = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[index]);

            Thread.Sleep(250);

            Console.Write("\b \b");

            index++;

            if (index >= animation.Length)
            {
                index = 0;
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string number = i.ToString();

            Console.Write(number);

            Thread.Sleep(1000);

            for (int j = 0; j < number.Length; j++)
            {
                Console.Write("\b");
            }

            for (int j = 0; j < number.Length; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < number.Length; j++)
            {
                Console.Write("\b");
            }
        }
    }
}