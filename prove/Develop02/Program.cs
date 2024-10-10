using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0; // Initialize choice outside the loop
        string journal_entry = ""; // Moved outside the loop so it's accessible across iterations

        while (choice != 5)
        {
            // Class greeting, menu selection
            Console.WriteLine("Choose one of the following:\n1. Write New Entry\n2. Display Journal\n3. Load Journal\n4. Save Journal\n5. Quit");
            choice = int.Parse(Console.ReadLine());

            // If, else if menu choices
            if (choice == 1)
            {
                // Call prompt and display
                string currentPrompt = Prompt.GetRandom();
                Console.WriteLine(currentPrompt);

                // Call current datetime
                DateTime currentDate = DateTime.Now;
                journal_entry += currentDate + "\n" + currentPrompt + "\n";
                string response = Console.ReadLine() + "\n"; // Append datetime, response to journal entry
                journal_entry += response + "\n";
            }
            else if (choice == 2)
            {
                // Display journal
                Console.WriteLine(journal_entry);
            }
            else if (choice == 3)
            {
                // Load journal
                Console.WriteLine("Move the load file into the same directory as the program.");
                journal_entry = FileManagement.LoadJournal(); // Update journal_entry after loading
            }
            else if (choice == 4)
            {
                // Save journal
                FileManagement.SaveJournal(journal_entry); // Pass journal_entry to save method
            }
            else if (choice == 5)
            {
                // Quit
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    // Class chooses random prompt
    public class Prompt
    {
        static List<string> prompts = new List<string>
        {
            "What are you grateful for today?",
            "Describe a moment that made you smile recently.",
            "What is a challenge you faced today and how did you handle it?",
            "Write about a person who has had a positive impact on your life.",
            "What are your goals for the upcoming week?",
            "Reflect on a recent accomplishment and how it made you feel.",
            "Describe a place you would like to visit and why.",
            "What is something new you learned today?",
            "Write about a favorite memory from your childhood.",
            "What are three things you love about yourself?"
        };

        public static string GetRandom()
        {
            Random random = new Random();
            int index = random.Next(0, prompts.Count);
            return prompts[index];
        }
    }

    public class FileManagement
    {
        public static string LoadJournal()
        {
            Console.WriteLine("Enter the file name to load: ");
            string file_name = Console.ReadLine();
            return System.IO.File.ReadAllText(file_name); // Return the loaded journal entry
        }

        public static void SaveJournal(string journal_entry)
        {
            Console.WriteLine("Enter the file name to save: ");
            string file_name = Console.ReadLine();
            System.IO.File.WriteAllText(file_name, journal_entry);
        }
    }
}

