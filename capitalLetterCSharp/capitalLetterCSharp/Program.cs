using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitalLetterCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // give instruction
            Console.WriteLine("Type something I will capitalize the first letter of each word");

            // create a variable to hold the input
            string input = Console.ReadLine();

            // create a delimeter to split the string
            char[] delim = { ' ', '.', '-' };

            //get the tokens from the input
            string[] tokens = input.Split(delim);

            foreach(string str in tokens)
            {
                // get char array
                str.ToCharArray();
                
                // capitalize first letter
                string capWord = char.ToUpper(str[0]) + str.Substring(1);

                // display new string
                Console.WriteLine(capWord);
            }

            // hold the screen open
            Console.ReadLine();
        }
    }
}
