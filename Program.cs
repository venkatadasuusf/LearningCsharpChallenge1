﻿using System;

namespace LearningCsharpChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What month were you born in");
            var month = Console.ReadLine();
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your name is: {0}", age);
            Console.WriteLine("Your name is: {0}", month);

            var passcode = "secret";
            var userpasscode = "";
            while (userpasscode != passcode)
            { 
                Console.WriteLine("What is your Passcode?");
                userpasscode = Console.ReadLine();
                Console.WriteLine("Authenticaton is Not Successful");
            }
            Console.WriteLine("Authenticaton Successful");
        }
    }
}
