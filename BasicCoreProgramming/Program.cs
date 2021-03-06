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
        /// p6 - Computing quotient and remainder for two number
        /// p7 - Swapping of two number
        /// p8 - Computing odd or even
        /// p9 - finding the alphabets is vowels or consonants
        /// p10 - Finding largest of three number
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
            Console.WriteLine("6) Quotient and Remainder of Two number");
            Console.WriteLine("7) Swapping of two number");
            Console.WriteLine("8) Odd or Even");
            Console.WriteLine("9) Volwels or Consonant");
            Console.WriteLine("10) Largest of three number");
            Console.WriteLine("0) To Exit");

            Console.WriteLine("Enter you choice:");
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

                //calling method to find quotient and remainder
                case 6:
                    QuotientAndRemainder.ReadInput();
                    break;

               //calling method to invoke swapping process
                case 7:
                    SwappingTwoNumber.ReadInput();
                    break;

                //Checking odd or even number
                case 8:
                    OddOrEven.ReadInput();
                    break;

                //Checking the alphabet is vowel or consonant
                case 9:
                    VowelOrConsonant.ReadInput();
                    break;

                //Finding largest of three number
                case 10:
                    LargestNumber.ReadInput();
                    break;

                default:
                    break;
            }
       
            Console.Read();
            
        }
    }
}
