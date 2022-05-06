using System;

namespace LeapYearProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to leap year program");
            LeapYear myobj=new LeapYear();
            myobj.checkLeapYearOrNot();
        }
    }
}
