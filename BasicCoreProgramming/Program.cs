using System;

namespace BasicCoreProgramming
{
    class Program
    {
        /// <summary>
        /// P1- Executing the Flip coin program and finding the percentage
        /// p2 - Executing leap year program
        /// p3 - Printing Tables for powers of two
        /// p4 - Executing Harmonic Number 
        /// p5 - Prime factorization of the number
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");

            //creating menu to choose the program to be executed
            Console.WriteLine("Choose a program:");
            Console.WriteLine("1) Flip Coin");
            Console.WriteLine("2) Leap Year");
            Console.WriteLine("3) Powers of 2");
            Console.WriteLine("4) Harmonic Number");
            Console.WriteLine("5) Prime factoriation");
            Console.WriteLine("0) To Exit");

            //Read the choice from user
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                //calling flip coin program
                case 1:
                    FlipCoin.ReadInput();
                    break;

                //calling leap year program
                case 2:
                    LeapYear.ReadInput();
                    break;

                //calling powers of two program
                case 3:
                    PowersOfTwo.ReadInput();
                    break;
                //calling Harmonic number Program
                case 4:
                    HarmonicNumber.ReadInput();
                    break;

                //calling prime factor of number class
                case 5:
                    PrimeFactorization.ReadInput();
                    break;


                default:
                    break;
            }
       
            Console.Read();
            
        }
    }
}
