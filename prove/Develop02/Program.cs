using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal(); // Initialize journal

        while (choice != 5)
        {
            Console.WriteLine("Choose one of the following:\n1. Write New Entry\n2. Display Journal\n3. Load Journal\n4. Save Journal\n5. Quit");
            choice = int.Parse(Console.ReadLine());

            // Pass the choice to the journal processing method
            journal.ProcessChoice(choice);
        }
    }

    // Class to handle journal-related actions
    public class Journal
    {
        List<string> journalEntries = new List<string>(); // List to store multiple entries

        // Method to process user choice
        public void ProcessChoice(int choice)
        {
            if (choice == 1)
            {
                // Call prompt and display
                Entry entry = new Entry(); // Initialize entry
                journalEntries.Add(entry.GetFormattedEntry()); // Add the new entry to the list
            }
            else if (choice == 2)
            {
                // Display all journal entries
                if (journalEntries.Count == 0)
                {
                    Console.WriteLine("No journal entries available.");
                }
                else
                {
                    Console.WriteLine("Journal Entries:\n");
                    foreach (var entry in journalEntries)
                    {
                        Console.WriteLine(entry);
                    }
                }
            }
            else if (choice == 3)
            {
                // Load journal (for simplicity, assume it loads a single entry for now)
                Console.WriteLine("Move the load file into the same directory as the program.");
                string loadedJournal = FileManagement._loadJournal();
                journalEntries.Add(loadedJournal); // Add loaded journal entry to the list
            }
            else if (choice == 4)
            {
                // Save all journal entries
                string allEntries = string.Join("\n\n", journalEntries); // Combine all entries into one string
                FileManagement._saveJournal(allEntries); // Pass the combined entries to the save method
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

        public static string _getRandom()
        {
            Random random = new Random();
            int index = random.Next(0, prompts.Count);
            return prompts[index];
        }
    }

    // Class to handle file management (load/save journal)
    public class FileManagement
    {
        public static string _loadJournal()
        {
            Console.WriteLine("Enter the file name to load: ");
            string file_name = Console.ReadLine();
            return System.IO.File.ReadAllText(file_name); // Return the loaded journal entry
        }

        public static void _saveJournal(string journal_entry)
        {
            Console.WriteLine("Enter the file name to save: ");
            string file_name = Console.ReadLine();
            System.IO.File.WriteAllText(file_name, journal_entry); // Save journal entry to file
        }
    }

    public class Entry
    {
        string formattedEntry;

        public Entry()
        {
            // Call prompt and display
            string currentPrompt = Prompt._getRandom();
            Console.WriteLine(currentPrompt);

            // Append datetime and prompt to journal entry
            DateTime currentDate = DateTime.Now;
            formattedEntry = $"{currentDate}\n{currentPrompt}\n";

            // Get user's response
            string response = Console.ReadLine();
            formattedEntry += response + "\n";
        }

        public string GetFormattedEntry()
        {
            return formattedEntry; // Return the formatted journal entry
        }
    }
}


