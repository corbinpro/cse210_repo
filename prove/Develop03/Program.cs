using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public class Word
    {
        private bool isHidden = false;
        private string text = "";
        public Word (string _text)
        {
            isHidden = false;
            text = _text;
        }

        public void _setText(string newText)
        {
            text = newText;
        }

        public string _getText()
        {
            return text;
        }

        public void _hidetext()
        {
            if (!isHidden)
            {
                isHidden = true;
                text = new string('_', text.Length);  // Creates a string of underscores with the same length as `text`
            } 
        }
        
        public bool IsHidden() // method to check if the word is hidden
        {
            return isHidden;
        }
    }
    
    public class Reference
    {
        private string text = "";

        public void _setRefrence(string refrenceText)
        {
            text = refrenceText;
        }

        public string _getRefrence()
        {
            return text;
        }

    }

    public class Scripture
    {
        private List<Word> scriptureTextList; //create the list of word objects (i didnt realize this was possible)

        public Scripture(string scriptureText)//constructor
        {
            _setScriptureText(scriptureText); //set the scripture text (calling its own method in the constructor)
        }

        public List<Word> _getScriptureTextList()//getter
        {
            return scriptureTextList;
        }

        public void _setScriptureText(string scriptureText)//setter
        {
            scriptureTextList = new List<Word>();//initialize the list
            foreach (var wordText in scriptureText.Split(' '))//split the scripture text into words
            {
                scriptureTextList.Add(new Word(wordText));//for each iteration loop add new instantiation of word into list
            }
        }

            public bool AllWordsHidden()
        {
            foreach (var word in scriptureTextList)
            {
                if (!word.IsHidden())
                    return false;
            }
            return true;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a scripture reference(book chapter:verse/verses):"); // Prompt the user for input
        string scriptureReference = Console.ReadLine(); // Read and store the user's input
        Reference reference = new Reference(); // Initialize reference
        reference._setRefrence(scriptureReference); // Set the reference text

        Console.WriteLine("Enter the scripture text:");
        string scriptureText = Console.ReadLine(); // Read and store the user's input
        Scripture scripture = new Scripture(scriptureText); // Initialize scripture
        scripture._setScriptureText(scriptureText); // Set the scripture text

        Random random = new Random(); // Initialize random number generator
        while (!scripture.AllWordsHidden())//logic to continue until all words are hidden. required new method in word that works like getter to see if text is hidden. 
        {
            List<Word> visibleWords = scripture._getScriptureTextList().FindAll(word => !word.IsHidden());//use lambada logic to find all words that are not hidden
            if (visibleWords.Count > 1)//if there is more than one word visible. 
            {
                // Randomly select two words from the visibleWords list and hide them
                int firstIndex = random.Next(visibleWords.Count);
                int secondIndex = 0;//must declare here so that it is visible outside of do while block
                
                do
                {
                    secondIndex = random.Next(visibleWords.Count);
                } while (secondIndex == firstIndex);

                visibleWords[firstIndex]._hidetext();//not necessary to call word here because visiblewords is already an instance or instances of word
                visibleWords[secondIndex]._hidetext();
            }
            else if (visibleWords.Count == 1) //if there is only one word visible
            {
                visibleWords[0]._hidetext();//hide only 1 word
            }

            // Display the current state of the scripture
            Console.Clear();
            Console.WriteLine("\nCurrent state of scripture:");
            foreach (var word in scripture._getScriptureTextList())
            {
                Console.Write(word._getText() + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to hide more words...");
            Console.ReadLine();
        }

        Console.WriteLine("All words are now hidden.");


    }
}