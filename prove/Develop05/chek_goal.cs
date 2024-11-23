using System;
using System.IO;
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{   
    private int _checklistPoints;
    private int _bonusPoints;
    private int _numTimes;
    private int _timesCompleted;
    private string _calcPoints;
    public ChecklistGoal()
    {
        _type = "Checklist";
    }
    public void _AddCheckListPoints() //add checklist points
    {
        Console.WriteLine("Enter the number of points this task is worth: ");
        _checklistPoints = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many times would you like to perform this task: ");
        _numTimes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of bonus points this task is worth: ");
        _bonusPoints = Convert.ToInt32(Console.ReadLine());
    }
    public int _getCheckListPoints()
    {
        return _checklistPoints;
    }
    public int _getBonusPoints()
    {
        return _bonusPoints;
    }
    public int _getNumTimes()
    {
        return _numTimes;
    }

    public sealed override void _Complete()
    {
        _timesCompleted += 1;
        if (_timesCompleted == _numTimes)
        {
            _isCompleted = true;
        }
    }

    public sealed override string _getStatus()
    {
        if (_isCompleted)
        {
            return "[X]";
        }
        else
        {
            return "[ ]"+ " " + _timesCompleted + "/" + _numTimes;

        }
    }

    public sealed override string _getList()
    {
        return _type + "," + _name + "," + _description + "," + _points + "," + _isCompleted + "," + _checklistPoints + "," + _bonusPoints + "," + _numTimes + "," + _timesCompleted + "\n"; 
    }

    public void _loadCheckListPoints(string points, int checklistPoints, int bonusPoints, int numTimes, int timesCompleted)
    {
        _checklistPoints = checklistPoints;
        _bonusPoints = bonusPoints;
        _numTimes = numTimes;
        _timesCompleted = timesCompleted;

        // Recalculate points based on the loaded values
        _calcPoints = Convert.ToString((_checklistPoints * _timesCompleted) + (timesCompleted == numTimes ? _bonusPoints : 0));
        _points = _calcPoints;
    }

    public sealed override string _getPoints()
    {
        _calcPoints = Convert.ToString((_checklistPoints * _numTimes) + _bonusPoints);
        return _calcPoints;
    }
    public sealed override void _setPoints()
    {
        _points = "0";
    }
}