using System;
using System.Diagnostics.CodeAnalysis;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstName;
            String LastName;
            int Age;
            int Year;
            String UserInput;

            Console.WriteLine("What is your First Name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("When were you born?");
            UserInput = Console.ReadLine();
            Year = Int32.Parse(UserInput);
            Age = 2020 - Year;

            Console.WriteLine($"Greetings {FirstName} {LastName}, Age {Age}");
        }
    }
}
