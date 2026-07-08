using System;
using System.Collections.Generic;
using System.Text;

public class Job
{
    // Class properties
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Class methods
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    } 

}