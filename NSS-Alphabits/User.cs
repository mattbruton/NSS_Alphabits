using System;
using System.Collections.Generic;

namespace NssAlphabits
{
    public class User
    {
        public User(string name)
        {
            NameGivenByAliens = name;
            FailuresAllowed = 3;
        }

        private string NameGivenByAliens { get; set; }
        public string UserName { get; private set; }
        private int FailuresAllowed { get; set; }

        public List<string> LetterStorage = new List<string>();

        public string GiveUserHumanName(string name)
        {
            UserName = name;
            return name;
        }

        public string Greeting()
        {
            return String.Format("{0}, we need your letters!\n\nIf you want to see your family again, write all of them!\n\nRecord your name, letterslave:", NameGivenByAliens);
        }

        public string Congratulate()
        {
            return String.Format("Thanks, here is some sludgefood. Tomorrow, we need your numbers.\nCongratulations, {0}!", NameGivenByAliens);
        }

        public void UnwittinglyProvideNameLetters(string name)
        {
            foreach (char letter in name)
            {
                AddChar(letter);
            }
        }

        public void AddChar(char letter)
        {
            bool inputIsLetter = char.IsLetter(letter);
            if (!LetterStorage.Contains(letter.ToString().ToLower()) && inputIsLetter) 
            {
                LetterStorage.Add(letter.ToString().ToLower());
            }
        }
    }
}
