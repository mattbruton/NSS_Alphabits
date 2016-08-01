using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NssAlphabits
{
    class Program
    {
        static void Main(string[] args)
        {
            User testSubject = new NssAlphabits.User("XB102108");
            Console.WriteLine(testSubject.Greeting());
            testSubject.GiveUserHumanName(Console.ReadLine());
            Console.WriteLine(testSubject.UserName);
            Console.WriteLine(testSubject.Congratulate());
        }
    }
}
