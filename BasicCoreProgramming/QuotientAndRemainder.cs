using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class QuotientAndRemainder
    {
        public static void ReadInput()
        {
            Console.WriteLine("Finding quotient and remainder");

            //getting dividend and divisor from user
            Console.WriteLine("Enter dividend and divisor :");
            int dividend = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());

            //calling the method
            FindQuotientAndRemainder(dividend, divisor);
        }

        //Finding the quotient and remainder
        private static void FindQuotientAndRemainder(int p,int q)
        {
            int quo = p / q;
            int rem = p % q;

            Console.WriteLine("The quotient of {0} divided by {1} is : {2}",p,q,quo);
            Console.WriteLine("The remainder of {0} divided by {1} is : {2}", p, q, rem);

        }
    }
}
