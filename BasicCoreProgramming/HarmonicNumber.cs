using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class HarmonicNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Harmonic Number");

            //getting input from user
            Console.WriteLine("Enter the Nth number:");
            int nthNumber = Convert.ToInt32(Console.ReadLine());
            FindHarmonicNumber(nthNumber);
        }

        //print the table for powers of two
        private static void FindHarmonicNumber(int num)
        {
           double harmonic = 0;
            for (int iter = 1; iter <= num; iter++)
            {
                harmonic += (double)1 / iter;
            }
            Console.WriteLine("The {0}th Harmonic Number is : {1}",num,harmonic);
        }
    }
}
