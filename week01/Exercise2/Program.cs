using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // User input
        Console.Write("What is your grade percentage? ");
        string userResponse = Console.ReadLine();
        int gradePercentage = int.Parse(userResponse);

        // Letter assignation logic
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Sign assignation logic
        string sign = "";

        // A+, F+, and F- logic
        if (gradePercentage >= 97)
        {
            sign = "";
        }
        else if (gradePercentage < 60)
        {
            sign = "";
        }
        else if ((gradePercentage % 10) >= 7)
        {
            sign = "+";
        }
        else if ((gradePercentage % 10) < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Final grade
        Console.WriteLine($"Your final grade is {letter}{sign}");

        // Passed or not the class logic
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Keep trying!");
        }
    }
}