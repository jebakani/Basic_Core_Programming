using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class LeapYear
    {
        public static void ReadInput()
        {
            Console.WriteLine("leap year program");

            //getting input from user
            Console.WriteLine("Enter the year :");
            int year = Convert.ToInt32(Console.ReadLine());

            //calling the method that checks for leap year
            CheckForLeapYear(year);

        }

        //method that check whether the given year is leap year or not
        private static void CheckForLeapYear(int year)
        {
            //checks the condition for leap year
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is the leap year",year);
            }
            else
            {
                Console.WriteLine("{0} is not the leap year",year);
            }

        }
    }

}
