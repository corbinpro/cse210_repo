using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
            Console.Clear();
            Console.WriteLine("Please choose one of the following:\n1. Add Goal\n2. List Goals And Points\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
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
                    checklistgoal._AddCheckListPoints();
                    GoalsList.Add(checklistgoal);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
                }
            }
            else if (choice == 2)
            {   
                int totalPoints = 0;
                foreach (Goal instance in GoalsList)
                {
                    if (instance._getStatus() == "[X]")
                    {
                        totalPoints += Convert.ToInt32(instance._getPoints());
                    }
                }
                Console.WriteLine("Total points: " + totalPoints);
                
                foreach (Goal instance in GoalsList)
                if (instance._getType() == "Checklist")
                {
                    Console.WriteLine(instance._getStatus()+"-" + instance._getDescription()); //add checklist points
                }
                else
                {
                    Console.WriteLine(instance._getStatus()+"-" + instance._getDescription());                  
                }

                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

            else if (choice == 3) //save files
            {
                File.WriteAllText("goals.txt", "");
                foreach (Goal instance in GoalsList)
                {
                    File.AppendAllText("goals.txt", instance._getList());
                }
            }

            else if (choice == 4) // load files
            {
                string[] lines = File.ReadAllLines("goals.txt");
                foreach (string line in lines)
                {   
                    Console.WriteLine(line);
                    string[] parts = line.Split(',');
                    string name = parts[1];
                    string description = parts[2];
                    // Check if a goal with the same name and description already exists
                    if (GoalsList.Any(goal => goal._getName() == name && goal._getDescription() == description))
                    {
                        Console.WriteLine($"Skipping duplicate goal: {name}");
                        continue;
                    }
                    string points = parts[3];
                    Boolean isCompleted = Convert.ToBoolean(parts[4]);
                    if (parts[0] == "Simple")
                    {
                        SimpGoal simpgoal = new SimpGoal();
                        simpgoal._loadName(name);
                        simpgoal._loadDescription(description);
                        simpgoal._loadPoints(points);
                        simpgoal._loadisCompleted(isCompleted);
                        GoalsList.Add(simpgoal);
                    }
                    else if (parts[0] == "Eternal")
                    {
                        EternalGoal eternalgoal = new EternalGoal();
                        eternalgoal._loadName(name);
                        eternalgoal._loadDescription(description);
                        eternalgoal._loadPoints(points);
                        eternalgoal._loadisCompleted(isCompleted);
                        GoalsList.Add(eternalgoal);
                    }
                    else if (parts[0] == "Checklist")
                    {
                        string cname = parts[1];
                        string cdescription = parts[2];
                        string cpoints = parts[3]; 
                        bool cisCompleted = Convert.ToBoolean(parts[4]);
                        int cchecklistPoints = Convert.ToInt32(parts[5]);
                        int cbonusPoints = Convert.ToInt32(parts[6]);
                        int cnumTimes = Convert.ToInt32(parts[7]);
                        int ctimesCompleted = Convert.ToInt32(parts[8]);

                        ChecklistGoal checklistgoal = new ChecklistGoal();
                        checklistgoal._loadName(cname);
                        checklistgoal._loadDescription(cdescription);
                        checklistgoal._loadisCompleted(cisCompleted);

                        checklistgoal._loadCheckListPoints(cpoints, cchecklistPoints, cbonusPoints, cnumTimes, ctimesCompleted);

                        GoalsList.Add(checklistgoal);
                    }
                    else 
                    {
                        Console.WriteLine("Error loading goals");
                    }
                }
                Console.WriteLine("Goals loaded successfully.(Press enter to continue)");
                Console.ReadLine();
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