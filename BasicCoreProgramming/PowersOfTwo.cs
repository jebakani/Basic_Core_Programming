using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class PowersOfTwo
    {
        public static void ReadInput()
        {
            Console.WriteLine("Table for power of 2");

            //getting input from user
            Console.WriteLine("Enter the power value :");
            int powerValue = Convert.ToInt32(Console.ReadLine());
            PrintPowerOfTwo(powerValue);
        }

        //print the table for powers of two
        private static void PrintPowerOfTwo(int num)
        {
            for(int pow=1;pow<=num;pow++)
            {
                Console.WriteLine("2^{0} : {1}",pow,Math.Pow(2,pow));
            }
        }
    }
}
