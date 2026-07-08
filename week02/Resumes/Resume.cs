using System;
using System.Collections.Generic;
using System.Text;

public class Resume
{
    // Class properties
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Class methods
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

}