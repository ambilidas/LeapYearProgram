using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearProgram
{
    internal class LeapYear
    {
        public void checkLeapYearOrNot()
        {
            Console.WriteLine("Enter The Year ");
            int year =Convert.ToInt32(Console.ReadLine());
            if(year >=1000 && year <= 9999)
            {
                if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("Leap year");
                }
                else
                {
                    Console.WriteLine("Not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid Year");
            }
        }
    }
}
