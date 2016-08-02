using System;
using System.Collections.Generic;

namespace NssAlphabits
{
    public class User
    {
        public User(string name)
        {
            FailuresAllowed = 3;
            NameGivenByAliens = name;
        }

        private int FailuresAllowed { get; set; }
        private string NameGivenByAliens { get; set; }
        public string UserName { get; private set; }
        public string UserInput { get; set; }

        public List<string> LetterStorage = new List<string>();

        public void AddChar(char letter)
        {
            bool inputIsLetter = char.IsLetter(letter);
            if (!LetterStorage.Contains(letter.ToString().ToLower()) && inputIsLetter)
            {   
                LetterStorage.Add(letter.ToString().ToLower());
            }
        }
        public string AlienPromptForNewLetter()
        {
            return string.Format("Give us a new letter, human.");
        }

        public void AlienLetterHandler()
        {
            Console.WriteLine(AlienPromptForNewLetter());
            UserInput = Console.ReadLine();
            if (UserInput.Length == 1)
            {
                foreach (char letter in UserInput)
                {
                    AddChar(letter);
                    Console.WriteLine(MessageAfterValidEntry());
                }
            }
            else
            {
                Console.WriteLine("One letter at a time, {0}.", NameGivenByAliens);
            }
        }

        public string MessageAfterNameEntry()
        {
            return string.Format("Silly human! We have taken the letters from your birth name, {0}. \nThis is a good start to our collection. \nYou have betrayed your race {1} times!", UserName, ListLength());
        }

        public string MessageAfterValidEntry()
        {
            return string.Format("This seems like a new valid character, {0}.\n\nWe will add this to our collection.\n\nYou have betrayed your race {1} times!", UserName, ListLength());
        }

        public string MessageAfterInvalidEntry()
        {
            return string.Format("Do you think this is some kind of game, {0}?! \n -violent probing occurs- \nYOU HAVE {1} MORE CHANCES, FLESHBAG!", NameGivenByAliens, FailuresAllowed);
        }

        public string Congratulate()
        {
            return string.Format("Thanks, here is some sludgefood. Tomorrow, we need your numbers.\nCongratulations, {0}!", NameGivenByAliens);
        }

        public string GiveUserHumanName(string name)
        {
            UserName = name;
            return name;
        }

        public string Greeting()
        {
            return string.Format("{0}, we need your letters!\n\nIf you want to see your family again, write all of them!\n\nRecord your name, letterslave:", NameGivenByAliens);
        }

        private int ListLength()
        {
            return LetterStorage.Count;
        }

        public void UnwittinglyProvideNameLetters(string name)
        {
            foreach (char letter in name)
            {
                AddChar(letter);
            }
            Console.WriteLine(MessageAfterNameEntry());
        }
    }
}
