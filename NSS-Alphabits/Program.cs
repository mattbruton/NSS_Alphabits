using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NssAlphabits.Images;

namespace NssAlphabits
{
    class Program
    {
        static string Prompt()
        {
            return String.Format("> ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Image.AlienImage());
            User testSubject = new NssAlphabits.User("XB102108");
            Console.WriteLine(testSubject.Greeting());
            Console.Write(Prompt());
            testSubject.GiveUserHumanName(Console.ReadLine());
            Console.WriteLine(testSubject.UserName);
            Console.WriteLine(testSubject.Congratulate());
        }
    }
}
