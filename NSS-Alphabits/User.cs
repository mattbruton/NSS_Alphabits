using System;
using System.Collections.Generic;

namespace NssAlphabits
{
    public class User
    {
        public User(string name)
        {
            UserName = name;
        }
        public string UserName { get; private set; }
        public void GiveUserHumanName(string name)
        {
            UserName = name;
        }
        public string Greeting()
        {
            return String.Format("Human, we need your letters!\n\nIf you want to see your family again, write all of them!\n\nRecord your name, letterslave:");
        }
        public string Congratulate()
        {
            return String.Format("Thanks, here is some sludgefood. Tomorrow, we need your numbers.\nCongratulations, {0}!", UserName);
        }
        public void AddChar()
        {

        }
    }
}
