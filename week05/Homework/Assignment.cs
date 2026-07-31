using System;

public class Assignment
{
    // Attributes
    private string _studentName = "";
    private string _topic = "";

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Getters
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    //Methods
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}