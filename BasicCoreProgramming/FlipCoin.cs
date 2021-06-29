using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class FlipCoin
    {
        public static void ReadInput()
        {
            Console.WriteLine("Flip coin program");
            
            //getting input from user
            Console.WriteLine("Enter number of times the coin to be fliped :");
            int numberOfTimeFlip = Convert.ToInt32(Console.ReadLine());

            //creating object for random class
            Random random = new Random();
           
            int head = 0;
            int tail = 0;

            //Calculating number of heads and tails for n times 
            for(int trail=1;trail<=numberOfTimeFlip;trail++)
            {
                //getting the flip result
                double headOrTail = random.NextDouble();

                //selecting head or tail
                if (headOrTail<0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }

            Console.WriteLine("Number of head out of "+numberOfTimeFlip+" is : "+head);
            Console.WriteLine("Number of tail out of "+numberOfTimeFlip+" is : "+tail);

            //calling method that calculate the percentage
            percentage(head, tail, numberOfTimeFlip);

        }

        // calculating the percentage of heads and tails
        private static void percentage(int heads , int tails, int flips)
        {
            double percentageOfHead = (double)heads / flips * 100;
            double percentageOfTail = (double)tails / flips * 100;
            Console.WriteLine("Percentage of head "+percentageOfHead);
            Console.WriteLine("Percentage of tail "+percentageOfTail);
        }


    }
}
