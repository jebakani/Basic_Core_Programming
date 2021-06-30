using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class SwappingTwoNumber
    {
        public static void ReadInput()
        {
            Console.WriteLine("Swapping of Two Numbers");
            //getting input from user
            Console.WriteLine("Enter the two number to be swapped:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            //calling static swapping method
            Swapping(number1,number2);
        }

        //Method two swap two number
        private static void Swapping(int num1,int num2)
        {
            Console.WriteLine("Before swapping \n number 1: {0} \n number 2: {1}",num1,num2);

            //swapping two number without temp variable
            num1 = num1 * num2;  
            num2 = num1 / num2;
            num1 = num1 / num2;

            Console.WriteLine("After swapping \n number 1: {0} \n number 2: {1}", num1, num2);
        }
    }
}
