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
            Console.WriteLine("Choose a program:");
            Console.WriteLine("1) Flip Coin");
            Console.WriteLine("0) To Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin.ReadInput();
                    break;
                default:
                    break;
            }
       
            Console.Read();
            
        }
    }
}
