using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class PrimeFactorization
    {
        public static void ReadInput()
        {
            Console.WriteLine("Prime factorization of number ");

            //getting input from user
            Console.WriteLine("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            FindPrimeFactor(number);
        }

        //print the factors for the number
        private static void FindPrimeFactor(int num)
        {
            Console.WriteLine("Prime Factors of {0} are:",num);
            int n = num;
            for (int fact = 2; fact <= Math.Sqrt(num); fact++)
            {
                while(n%fact==0)
                {
                    Console.WriteLine("{0} ",fact);
                    n /= fact;
                }
            }
            if (n > 2)
            {
                Console.WriteLine("{0}",n);
            }
        }
    }
}
