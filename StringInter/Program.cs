using System;

namespace StringInter
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstName;
            String LastName;
            Console.WriteLine("What is your fist name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            //Console.WriteLine("Hello, " + FirstName + " " + LastName);
            //string interpolation
            //$ - alt + crtl+4 { - alt gr + 7, } - alt gr + 0
            Console.WriteLine($"Hello, {FirstName} {LastName}");

        }
    }
}
