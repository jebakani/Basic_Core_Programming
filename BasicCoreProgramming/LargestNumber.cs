using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class LargestNumber
    {
        public static void ReadInput()
        {
            LargestNumber largestNumber = new LargestNumber();
            Console.WriteLine("Largest of three number");

            //getting input from user
            Console.WriteLine("Enter the three number :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            largestNumber.LargestOfThreeNumber(number1, number2, number3);
        }

        //Checking the largest number amoung three
        private void LargestOfThreeNumber(int num1,int num2,int num3)
        {
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("{0} is largest number", num1);
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("{0} is largest number", num2);
            }

            else
            { 
                Console.WriteLine("{0} is largest number", num3);
            }
        }
    }
}
