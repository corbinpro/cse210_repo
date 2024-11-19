using System;
using System.IO;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    public string _type;
    private string _name;
    private string _description;
    private string _points;
    private Boolean _isCompleted;
    public string loadFilePath = "save_file.txt";

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public Goal()
    {
        string[] lines = File.ReadAllLines(loadFilePath);
            _name = lines[0];
            _description = lines[1];
            _points = lines[2];
            _isCompleted = Convert.ToBoolean(lines[3]);
    }
    public void _setName()
    {
        Console.WriteLine("Enter the name of the goal: ");
        _name = Console.ReadLine();

    }
    public string _getName()
    {
        return _name;
    }
    
    public void _setDescription()
    {
        Console.WriteLine("Enter a short description of the goal: ");
        _description = Console.ReadLine();
    }
    public string _getDescription()
    {
        return _description;
    }
    public void _setPoints()
    {
        Console.WriteLine("Enter the number of points this goal is worth: ");
        _points = Console.ReadLine();
    }
    public string _getPoints()
    {
        return _points;
    }
    public string _getStatus()
    {
        if (_isCompleted)
        {
            return "[ ]";
        }
        else
        {
            return "[X]";
        }
    }
        public void _Complete()
    {
        _isCompleted = true;
    }

    public string _getList()
    {
        return _type + "," + _name + "," + _description + "," + _points + "," + _isCompleted + "," + "\n";
    }



}