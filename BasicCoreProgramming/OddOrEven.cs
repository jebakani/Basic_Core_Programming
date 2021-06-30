using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class OddOrEven
    {
        public static void ReadInput()
        {
            Console.WriteLine("Finding the number is odd or even");
            //getting input from user
            Console.WriteLine("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            FindOddOrEven(number);
        }

        //checking number is odd or even
        private static void FindOddOrEven(int num)
        {
            if(num%2==0)
            {
                Console.WriteLine("{0} is an EVEN number",num);
            }
            else
            {
                Console.WriteLine("{0} is an ODD number", num);
            }
        }
    }
}
