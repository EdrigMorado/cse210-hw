using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new job instance named job1
        Job job1 = new Job();
        // Setting member variables 
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Creating a second job instance named job2
        Job job2 = new Job();
        // Setting member variables 
        job2._jobTitle = "Software Developer";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2022;

        // Creating a new resume instance named myResume
        Resume myResume = new Resume();
        // Setting member variables
        myResume._name = "Edgar Morado";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}