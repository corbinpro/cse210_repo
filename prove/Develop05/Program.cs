using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        List<Goal> GoalsList = new List<Goal>();
        while (choice != 6)
        {
            Console.WriteLine("Please choose one of the following:\n1. Add Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please choose one of the following:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    SimpGoal simpgoal = new SimpGoal();
                    simpgoal._setName();
                    simpgoal._setDescription();
                    simpgoal._setPoints();
                    GoalsList.Add(simpgoal);
                }
                else if (num == 2)
                {
                    EternalGoal eternalgoal = new EternalGoal();
                    eternalgoal._setName();
                    eternalgoal._setDescription();
                    eternalgoal._setPoints();
                    GoalsList.Add(eternalgoal);
                }
                else if (num == 3)
                {
                    ChecklistGoal checklistgoal = new ChecklistGoal();
                    checklistgoal._setName();
                    checklistgoal._setDescription();
                    checklistgoal._setPoints();
                    //how may times would you like to perform this task
                    GoalsList.Add(checklistgoal);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
                }
            }
            else if (choice == 2)
            {
                foreach (Goal instance in GoalsList)
                if (instance._type == "Checklist")
                {
                    Console.WriteLine(instance._getStatus()+"-" + instance._getDescription()); //add checklist points
                }
                else
                {
                    Console.WriteLine(instance._getStatus()+"-" + instance._getDescription());                  
                }
            }

            else if (choice == 3)
            {
                foreach (Goal instance in GoalsList)
                {
                    File.WriteAllText("goals.txt", instance._getList());
                }
            }

            else if (choice == 4) // figure out why the permissions do not allow goals to be interacted with here. 
            {
                string[] lines = File.ReadAllLines("goals.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == "Simple")
                    {
                        SimpGoal simpgoal = new SimpGoal();
                        simpgoal._name = parts[1];
                        simpgoal._description = parts[2];
                        simpgoal._points = parts[3];
                        simpgoal._isCompleted = Convert.ToBoolean(parts[4]);
                        GoalsList.Add(simpgoal);
                    }
                    else if (parts[0] == "Eternal")
                    {
                        EternalGoal eternalgoal = new EternalGoal();
                        eternalgoal._name = parts[1];
                        eternalgoal._description = parts[2];
                        eternalgoal._points = parts[3];
                        eternalgoal._isCompleted = Convert.ToBoolean(parts[4]);
                        GoalsList.Add(eternalgoal);
                    }
                    else if (parts[0] == "Checklist")
                    {
                        ChecklistGoal checklistgoal = new ChecklistGoal();
                        checklistgoal._name = parts[1];
                        checklistgoal._description = parts[2];
                        checklistgoal._points = parts[3];
                        checklistgoal._isCompleted = Convert.ToBoolean(parts[4]);
                        GoalsList.Add(checklistgoal);
                    }
                }
            }

            else if (choice == 5)
            {
                Console.WriteLine("Please choose one of your goals:");
                foreach (Goal instance in GoalsList)
                {
                    Console.WriteLine(GoalsList.IndexOf(instance) + "-" + instance._getDescription());
                }
                int num = Convert.ToInt32(Console.ReadLine());
                GoalsList[num]._Complete();

            }

            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
        }
    }
}