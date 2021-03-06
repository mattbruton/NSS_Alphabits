﻿using System;
using System.Collections.Generic;
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
            // Display Alien ASCII Art upon application loading.
            Console.WriteLine(Image.AlienImage());
            // Instantiate User, provide Alien Identification for use in dialog.
            User testSubject = new User("XB102108");

            // Brief intro to explain how this works to the user.
            Console.WriteLine(testSubject.Greeting());

            // Aliens trick the user into giving up characters from their Human name to be added to the list.
            Console.Write(Prompt());
            testSubject.GiveUserHumanName(Console.ReadLine());
            testSubject.UnwittinglyProvideNameLetters(testSubject.UserName);

            // Logic for taking in new letters and outcomes based on what information user provides.
            while(!testSubject.HasGivenCompleteAlphabet)
            {
                if(testSubject.HasFailed)
                {
                    Console.WriteLine(testSubject.MessageForFailure());
                    break;
                }
                testSubject.AlienLetterHandler();
            }

            // After all 26 characters have been added, end the appliction.
            if (testSubject.HasGivenCompleteAlphabet)
            {
                Console.WriteLine(testSubject.Congratulate());

            }
            Console.ReadKey();
        }
    }
}
