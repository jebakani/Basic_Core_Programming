using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class VowelOrConsonant
    {
        public static void ReadInput()
        {
            Console.WriteLine("Checking the alphabet is Vowel or consonant");
            //getting input from user
            Console.WriteLine("Enter the alphabet :");
            char alphabet = Convert.ToChar(Console.ReadLine());
            FindVowelOrConsonant(alphabet) ;
        }

        //checking alphabet is vowel  or consonant
        private static void FindVowelOrConsonant(char alpha)
        {
            
                if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' || alpha == 'A' || alpha == 'E' || alpha == 'I' || alpha == 'O' || alpha == 'U')
                {
                    Console.WriteLine("{0} is a VOWEL", alpha);
                }

                //checks whether it is alphabet or number 
                else if (Char.IsLetter(alpha))
                {
                    Console.WriteLine("{0} is a Consonant", alpha);
                }
            
        }
    }
}
