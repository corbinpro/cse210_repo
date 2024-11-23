using System;
using System.IO;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected string _points;
    protected Boolean _isCompleted;
    protected string loadFilePath = "save_file.txt";

    public Goal()
    {
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
    public virtual void _setPoints()
    {
        Console.WriteLine("Enter the number of points this goal is worth: ");
        _points = Console.ReadLine();
    }
    public virtual string _getPoints()
    {
        return _points;
    }
    public virtual string _getStatus()
    {
        if (_isCompleted)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
    public virtual void _Complete()
    {
        _isCompleted = true;
    }

    public string _getType()
    {
        return _type;
    }

    public virtual string _getList()
    {
        return _type + "," + _name + "," + _description + "," + _points + "," + _isCompleted + "," + "\n";
    }
    public void _loadName(string name)
    {
        _name = name;
    }

    public void _loadDescription(string description)
    {
        _description = description;
    }
    public void _loadPoints(string points)
    {
        _points = points;
    }
    public void _loadisCompleted(Boolean isCompleted)
    {
        _isCompleted = isCompleted;
    }


}