using System;

namespace BasicCoreProgramming
{
    class Program
    {
        /// <summary>
        /// P1- Executing the Flip coin program and finding the percentage
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic C# programs");

            //calling static object for Flipcoin
            FlipCoin.ReadInput();
            Console.Read();
            
        }
    }
}
